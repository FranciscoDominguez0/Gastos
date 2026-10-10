using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Gastos.Datos;

namespace Gastos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            try
            {
                ConexionBD conexionBD = new ConexionBD();

                using (MySqlConnection conexion = conexionBD.ObtenerConexion())
                {
                    conexion.Open();

                    MessageBox.Show(
                        "Conexión exitosa con MySQL",
                        "Conexión",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    lblMensaje.Text = "Conectado a MySQL";
                    lblMensaje.ForeColor = Color.Green;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error de conexión: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                lblMensaje.Text = "Error al conectar con MySQL";
                lblMensaje.ForeColor = Color.Red;
            }
        }

        private void lblFondoEncabezado_Click(object sender, EventArgs e)
        {

        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblFondoDatos_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
        }
    }
}
