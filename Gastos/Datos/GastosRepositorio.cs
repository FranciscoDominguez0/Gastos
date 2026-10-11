
using Gastos.Modelos;
using MySql.Data.MySqlClient;

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
                    comando.Parameters.AddWithValue("@concepto", gasto.Concepto);
                    comando.Parameters.AddWithValue("@categoria", gasto.Categoria);
                    comando.Parameters.AddWithValue("@monto", gasto.Monto);
                    comando.Parameters.AddWithValue("@fecha", gasto.Fecha);

                    comando.ExecuteNonQuery();
                }
            }
        }
    }
}
