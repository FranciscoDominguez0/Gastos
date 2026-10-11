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
using Gastos.Modelos;
using Gastos.Validaciones;


namespace Gastos
{
    
    public partial class Form1 : Form
    {
        private readonly GastoRepositorio repositorio = new GastoRepositorio();
        public Form1()
        {
            InitializeComponent();
           
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


        private void LimpiarCampos()
        {
            txtConcepto.Clear();
            txtMonto.Clear();
            txtFecha.Clear();
            lstCategoria.ClearSelected();
            chkConfirmarEliminar.Checked = false;
            dgvGastos.ClearSelection();
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidarGasto.IntentarValidar(
        txtConcepto.Text,
        lstCategoria.SelectedItem?.ToString(),
        txtMonto.Text,
        txtFecha.Text,
        out Gasto gasto,
        out string mensaje))
            {
                MessageBox.Show(
                    mensaje,
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            try
            {
                repositorio.Guardar(gasto);

                LimpiarCampos();

                MessageBox.Show(
                    "Gasto guardado correctamente.",
                    "Registro exitoso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            catch (Exception)
            {
                MessageBox.Show(
                    "No fue posible guardar el gasto.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }

        }

        private void lblMensaje_Click(object sender, EventArgs e)
        {

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

        }
    }
}
