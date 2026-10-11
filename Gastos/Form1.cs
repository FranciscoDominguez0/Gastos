
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Gastos.Datos;
using Gastos.Modelos;
using Gastos.Validaciones;

namespace Gastos
{
    public partial class Form1 : Form
    {
        private readonly GastoRepositorio repositorio = new GastoRepositorio();
        private int? idSeleccionado = null;

        public Form1()
        {
            InitializeComponent();
            CargarGastos();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!ObtenerGastoValidado(out Gasto gasto))
            {
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

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                string concepto = txtConcepto.Text.Trim();
                string categoria = lstCategoria.SelectedItem?.ToString();

                if (!ValidarGasto.ValidarBusqueda(
                    concepto,
                    categoria,
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

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (!idSeleccionado.HasValue)
            {
                MessageBox.Show(
                    "Seleccione un gasto de la tabla para actualizar.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            if (!ObtenerGastoValidado(out Gasto gasto))
            {
                return;
            }

            gasto.Id = idSeleccionado.Value;

            try
            {
                bool actualizado = repositorio.Actualizar(gasto);

                if (!actualizado)
                {
                    MessageBox.Show(
                        "No se actualizó ningún registro. Verifique si hubo cambios.",
                        "Información",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    return;
                }

                LimpiarCampos();
                idSeleccionado = null;
                CargarGastos();

                MessageBox.Show(
                    "Gasto actualizado correctamente.",
                    "Actualización",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "No fue posible actualizar el gasto.\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (!idSeleccionado.HasValue)
            {
                MessageBox.Show(
                    "Seleccione un gasto de la tabla para eliminar.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            if (!chkConfirmarEliminar.Checked)
            {
                MessageBox.Show(
                    "Debe marcar la casilla de confirmación para eliminar.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            DialogResult respuesta = MessageBox.Show(
                "¿Está seguro de que desea eliminar este gasto?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (respuesta != DialogResult.Yes)
            {
                return;
            }

            try
            {
                bool eliminado = repositorio.Eliminar(idSeleccionado.Value);

                if (!eliminado)
                {
                    MessageBox.Show(
                        "El gasto seleccionado ya no existe.",
                        "Información",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    LimpiarCampos();
                    CargarGastos();

                    return;
                }

                LimpiarCampos();
                CargarGastos();

                MessageBox.Show(
                    "Gasto eliminado correctamente.",
                    "Eliminación exitosa",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "No fue posible eliminar el gasto.\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            CargarGastos();
        }

        private void dgvGastos_CellContentClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            SeleccionarGasto();
        }

        private void dgvGastos_CellContentClick_1(
            object sender,
            DataGridViewCellEventArgs e)
        {
            SeleccionarGasto();
        }

        private void SeleccionarGasto()
        {
            if (dgvGastos.SelectedRows.Count == 0)
            {
                return;
            }

            Gasto gasto = dgvGastos.SelectedRows[0].DataBoundItem as Gasto;

            if (gasto == null)
            {
                return;
            }

            idSeleccionado = gasto.Id;

            txtConcepto.Text = gasto.Concepto;
            lstCategoria.SelectedItem = gasto.Categoria;

            txtMonto.Text = gasto.Monto.ToString(
                System.Globalization.CultureInfo.InvariantCulture
            );

            txtFecha.Text = gasto.Fecha.ToString("yyyy-MM-dd");

            chkConfirmarEliminar.Checked = false;
        }

        private void LimpiarCampos()
        {
            txtConcepto.Clear();
            txtMonto.Clear();
            txtFecha.Clear();
            lstCategoria.ClearSelected();

            chkConfirmarEliminar.Checked = false;
            dgvGastos.ClearSelection();

            idSeleccionado = null;
        }

        private void MostrarGastos(List<Gasto> gastos)
        {
            dgvGastos.AutoGenerateColumns = false;
            dgvGastos.DataSource = null;
            dgvGastos.DataSource = gastos;
            dgvGastos.ClearSelection();
        }

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

        private bool ObtenerGastoValidado(out Gasto gasto)
        {
            bool valido = ValidarGasto.IntentarValidar(
                txtConcepto.Text,
                lstCategoria.SelectedItem?.ToString(),
                txtMonto.Text,
                txtFecha.Text,
                out gasto,
                out string mensaje
            );

            if (!valido)
            {
                MessageBox.Show(
                    mensaje,
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }

            return valido;
        }

        private void lblFondoDatos_Click(object sender, EventArgs e)
        {

        }

    }
}
