
namespace SIDAC.VISTA
{
    partial class FrmCompras
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlSeleccioFormulario = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlCompras = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlNuevaCompra = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlFactura = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlDatosPagos = new Guna.UI2.WinForms.Guna2Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.txtProveedor = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtValor = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtFecha = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lblIdCompra = new System.Windows.Forms.Label();
            this.txtNumeroCompra = new Guna.UI2.WinForms.Guna2TextBox();
            this.pnlEncabezadoNuevoCompra = new Guna.UI2.WinForms.Guna2Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAgregar = new Guna.UI2.WinForms.Guna2Button();
            this.btnModificar = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ptrFactura = new System.Windows.Forms.PictureBox();
            this.btnRealizarCompra = new Guna.UI2.WinForms.Guna2Button();
            this.pnlNuevoCompra = new Guna.UI2.WinForms.Guna2Panel();
            this.primero = new System.Windows.Forms.Panel();
            this.dtgCompras = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imagenFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tercero = new System.Windows.Forms.Panel();
            this.btnActualizar = new Guna.UI2.WinForms.Guna2Button();
            this.lblTotalCompras = new System.Windows.Forms.Label();
            this.btnEliminar = new Guna.UI2.WinForms.Guna2Button();
            this.label7 = new System.Windows.Forms.Label();
            this.segundo = new System.Windows.Forms.Panel();
            this.btnDesplagarMenu = new Guna.UI2.WinForms.Guna2Button();
            this.label6 = new System.Windows.Forms.Label();
            this.pnlCompras.SuspendLayout();
            this.pnlNuevaCompra.SuspendLayout();
            this.pnlFactura.SuspendLayout();
            this.pnlDatosPagos.SuspendLayout();
            this.pnlEncabezadoNuevoCompra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptrFactura)).BeginInit();
            this.pnlNuevoCompra.SuspendLayout();
            this.primero.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCompras)).BeginInit();
            this.tercero.SuspendLayout();
            this.segundo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSeleccioFormulario
            // 
            this.pnlSeleccioFormulario.BackColor = System.Drawing.Color.Silver;
            this.pnlSeleccioFormulario.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSeleccioFormulario.Location = new System.Drawing.Point(0, 0);
            this.pnlSeleccioFormulario.Name = "pnlSeleccioFormulario";
            this.pnlSeleccioFormulario.ShadowDecoration.Parent = this.pnlSeleccioFormulario;
            this.pnlSeleccioFormulario.Size = new System.Drawing.Size(984, 30);
            this.pnlSeleccioFormulario.TabIndex = 0;
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
            this.pnlCompras.Size = new System.Drawing.Size(984, 551);
            this.pnlCompras.TabIndex = 1;
            // 
            // pnlNuevaCompra
            // 
            this.pnlNuevaCompra.Controls.Add(this.pnlFactura);
            this.pnlNuevaCompra.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlNuevaCompra.Location = new System.Drawing.Point(10, 10);
            this.pnlNuevaCompra.Name = "pnlNuevaCompra";
            this.pnlNuevaCompra.ShadowDecoration.Parent = this.pnlNuevaCompra;
            this.pnlNuevaCompra.Size = new System.Drawing.Size(964, 531);
            this.pnlNuevaCompra.TabIndex = 1;
            // 
            // pnlFactura
            // 
            this.pnlFactura.BackColor = System.Drawing.Color.White;
            this.pnlFactura.Controls.Add(this.primero);
            this.pnlFactura.Controls.Add(this.pnlNuevoCompra);
            this.pnlFactura.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFactura.Location = new System.Drawing.Point(0, 0);
            this.pnlFactura.Name = "pnlFactura";
            this.pnlFactura.ShadowDecoration.Parent = this.pnlFactura;
            this.pnlFactura.Size = new System.Drawing.Size(964, 531);
            this.pnlFactura.TabIndex = 1;
            // 
            // pnlDatosPagos
            // 
            this.pnlDatosPagos.BorderColor = System.Drawing.Color.Silver;
            this.pnlDatosPagos.BorderRadius = 14;
            this.pnlDatosPagos.BorderThickness = 1;
            this.pnlDatosPagos.Controls.Add(this.txtNumeroCompra);
            this.pnlDatosPagos.Controls.Add(this.lblIdCompra);
            this.pnlDatosPagos.Controls.Add(this.txtFecha);
            this.pnlDatosPagos.Controls.Add(this.label11);
            this.pnlDatosPagos.Controls.Add(this.label10);
            this.pnlDatosPagos.Controls.Add(this.label5);
            this.pnlDatosPagos.Controls.Add(this.txtValor);
            this.pnlDatosPagos.Controls.Add(this.txtProveedor);
            this.pnlDatosPagos.Controls.Add(this.label9);
            this.pnlDatosPagos.Location = new System.Drawing.Point(20, 55);
            this.pnlDatosPagos.Name = "pnlDatosPagos";
            this.pnlDatosPagos.Padding = new System.Windows.Forms.Padding(10);
            this.pnlDatosPagos.ShadowDecoration.Parent = this.pnlDatosPagos;
            this.pnlDatosPagos.Size = new System.Drawing.Size(361, 186);
            this.pnlDatosPagos.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 121);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 18);
            this.label9.TabIndex = 19;
            this.label9.Text = "Valor:";
            // 
            // txtProveedor
            // 
            this.txtProveedor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtProveedor.DefaultText = "";
            this.txtProveedor.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtProveedor.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtProveedor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtProveedor.DisabledState.Parent = this.txtProveedor;
            this.txtProveedor.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtProveedor.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtProveedor.FocusedState.Parent = this.txtProveedor;
            this.txtProveedor.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProveedor.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtProveedor.HoverState.Parent = this.txtProveedor;
            this.txtProveedor.Location = new System.Drawing.Point(14, 86);
            this.txtProveedor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtProveedor.Name = "txtProveedor";
            this.txtProveedor.PasswordChar = '\0';
            this.txtProveedor.PlaceholderText = "";
            this.txtProveedor.SelectedText = "";
            this.txtProveedor.ShadowDecoration.Parent = this.txtProveedor;
            this.txtProveedor.Size = new System.Drawing.Size(327, 30);
            this.txtProveedor.TabIndex = 9;
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Proveedor:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(186, 122);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 18);
            this.label10.TabIndex = 21;
            this.label10.Text = "Fecha:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(16, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(139, 19);
            this.label11.TabIndex = 8;
            this.label11.Text = "Datos de compra";
            // 
            // txtFecha
            // 
            this.txtFecha.BorderColor = System.Drawing.Color.Gainsboro;
            this.txtFecha.BorderThickness = 1;
            this.txtFecha.CheckedState.Parent = this.txtFecha;
            this.txtFecha.FillColor = System.Drawing.Color.White;
            this.txtFecha.Font = new System.Drawing.Font("Arial", 12F);
            this.txtFecha.ForeColor = System.Drawing.Color.Gray;
            this.txtFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtFecha.HoverState.Parent = this.txtFecha;
            this.txtFecha.Location = new System.Drawing.Point(188, 143);
            this.txtFecha.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtFecha.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.ShadowDecoration.Parent = this.txtFecha;
            this.txtFecha.Size = new System.Drawing.Size(151, 30);
            this.txtFecha.TabIndex = 22;
            this.txtFecha.Value = new System.DateTime(2021, 6, 27, 8, 21, 18, 928);
            // 
            // lblIdCompra
            // 
            this.lblIdCompra.AutoSize = true;
            this.lblIdCompra.Location = new System.Drawing.Point(242, 11);
            this.lblIdCompra.Name = "lblIdCompra";
            this.lblIdCompra.Size = new System.Drawing.Size(97, 18);
            this.lblIdCompra.TabIndex = 25;
            this.lblIdCompra.Text = "No. Compra:";
            // 
            // txtNumeroCompra
            // 
            this.txtNumeroCompra.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNumeroCompra.DefaultText = "";
            this.txtNumeroCompra.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNumeroCompra.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNumeroCompra.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNumeroCompra.DisabledState.Parent = this.txtNumeroCompra;
            this.txtNumeroCompra.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNumeroCompra.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNumeroCompra.FocusedState.Parent = this.txtNumeroCompra;
            this.txtNumeroCompra.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroCompra.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNumeroCompra.HoverState.Parent = this.txtNumeroCompra;
            this.txtNumeroCompra.Location = new System.Drawing.Point(239, 33);
            this.txtNumeroCompra.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNumeroCompra.Name = "txtNumeroCompra";
            this.txtNumeroCompra.PasswordChar = '\0';
            this.txtNumeroCompra.PlaceholderText = "";
            this.txtNumeroCompra.SelectedText = "";
            this.txtNumeroCompra.ShadowDecoration.Parent = this.txtNumeroCompra;
            this.txtNumeroCompra.Size = new System.Drawing.Size(100, 30);
            this.txtNumeroCompra.TabIndex = 26;
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
            this.pnlEncabezadoNuevoCompra.DoubleClick += new System.EventHandler(this.pnlEncabezadoNuevoCompra_DoubleClick);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(-71, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "NUEVA COMPRA";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 244);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 19);
            this.label1.TabIndex = 27;
            this.label1.Text = "Factura";
            // 
            // ptrFactura
            // 
            this.ptrFactura.BackColor = System.Drawing.Color.Snow;
            this.ptrFactura.Location = new System.Drawing.Point(19, 276);
            this.ptrFactura.Name = "ptrFactura";
            this.ptrFactura.Size = new System.Drawing.Size(361, 194);
            this.ptrFactura.TabIndex = 28;
            this.ptrFactura.TabStop = false;
            this.ptrFactura.Click += new System.EventHandler(this.ptrFactura_Click);
            // 
            // btnRealizarCompra
            // 
            this.btnRealizarCompra.BorderColor = System.Drawing.Color.DimGray;
            this.btnRealizarCompra.BorderRadius = 7;
            this.btnRealizarCompra.BorderThickness = 1;
            this.btnRealizarCompra.CheckedState.Parent = this.btnRealizarCompra;
            this.btnRealizarCompra.CustomImages.Parent = this.btnRealizarCompra;
            this.btnRealizarCompra.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnRealizarCompra.FillColor = System.Drawing.Color.Gray;
            this.btnRealizarCompra.Font = new System.Drawing.Font("Arial", 12F);
            this.btnRealizarCompra.ForeColor = System.Drawing.Color.White;
            this.btnRealizarCompra.HoverState.Parent = this.btnRealizarCompra;
            this.btnRealizarCompra.Location = new System.Drawing.Point(20, 491);
            this.btnRealizarCompra.Name = "btnRealizarCompra";
            this.btnRealizarCompra.ShadowDecoration.Parent = this.btnRealizarCompra;
            this.btnRealizarCompra.Size = new System.Drawing.Size(0, 30);
            this.btnRealizarCompra.TabIndex = 29;
            this.btnRealizarCompra.Text = "Agregar compra";
            this.btnRealizarCompra.Click += new System.EventHandler(this.btnRealizarCompra_Click);
            // 
            // pnlNuevoCompra
            // 
            this.pnlNuevoCompra.BackColor = System.Drawing.Color.Transparent;
            this.pnlNuevoCompra.BorderColor = System.Drawing.Color.Silver;
            this.pnlNuevoCompra.BorderRadius = 14;
            this.pnlNuevoCompra.BorderThickness = 1;
            this.pnlNuevoCompra.Controls.Add(this.btnRealizarCompra);
            this.pnlNuevoCompra.Controls.Add(this.ptrFactura);
            this.pnlNuevoCompra.Controls.Add(this.label1);
            this.pnlNuevoCompra.Controls.Add(this.btnModificar);
            this.pnlNuevoCompra.Controls.Add(this.btnAgregar);
            this.pnlNuevoCompra.Controls.Add(this.pnlEncabezadoNuevoCompra);
            this.pnlNuevoCompra.Controls.Add(this.pnlDatosPagos);
            this.pnlNuevoCompra.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlNuevoCompra.Enabled = false;
            this.pnlNuevoCompra.FillColor = System.Drawing.SystemColors.Control;
            this.pnlNuevoCompra.Location = new System.Drawing.Point(954, 0);
            this.pnlNuevoCompra.Name = "pnlNuevoCompra";
            this.pnlNuevoCompra.Padding = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.pnlNuevoCompra.ShadowDecoration.Parent = this.pnlNuevoCompra;
            this.pnlNuevoCompra.Size = new System.Drawing.Size(10, 531);
            this.pnlNuevoCompra.TabIndex = 18;
            // 
            // primero
            // 
            this.primero.Controls.Add(this.dtgCompras);
            this.primero.Controls.Add(this.tercero);
            this.primero.Controls.Add(this.segundo);
            this.primero.Dock = System.Windows.Forms.DockStyle.Fill;
            this.primero.Location = new System.Drawing.Point(0, 0);
            this.primero.Name = "primero";
            this.primero.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.primero.Size = new System.Drawing.Size(954, 531);
            this.primero.TabIndex = 36;
            // 
            // dtgCompras
            // 
            this.dtgCompras.AllowUserToAddRows = false;
            this.dtgCompras.AllowUserToDeleteRows = false;
            this.dtgCompras.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dtgCompras.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgCompras.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgCompras.BackgroundColor = System.Drawing.Color.White;
            this.dtgCompras.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgCompras.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgCompras.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgCompras.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgCompras.ColumnHeadersHeight = 38;
            this.dtgCompras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.id,
            this.Column6,
            this.Column7,
            this.Column8,
            this.imagenFactura});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgCompras.DefaultCellStyle = dataGridViewCellStyle8;
            this.dtgCompras.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgCompras.EnableHeadersVisualStyles = false;
            this.dtgCompras.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgCompras.Location = new System.Drawing.Point(0, 35);
            this.dtgCompras.Name = "dtgCompras";
            this.dtgCompras.ReadOnly = true;
            this.dtgCompras.RowHeadersVisible = false;
            this.dtgCompras.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgCompras.Size = new System.Drawing.Size(944, 458);
            this.dtgCompras.TabIndex = 19;
            this.dtgCompras.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dtgCompras.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgCompras.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dtgCompras.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dtgCompras.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dtgCompras.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dtgCompras.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dtgCompras.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgCompras.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtgCompras.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgCompras.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgCompras.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtgCompras.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dtgCompras.ThemeStyle.HeaderStyle.Height = 38;
            this.dtgCompras.ThemeStyle.ReadOnly = true;
            this.dtgCompras.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgCompras.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgCompras.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgCompras.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dtgCompras.ThemeStyle.RowsStyle.Height = 22;
            this.dtgCompras.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgCompras.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtgCompras.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.guna2DataGridView1_CellDoubleClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // id
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.NullValue = "-";
            this.id.DefaultCellStyle = dataGridViewCellStyle3;
            this.id.FillWeight = 50F;
            this.id.HeaderText = "No.";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // Column6
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.Column6.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column6.FillWeight = 200F;
            this.Column6.HeaderText = "Proveedor";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.Format = "C4";
            dataGridViewCellStyle5.NullValue = "-";
            this.Column7.DefaultCellStyle = dataGridViewCellStyle5;
            this.Column7.HeaderText = "Valor";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.Format = "d";
            dataGridViewCellStyle6.NullValue = "-";
            this.Column8.DefaultCellStyle = dataGridViewCellStyle6;
            this.Column8.HeaderText = "Fecha";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // imagenFactura
            // 
            dataGridViewCellStyle7.NullValue = "-";
            this.imagenFactura.DefaultCellStyle = dataGridViewCellStyle7;
            this.imagenFactura.HeaderText = "Factura";
            this.imagenFactura.Name = "imagenFactura";
            this.imagenFactura.ReadOnly = true;
            this.imagenFactura.Visible = false;
            // 
            // tercero
            // 
            this.tercero.Controls.Add(this.btnActualizar);
            this.tercero.Controls.Add(this.lblTotalCompras);
            this.tercero.Controls.Add(this.btnEliminar);
            this.tercero.Controls.Add(this.label7);
            this.tercero.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tercero.Location = new System.Drawing.Point(0, 493);
            this.tercero.Name = "tercero";
            this.tercero.Size = new System.Drawing.Size(944, 38);
            this.tercero.TabIndex = 34;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActualizar.BorderColor = System.Drawing.Color.DimGray;
            this.btnActualizar.BorderRadius = 7;
            this.btnActualizar.BorderThickness = 1;
            this.btnActualizar.CheckedState.Parent = this.btnActualizar;
            this.btnActualizar.CustomImages.Parent = this.btnActualizar;
            this.btnActualizar.FillColor = System.Drawing.Color.Gray;
            this.btnActualizar.Font = new System.Drawing.Font("Arial", 12F);
            this.btnActualizar.ForeColor = System.Drawing.Color.White;
            this.btnActualizar.HoverState.Parent = this.btnActualizar;
            this.btnActualizar.Location = new System.Drawing.Point(812, 3);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.ShadowDecoration.Parent = this.btnActualizar;
            this.btnActualizar.Size = new System.Drawing.Size(120, 30);
            this.btnActualizar.TabIndex = 31;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            this.btnActualizar.DoubleClick += new System.EventHandler(this.btnActualizar_DoubleClick);
            // 
            // lblTotalCompras
            // 
            this.lblTotalCompras.AutoSize = true;
            this.lblTotalCompras.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCompras.Location = new System.Drawing.Point(61, 3);
            this.lblTotalCompras.Name = "lblTotalCompras";
            this.lblTotalCompras.Size = new System.Drawing.Size(58, 19);
            this.lblTotalCompras.TabIndex = 29;
            this.lblTotalCompras.Text = "0.0000";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminar.BorderColor = System.Drawing.Color.DimGray;
            this.btnEliminar.BorderRadius = 7;
            this.btnEliminar.BorderThickness = 1;
            this.btnEliminar.CheckedState.Parent = this.btnEliminar;
            this.btnEliminar.CustomImages.Parent = this.btnEliminar;
            this.btnEliminar.FillColor = System.Drawing.Color.Gray;
            this.btnEliminar.Font = new System.Drawing.Font("Arial", 12F);
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.HoverState.Parent = this.btnEliminar;
            this.btnEliminar.Location = new System.Drawing.Point(686, 3);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.ShadowDecoration.Parent = this.btnEliminar;
            this.btnEliminar.Size = new System.Drawing.Size(120, 30);
            this.btnEliminar.TabIndex = 30;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 19);
            this.label7.TabIndex = 28;
            this.label7.Text = "Total:";
            // 
            // segundo
            // 
            this.segundo.Controls.Add(this.btnDesplagarMenu);
            this.segundo.Controls.Add(this.label6);
            this.segundo.Dock = System.Windows.Forms.DockStyle.Top;
            this.segundo.Location = new System.Drawing.Point(0, 0);
            this.segundo.Name = "segundo";
            this.segundo.Size = new System.Drawing.Size(944, 35);
            this.segundo.TabIndex = 33;
            // 
            // btnDesplagarMenu
            // 
            this.btnDesplagarMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDesplagarMenu.CheckedState.Parent = this.btnDesplagarMenu;
            this.btnDesplagarMenu.CustomImages.Parent = this.btnDesplagarMenu;
            this.btnDesplagarMenu.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDesplagarMenu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDesplagarMenu.ForeColor = System.Drawing.Color.White;
            this.btnDesplagarMenu.HoverState.Parent = this.btnDesplagarMenu;
            this.btnDesplagarMenu.Location = new System.Drawing.Point(836, 6);
            this.btnDesplagarMenu.Name = "btnDesplagarMenu";
            this.btnDesplagarMenu.ShadowDecoration.Parent = this.btnDesplagarMenu;
            this.btnDesplagarMenu.Size = new System.Drawing.Size(108, 26);
            this.btnDesplagarMenu.TabIndex = 32;
            this.btnDesplagarMenu.Text = "Nueva Compra";
            this.btnDesplagarMenu.Click += new System.EventHandler(this.btnDesplagarMenu_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(203, 19);
            this.label6.TabIndex = 20;
            this.label6.Text = "COMPRAS REALIZADAS:";
            // 
            // FrmCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 581);
            this.Controls.Add(this.pnlCompras);
            this.Controls.Add(this.pnlSeleccioFormulario);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmCompras";
            this.Text = "FrmCompras";
            this.Load += new System.EventHandler(this.FrmCompras_Load);
            this.pnlCompras.ResumeLayout(false);
            this.pnlNuevaCompra.ResumeLayout(false);
            this.pnlFactura.ResumeLayout(false);
            this.pnlDatosPagos.ResumeLayout(false);
            this.pnlDatosPagos.PerformLayout();
            this.pnlEncabezadoNuevoCompra.ResumeLayout(false);
            this.pnlEncabezadoNuevoCompra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptrFactura)).EndInit();
            this.pnlNuevoCompra.ResumeLayout(false);
            this.pnlNuevoCompra.PerformLayout();
            this.primero.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgCompras)).EndInit();
            this.tercero.ResumeLayout(false);
            this.tercero.PerformLayout();
            this.segundo.ResumeLayout(false);
            this.segundo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlSeleccioFormulario;
        private Guna.UI2.WinForms.Guna2Panel pnlCompras;
        private Guna.UI2.WinForms.Guna2Panel pnlFactura;
        private Guna.UI2.WinForms.Guna2Panel pnlNuevaCompra;
        private Guna.UI2.WinForms.Guna2Panel pnlNuevoCompra;
        private Guna.UI2.WinForms.Guna2Button btnRealizarCompra;
        private System.Windows.Forms.PictureBox ptrFactura;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnModificar;
        private Guna.UI2.WinForms.Guna2Button btnAgregar;
        private Guna.UI2.WinForms.Guna2Panel pnlEncabezadoNuevoCompra;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Panel pnlDatosPagos;
        private Guna.UI2.WinForms.Guna2TextBox txtNumeroCompra;
        private System.Windows.Forms.Label lblIdCompra;
        private Guna.UI2.WinForms.Guna2DateTimePicker txtFecha;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox txtValor;
        private Guna.UI2.WinForms.Guna2TextBox txtProveedor;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel primero;
        private Guna.UI2.WinForms.Guna2DataGridView dtgCompras;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn imagenFactura;
        private System.Windows.Forms.Panel tercero;
        private Guna.UI2.WinForms.Guna2Button btnActualizar;
        private System.Windows.Forms.Label lblTotalCompras;
        private Guna.UI2.WinForms.Guna2Button btnEliminar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel segundo;
        private Guna.UI2.WinForms.Guna2Button btnDesplagarMenu;
        private System.Windows.Forms.Label label6;
    }
}