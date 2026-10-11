
using Gastos.Modelos;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gastos.Datos
{
    public class GastoRepositorio
    {
        private readonly ConexionBD conexionBD = new ConexionBD();

        public void Guardar(Gasto gasto)
        {
            const string sql =
                "INSERT INTO gastos (concepto, categoria, monto, fecha) " +
                "VALUES (@concepto, @categoria, @monto, @fecha)";

            using (MySqlConnection conexion = conexionBD.ObtenerConexion())
            {
                conexion.Open();

                using (MySqlCommand comando = new MySqlCommand(sql, conexion))
                {
                    AgregarParametrosGasto(comando, gasto);
                    comando.ExecuteNonQuery();
                }
            }
        }

        public List<Gasto> Consultar()
        {
            return Buscar(string.Empty, string.Empty);
        }

        public List<Gasto> Buscar(string concepto, string categoria)
        {
            List<Gasto> gastos = new List<Gasto>();

            concepto = (concepto ?? string.Empty).Trim();
            categoria = (categoria ?? string.Empty).Trim();

            StringBuilder sql = new StringBuilder(
                "SELECT id, concepto, categoria, monto, fecha " +
                "FROM gastos WHERE 1 = 1"
            );

            if (!string.IsNullOrWhiteSpace(concepto))
            {
                sql.Append(" AND concepto LIKE @concepto");
            }

            if (!string.IsNullOrWhiteSpace(categoria))
            {
                sql.Append(" AND categoria = @categoria");
            }

            sql.Append(" ORDER BY id DESC");

            using (MySqlConnection conexion = conexionBD.ObtenerConexion())
            {
                conexion.Open();

                using (MySqlCommand comando = new MySqlCommand(sql.ToString(), conexion))
                {
                    if (!string.IsNullOrWhiteSpace(concepto))
                    {
                        comando.Parameters.AddWithValue(
                            "@concepto", "%" + concepto + "%"
                        );
                    }

                    if (!string.IsNullOrWhiteSpace(categoria))
                    {
                        comando.Parameters.AddWithValue(
                            "@categoria", categoria
                        );
                    }

                    using (MySqlDataReader lector = comando.ExecuteReader())
                    {
                        while (lector.Read())
                        {
                            gastos.Add(MapearGasto(lector));
                        }
                    }
                }
            }

            return gastos;
        }

        public bool Actualizar(Gasto gasto)
        {
            const string sql =
                "UPDATE gastos SET " +
                "concepto = @concepto, " +
                "categoria = @categoria, " +
                "monto = @monto, " +
                "fecha = @fecha " +
                "WHERE id = @id";

            using (MySqlConnection conexion = conexionBD.ObtenerConexion())
            {
                conexion.Open();

                using (MySqlCommand comando = new MySqlCommand(sql, conexion))
                {
                    AgregarParametrosGasto(comando, gasto);
                    comando.Parameters.AddWithValue("@id", gasto.Id);

                    return comando.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool Eliminar(int id)
        {
            const string sql = "DELETE FROM gastos WHERE id = @id";

            using (MySqlConnection conexion = conexionBD.ObtenerConexion())
            {
                conexion.Open();

                using (MySqlCommand comando = new MySqlCommand(sql, conexion))
                {
                    comando.Parameters.AddWithValue("@id", id);

                    return comando.ExecuteNonQuery() > 0;
                }
            }
        }

        private static void AgregarParametrosGasto(
            MySqlCommand comando,
            Gasto gasto)
        {
            comando.Parameters.AddWithValue("@concepto", gasto.Concepto);
            comando.Parameters.AddWithValue("@categoria", gasto.Categoria);
            comando.Parameters.AddWithValue("@monto", gasto.Monto);
            comando.Parameters.AddWithValue("@fecha", gasto.Fecha);
        }

        private static Gasto MapearGasto(MySqlDataReader lector)
        {
            return new Gasto
            {
                Id = lector.GetInt32("id"),
                Concepto = lector.GetString("concepto"),
                Categoria = lector.GetString("categoria"),
                Monto = lector.GetDecimal("monto"),
                Fecha = lector.GetDateTime("fecha")
            };
        }
    }
}
