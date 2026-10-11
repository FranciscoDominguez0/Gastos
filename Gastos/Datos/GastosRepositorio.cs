
using Gastos.Modelos;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Text;

namespace Gastos.Datos
{
    public class GastoRepositorio
    {
        private readonly ConexionBD conexionBD = new ConexionBD();


        // Guardar un nuevo gasto
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
                    comando.Parameters.AddWithValue("@concepto", gasto.Concepto);
                    comando.Parameters.AddWithValue("@categoria", gasto.Categoria);
                    comando.Parameters.AddWithValue("@monto", gasto.Monto);
                    comando.Parameters.AddWithValue("@fecha", gasto.Fecha);

                    comando.ExecuteNonQuery();
                }
            }
        }


        // Consulta de todos los gastos
        public List<Gasto> Consultar()
        {
            return Buscar(string.Empty, string.Empty);
        }


        // Buscar gastos por concepto y categoría
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
                            Gasto gasto = new Gasto
                            {
                                Id = lector.GetInt32("id"),
                                Concepto = lector.GetString("concepto"),
                                Categoria = lector.GetString("categoria"),
                                Monto = lector.GetDecimal("monto"),
                                Fecha = lector.GetDateTime("fecha")
                            };

                            gastos.Add(gasto);
                        }
                    }
                }
            }

            return gastos;
        }
    }



    }
}
