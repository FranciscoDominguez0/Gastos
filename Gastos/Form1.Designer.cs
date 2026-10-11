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
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label lblFondoHistorial;
        private System.Windows.Forms.Label lblHistorial;
        private System.Windows.Forms.Label lblIconoHistorial;
        private System.Windows.Forms.DataGridView dgvGastos;
        private System.Windows.Forms.Label lblFondoEliminar;
        private System.Windows.Forms.CheckBox chkConfirmarEliminar;

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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.lblFondoHistorial = new System.Windows.Forms.Label();
            this.lblHistorial = new System.Windows.Forms.Label();
            this.lblIconoHistorial = new System.Windows.Forms.Label();
            this.dgvGastos = new System.Windows.Forms.DataGridView();
            this.lblFondoEliminar = new System.Windows.Forms.Label();
            this.chkConfirmarEliminar = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colConcepto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMonto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGastos)).BeginInit();
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
            this.lblFondoDatos.Click += new System.EventHandler(this.lblFondoDatos_Click);
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
            this.txtMonto.TextChanged += new System.EventHandler(this.txtMonto_TextChanged);
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
            this.lblIconoConcepto.Image = global::Gastos.Properties.Resources.receipt;
            this.lblIconoConcepto.Location = new System.Drawing.Point(45, 250);
            this.lblIconoConcepto.Name = "lblIconoConcepto";
            this.lblIconoConcepto.Size = new System.Drawing.Size(30, 30);
            this.lblIconoConcepto.TabIndex = 4;
            // 
            // lblIconoCategoria
            // 
            this.lblIconoCategoria.BackColor = System.Drawing.Color.White;
            this.lblIconoCategoria.Image = global::Gastos.Properties.Resources.file_box;
            this.lblIconoCategoria.Location = new System.Drawing.Point(560, 250);
            this.lblIconoCategoria.Name = "lblIconoCategoria";
            this.lblIconoCategoria.Size = new System.Drawing.Size(30, 30);
            this.lblIconoCategoria.TabIndex = 7;
            // 
            // lblIconoMonto
            // 
            this.lblIconoMonto.BackColor = System.Drawing.Color.White;
            this.lblIconoMonto.Image = global::Gastos.Properties.Resources.circle_dollar_sign__1_;
            this.lblIconoMonto.Location = new System.Drawing.Point(45, 350);
            this.lblIconoMonto.Name = "lblIconoMonto";
            this.lblIconoMonto.Size = new System.Drawing.Size(30, 30);
            this.lblIconoMonto.TabIndex = 10;
            // 
            // lblIconoFecha
            // 
            this.lblIconoFecha.BackColor = System.Drawing.Color.White;
            this.lblIconoFecha.Image = global::Gastos.Properties.Resources.calendar_chevrons_right__1_;
            this.lblIconoFecha.Location = new System.Drawing.Point(560, 350);
            this.lblIconoFecha.Name = "lblIconoFecha";
            this.lblIconoFecha.Size = new System.Drawing.Size(30, 30);
            this.lblIconoFecha.TabIndex = 13;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(151)))), ((int)(((byte)(88)))));
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Image = global::Gastos.Properties.Resources.save_check;
            this.btnGuardar.Location = new System.Drawing.Point(20, 420);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.btnGuardar.Size = new System.Drawing.Size(196, 48);
            this.btnGuardar.TabIndex = 16;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(129)))), ((int)(((byte)(234)))));
            this.btnConsultar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsultar.FlatAppearance.BorderSize = 0;
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.ForeColor = System.Drawing.Color.White;
            this.btnConsultar.Image = global::Gastos.Properties.Resources.search;
            this.btnConsultar.Location = new System.Drawing.Point(231, 420);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.btnConsultar.Size = new System.Drawing.Size(196, 48);
            this.btnConsultar.TabIndex = 17;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(32)))));
            this.btnActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizar.FlatAppearance.BorderSize = 0;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(40)))), ((int)(((byte)(0)))));
            this.btnActualizar.Image = global::Gastos.Properties.Resources.pencil;
            this.btnActualizar.Location = new System.Drawing.Point(442, 420);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.btnActualizar.Size = new System.Drawing.Size(196, 48);
            this.btnActualizar.TabIndex = 18;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(65)))), ((int)(((byte)(56)))));
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Image = global::Gastos.Properties.Resources.trash;
            this.btnEliminar.Location = new System.Drawing.Point(653, 420);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.btnEliminar.Size = new System.Drawing.Size(196, 48);
            this.btnEliminar.TabIndex = 19;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(146)))), ((int)(((byte)(172)))));
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.Image = global::Gastos.Properties.Resources.broom;
            this.btnLimpiar.Location = new System.Drawing.Point(864, 420);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.btnLimpiar.Size = new System.Drawing.Size(196, 48);
            this.btnLimpiar.TabIndex = 20;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // lblFondoHistorial
            // 
            this.lblFondoHistorial.BackColor = System.Drawing.Color.White;
            this.lblFondoHistorial.Location = new System.Drawing.Point(20, 485);
            this.lblFondoHistorial.Name = "lblFondoHistorial";
            this.lblFondoHistorial.Size = new System.Drawing.Size(1040, 210);
            this.lblFondoHistorial.TabIndex = 21;
            // 
            // lblHistorial
            // 
            this.lblHistorial.AutoSize = true;
            this.lblHistorial.BackColor = System.Drawing.Color.White;
            this.lblHistorial.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHistorial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(43)))), ((int)(((byte)(77)))));
            this.lblHistorial.Location = new System.Drawing.Point(75, 500);
            this.lblHistorial.Name = "lblHistorial";
            this.lblHistorial.Size = new System.Drawing.Size(151, 21);
            this.lblHistorial.TabIndex = 23;
            this.lblHistorial.Text = "Historial de gastos";
            // 
            // lblIconoHistorial
            // 
            this.lblIconoHistorial.BackColor = System.Drawing.Color.White;
            this.lblIconoHistorial.Location = new System.Drawing.Point(35, 497);
            this.lblIconoHistorial.Name = "lblIconoHistorial";
            this.lblIconoHistorial.Size = new System.Drawing.Size(32, 32);
            this.lblIconoHistorial.TabIndex = 22;
            // 
            // dgvGastos
            // 
            this.dgvGastos.AllowUserToAddRows = false;
            this.dgvGastos.AllowUserToDeleteRows = false;
            this.dgvGastos.AllowUserToResizeColumns = false;
            this.dgvGastos.AllowUserToResizeRows = false;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
            this.dgvGastos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvGastos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGastos.BackgroundColor = System.Drawing.Color.White;
            this.dgvGastos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(241)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(43)))), ((int)(((byte)(77)))));
            this.dgvGastos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dgvGastos.ColumnHeadersHeight = 30;
            this.dgvGastos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvGastos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colConcepto,
            this.colCategoria,
            this.colMonto,
            this.colFecha});
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(43)))), ((int)(((byte)(77)))));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(137)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvGastos.DefaultCellStyle = dataGridViewCellStyle15;
            this.dgvGastos.EnableHeadersVisualStyles = false;
            this.dgvGastos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(245)))));
            this.dgvGastos.Location = new System.Drawing.Point(35, 540);
            this.dgvGastos.MultiSelect = false;
            this.dgvGastos.Name = "dgvGastos";
            this.dgvGastos.ReadOnly = true;
            this.dgvGastos.RowHeadersVisible = false;
            this.dgvGastos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvGastos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGastos.Size = new System.Drawing.Size(1010, 140);
            this.dgvGastos.TabIndex = 24;
            this.dgvGastos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGastos_CellContentClick);
            // 
            // lblFondoEliminar
            // 
            this.lblFondoEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblFondoEliminar.Location = new System.Drawing.Point(20, 710);
            this.lblFondoEliminar.Name = "lblFondoEliminar";
            this.lblFondoEliminar.Size = new System.Drawing.Size(510, 55);
            this.lblFondoEliminar.TabIndex = 26;
            // 
            // chkConfirmarEliminar
            // 
            this.chkConfirmarEliminar.AutoSize = true;
            this.chkConfirmarEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.chkConfirmarEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkConfirmarEliminar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkConfirmarEliminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.chkConfirmarEliminar.Location = new System.Drawing.Point(40, 727);
            this.chkConfirmarEliminar.Name = "chkConfirmarEliminar";
            this.chkConfirmarEliminar.Size = new System.Drawing.Size(320, 19);
            this.chkConfirmarEliminar.TabIndex = 25;
            this.chkConfirmarEliminar.Text = "Confirmo que deseo eliminar el registro seleccionado";
            this.chkConfirmarEliminar.UseVisualStyleBackColor = false;
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
            // colId
            // 
            this.colId.DataPropertyName = "Id";
            this.colId.FillWeight = 35F;
            this.colId.HeaderText = "ID";
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            // 
            // colConcepto
            // 
            this.colConcepto.DataPropertyName = "Concepto";
            this.colConcepto.FillWeight = 180F;
            this.colConcepto.HeaderText = "Concepto";
            this.colConcepto.Name = "colConcepto";
            this.colConcepto.ReadOnly = true;
            // 
            // colCategoria
            // 
            this.colCategoria.DataPropertyName = "Categoria";
            this.colCategoria.FillWeight = 120F;
            this.colCategoria.HeaderText = "Categoría";
            this.colCategoria.Name = "colCategoria";
            this.colCategoria.ReadOnly = true;
            // 
            // colMonto
            // 
            this.colMonto.DataPropertyName = "Monto";
            this.colMonto.FillWeight = 90F;
            this.colMonto.HeaderText = "Monto ($)";
            this.colMonto.Name = "colMonto";
            this.colMonto.ReadOnly = true;
            // 
            // colFecha
            // 
            this.colFecha.DataPropertyName = "Fecha";
            this.colFecha.FillWeight = 110F;
            this.colFecha.HeaderText = "Fecha";
            this.colFecha.Name = "colFecha";
            this.colFecha.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(1072, 800);
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
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSubtitulo);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblFondoEncabezado);
            this.Controls.Add(this.lblIconoHistorial);
            this.Controls.Add(this.lblHistorial);
            this.Controls.Add(this.dgvGastos);
            this.Controls.Add(this.chkConfirmarEliminar);
            this.Controls.Add(this.lblFondoEliminar);
            this.Controls.Add(this.lblFondoDatos);
            this.Controls.Add(this.lblFondoHistorial);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Gestión de Gastos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvGastos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colConcepto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMonto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFecha;
    }
}

