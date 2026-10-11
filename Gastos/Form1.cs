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
            CargarGastos();



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
            CargarGastos();

        }

        private void lblMensaje_Click(object sender, EventArgs e)
        {

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

        }

        private void dgvGastos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        //Limpiar campos
        private void LimpiarCampos()
        {
            txtConcepto.Clear();
            txtMonto.Clear();
            txtFecha.Clear();
            lstCategoria.ClearSelected();
            chkConfirmarEliminar.Checked = false;
            dgvGastos.ClearSelection();
        }

        private void MostrarGastos(List<Gasto> gastos)
        {
            dgvGastos.AutoGenerateColumns = false;
            dgvGastos.DataSource = null;
            dgvGastos.DataSource = gastos;
            dgvGastos.ClearSelection();
        }


        // buscar datos
        private void CargarGastos()
        {
            try
            {
                MostrarGastos(repositorio.Consultar());
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "No fue posible consultar los gastos.\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                string concepto = txtConcepto.Text.Trim();
                string categoria = lstCategoria.SelectedItem?.ToString();

                List<Gasto> resultados = repositorio.Buscar(concepto, categoria);

                MostrarGastos(resultados);

                if (resultados.Count == 0)
                {
                    MessageBox.Show(
                        "No se encontraron gastos con esos criterios.",
                        "Sin resultados",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "No fue posible realizar la búsqueda.\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }

        }
    }
}
