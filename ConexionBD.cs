
using System;
using MySql.Data.MySqlClient;

namespace Gastos.Datos
{
    public class ConexionBD
    {
        private readonly string cadenaConexion =
            "Server=localhost;" +
            "Port=3306;" +
            "Database=laboratorio_crud;" +
            "Uid=root;" +
            "Pwd=12345678;";

        public MySqlConnection ObtenerConexion()
        {
            return new MySqlConnection(cadenaConexion);
        }
    }
}
