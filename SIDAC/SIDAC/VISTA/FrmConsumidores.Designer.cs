
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlNuevoConsumidor = new Guna.UI2.WinForms.Guna2Panel();
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
            this.pnlEncabezadoNuevoConsumidor = new Guna.UI2.WinForms.Guna2Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlConsumidores = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlTablaConsumidores = new Guna.UI2.WinForms.Guna2Panel();
            this.rbActivos = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rbInactivos = new Guna.UI2.WinForms.Guna2RadioButton();
            this.pnlEliminar = new Guna.UI2.WinForms.Guna2Panel();
            this.btnEliminar = new Guna.UI2.WinForms.Guna2Button();
            this.dtgConsumidores = new Guna.UI2.WinForms.Guna2DataGridView();
            this.pnlEncabezadoConsumidores = new Guna.UI2.WinForms.Guna2Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblCantidadConsumidores = new System.Windows.Forms.Label();
            this.pnlNuevoConsumidor.SuspendLayout();
            this.pnlEncabezadoNuevoConsumidor.SuspendLayout();
            this.pnlConsumidores.SuspendLayout();
            this.pnlTablaConsumidores.SuspendLayout();
            this.pnlEliminar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgConsumidores)).BeginInit();
            this.pnlEncabezadoConsumidores.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlNuevoConsumidor
            // 
            this.pnlNuevoConsumidor.BorderColor = System.Drawing.Color.Silver;
            this.pnlNuevoConsumidor.BorderThickness = 1;
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
            this.pnlNuevoConsumidor.Controls.Add(this.pnlEncabezadoNuevoConsumidor);
            this.pnlNuevoConsumidor.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlNuevoConsumidor.Location = new System.Drawing.Point(700, 0);
            this.pnlNuevoConsumidor.Name = "pnlNuevoConsumidor";
            this.pnlNuevoConsumidor.ShadowDecoration.Parent = this.pnlNuevoConsumidor;
            this.pnlNuevoConsumidor.Size = new System.Drawing.Size(300, 620);
            this.pnlNuevoConsumidor.TabIndex = 0;
            this.pnlNuevoConsumidor.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlNuevoConsumidor_Paint);
            this.pnlNuevoConsumidor.DoubleClick += new System.EventHandler(this.pnlNuevoConsumidor_DoubleClick);
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
            this.btnModificar.Location = new System.Drawing.Point(163, 428);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.ShadowDecoration.Parent = this.btnModificar;
            this.btnModificar.Size = new System.Drawing.Size(125, 35);
            this.btnModificar.TabIndex = 15;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.CheckedState.Parent = this.btnAgregar;
            this.btnAgregar.CustomImages.Parent = this.btnAgregar;
            this.btnAgregar.FillColor = System.Drawing.Color.Gray;
            this.btnAgregar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.HoverState.Parent = this.btnAgregar;
            this.btnAgregar.Location = new System.Drawing.Point(21, 428);
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
            this.cbEstado.Size = new System.Drawing.Size(267, 36);
            this.cbEstado.TabIndex = 13;
            this.cbEstado.SelectedIndexChanged += new System.EventHandler(this.cbEstado_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 364);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 18);
            this.label7.TabIndex = 12;
            this.label7.Text = "Estado:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtCorreo
            // 
            this.txtCorreo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCorreo.DefaultText = "";
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
            this.txtCorreo.PlaceholderText = "";
            this.txtCorreo.SelectedText = "";
            this.txtCorreo.ShadowDecoration.Parent = this.txtCorreo;
            this.txtCorreo.Size = new System.Drawing.Size(267, 36);
            this.txtCorreo.TabIndex = 11;
            this.txtCorreo.TextChanged += new System.EventHandler(this.txtCorreo_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 304);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 18);
            this.label6.TabIndex = 10;
            this.label6.Text = "Correo:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtTelefono
            // 
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
            this.txtTelefono.PlaceholderText = "";
            this.txtTelefono.SelectedText = "";
            this.txtTelefono.ShadowDecoration.Parent = this.txtTelefono;
            this.txtTelefono.Size = new System.Drawing.Size(267, 36);
            this.txtTelefono.TabIndex = 9;
            this.txtTelefono.TextChanged += new System.EventHandler(this.txtTelefono_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Teléfono:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtApellidos
            // 
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
            this.txtApellidos.Size = new System.Drawing.Size(268, 36);
            this.txtApellidos.TabIndex = 7;
            this.txtApellidos.TextChanged += new System.EventHandler(this.txtApellidos_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Apellidos:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtNombres
            // 
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
            this.txtNombres.Size = new System.Drawing.Size(268, 36);
            this.txtNombres.TabIndex = 5;
            this.txtNombres.TextChanged += new System.EventHandler(this.txtNombres_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nombres:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtID
            // 
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
            this.txtID.Location = new System.Drawing.Point(223, 80);
            this.txtID.Name = "txtID";
            this.txtID.PasswordChar = '\0';
            this.txtID.PlaceholderText = "";
            this.txtID.SelectedText = "";
            this.txtID.ShadowDecoration.Parent = this.txtID;
            this.txtID.Size = new System.Drawing.Size(65, 36);
            this.txtID.TabIndex = 3;
            this.txtID.Visible = false;
            this.txtID.TextChanged += new System.EventHandler(this.txtID_TextChanged);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(190, 80);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(27, 18);
            this.lblId.TabIndex = 2;
            this.lblId.Text = "ID:";
            this.lblId.Visible = false;
            this.lblId.Click += new System.EventHandler(this.lblId_Click);
            // 
            // pnlEncabezadoNuevoConsumidor
            // 
            this.pnlEncabezadoNuevoConsumidor.BackColor = System.Drawing.Color.Silver;
            this.pnlEncabezadoNuevoConsumidor.Controls.Add(this.label2);
            this.pnlEncabezadoNuevoConsumidor.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEncabezadoNuevoConsumidor.Location = new System.Drawing.Point(0, 0);
            this.pnlEncabezadoNuevoConsumidor.Name = "pnlEncabezadoNuevoConsumidor";
            this.pnlEncabezadoNuevoConsumidor.ShadowDecoration.Parent = this.pnlEncabezadoNuevoConsumidor;
            this.pnlEncabezadoNuevoConsumidor.Size = new System.Drawing.Size(300, 60);
            this.pnlEncabezadoNuevoConsumidor.TabIndex = 1;
            this.pnlEncabezadoNuevoConsumidor.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlEncabezadoNuevoConsumidor_Paint);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(65, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "NUEVO CONSUMIDOR";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // pnlConsumidores
            // 
            this.pnlConsumidores.Controls.Add(this.pnlTablaConsumidores);
            this.pnlConsumidores.Controls.Add(this.pnlEncabezadoConsumidores);
            this.pnlConsumidores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlConsumidores.Location = new System.Drawing.Point(0, 0);
            this.pnlConsumidores.Name = "pnlConsumidores";
            this.pnlConsumidores.ShadowDecoration.Parent = this.pnlConsumidores;
            this.pnlConsumidores.Size = new System.Drawing.Size(700, 620);
            this.pnlConsumidores.TabIndex = 1;
            this.pnlConsumidores.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlConsumidores_Paint);
            // 
            // pnlTablaConsumidores
            // 
            this.pnlTablaConsumidores.Controls.Add(this.rbActivos);
            this.pnlTablaConsumidores.Controls.Add(this.rbInactivos);
            this.pnlTablaConsumidores.Controls.Add(this.pnlEliminar);
            this.pnlTablaConsumidores.Controls.Add(this.dtgConsumidores);
            this.pnlTablaConsumidores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTablaConsumidores.Location = new System.Drawing.Point(0, 60);
            this.pnlTablaConsumidores.Name = "pnlTablaConsumidores";
            this.pnlTablaConsumidores.Padding = new System.Windows.Forms.Padding(20);
            this.pnlTablaConsumidores.ShadowDecoration.Parent = this.pnlTablaConsumidores;
            this.pnlTablaConsumidores.Size = new System.Drawing.Size(700, 560);
            this.pnlTablaConsumidores.TabIndex = 5;
            this.pnlTablaConsumidores.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlTablaConsumidores_Paint);
            // 
            // rbActivos
            // 
            this.rbActivos.AutoSize = true;
            this.rbActivos.BackColor = System.Drawing.Color.WhiteSmoke;
            this.rbActivos.Checked = true;
            this.rbActivos.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbActivos.CheckedState.BorderThickness = 0;
            this.rbActivos.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbActivos.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbActivos.CheckedState.InnerOffset = -4;
            this.rbActivos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbActivos.Location = new System.Drawing.Point(114, 6);
            this.rbActivos.Name = "rbActivos";
            this.rbActivos.Size = new System.Drawing.Size(76, 22);
            this.rbActivos.TabIndex = 3;
            this.rbActivos.TabStop = true;
            this.rbActivos.Text = "Activos";
            this.rbActivos.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbActivos.UncheckedState.BorderThickness = 2;
            this.rbActivos.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbActivos.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rbActivos.UseVisualStyleBackColor = false;
            this.rbActivos.CheckedChanged += new System.EventHandler(this.rbActivos_CheckedChanged);
            // 
            // rbInactivos
            // 
            this.rbInactivos.AutoSize = true;
            this.rbInactivos.BackColor = System.Drawing.Color.WhiteSmoke;
            this.rbInactivos.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbInactivos.CheckedState.BorderThickness = 0;
            this.rbInactivos.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbInactivos.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbInactivos.CheckedState.InnerOffset = -4;
            this.rbInactivos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbInactivos.Location = new System.Drawing.Point(23, 6);
            this.rbInactivos.Name = "rbInactivos";
            this.rbInactivos.Size = new System.Drawing.Size(85, 22);
            this.rbInactivos.TabIndex = 2;
            this.rbInactivos.Text = "Inactivos";
            this.rbInactivos.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbInactivos.UncheckedState.BorderThickness = 2;
            this.rbInactivos.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbInactivos.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rbInactivos.UseVisualStyleBackColor = false;
            this.rbInactivos.CheckedChanged += new System.EventHandler(this.rbTodos_CheckedChanged);
            // 
            // pnlEliminar
            // 
            this.pnlEliminar.Controls.Add(this.lblCantidadConsumidores);
            this.pnlEliminar.Controls.Add(this.btnEliminar);
            this.pnlEliminar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlEliminar.Location = new System.Drawing.Point(20, 505);
            this.pnlEliminar.Name = "pnlEliminar";
            this.pnlEliminar.ShadowDecoration.Parent = this.pnlEliminar;
            this.pnlEliminar.Size = new System.Drawing.Size(660, 35);
            this.pnlEliminar.TabIndex = 1;
            this.pnlEliminar.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlEliminar_Paint);
            // 
            // btnEliminar
            // 
            this.btnEliminar.CheckedState.Parent = this.btnEliminar;
            this.btnEliminar.CustomImages.Parent = this.btnEliminar;
            this.btnEliminar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnEliminar.Enabled = false;
            this.btnEliminar.FillColor = System.Drawing.Color.Gray;
            this.btnEliminar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.HoverState.Parent = this.btnEliminar;
            this.btnEliminar.Location = new System.Drawing.Point(0, 0);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.ShadowDecoration.Parent = this.btnEliminar;
            this.btnEliminar.Size = new System.Drawing.Size(200, 35);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
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
            this.dtgConsumidores.EnableHeadersVisualStyles = false;
            this.dtgConsumidores.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgConsumidores.Location = new System.Drawing.Point(23, 34);
            this.dtgConsumidores.Name = "dtgConsumidores";
            this.dtgConsumidores.ReadOnly = true;
            this.dtgConsumidores.RowHeadersVisible = false;
            this.dtgConsumidores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgConsumidores.Size = new System.Drawing.Size(654, 465);
            this.dtgConsumidores.TabIndex = 0;
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
            // pnlEncabezadoConsumidores
            // 
            this.pnlEncabezadoConsumidores.BackColor = System.Drawing.Color.Silver;
            this.pnlEncabezadoConsumidores.Controls.Add(this.label1);
            this.pnlEncabezadoConsumidores.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEncabezadoConsumidores.Location = new System.Drawing.Point(0, 0);
            this.pnlEncabezadoConsumidores.Name = "pnlEncabezadoConsumidores";
            this.pnlEncabezadoConsumidores.ShadowDecoration.Parent = this.pnlEncabezadoConsumidores;
            this.pnlEncabezadoConsumidores.Size = new System.Drawing.Size(700, 60);
            this.pnlEncabezadoConsumidores.TabIndex = 3;
            this.pnlEncabezadoConsumidores.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlEncabezadoConsumidores_Paint);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(240, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "GESTIÓN DE CONSUMIDORES";
            this.label1.Click += new System.EventHandler(this.label1_Click);
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
            // lblCantidadConsumidores
            // 
            this.lblCantidadConsumidores.AutoSize = true;
            this.lblCantidadConsumidores.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblCantidadConsumidores.Location = new System.Drawing.Point(630, 0);
            this.lblCantidadConsumidores.Name = "lblCantidadConsumidores";
            this.lblCantidadConsumidores.Size = new System.Drawing.Size(30, 18);
            this.lblCantidadConsumidores.TabIndex = 4;
            this.lblCantidadConsumidores.Text = "0.0";
            // 
            // FrmConsumidores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1000, 620);
            this.Controls.Add(this.pnlConsumidores);
            this.Controls.Add(this.pnlNuevoConsumidor);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmConsumidores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmConsumidores";
            this.Load += new System.EventHandler(this.FrmConsumidores_Load);
            this.pnlNuevoConsumidor.ResumeLayout(false);
            this.pnlNuevoConsumidor.PerformLayout();
            this.pnlEncabezadoNuevoConsumidor.ResumeLayout(false);
            this.pnlEncabezadoNuevoConsumidor.PerformLayout();
            this.pnlConsumidores.ResumeLayout(false);
            this.pnlTablaConsumidores.ResumeLayout(false);
            this.pnlTablaConsumidores.PerformLayout();
            this.pnlEliminar.ResumeLayout(false);
            this.pnlEliminar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgConsumidores)).EndInit();
            this.pnlEncabezadoConsumidores.ResumeLayout(false);
            this.pnlEncabezadoConsumidores.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlNuevoConsumidor;
        private Guna.UI2.WinForms.Guna2Panel pnlEncabezadoNuevoConsumidor;
        private Guna.UI2.WinForms.Guna2Panel pnlConsumidores;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Panel pnlEncabezadoConsumidores;
        private System.Windows.Forms.Label label1;
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
        private Guna.UI2.WinForms.Guna2Button btnModificar;
        private Guna.UI2.WinForms.Guna2Button btnAgregar;
        private Guna.UI2.WinForms.Guna2Panel pnlTablaConsumidores;
        private Guna.UI2.WinForms.Guna2RadioButton rbActivos;
        private Guna.UI2.WinForms.Guna2RadioButton rbInactivos;
        private Guna.UI2.WinForms.Guna2Panel pnlEliminar;
        private Guna.UI2.WinForms.Guna2Button btnEliminar;
        private Guna.UI2.WinForms.Guna2DataGridView dtgConsumidores;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Label lblCantidadConsumidores;
    }
}