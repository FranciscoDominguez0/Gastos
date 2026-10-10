namespace Gastos
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblFondoEncabezado;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Label lblFondoDatos;
        private System.Windows.Forms.Label lblSeccionDatos;
        private System.Windows.Forms.Label lblLineaDatos;
        private System.Windows.Forms.Label lblConcepto;
        private System.Windows.Forms.TextBox txtConcepto;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.ListBox lstCategoria;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.Label lblIconoDatos;
        private System.Windows.Forms.Label lblIconoConcepto;
        private System.Windows.Forms.Label lblIconoCategoria;
        private System.Windows.Forms.Label lblIconoMonto;
        private System.Windows.Forms.Label lblIconoFecha;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblFondoEncabezado = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.lblFondoDatos = new System.Windows.Forms.Label();
            this.lblSeccionDatos = new System.Windows.Forms.Label();
            this.lblLineaDatos = new System.Windows.Forms.Label();
            this.lblConcepto = new System.Windows.Forms.Label();
            this.txtConcepto = new System.Windows.Forms.TextBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lstCategoria = new System.Windows.Forms.ListBox();
            this.lblMonto = new System.Windows.Forms.Label();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.lblIconoDatos = new System.Windows.Forms.Label();
            this.lblIconoConcepto = new System.Windows.Forms.Label();
            this.lblIconoCategoria = new System.Windows.Forms.Label();
            this.lblIconoMonto = new System.Windows.Forms.Label();
            this.lblIconoFecha = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblFondoEncabezado
            // 
            this.lblFondoEncabezado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(67)))), ((int)(((byte)(129)))));
            this.lblFondoEncabezado.Location = new System.Drawing.Point(12, 18);
            this.lblFondoEncabezado.Name = "lblFondoEncabezado";
            this.lblFondoEncabezado.Size = new System.Drawing.Size(1040, 125);
            this.lblFondoEncabezado.TabIndex = 0;
            this.lblFondoEncabezado.Click += new System.EventHandler(this.lblFondoEncabezado_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(67)))), ((int)(((byte)(129)))));
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(191, 45);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(352, 45);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "CONTROL DE GASTOS";
            this.lblTitulo.Click += new System.EventHandler(this.lblTitulo_Click);
            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(67)))), ((int)(((byte)(129)))));
            this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtitulo.ForeColor = System.Drawing.Color.White;
            this.lblSubtitulo.Location = new System.Drawing.Point(199, 95);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(322, 21);
            this.lblSubtitulo.TabIndex = 2;
            this.lblSubtitulo.Text = "Registro, consulta y administración de gastos";
            // 
            // lblFondoDatos
            // 
            this.lblFondoDatos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblFondoDatos.Location = new System.Drawing.Point(20, 165);
            this.lblFondoDatos.Name = "lblFondoDatos";
            this.lblFondoDatos.Size = new System.Drawing.Size(1040, 235);
            this.lblFondoDatos.TabIndex = 0;
            // 
            // lblSeccionDatos
            // 
            this.lblSeccionDatos.AutoSize = true;
            this.lblSeccionDatos.BackColor = System.Drawing.Color.White;
            this.lblSeccionDatos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeccionDatos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(43)))), ((int)(((byte)(77)))));
            this.lblSeccionDatos.Location = new System.Drawing.Point(85, 178);
            this.lblSeccionDatos.Name = "lblSeccionDatos";
            this.lblSeccionDatos.Size = new System.Drawing.Size(128, 21);
            this.lblSeccionDatos.TabIndex = 2;
            this.lblSeccionDatos.Text = "Datos del gasto";
            // 
            // lblLineaDatos
            // 
            this.lblLineaDatos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(220)))), ((int)(((byte)(245)))));
            this.lblLineaDatos.Location = new System.Drawing.Point(235, 192);
            this.lblLineaDatos.Name = "lblLineaDatos";
            this.lblLineaDatos.Size = new System.Drawing.Size(790, 1);
            this.lblLineaDatos.TabIndex = 3;
            // 
            // lblConcepto
            // 
            this.lblConcepto.AutoSize = true;
            this.lblConcepto.BackColor = System.Drawing.Color.White;
            this.lblConcepto.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConcepto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(43)))), ((int)(((byte)(77)))));
            this.lblConcepto.Location = new System.Drawing.Point(85, 225);
            this.lblConcepto.Name = "lblConcepto";
            this.lblConcepto.Size = new System.Drawing.Size(153, 19);
            this.lblConcepto.TabIndex = 5;
            this.lblConcepto.Text = "Concepto del gasto: *";
            // 
            // txtConcepto
            // 
            this.txtConcepto.BackColor = System.Drawing.Color.White;
            this.txtConcepto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtConcepto.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConcepto.Location = new System.Drawing.Point(85, 250);
            this.txtConcepto.Name = "txtConcepto";
            this.txtConcepto.Size = new System.Drawing.Size(400, 27);
            this.txtConcepto.TabIndex = 6;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.BackColor = System.Drawing.Color.White;
            this.lblCategoria.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(43)))), ((int)(((byte)(77)))));
            this.lblCategoria.Location = new System.Drawing.Point(600, 225);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(89, 19);
            this.lblCategoria.TabIndex = 8;
            this.lblCategoria.Text = "Categoría: *";
            // 
            // lstCategoria
            // 
            this.lstCategoria.BackColor = System.Drawing.Color.White;
            this.lstCategoria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstCategoria.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstCategoria.ItemHeight = 17;
            this.lstCategoria.Items.AddRange(new object[] {
            "Transporte",
            "Alimentación",
            "Servicios"});
            this.lstCategoria.Location = new System.Drawing.Point(600, 250);
            this.lstCategoria.Name = "lstCategoria";
            this.lstCategoria.Size = new System.Drawing.Size(400, 53);
            this.lstCategoria.TabIndex = 9;
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.BackColor = System.Drawing.Color.White;
            this.lblMonto.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(43)))), ((int)(((byte)(77)))));
            this.lblMonto.Location = new System.Drawing.Point(85, 325);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(89, 19);
            this.lblMonto.TabIndex = 11;
            this.lblMonto.Text = "Monto ($): *";
            // 
            // txtMonto
            // 
            this.txtMonto.BackColor = System.Drawing.Color.White;
            this.txtMonto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMonto.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMonto.Location = new System.Drawing.Point(85, 350);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(400, 27);
            this.txtMonto.TabIndex = 12;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.BackColor = System.Drawing.Color.White;
            this.lblFecha.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(43)))), ((int)(((byte)(77)))));
            this.lblFecha.Location = new System.Drawing.Point(600, 325);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(163, 19);
            this.lblFecha.TabIndex = 14;
            this.lblFecha.Text = "Fecha (yyyy-MM-dd): *";
            // 
            // txtFecha
            // 
            this.txtFecha.BackColor = System.Drawing.Color.White;
            this.txtFecha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFecha.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFecha.Location = new System.Drawing.Point(600, 350);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(400, 27);
            this.txtFecha.TabIndex = 15;
            // 
            // lblIconoDatos
            // 
            this.lblIconoDatos.BackColor = System.Drawing.Color.White;
            this.lblIconoDatos.Location = new System.Drawing.Point(45, 175);
            this.lblIconoDatos.Name = "lblIconoDatos";
            this.lblIconoDatos.Size = new System.Drawing.Size(32, 32);
            this.lblIconoDatos.TabIndex = 1;
            // 
            // lblIconoConcepto
            // 
            this.lblIconoConcepto.BackColor = System.Drawing.Color.White;
            this.lblIconoConcepto.Location = new System.Drawing.Point(45, 250);
            this.lblIconoConcepto.Name = "lblIconoConcepto";
            this.lblIconoConcepto.Size = new System.Drawing.Size(30, 30);
            this.lblIconoConcepto.TabIndex = 4;
            // 
            // lblIconoCategoria
            // 
            this.lblIconoCategoria.BackColor = System.Drawing.Color.White;
            this.lblIconoCategoria.Location = new System.Drawing.Point(560, 250);
            this.lblIconoCategoria.Name = "lblIconoCategoria";
            this.lblIconoCategoria.Size = new System.Drawing.Size(30, 30);
            this.lblIconoCategoria.TabIndex = 7;
            // 
            // lblIconoMonto
            // 
            this.lblIconoMonto.BackColor = System.Drawing.Color.White;
            this.lblIconoMonto.Location = new System.Drawing.Point(45, 350);
            this.lblIconoMonto.Name = "lblIconoMonto";
            this.lblIconoMonto.Size = new System.Drawing.Size(30, 30);
            this.lblIconoMonto.TabIndex = 10;
            // 
            // lblIconoFecha
            // 
            this.lblIconoFecha.BackColor = System.Drawing.Color.White;
            this.lblIconoFecha.Location = new System.Drawing.Point(560, 350);
            this.lblIconoFecha.Name = "lblIconoFecha";
            this.lblIconoFecha.Size = new System.Drawing.Size(30, 30);
            this.lblIconoFecha.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(196, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 3;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(1100, 800);
            this.Controls.Add(this.lblIconoDatos);
            this.Controls.Add(this.lblSeccionDatos);
            this.Controls.Add(this.lblLineaDatos);
            this.Controls.Add(this.lblIconoConcepto);
            this.Controls.Add(this.lblConcepto);
            this.Controls.Add(this.txtConcepto);
            this.Controls.Add(this.lblIconoCategoria);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lstCategoria);
            this.Controls.Add(this.lblIconoMonto);
            this.Controls.Add(this.lblMonto);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.lblIconoFecha);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSubtitulo);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblFondoEncabezado);
            this.Controls.Add(this.lblFondoDatos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Gestión de Gastos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
    }
}

