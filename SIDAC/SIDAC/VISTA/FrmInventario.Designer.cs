
namespace SIDAC.VISTA
{
    partial class FrmInventario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtgInventario = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imagenFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tercero = new System.Windows.Forms.Panel();
            this.lblTotal = new System.Windows.Forms.Label();
            this.segundo = new System.Windows.Forms.Panel();
            this.btnReporte = new Guna.UI2.WinForms.Guna2Button();
            this.btnDesplagarMenu = new Guna.UI2.WinForms.Guna2Button();
            this.lblNombreTabla = new System.Windows.Forms.Label();
            this.pnlCompras = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlNuevaCompra = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlFactura = new Guna.UI2.WinForms.Guna2Panel();
            this.primero = new System.Windows.Forms.Panel();
            this.pnlRetiroInventario = new Guna.UI2.WinForms.Guna2Panel();
            this.btnModificar = new Guna.UI2.WinForms.Guna2Button();
            this.btnAgregar = new Guna.UI2.WinForms.Guna2Button();
            this.pnlEncabezadoNuevoCompra = new Guna.UI2.WinForms.Guna2Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlDatosPagos = new Guna.UI2.WinForms.Guna2Panel();
            this.rdAgregarInventario = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.rdRetirarInventario = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.txtTotal = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRealizarRetiro = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMotivo = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtCantidad = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.lblIdCompra = new System.Windows.Forms.Label();
            this.txtFecha = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtValor = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtMaterial = new Guna.UI2.WinForms.Guna2TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.pnlSeleccioFormulario = new Guna.UI2.WinForms.Guna2Panel();
            this.btnRegistro = new Guna.UI2.WinForms.Guna2Button();
            this.btnAgotados = new Guna.UI2.WinForms.Guna2Button();
            this.btnStock = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgInventario)).BeginInit();
            this.tercero.SuspendLayout();
            this.segundo.SuspendLayout();
            this.pnlCompras.SuspendLayout();
            this.pnlNuevaCompra.SuspendLayout();
            this.pnlFactura.SuspendLayout();
            this.primero.SuspendLayout();
            this.pnlRetiroInventario.SuspendLayout();
            this.pnlEncabezadoNuevoCompra.SuspendLayout();
            this.pnlDatosPagos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidad)).BeginInit();
            this.pnlSeleccioFormulario.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgInventario
            // 
            this.dtgInventario.AllowUserToAddRows = false;
            this.dtgInventario.AllowUserToDeleteRows = false;
            this.dtgInventario.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dtgInventario.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgInventario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgInventario.BackgroundColor = System.Drawing.Color.White;
            this.dtgInventario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgInventario.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgInventario.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgInventario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgInventario.ColumnHeadersHeight = 38;
            this.dtgInventario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.id,
            this.Column1,
            this.Column6,
            this.Column7,
            this.Column8,
            this.imagenFactura,
            this.Column2});
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgInventario.DefaultCellStyle = dataGridViewCellStyle10;
            this.dtgInventario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgInventario.EnableHeadersVisualStyles = false;
            this.dtgInventario.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgInventario.Location = new System.Drawing.Point(0, 35);
            this.dtgInventario.Name = "dtgInventario";
            this.dtgInventario.ReadOnly = true;
            this.dtgInventario.RowHeadersVisible = false;
            this.dtgInventario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgInventario.Size = new System.Drawing.Size(960, 497);
            this.dtgInventario.TabIndex = 19;
            this.dtgInventario.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dtgInventario.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgInventario.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dtgInventario.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dtgInventario.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dtgInventario.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dtgInventario.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dtgInventario.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgInventario.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtgInventario.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgInventario.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgInventario.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtgInventario.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dtgInventario.ThemeStyle.HeaderStyle.Height = 38;
            this.dtgInventario.ThemeStyle.ReadOnly = true;
            this.dtgInventario.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgInventario.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgInventario.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgInventario.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dtgInventario.ThemeStyle.RowsStyle.Height = 22;
            this.dtgInventario.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgInventario.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtgInventario.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgInventario_CellDoubleClick);
            // 
            // Column3
            // 
            dataGridViewCellStyle3.Format = "N0";
            dataGridViewCellStyle3.NullValue = null;
            this.Column3.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column3.HeaderText = "Id";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Visible = false;
            // 
            // id
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.Format = "N0";
            dataGridViewCellStyle4.NullValue = "-";
            this.id.DefaultCellStyle = dataGridViewCellStyle4;
            this.id.FillWeight = 70F;
            this.id.HeaderText = "No. Compra";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // Column1
            // 
            dataGridViewCellStyle5.Format = "N0";
            dataGridViewCellStyle5.NullValue = null;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle5;
            this.Column1.HeaderText = "Cantidad";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column6
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.NullValue = null;
            this.Column6.DefaultCellStyle = dataGridViewCellStyle6;
            this.Column6.FillWeight = 150F;
            this.Column6.HeaderText = "Descripcion";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.Format = "C4";
            dataGridViewCellStyle7.NullValue = "-";
            this.Column7.DefaultCellStyle = dataGridViewCellStyle7;
            this.Column7.FillWeight = 60F;
            this.Column7.HeaderText = "P/U";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.Format = "C4";
            dataGridViewCellStyle8.NullValue = "-";
            this.Column8.DefaultCellStyle = dataGridViewCellStyle8;
            this.Column8.FillWeight = 60F;
            this.Column8.HeaderText = "Subtotal";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // imagenFactura
            // 
            dataGridViewCellStyle9.Format = "N0";
            dataGridViewCellStyle9.NullValue = "-";
            this.imagenFactura.DefaultCellStyle = dataGridViewCellStyle9;
            this.imagenFactura.FillWeight = 60F;
            this.imagenFactura.HeaderText = "Utilizado";
            this.imagenFactura.Name = "imagenFactura";
            this.imagenFactura.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.FillWeight = 60F;
            this.Column2.HeaderText = "Estado";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // tercero
            // 
            this.tercero.Controls.Add(this.lblTotal);
            this.tercero.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tercero.Location = new System.Drawing.Point(0, 532);
            this.tercero.Name = "tercero";
            this.tercero.Padding = new System.Windows.Forms.Padding(5);
            this.tercero.Size = new System.Drawing.Size(960, 38);
            this.tercero.TabIndex = 34;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTotal.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(5, 5);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(52, 17);
            this.lblTotal.TabIndex = 29;
            this.lblTotal.Text = "0.0000";
            // 
            // segundo
            // 
            this.segundo.Controls.Add(this.btnReporte);
            this.segundo.Controls.Add(this.btnDesplagarMenu);
            this.segundo.Controls.Add(this.lblNombreTabla);
            this.segundo.Dock = System.Windows.Forms.DockStyle.Top;
            this.segundo.Location = new System.Drawing.Point(0, 0);
            this.segundo.Name = "segundo";
            this.segundo.Padding = new System.Windows.Forms.Padding(0, 5, 5, 5);
            this.segundo.Size = new System.Drawing.Size(960, 35);
            this.segundo.TabIndex = 33;
            // 
            // btnReporte
            // 
            this.btnReporte.CheckedState.Parent = this.btnReporte;
            this.btnReporte.CustomImages.Parent = this.btnReporte;
            this.btnReporte.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnReporte.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnReporte.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnReporte.ForeColor = System.Drawing.Color.White;
            this.btnReporte.HoverState.Parent = this.btnReporte;
            this.btnReporte.Location = new System.Drawing.Point(715, 5);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.ShadowDecoration.Parent = this.btnReporte;
            this.btnReporte.Size = new System.Drawing.Size(120, 25);
            this.btnReporte.TabIndex = 33;
            this.btnReporte.Text = "Reporte";
            // 
            // btnDesplagarMenu
            // 
            this.btnDesplagarMenu.CheckedState.Parent = this.btnDesplagarMenu;
            this.btnDesplagarMenu.CustomImages.Parent = this.btnDesplagarMenu;
            this.btnDesplagarMenu.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnDesplagarMenu.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDesplagarMenu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDesplagarMenu.ForeColor = System.Drawing.Color.White;
            this.btnDesplagarMenu.HoverState.Parent = this.btnDesplagarMenu;
            this.btnDesplagarMenu.Location = new System.Drawing.Point(835, 5);
            this.btnDesplagarMenu.Name = "btnDesplagarMenu";
            this.btnDesplagarMenu.ShadowDecoration.Parent = this.btnDesplagarMenu;
            this.btnDesplagarMenu.Size = new System.Drawing.Size(120, 25);
            this.btnDesplagarMenu.TabIndex = 32;
            this.btnDesplagarMenu.Text = "Retirar Inventario";
            this.btnDesplagarMenu.Click += new System.EventHandler(this.btnDesplagarMenu_Click);
            // 
            // lblNombreTabla
            // 
            this.lblNombreTabla.AutoSize = true;
            this.lblNombreTabla.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblNombreTabla.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreTabla.Location = new System.Drawing.Point(0, 5);
            this.lblNombreTabla.Name = "lblNombreTabla";
            this.lblNombreTabla.Size = new System.Drawing.Size(107, 19);
            this.lblNombreTabla.TabIndex = 20;
            this.lblNombreTabla.Text = "INVENTARIO";
            // 
            // pnlCompras
            // 
            this.pnlCompras.BackColor = System.Drawing.Color.White;
            this.pnlCompras.Controls.Add(this.pnlNuevaCompra);
            this.pnlCompras.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCompras.Location = new System.Drawing.Point(0, 30);
            this.pnlCompras.Name = "pnlCompras";
            this.pnlCompras.Padding = new System.Windows.Forms.Padding(10);
            this.pnlCompras.ShadowDecoration.Parent = this.pnlCompras;
            this.pnlCompras.Size = new System.Drawing.Size(1000, 590);
            this.pnlCompras.TabIndex = 3;
            // 
            // pnlNuevaCompra
            // 
            this.pnlNuevaCompra.Controls.Add(this.pnlFactura);
            this.pnlNuevaCompra.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlNuevaCompra.Location = new System.Drawing.Point(10, 10);
            this.pnlNuevaCompra.Name = "pnlNuevaCompra";
            this.pnlNuevaCompra.ShadowDecoration.Parent = this.pnlNuevaCompra;
            this.pnlNuevaCompra.Size = new System.Drawing.Size(980, 570);
            this.pnlNuevaCompra.TabIndex = 1;
            // 
            // pnlFactura
            // 
            this.pnlFactura.BackColor = System.Drawing.Color.White;
            this.pnlFactura.Controls.Add(this.primero);
            this.pnlFactura.Controls.Add(this.pnlRetiroInventario);
            this.pnlFactura.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFactura.Location = new System.Drawing.Point(0, 0);
            this.pnlFactura.Name = "pnlFactura";
            this.pnlFactura.ShadowDecoration.Parent = this.pnlFactura;
            this.pnlFactura.Size = new System.Drawing.Size(980, 570);
            this.pnlFactura.TabIndex = 1;
            // 
            // primero
            // 
            this.primero.Controls.Add(this.dtgInventario);
            this.primero.Controls.Add(this.tercero);
            this.primero.Controls.Add(this.segundo);
            this.primero.Dock = System.Windows.Forms.DockStyle.Fill;
            this.primero.Location = new System.Drawing.Point(0, 0);
            this.primero.Name = "primero";
            this.primero.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.primero.Size = new System.Drawing.Size(970, 570);
            this.primero.TabIndex = 36;
            // 
            // pnlRetiroInventario
            // 
            this.pnlRetiroInventario.BackColor = System.Drawing.Color.Transparent;
            this.pnlRetiroInventario.BorderColor = System.Drawing.Color.Silver;
            this.pnlRetiroInventario.BorderRadius = 14;
            this.pnlRetiroInventario.BorderThickness = 1;
            this.pnlRetiroInventario.Controls.Add(this.btnModificar);
            this.pnlRetiroInventario.Controls.Add(this.btnAgregar);
            this.pnlRetiroInventario.Controls.Add(this.pnlEncabezadoNuevoCompra);
            this.pnlRetiroInventario.Controls.Add(this.pnlDatosPagos);
            this.pnlRetiroInventario.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlRetiroInventario.Enabled = false;
            this.pnlRetiroInventario.FillColor = System.Drawing.SystemColors.Control;
            this.pnlRetiroInventario.Location = new System.Drawing.Point(970, 0);
            this.pnlRetiroInventario.Name = "pnlRetiroInventario";
            this.pnlRetiroInventario.Padding = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.pnlRetiroInventario.ShadowDecoration.Parent = this.pnlRetiroInventario;
            this.pnlRetiroInventario.Size = new System.Drawing.Size(10, 570);
            this.pnlRetiroInventario.TabIndex = 18;
            // 
            // btnModificar
            // 
            this.btnModificar.CheckedState.Parent = this.btnModificar;
            this.btnModificar.CustomImages.Parent = this.btnModificar;
            this.btnModificar.Enabled = false;
            this.btnModificar.FillColor = System.Drawing.Color.Gray;
            this.btnModificar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.Color.White;
            this.btnModificar.HoverState.Parent = this.btnModificar;
            this.btnModificar.Location = new System.Drawing.Point(221, 573);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.ShadowDecoration.Parent = this.btnModificar;
            this.btnModificar.Size = new System.Drawing.Size(160, 35);
            this.btnModificar.TabIndex = 15;
            this.btnModificar.Text = "Modificar";
            // 
            // btnAgregar
            // 
            this.btnAgregar.CheckedState.Parent = this.btnAgregar;
            this.btnAgregar.CustomImages.Parent = this.btnAgregar;
            this.btnAgregar.FillColor = System.Drawing.Color.Gray;
            this.btnAgregar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.HoverState.Parent = this.btnAgregar;
            this.btnAgregar.Location = new System.Drawing.Point(20, 573);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.ShadowDecoration.Parent = this.btnAgregar;
            this.btnAgregar.Size = new System.Drawing.Size(160, 35);
            this.btnAgregar.TabIndex = 14;
            this.btnAgregar.Text = "Agregar";
            // 
            // pnlEncabezadoNuevoCompra
            // 
            this.pnlEncabezadoNuevoCompra.BackColor = System.Drawing.Color.Transparent;
            this.pnlEncabezadoNuevoCompra.BorderColor = System.Drawing.Color.Silver;
            this.pnlEncabezadoNuevoCompra.BorderRadius = 14;
            this.pnlEncabezadoNuevoCompra.BorderThickness = 1;
            this.pnlEncabezadoNuevoCompra.Controls.Add(this.label2);
            this.pnlEncabezadoNuevoCompra.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEncabezadoNuevoCompra.FillColor = System.Drawing.Color.DarkGray;
            this.pnlEncabezadoNuevoCompra.Location = new System.Drawing.Point(20, 10);
            this.pnlEncabezadoNuevoCompra.Name = "pnlEncabezadoNuevoCompra";
            this.pnlEncabezadoNuevoCompra.ShadowDecoration.Parent = this.pnlEncabezadoNuevoCompra;
            this.pnlEncabezadoNuevoCompra.Size = new System.Drawing.Size(0, 35);
            this.pnlEncabezadoNuevoCompra.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(-148, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "RETIRO DE INVENTARIO";
            // 
            // pnlDatosPagos
            // 
            this.pnlDatosPagos.BorderColor = System.Drawing.Color.Silver;
            this.pnlDatosPagos.BorderRadius = 14;
            this.pnlDatosPagos.BorderThickness = 1;
            this.pnlDatosPagos.Controls.Add(this.rdAgregarInventario);
            this.pnlDatosPagos.Controls.Add(this.rdRetirarInventario);
            this.pnlDatosPagos.Controls.Add(this.txtTotal);
            this.pnlDatosPagos.Controls.Add(this.label3);
            this.pnlDatosPagos.Controls.Add(this.btnRealizarRetiro);
            this.pnlDatosPagos.Controls.Add(this.label1);
            this.pnlDatosPagos.Controls.Add(this.txtMotivo);
            this.pnlDatosPagos.Controls.Add(this.txtCantidad);
            this.pnlDatosPagos.Controls.Add(this.lblIdCompra);
            this.pnlDatosPagos.Controls.Add(this.txtFecha);
            this.pnlDatosPagos.Controls.Add(this.label11);
            this.pnlDatosPagos.Controls.Add(this.label10);
            this.pnlDatosPagos.Controls.Add(this.label5);
            this.pnlDatosPagos.Controls.Add(this.txtValor);
            this.pnlDatosPagos.Controls.Add(this.txtMaterial);
            this.pnlDatosPagos.Controls.Add(this.label9);
            this.pnlDatosPagos.Location = new System.Drawing.Point(20, 55);
            this.pnlDatosPagos.Name = "pnlDatosPagos";
            this.pnlDatosPagos.Padding = new System.Windows.Forms.Padding(10);
            this.pnlDatosPagos.ShadowDecoration.Parent = this.pnlDatosPagos;
            this.pnlDatosPagos.Size = new System.Drawing.Size(361, 419);
            this.pnlDatosPagos.TabIndex = 23;
            // 
            // rdAgregarInventario
            // 
            this.rdAgregarInventario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rdAgregarInventario.BackgroundImage = global::SIDAC.Properties.Resources.AgregarInventario;
            this.rdAgregarInventario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rdAgregarInventario.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdAgregarInventario.CheckedState.BorderThickness = 0;
            this.rdAgregarInventario.CheckedState.FillColor = System.Drawing.Color.LimeGreen;
            this.rdAgregarInventario.CheckedState.InnerColor = System.Drawing.Color.CornflowerBlue;
            this.rdAgregarInventario.CheckedState.Parent = this.rdAgregarInventario;
            this.rdAgregarInventario.Location = new System.Drawing.Point(190, 32);
            this.rdAgregarInventario.Name = "rdAgregarInventario";
            this.rdAgregarInventario.ShadowDecoration.Parent = this.rdAgregarInventario;
            this.rdAgregarInventario.Size = new System.Drawing.Size(29, 30);
            this.rdAgregarInventario.TabIndex = 36;
            this.rdAgregarInventario.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rdAgregarInventario.UncheckedState.BorderThickness = 0;
            this.rdAgregarInventario.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdAgregarInventario.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rdAgregarInventario.UncheckedState.Parent = this.rdAgregarInventario;
            this.rdAgregarInventario.CheckedChanged += new System.EventHandler(this.rdAgregarInventario_CheckedChanged);
            // 
            // rdRetirarInventario
            // 
            this.rdRetirarInventario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rdRetirarInventario.BackgroundImage = global::SIDAC.Properties.Resources.RetiroInventario;
            this.rdRetirarInventario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rdRetirarInventario.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdRetirarInventario.CheckedState.BorderThickness = 0;
            this.rdRetirarInventario.CheckedState.FillColor = System.Drawing.Color.Red;
            this.rdRetirarInventario.CheckedState.InnerColor = System.Drawing.Color.CornflowerBlue;
            this.rdRetirarInventario.CheckedState.Parent = this.rdRetirarInventario;
            this.rdRetirarInventario.Location = new System.Drawing.Point(225, 32);
            this.rdRetirarInventario.Name = "rdRetirarInventario";
            this.rdRetirarInventario.ShadowDecoration.Parent = this.rdRetirarInventario;
            this.rdRetirarInventario.Size = new System.Drawing.Size(29, 30);
            this.rdRetirarInventario.TabIndex = 35;
            this.rdRetirarInventario.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rdRetirarInventario.UncheckedState.BorderThickness = 0;
            this.rdRetirarInventario.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdRetirarInventario.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rdRetirarInventario.UncheckedState.Parent = this.rdRetirarInventario;
            this.rdRetirarInventario.CheckedChanged += new System.EventHandler(this.rdRetirarInventario_CheckedChanged);
            // 
            // txtTotal
            // 
            this.txtTotal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTotal.DefaultText = "";
            this.txtTotal.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTotal.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTotal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTotal.DisabledState.Parent = this.txtTotal;
            this.txtTotal.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTotal.Enabled = false;
            this.txtTotal.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTotal.FocusedState.Parent = this.txtTotal;
            this.txtTotal.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTotal.HoverState.Parent = this.txtTotal;
            this.txtTotal.Location = new System.Drawing.Point(189, 143);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.PasswordChar = '\0';
            this.txtTotal.PlaceholderText = "0.00";
            this.txtTotal.SelectedText = "";
            this.txtTotal.ShadowDecoration.Parent = this.txtTotal;
            this.txtTotal.Size = new System.Drawing.Size(150, 30);
            this.txtTotal.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(185, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 18);
            this.label3.TabIndex = 31;
            this.label3.Text = "Total:";
            // 
            // btnRealizarRetiro
            // 
            this.btnRealizarRetiro.BorderColor = System.Drawing.Color.DimGray;
            this.btnRealizarRetiro.BorderRadius = 7;
            this.btnRealizarRetiro.BorderThickness = 1;
            this.btnRealizarRetiro.CheckedState.Parent = this.btnRealizarRetiro;
            this.btnRealizarRetiro.CustomImages.Parent = this.btnRealizarRetiro;
            this.btnRealizarRetiro.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnRealizarRetiro.FillColor = System.Drawing.Color.Gray;
            this.btnRealizarRetiro.Font = new System.Drawing.Font("Arial", 12F);
            this.btnRealizarRetiro.ForeColor = System.Drawing.Color.White;
            this.btnRealizarRetiro.HoverState.Parent = this.btnRealizarRetiro;
            this.btnRealizarRetiro.Location = new System.Drawing.Point(10, 379);
            this.btnRealizarRetiro.Name = "btnRealizarRetiro";
            this.btnRealizarRetiro.ShadowDecoration.Parent = this.btnRealizarRetiro;
            this.btnRealizarRetiro.Size = new System.Drawing.Size(341, 30);
            this.btnRealizarRetiro.TabIndex = 30;
            this.btnRealizarRetiro.Text = "Retirar material";
            this.btnRealizarRetiro.Click += new System.EventHandler(this.btnRealizarRetiro_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 243);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 18);
            this.label1.TabIndex = 27;
            this.label1.Text = "Razón por la cual retiro inventario:";
            // 
            // txtMotivo
            // 
            this.txtMotivo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMotivo.DefaultText = "";
            this.txtMotivo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMotivo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMotivo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMotivo.DisabledState.Parent = this.txtMotivo;
            this.txtMotivo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMotivo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMotivo.FocusedState.Parent = this.txtMotivo;
            this.txtMotivo.Font = new System.Drawing.Font("Arial", 12F);
            this.txtMotivo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMotivo.HoverState.Parent = this.txtMotivo;
            this.txtMotivo.Location = new System.Drawing.Point(16, 264);
            this.txtMotivo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMotivo.Multiline = true;
            this.txtMotivo.Name = "txtMotivo";
            this.txtMotivo.PasswordChar = '\0';
            this.txtMotivo.PlaceholderText = "";
            this.txtMotivo.SelectedText = "";
            this.txtMotivo.ShadowDecoration.Parent = this.txtMotivo;
            this.txtMotivo.Size = new System.Drawing.Size(327, 96);
            this.txtMotivo.TabIndex = 28;
            // 
            // txtCantidad
            // 
            this.txtCantidad.BackColor = System.Drawing.Color.Transparent;
            this.txtCantidad.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCantidad.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCantidad.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCantidad.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCantidad.DisabledState.Parent = this.txtCantidad;
            this.txtCantidad.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
            this.txtCantidad.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.txtCantidad.Enabled = false;
            this.txtCantidad.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCantidad.FocusedState.Parent = this.txtCantidad;
            this.txtCantidad.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCantidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.txtCantidad.Location = new System.Drawing.Point(260, 32);
            this.txtCantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.ShadowDecoration.Parent = this.txtCantidad;
            this.txtCantidad.Size = new System.Drawing.Size(79, 30);
            this.txtCantidad.TabIndex = 26;
            this.txtCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtCantidad.ValueChanged += new System.EventHandler(this.txtCantidad_ValueChanged);
            // 
            // lblIdCompra
            // 
            this.lblIdCompra.AutoSize = true;
            this.lblIdCompra.Location = new System.Drawing.Point(257, 11);
            this.lblIdCompra.Name = "lblIdCompra";
            this.lblIdCompra.Size = new System.Drawing.Size(76, 18);
            this.lblIdCompra.TabIndex = 25;
            this.lblIdCompra.Text = "Cantidad:";
            // 
            // txtFecha
            // 
            this.txtFecha.BorderColor = System.Drawing.Color.Gainsboro;
            this.txtFecha.BorderThickness = 1;
            this.txtFecha.CheckedState.Parent = this.txtFecha;
            this.txtFecha.CustomFormat = "dd/MM/yyyy";
            this.txtFecha.FillColor = System.Drawing.Color.White;
            this.txtFecha.Font = new System.Drawing.Font("Arial", 12F);
            this.txtFecha.ForeColor = System.Drawing.Color.Gray;
            this.txtFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtFecha.HoverState.Parent = this.txtFecha;
            this.txtFecha.Location = new System.Drawing.Point(15, 202);
            this.txtFecha.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtFecha.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.ShadowDecoration.Parent = this.txtFecha;
            this.txtFecha.Size = new System.Drawing.Size(151, 30);
            this.txtFecha.TabIndex = 22;
            this.txtFecha.Value = new System.DateTime(2021, 6, 27, 8, 21, 18, 928);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(16, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(127, 19);
            this.label11.TabIndex = 8;
            this.label11.Text = "Datos de retiro:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 181);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 18);
            this.label10.TabIndex = 21;
            this.label10.Text = "Fecha:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Material:";
            // 
            // txtValor
            // 
            this.txtValor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtValor.DefaultText = "";
            this.txtValor.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtValor.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtValor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtValor.DisabledState.Parent = this.txtValor;
            this.txtValor.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtValor.Enabled = false;
            this.txtValor.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtValor.FocusedState.Parent = this.txtValor;
            this.txtValor.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtValor.HoverState.Parent = this.txtValor;
            this.txtValor.Location = new System.Drawing.Point(15, 143);
            this.txtValor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtValor.Name = "txtValor";
            this.txtValor.PasswordChar = '\0';
            this.txtValor.PlaceholderText = "0.00";
            this.txtValor.SelectedText = "";
            this.txtValor.ShadowDecoration.Parent = this.txtValor;
            this.txtValor.Size = new System.Drawing.Size(150, 30);
            this.txtValor.TabIndex = 20;
            // 
            // txtMaterial
            // 
            this.txtMaterial.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaterial.DefaultText = "";
            this.txtMaterial.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMaterial.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMaterial.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaterial.DisabledState.Parent = this.txtMaterial;
            this.txtMaterial.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaterial.Enabled = false;
            this.txtMaterial.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaterial.FocusedState.Parent = this.txtMaterial;
            this.txtMaterial.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaterial.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaterial.HoverState.Parent = this.txtMaterial;
            this.txtMaterial.Location = new System.Drawing.Point(14, 86);
            this.txtMaterial.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMaterial.Name = "txtMaterial";
            this.txtMaterial.PasswordChar = '\0';
            this.txtMaterial.PlaceholderText = "";
            this.txtMaterial.SelectedText = "";
            this.txtMaterial.ShadowDecoration.Parent = this.txtMaterial;
            this.txtMaterial.Size = new System.Drawing.Size(327, 30);
            this.txtMaterial.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 121);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(133, 18);
            this.label9.TabIndex = 19;
            this.label9.Text = "Valor del material:";
            // 
            // pnlSeleccioFormulario
            // 
            this.pnlSeleccioFormulario.BackColor = System.Drawing.Color.Silver;
            this.pnlSeleccioFormulario.Controls.Add(this.btnRegistro);
            this.pnlSeleccioFormulario.Controls.Add(this.btnAgotados);
            this.pnlSeleccioFormulario.Controls.Add(this.btnStock);
            this.pnlSeleccioFormulario.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSeleccioFormulario.Location = new System.Drawing.Point(0, 0);
            this.pnlSeleccioFormulario.Name = "pnlSeleccioFormulario";
            this.pnlSeleccioFormulario.Padding = new System.Windows.Forms.Padding(5);
            this.pnlSeleccioFormulario.ShadowDecoration.Parent = this.pnlSeleccioFormulario;
            this.pnlSeleccioFormulario.Size = new System.Drawing.Size(1000, 30);
            this.pnlSeleccioFormulario.TabIndex = 2;
            // 
            // btnRegistro
            // 
            this.btnRegistro.CheckedState.Parent = this.btnRegistro;
            this.btnRegistro.CustomImages.Parent = this.btnRegistro;
            this.btnRegistro.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnRegistro.FillColor = System.Drawing.Color.Gray;
            this.btnRegistro.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRegistro.ForeColor = System.Drawing.Color.White;
            this.btnRegistro.HoverState.Parent = this.btnRegistro;
            this.btnRegistro.Location = new System.Drawing.Point(245, 5);
            this.btnRegistro.Name = "btnRegistro";
            this.btnRegistro.ShadowDecoration.Parent = this.btnRegistro;
            this.btnRegistro.Size = new System.Drawing.Size(120, 20);
            this.btnRegistro.TabIndex = 36;
            this.btnRegistro.Text = "Registro E/S";
            this.btnRegistro.Click += new System.EventHandler(this.btnRegistro_Click);
            // 
            // btnAgotados
            // 
            this.btnAgotados.CheckedState.Parent = this.btnAgotados;
            this.btnAgotados.CustomImages.Parent = this.btnAgotados;
            this.btnAgotados.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAgotados.FillColor = System.Drawing.Color.Gray;
            this.btnAgotados.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAgotados.ForeColor = System.Drawing.Color.White;
            this.btnAgotados.HoverState.Parent = this.btnAgotados;
            this.btnAgotados.Location = new System.Drawing.Point(125, 5);
            this.btnAgotados.Name = "btnAgotados";
            this.btnAgotados.ShadowDecoration.Parent = this.btnAgotados;
            this.btnAgotados.Size = new System.Drawing.Size(120, 20);
            this.btnAgotados.TabIndex = 35;
            this.btnAgotados.Text = "Agotados";
            this.btnAgotados.Click += new System.EventHandler(this.btnAgotados_Click);
            // 
            // btnStock
            // 
            this.btnStock.CheckedState.Parent = this.btnStock;
            this.btnStock.CustomImages.Parent = this.btnStock;
            this.btnStock.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnStock.FillColor = System.Drawing.Color.Gray;
            this.btnStock.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnStock.ForeColor = System.Drawing.Color.White;
            this.btnStock.HoverState.Parent = this.btnStock;
            this.btnStock.Location = new System.Drawing.Point(5, 5);
            this.btnStock.Name = "btnStock";
            this.btnStock.ShadowDecoration.Parent = this.btnStock;
            this.btnStock.Size = new System.Drawing.Size(120, 20);
            this.btnStock.TabIndex = 34;
            this.btnStock.Text = "Stock";
            this.btnStock.Click += new System.EventHandler(this.btnStock_Click);
            // 
            // FrmInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 620);
            this.Controls.Add(this.pnlCompras);
            this.Controls.Add(this.pnlSeleccioFormulario);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmInventario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmInventario";
            ((System.ComponentModel.ISupportInitialize)(this.dtgInventario)).EndInit();
            this.tercero.ResumeLayout(false);
            this.tercero.PerformLayout();
            this.segundo.ResumeLayout(false);
            this.segundo.PerformLayout();
            this.pnlCompras.ResumeLayout(false);
            this.pnlNuevaCompra.ResumeLayout(false);
            this.pnlFactura.ResumeLayout(false);
            this.primero.ResumeLayout(false);
            this.pnlRetiroInventario.ResumeLayout(false);
            this.pnlEncabezadoNuevoCompra.ResumeLayout(false);
            this.pnlEncabezadoNuevoCompra.PerformLayout();
            this.pnlDatosPagos.ResumeLayout(false);
            this.pnlDatosPagos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidad)).EndInit();
            this.pnlSeleccioFormulario.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dtgInventario;
        private System.Windows.Forms.Panel tercero;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Panel segundo;
        private System.Windows.Forms.Label lblNombreTabla;
        private Guna.UI2.WinForms.Guna2Panel pnlCompras;
        private Guna.UI2.WinForms.Guna2Panel pnlNuevaCompra;
        private Guna.UI2.WinForms.Guna2Panel pnlFactura;
        private System.Windows.Forms.Panel primero;
        private Guna.UI2.WinForms.Guna2Panel pnlRetiroInventario;
        private Guna.UI2.WinForms.Guna2Button btnModificar;
        private Guna.UI2.WinForms.Guna2Button btnAgregar;
        private Guna.UI2.WinForms.Guna2Panel pnlEncabezadoNuevoCompra;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Panel pnlDatosPagos;
        private System.Windows.Forms.Label lblIdCompra;
        private Guna.UI2.WinForms.Guna2DateTimePicker txtFecha;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox txtValor;
        private Guna.UI2.WinForms.Guna2TextBox txtMaterial;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2Panel pnlSeleccioFormulario;
        private Guna.UI2.WinForms.Guna2Button btnDesplagarMenu;
        private Guna.UI2.WinForms.Guna2NumericUpDown txtCantidad;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtMotivo;
        private Guna.UI2.WinForms.Guna2Button btnRealizarRetiro;
        private Guna.UI2.WinForms.Guna2TextBox txtTotal;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button btnReporte;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn imagenFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private Guna.UI2.WinForms.Guna2Button btnAgotados;
        private Guna.UI2.WinForms.Guna2Button btnStock;
        private Guna.UI2.WinForms.Guna2CustomRadioButton rdAgregarInventario;
        private Guna.UI2.WinForms.Guna2CustomRadioButton rdRetirarInventario;
        private Guna.UI2.WinForms.Guna2Button btnRegistro;
    }
}