
using System;
using MySql.Data.MySqlClient;

namespace Gastos.Datos
{
    internal class ConexionBD
    {
        private readonly string cadenaConexion =
            "Server=localhost;" +
            "Port=3306;" +
            "Database=laboratorio_crud;" +
            "Uid=root;" +
            "Pwd=TU_CONTRASEÑA;";

        public MySqlConnection ObtenerConexion()
        {
            return new MySqlConnection(cadenaConexion);
        }
    }
}
