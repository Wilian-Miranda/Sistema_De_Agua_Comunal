
namespace SIDAC.VISTA
{
    partial class FrmConsumidores
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.validacion = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlEncabezadoConsumidores = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlConsumidores = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlTablaConsumidores = new Guna.UI2.WinForms.Guna2Panel();
            this.dtgConsumidores = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAbrirFormulario = new Guna.UI2.WinForms.Guna2Button();
            this.pnlEliminar = new Guna.UI2.WinForms.Guna2Panel();
            this.lblCantidadConsumidores = new System.Windows.Forms.Label();
            this.btnEliminar = new Guna.UI2.WinForms.Guna2Button();
            this.pnlNuevoConsumidor = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlEncabezadoNuevoConsumidor = new Guna.UI2.WinForms.Guna2Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnModificar = new Guna.UI2.WinForms.Guna2Button();
            this.btnAgregar = new Guna.UI2.WinForms.Guna2Button();
            this.cbEstado = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCorreo = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTelefono = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtApellidos = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombres = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtID = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.rbInactivos = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rbActivos = new Guna.UI2.WinForms.Guna2RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.validacion)).BeginInit();
            this.pnlConsumidores.SuspendLayout();
            this.pnlTablaConsumidores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgConsumidores)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnlEliminar.SuspendLayout();
            this.pnlNuevoConsumidor.SuspendLayout();
            this.pnlEncabezadoNuevoConsumidor.SuspendLayout();
            this.SuspendLayout();
            // 
            // validacion
            // 
            this.validacion.ContainerControl = this;
            // 
            // pnlEncabezadoConsumidores
            // 
            this.pnlEncabezadoConsumidores.BackColor = System.Drawing.Color.Silver;
            this.pnlEncabezadoConsumidores.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEncabezadoConsumidores.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(164)))), ((int)(((byte)(235)))));
            this.pnlEncabezadoConsumidores.Location = new System.Drawing.Point(0, 0);
            this.pnlEncabezadoConsumidores.Name = "pnlEncabezadoConsumidores";
            this.pnlEncabezadoConsumidores.Padding = new System.Windows.Forms.Padding(5);
            this.pnlEncabezadoConsumidores.ShadowDecoration.Parent = this.pnlEncabezadoConsumidores;
            this.pnlEncabezadoConsumidores.Size = new System.Drawing.Size(1000, 30);
            this.pnlEncabezadoConsumidores.TabIndex = 4;
            // 
            // pnlConsumidores
            // 
            this.pnlConsumidores.BackColor = System.Drawing.Color.White;
            this.pnlConsumidores.Controls.Add(this.pnlTablaConsumidores);
            this.pnlConsumidores.Controls.Add(this.pnlNuevoConsumidor);
            this.pnlConsumidores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlConsumidores.Location = new System.Drawing.Point(0, 30);
            this.pnlConsumidores.Name = "pnlConsumidores";
            this.pnlConsumidores.Padding = new System.Windows.Forms.Padding(10);
            this.pnlConsumidores.ShadowDecoration.Parent = this.pnlConsumidores;
            this.pnlConsumidores.Size = new System.Drawing.Size(1000, 590);
            this.pnlConsumidores.TabIndex = 5;
            // 
            // pnlTablaConsumidores
            // 
            this.pnlTablaConsumidores.BackColor = System.Drawing.Color.White;
            this.pnlTablaConsumidores.Controls.Add(this.dtgConsumidores);
            this.pnlTablaConsumidores.Controls.Add(this.panel1);
            this.pnlTablaConsumidores.Controls.Add(this.pnlEliminar);
            this.pnlTablaConsumidores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTablaConsumidores.Location = new System.Drawing.Point(10, 10);
            this.pnlTablaConsumidores.Name = "pnlTablaConsumidores";
            this.pnlTablaConsumidores.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.pnlTablaConsumidores.ShadowDecoration.Parent = this.pnlTablaConsumidores;
            this.pnlTablaConsumidores.Size = new System.Drawing.Size(970, 570);
            this.pnlTablaConsumidores.TabIndex = 6;
            // 
            // dtgConsumidores
            // 
            this.dtgConsumidores.AllowUserToAddRows = false;
            this.dtgConsumidores.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dtgConsumidores.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgConsumidores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgConsumidores.BackgroundColor = System.Drawing.Color.White;
            this.dtgConsumidores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgConsumidores.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgConsumidores.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgConsumidores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgConsumidores.ColumnHeadersHeight = 20;
            this.dtgConsumidores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgConsumidores.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgConsumidores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgConsumidores.EnableHeadersVisualStyles = false;
            this.dtgConsumidores.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgConsumidores.Location = new System.Drawing.Point(0, 40);
            this.dtgConsumidores.Name = "dtgConsumidores";
            this.dtgConsumidores.ReadOnly = true;
            this.dtgConsumidores.RowHeadersVisible = false;
            this.dtgConsumidores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgConsumidores.Size = new System.Drawing.Size(960, 494);
            this.dtgConsumidores.TabIndex = 5;
            this.dtgConsumidores.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dtgConsumidores.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgConsumidores.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dtgConsumidores.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dtgConsumidores.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dtgConsumidores.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dtgConsumidores.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dtgConsumidores.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgConsumidores.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtgConsumidores.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgConsumidores.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgConsumidores.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtgConsumidores.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dtgConsumidores.ThemeStyle.HeaderStyle.Height = 20;
            this.dtgConsumidores.ThemeStyle.ReadOnly = true;
            this.dtgConsumidores.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgConsumidores.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgConsumidores.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgConsumidores.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dtgConsumidores.ThemeStyle.RowsStyle.Height = 22;
            this.dtgConsumidores.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgConsumidores.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtgConsumidores.DoubleClick += new System.EventHandler(this.dtgConsumidores_DoubleClick);
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Código";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Visible = false;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nombre";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Apellido";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Teléfono";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Correo";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Estado";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbActivos);
            this.panel1.Controls.Add(this.rbInactivos);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnAbrirFormulario);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.panel1.Size = new System.Drawing.Size(960, 40);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(351, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "GESTIÓN DE CONSUMIDORES";
            // 
            // btnAbrirFormulario
            // 
            this.btnAbrirFormulario.BorderColor = System.Drawing.Color.Lavender;
            this.btnAbrirFormulario.BorderRadius = 3;
            this.btnAbrirFormulario.BorderThickness = 1;
            this.btnAbrirFormulario.CheckedState.Parent = this.btnAbrirFormulario;
            this.btnAbrirFormulario.CustomImages.Parent = this.btnAbrirFormulario;
            this.btnAbrirFormulario.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAbrirFormulario.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(181)))), ((int)(((byte)(212)))));
            this.btnAbrirFormulario.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAbrirFormulario.ForeColor = System.Drawing.Color.White;
            this.btnAbrirFormulario.HoverState.Parent = this.btnAbrirFormulario;
            this.btnAbrirFormulario.Location = new System.Drawing.Point(810, 5);
            this.btnAbrirFormulario.Name = "btnAbrirFormulario";
            this.btnAbrirFormulario.ShadowDecoration.Parent = this.btnAbrirFormulario;
            this.btnAbrirFormulario.Size = new System.Drawing.Size(150, 30);
            this.btnAbrirFormulario.TabIndex = 4;
            this.btnAbrirFormulario.Text = "Nuevo consumidor";
            this.btnAbrirFormulario.Click += new System.EventHandler(this.btnAbrirFormulario_Click);
            // 
            // pnlEliminar
            // 
            this.pnlEliminar.Controls.Add(this.lblCantidadConsumidores);
            this.pnlEliminar.Controls.Add(this.btnEliminar);
            this.pnlEliminar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlEliminar.Location = new System.Drawing.Point(0, 534);
            this.pnlEliminar.Name = "pnlEliminar";
            this.pnlEliminar.Padding = new System.Windows.Forms.Padding(3);
            this.pnlEliminar.ShadowDecoration.Parent = this.pnlEliminar;
            this.pnlEliminar.Size = new System.Drawing.Size(960, 36);
            this.pnlEliminar.TabIndex = 1;
            // 
            // lblCantidadConsumidores
            // 
            this.lblCantidadConsumidores.AutoSize = true;
            this.lblCantidadConsumidores.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblCantidadConsumidores.Location = new System.Drawing.Point(927, 3);
            this.lblCantidadConsumidores.Name = "lblCantidadConsumidores";
            this.lblCantidadConsumidores.Size = new System.Drawing.Size(30, 18);
            this.lblCantidadConsumidores.TabIndex = 4;
            this.lblCantidadConsumidores.Text = "0.0";
            // 
            // btnEliminar
            // 
            this.btnEliminar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(181)))), ((int)(((byte)(212)))));
            this.btnEliminar.BorderRadius = 3;
            this.btnEliminar.BorderThickness = 1;
            this.btnEliminar.CheckedState.Parent = this.btnEliminar;
            this.btnEliminar.CustomImages.Parent = this.btnEliminar;
            this.btnEliminar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnEliminar.Enabled = false;
            this.btnEliminar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(181)))), ((int)(((byte)(212)))));
            this.btnEliminar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.HoverState.Parent = this.btnEliminar;
            this.btnEliminar.Image = global::SIDAC.Properties.Resources.eliminar_base_de_datos;
            this.btnEliminar.Location = new System.Drawing.Point(3, 3);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.ShadowDecoration.Parent = this.btnEliminar;
            this.btnEliminar.Size = new System.Drawing.Size(150, 30);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // pnlNuevoConsumidor
            // 
            this.pnlNuevoConsumidor.BackColor = System.Drawing.Color.Azure;
            this.pnlNuevoConsumidor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(181)))), ((int)(((byte)(212)))));
            this.pnlNuevoConsumidor.BorderRadius = 14;
            this.pnlNuevoConsumidor.BorderThickness = 1;
            this.pnlNuevoConsumidor.Controls.Add(this.pnlEncabezadoNuevoConsumidor);
            this.pnlNuevoConsumidor.Controls.Add(this.btnModificar);
            this.pnlNuevoConsumidor.Controls.Add(this.btnAgregar);
            this.pnlNuevoConsumidor.Controls.Add(this.cbEstado);
            this.pnlNuevoConsumidor.Controls.Add(this.label7);
            this.pnlNuevoConsumidor.Controls.Add(this.txtCorreo);
            this.pnlNuevoConsumidor.Controls.Add(this.label6);
            this.pnlNuevoConsumidor.Controls.Add(this.txtTelefono);
            this.pnlNuevoConsumidor.Controls.Add(this.label5);
            this.pnlNuevoConsumidor.Controls.Add(this.txtApellidos);
            this.pnlNuevoConsumidor.Controls.Add(this.label4);
            this.pnlNuevoConsumidor.Controls.Add(this.txtNombres);
            this.pnlNuevoConsumidor.Controls.Add(this.label3);
            this.pnlNuevoConsumidor.Controls.Add(this.txtID);
            this.pnlNuevoConsumidor.Controls.Add(this.lblId);
            this.pnlNuevoConsumidor.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlNuevoConsumidor.Enabled = false;
            this.pnlNuevoConsumidor.Location = new System.Drawing.Point(980, 10);
            this.pnlNuevoConsumidor.Name = "pnlNuevoConsumidor";
            this.pnlNuevoConsumidor.ShadowDecoration.Parent = this.pnlNuevoConsumidor;
            this.pnlNuevoConsumidor.Size = new System.Drawing.Size(10, 570);
            this.pnlNuevoConsumidor.TabIndex = 1;
            this.pnlNuevoConsumidor.DoubleClick += new System.EventHandler(this.pnlNuevoConsumidor_DoubleClick);
            // 
            // pnlEncabezadoNuevoConsumidor
            // 
            this.pnlEncabezadoNuevoConsumidor.BackColor = System.Drawing.Color.Transparent;
            this.pnlEncabezadoNuevoConsumidor.BorderColor = System.Drawing.Color.DarkGray;
            this.pnlEncabezadoNuevoConsumidor.BorderRadius = 14;
            this.pnlEncabezadoNuevoConsumidor.Controls.Add(this.label2);
            this.pnlEncabezadoNuevoConsumidor.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(164)))), ((int)(((byte)(235)))));
            this.pnlEncabezadoNuevoConsumidor.Location = new System.Drawing.Point(20, 14);
            this.pnlEncabezadoNuevoConsumidor.Name = "pnlEncabezadoNuevoConsumidor";
            this.pnlEncabezadoNuevoConsumidor.ShadowDecoration.Parent = this.pnlEncabezadoNuevoConsumidor;
            this.pnlEncabezadoNuevoConsumidor.Size = new System.Drawing.Size(260, 40);
            this.pnlEncabezadoNuevoConsumidor.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(164)))), ((int)(((byte)(235)))));
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(45, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "NUEVO CONSUMIDOR";
            // 
            // btnModificar
            // 
            this.btnModificar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(181)))), ((int)(((byte)(212)))));
            this.btnModificar.BorderRadius = 3;
            this.btnModificar.BorderThickness = 1;
            this.btnModificar.CheckedState.Parent = this.btnModificar;
            this.btnModificar.CustomImages.Parent = this.btnModificar;
            this.btnModificar.Enabled = false;
            this.btnModificar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(181)))), ((int)(((byte)(212)))));
            this.btnModificar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.Color.White;
            this.btnModificar.HoverState.Parent = this.btnModificar;
            this.btnModificar.Image = global::SIDAC.Properties.Resources.actualizar;
            this.btnModificar.Location = new System.Drawing.Point(155, 444);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.ShadowDecoration.Parent = this.btnModificar;
            this.btnModificar.Size = new System.Drawing.Size(125, 35);
            this.btnModificar.TabIndex = 15;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(181)))), ((int)(((byte)(212)))));
            this.btnAgregar.BorderRadius = 3;
            this.btnAgregar.BorderThickness = 1;
            this.btnAgregar.CheckedState.Parent = this.btnAgregar;
            this.btnAgregar.CustomImages.Parent = this.btnAgregar;
            this.btnAgregar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(181)))), ((int)(((byte)(212)))));
            this.btnAgregar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.HoverState.Parent = this.btnAgregar;
            this.btnAgregar.Image = global::SIDAC.Properties.Resources.guardar_datos;
            this.btnAgregar.Location = new System.Drawing.Point(21, 444);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.ShadowDecoration.Parent = this.btnAgregar;
            this.btnAgregar.Size = new System.Drawing.Size(125, 35);
            this.btnAgregar.TabIndex = 14;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // cbEstado
            // 
            this.cbEstado.BackColor = System.Drawing.Color.Transparent;
            this.cbEstado.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(181)))), ((int)(((byte)(212)))));
            this.cbEstado.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstado.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbEstado.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbEstado.FocusedState.Parent = this.cbEstado;
            this.cbEstado.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbEstado.HoverState.Parent = this.cbEstado;
            this.cbEstado.ItemHeight = 30;
            this.cbEstado.ItemsAppearance.Parent = this.cbEstado;
            this.cbEstado.Location = new System.Drawing.Point(21, 386);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.ShadowDecoration.Parent = this.cbEstado;
            this.cbEstado.Size = new System.Drawing.Size(259, 36);
            this.cbEstado.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 364);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 18);
            this.label7.TabIndex = 12;
            this.label7.Text = "Estado:";
            // 
            // txtCorreo
            // 
            this.txtCorreo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(181)))), ((int)(((byte)(212)))));
            this.txtCorreo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCorreo.DefaultText = "-";
            this.txtCorreo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCorreo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCorreo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCorreo.DisabledState.Parent = this.txtCorreo;
            this.txtCorreo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCorreo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCorreo.FocusedState.Parent = this.txtCorreo;
            this.txtCorreo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCorreo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCorreo.HoverState.Parent = this.txtCorreo;
            this.txtCorreo.Location = new System.Drawing.Point(21, 325);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.PasswordChar = '\0';
            this.txtCorreo.PlaceholderText = "-";
            this.txtCorreo.SelectedText = "";
            this.txtCorreo.SelectionStart = 1;
            this.txtCorreo.ShadowDecoration.Parent = this.txtCorreo;
            this.txtCorreo.Size = new System.Drawing.Size(259, 36);
            this.txtCorreo.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 304);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 18);
            this.label6.TabIndex = 10;
            this.label6.Text = "Correo:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(181)))), ((int)(((byte)(212)))));
            this.txtTelefono.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTelefono.DefaultText = "";
            this.txtTelefono.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTelefono.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTelefono.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTelefono.DisabledState.Parent = this.txtTelefono;
            this.txtTelefono.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTelefono.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTelefono.FocusedState.Parent = this.txtTelefono;
            this.txtTelefono.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTelefono.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTelefono.HoverState.Parent = this.txtTelefono;
            this.txtTelefono.Location = new System.Drawing.Point(21, 265);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.PasswordChar = '\0';
            this.txtTelefono.PlaceholderText = "-";
            this.txtTelefono.SelectedText = "";
            this.txtTelefono.ShadowDecoration.Parent = this.txtTelefono;
            this.txtTelefono.Size = new System.Drawing.Size(259, 36);
            this.txtTelefono.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Teléfono:";
            // 
            // txtApellidos
            // 
            this.txtApellidos.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(181)))), ((int)(((byte)(212)))));
            this.txtApellidos.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtApellidos.DefaultText = "";
            this.txtApellidos.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtApellidos.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtApellidos.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtApellidos.DisabledState.Parent = this.txtApellidos;
            this.txtApellidos.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtApellidos.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtApellidos.FocusedState.Parent = this.txtApellidos;
            this.txtApellidos.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtApellidos.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtApellidos.HoverState.Parent = this.txtApellidos;
            this.txtApellidos.Location = new System.Drawing.Point(20, 205);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.PasswordChar = '\0';
            this.txtApellidos.PlaceholderText = "";
            this.txtApellidos.SelectedText = "";
            this.txtApellidos.ShadowDecoration.Parent = this.txtApellidos;
            this.txtApellidos.Size = new System.Drawing.Size(260, 36);
            this.txtApellidos.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Apellidos:";
            // 
            // txtNombres
            // 
            this.txtNombres.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(181)))), ((int)(((byte)(212)))));
            this.txtNombres.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombres.DefaultText = "";
            this.txtNombres.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNombres.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNombres.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNombres.DisabledState.Parent = this.txtNombres;
            this.txtNombres.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNombres.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNombres.FocusedState.Parent = this.txtNombres;
            this.txtNombres.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNombres.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNombres.HoverState.Parent = this.txtNombres;
            this.txtNombres.Location = new System.Drawing.Point(20, 145);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.PasswordChar = '\0';
            this.txtNombres.PlaceholderText = "";
            this.txtNombres.SelectedText = "";
            this.txtNombres.ShadowDecoration.Parent = this.txtNombres;
            this.txtNombres.Size = new System.Drawing.Size(260, 36);
            this.txtNombres.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nombres:";
            // 
            // txtID
            // 
            this.txtID.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(181)))), ((int)(((byte)(212)))));
            this.txtID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtID.DefaultText = "";
            this.txtID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtID.DisabledState.Parent = this.txtID;
            this.txtID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtID.Enabled = false;
            this.txtID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtID.FocusedState.Parent = this.txtID;
            this.txtID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtID.HoverState.Parent = this.txtID;
            this.txtID.Location = new System.Drawing.Point(215, 80);
            this.txtID.Name = "txtID";
            this.txtID.PasswordChar = '\0';
            this.txtID.PlaceholderText = "";
            this.txtID.SelectedText = "";
            this.txtID.ShadowDecoration.Parent = this.txtID;
            this.txtID.Size = new System.Drawing.Size(65, 36);
            this.txtID.TabIndex = 3;
            this.txtID.Visible = false;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(182, 80);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(27, 18);
            this.lblId.TabIndex = 2;
            this.lblId.Text = "ID:";
            this.lblId.Visible = false;
            // 
            // rbInactivos
            // 
            this.rbInactivos.AutoSize = true;
            this.rbInactivos.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbInactivos.CheckedState.BorderThickness = 0;
            this.rbInactivos.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbInactivos.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbInactivos.CheckedState.InnerOffset = -4;
            this.rbInactivos.Location = new System.Drawing.Point(3, 10);
            this.rbInactivos.Name = "rbInactivos";
            this.rbInactivos.Size = new System.Drawing.Size(86, 22);
            this.rbInactivos.TabIndex = 6;
            this.rbInactivos.Text = "Inactivos";
            this.rbInactivos.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbInactivos.UncheckedState.BorderThickness = 2;
            this.rbInactivos.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbInactivos.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rbInactivos.CheckedChanged += new System.EventHandler(this.rbTodos_CheckedChanged);
            // 
            // rbActivos
            // 
            this.rbActivos.AutoSize = true;
            this.rbActivos.Checked = true;
            this.rbActivos.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbActivos.CheckedState.BorderThickness = 0;
            this.rbActivos.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbActivos.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbActivos.CheckedState.InnerOffset = -4;
            this.rbActivos.Location = new System.Drawing.Point(95, 10);
            this.rbActivos.Name = "rbActivos";
            this.rbActivos.Size = new System.Drawing.Size(77, 22);
            this.rbActivos.TabIndex = 7;
            this.rbActivos.TabStop = true;
            this.rbActivos.Text = "Activos";
            this.rbActivos.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbActivos.UncheckedState.BorderThickness = 2;
            this.rbActivos.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbActivos.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rbActivos.CheckedChanged += new System.EventHandler(this.rbActivos_CheckedChanged);
            // 
            // FrmConsumidores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1000, 620);
            this.Controls.Add(this.pnlConsumidores);
            this.Controls.Add(this.pnlEncabezadoConsumidores);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmConsumidores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consumidores";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmConsumidores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.validacion)).EndInit();
            this.pnlConsumidores.ResumeLayout(false);
            this.pnlTablaConsumidores.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgConsumidores)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlEliminar.ResumeLayout(false);
            this.pnlEliminar.PerformLayout();
            this.pnlNuevoConsumidor.ResumeLayout(false);
            this.pnlNuevoConsumidor.PerformLayout();
            this.pnlEncabezadoNuevoConsumidor.ResumeLayout(false);
            this.pnlEncabezadoNuevoConsumidor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ErrorProvider validacion;
        private Guna.UI2.WinForms.Guna2Panel pnlConsumidores;
        private Guna.UI2.WinForms.Guna2Panel pnlTablaConsumidores;
        private Guna.UI2.WinForms.Guna2DataGridView dtgConsumidores;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnAbrirFormulario;
        private Guna.UI2.WinForms.Guna2Panel pnlEliminar;
        private System.Windows.Forms.Label lblCantidadConsumidores;
        private Guna.UI2.WinForms.Guna2Button btnEliminar;
        private Guna.UI2.WinForms.Guna2Panel pnlNuevoConsumidor;
        private Guna.UI2.WinForms.Guna2Panel pnlEncabezadoNuevoConsumidor;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button btnModificar;
        private Guna.UI2.WinForms.Guna2Button btnAgregar;
        private Guna.UI2.WinForms.Guna2ComboBox cbEstado;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox txtCorreo;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox txtTelefono;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox txtApellidos;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox txtNombres;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtID;
        private System.Windows.Forms.Label lblId;
        private Guna.UI2.WinForms.Guna2Panel pnlEncabezadoConsumidores;
        private Guna.UI2.WinForms.Guna2RadioButton rbActivos;
        private Guna.UI2.WinForms.Guna2RadioButton rbInactivos;
    }
}