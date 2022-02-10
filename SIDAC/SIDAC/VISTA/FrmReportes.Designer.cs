
namespace SIDAC.VISTA
{
    partial class FrmReportes
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
            this.pnlControlesPagos = new System.Windows.Forms.Panel();
            this.rbReporteGeneral = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rbReportePorConsumidor = new Guna.UI2.WinForms.Guna2RadioButton();
            this.txtYear_Pagos = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnBusrcarConsumidor_Pagos = new Guna.UI2.WinForms.Guna2Button();
            this.cbConsumidor_Pagos = new System.Windows.Forms.ComboBox();
            this.Consumidor = new System.Windows.Forms.Label();
            this.btnImprimir_Pagos = new Guna.UI2.WinForms.Guna2Button();
            this.btnCargarDatos = new Guna.UI2.WinForms.Guna2Button();
            this.pnlDetallesPagos = new System.Windows.Forms.Panel();
            this.lblIdConsumidor = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblMora_Pagos = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblPendiente = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblCancelado_Pagos = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblMontoTotal_Pagos = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblConsumidor_Pagos = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblNumRegistros_Pagos = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pnlControlesPagos.SuspendLayout();
            this.pnlDetallesPagos.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlControlesPagos
            // 
            this.pnlControlesPagos.BackColor = System.Drawing.SystemColors.Control;
            this.pnlControlesPagos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlControlesPagos.Controls.Add(this.rbReporteGeneral);
            this.pnlControlesPagos.Controls.Add(this.rbReportePorConsumidor);
            this.pnlControlesPagos.Controls.Add(this.txtYear_Pagos);
            this.pnlControlesPagos.Controls.Add(this.btnBusrcarConsumidor_Pagos);
            this.pnlControlesPagos.Controls.Add(this.cbConsumidor_Pagos);
            this.pnlControlesPagos.Controls.Add(this.Consumidor);
            this.pnlControlesPagos.Controls.Add(this.btnImprimir_Pagos);
            this.pnlControlesPagos.Controls.Add(this.btnCargarDatos);
            this.pnlControlesPagos.Controls.Add(this.pnlDetallesPagos);
            this.pnlControlesPagos.Controls.Add(this.label2);
            this.pnlControlesPagos.Controls.Add(this.label1);
            this.pnlControlesPagos.Controls.Add(this.guna2HtmlLabel1);
            this.pnlControlesPagos.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlControlesPagos.ForeColor = System.Drawing.Color.Black;
            this.pnlControlesPagos.Location = new System.Drawing.Point(0, 0);
            this.pnlControlesPagos.Name = "pnlControlesPagos";
            this.pnlControlesPagos.Size = new System.Drawing.Size(984, 288);
            this.pnlControlesPagos.TabIndex = 1;
            // 
            // rbReporteGeneral
            // 
            this.rbReporteGeneral.AutoSize = true;
            this.rbReporteGeneral.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbReporteGeneral.CheckedState.BorderThickness = 0;
            this.rbReporteGeneral.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbReporteGeneral.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbReporteGeneral.CheckedState.InnerOffset = -4;
            this.rbReporteGeneral.Location = new System.Drawing.Point(186, 68);
            this.rbReporteGeneral.Name = "rbReporteGeneral";
            this.rbReporteGeneral.Size = new System.Drawing.Size(81, 22);
            this.rbReporteGeneral.TabIndex = 14;
            this.rbReporteGeneral.Text = "General";
            this.rbReporteGeneral.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbReporteGeneral.UncheckedState.BorderThickness = 2;
            this.rbReporteGeneral.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbReporteGeneral.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rbReporteGeneral.CheckedChanged += new System.EventHandler(this.rbReporteGeneral_CheckedChanged);
            // 
            // rbReportePorConsumidor
            // 
            this.rbReportePorConsumidor.AutoSize = true;
            this.rbReportePorConsumidor.Checked = true;
            this.rbReportePorConsumidor.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbReportePorConsumidor.CheckedState.BorderThickness = 0;
            this.rbReportePorConsumidor.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbReportePorConsumidor.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbReportePorConsumidor.CheckedState.InnerOffset = -4;
            this.rbReportePorConsumidor.Location = new System.Drawing.Point(16, 68);
            this.rbReportePorConsumidor.Name = "rbReportePorConsumidor";
            this.rbReportePorConsumidor.Size = new System.Drawing.Size(140, 22);
            this.rbReportePorConsumidor.TabIndex = 13;
            this.rbReportePorConsumidor.TabStop = true;
            this.rbReportePorConsumidor.Text = "Por Consumidor";
            this.rbReportePorConsumidor.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbReportePorConsumidor.UncheckedState.BorderThickness = 2;
            this.rbReportePorConsumidor.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbReportePorConsumidor.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rbReportePorConsumidor.CheckedChanged += new System.EventHandler(this.cbReportePorConsumidor_CheckedChanged);
            // 
            // txtYear_Pagos
            // 
            this.txtYear_Pagos.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtYear_Pagos.DefaultText = "";
            this.txtYear_Pagos.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtYear_Pagos.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtYear_Pagos.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtYear_Pagos.DisabledState.Parent = this.txtYear_Pagos;
            this.txtYear_Pagos.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtYear_Pagos.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtYear_Pagos.FocusedState.Parent = this.txtYear_Pagos;
            this.txtYear_Pagos.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtYear_Pagos.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtYear_Pagos.HoverState.Parent = this.txtYear_Pagos;
            this.txtYear_Pagos.Location = new System.Drawing.Point(16, 129);
            this.txtYear_Pagos.Name = "txtYear_Pagos";
            this.txtYear_Pagos.PasswordChar = '\0';
            this.txtYear_Pagos.PlaceholderText = "";
            this.txtYear_Pagos.SelectedText = "";
            this.txtYear_Pagos.ShadowDecoration.Parent = this.txtYear_Pagos;
            this.txtYear_Pagos.Size = new System.Drawing.Size(127, 36);
            this.txtYear_Pagos.TabIndex = 12;
            this.txtYear_Pagos.Enter += new System.EventHandler(this.txtYear_Pagos_Enter);
            // 
            // btnBusrcarConsumidor_Pagos
            // 
            this.btnBusrcarConsumidor_Pagos.CheckedState.Parent = this.btnBusrcarConsumidor_Pagos;
            this.btnBusrcarConsumidor_Pagos.CustomImages.Parent = this.btnBusrcarConsumidor_Pagos;
            this.btnBusrcarConsumidor_Pagos.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBusrcarConsumidor_Pagos.ForeColor = System.Drawing.Color.White;
            this.btnBusrcarConsumidor_Pagos.HoverState.Parent = this.btnBusrcarConsumidor_Pagos;
            this.btnBusrcarConsumidor_Pagos.Location = new System.Drawing.Point(424, 244);
            this.btnBusrcarConsumidor_Pagos.Name = "btnBusrcarConsumidor_Pagos";
            this.btnBusrcarConsumidor_Pagos.ShadowDecoration.Parent = this.btnBusrcarConsumidor_Pagos;
            this.btnBusrcarConsumidor_Pagos.Size = new System.Drawing.Size(120, 30);
            this.btnBusrcarConsumidor_Pagos.TabIndex = 10;
            this.btnBusrcarConsumidor_Pagos.Text = "Buscar";
            this.btnBusrcarConsumidor_Pagos.Click += new System.EventHandler(this.btnBusrcarConsumidor_Pagos_Click);
            // 
            // cbConsumidor_Pagos
            // 
            this.cbConsumidor_Pagos.FormattingEnabled = true;
            this.cbConsumidor_Pagos.Location = new System.Drawing.Point(16, 248);
            this.cbConsumidor_Pagos.Name = "cbConsumidor_Pagos";
            this.cbConsumidor_Pagos.Size = new System.Drawing.Size(402, 26);
            this.cbConsumidor_Pagos.TabIndex = 9;
            this.cbConsumidor_Pagos.SelectedIndexChanged += new System.EventHandler(this.cbConsumidor_Pagos_SelectedIndexChanged);
            this.cbConsumidor_Pagos.Enter += new System.EventHandler(this.cbConsumidor_Pagos_Enter);
            // 
            // Consumidor
            // 
            this.Consumidor.AutoSize = true;
            this.Consumidor.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Consumidor.Location = new System.Drawing.Point(12, 226);
            this.Consumidor.Name = "Consumidor";
            this.Consumidor.Size = new System.Drawing.Size(199, 19);
            this.Consumidor.TabIndex = 8;
            this.Consumidor.Text = "Nombre del consumidor:";
            // 
            // btnImprimir_Pagos
            // 
            this.btnImprimir_Pagos.CheckedState.Parent = this.btnImprimir_Pagos;
            this.btnImprimir_Pagos.CustomImages.Parent = this.btnImprimir_Pagos;
            this.btnImprimir_Pagos.Enabled = false;
            this.btnImprimir_Pagos.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir_Pagos.ForeColor = System.Drawing.Color.White;
            this.btnImprimir_Pagos.HoverState.Parent = this.btnImprimir_Pagos;
            this.btnImprimir_Pagos.Location = new System.Drawing.Point(852, 46);
            this.btnImprimir_Pagos.Name = "btnImprimir_Pagos";
            this.btnImprimir_Pagos.ShadowDecoration.Parent = this.btnImprimir_Pagos;
            this.btnImprimir_Pagos.Size = new System.Drawing.Size(120, 30);
            this.btnImprimir_Pagos.TabIndex = 7;
            this.btnImprimir_Pagos.Text = "Imprimir";
            this.btnImprimir_Pagos.Click += new System.EventHandler(this.btnImprimir_Pagos_Click);
            // 
            // btnCargarDatos
            // 
            this.btnCargarDatos.CheckedState.Parent = this.btnCargarDatos;
            this.btnCargarDatos.CustomImages.Parent = this.btnCargarDatos;
            this.btnCargarDatos.Enabled = false;
            this.btnCargarDatos.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarDatos.ForeColor = System.Drawing.Color.White;
            this.btnCargarDatos.HoverState.Parent = this.btnCargarDatos;
            this.btnCargarDatos.Location = new System.Drawing.Point(852, 6);
            this.btnCargarDatos.Name = "btnCargarDatos";
            this.btnCargarDatos.ShadowDecoration.Parent = this.btnCargarDatos;
            this.btnCargarDatos.Size = new System.Drawing.Size(120, 30);
            this.btnCargarDatos.TabIndex = 6;
            this.btnCargarDatos.Text = "Cargar datos";
            this.btnCargarDatos.Click += new System.EventHandler(this.btnCargarDatos_Click);
            // 
            // pnlDetallesPagos
            // 
            this.pnlDetallesPagos.BackColor = System.Drawing.Color.White;
            this.pnlDetallesPagos.Controls.Add(this.lblIdConsumidor);
            this.pnlDetallesPagos.Controls.Add(this.label9);
            this.pnlDetallesPagos.Controls.Add(this.lblMora_Pagos);
            this.pnlDetallesPagos.Controls.Add(this.label7);
            this.pnlDetallesPagos.Controls.Add(this.lblPendiente);
            this.pnlDetallesPagos.Controls.Add(this.label10);
            this.pnlDetallesPagos.Controls.Add(this.lblCancelado_Pagos);
            this.pnlDetallesPagos.Controls.Add(this.label8);
            this.pnlDetallesPagos.Controls.Add(this.lblMontoTotal_Pagos);
            this.pnlDetallesPagos.Controls.Add(this.label6);
            this.pnlDetallesPagos.Controls.Add(this.lblConsumidor_Pagos);
            this.pnlDetallesPagos.Controls.Add(this.label5);
            this.pnlDetallesPagos.Controls.Add(this.lblNumRegistros_Pagos);
            this.pnlDetallesPagos.Controls.Add(this.label3);
            this.pnlDetallesPagos.Enabled = false;
            this.pnlDetallesPagos.Location = new System.Drawing.Point(359, 6);
            this.pnlDetallesPagos.Name = "pnlDetallesPagos";
            this.pnlDetallesPagos.Size = new System.Drawing.Size(487, 232);
            this.pnlDetallesPagos.TabIndex = 5;
            // 
            // lblIdConsumidor
            // 
            this.lblIdConsumidor.AutoSize = true;
            this.lblIdConsumidor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblIdConsumidor.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdConsumidor.Location = new System.Drawing.Point(157, 9);
            this.lblIdConsumidor.Name = "lblIdConsumidor";
            this.lblIdConsumidor.Size = new System.Drawing.Size(2, 21);
            this.lblIdConsumidor.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(15, 11);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 19);
            this.label9.TabIndex = 16;
            this.label9.Text = "Id:";
            // 
            // lblMora_Pagos
            // 
            this.lblMora_Pagos.AutoSize = true;
            this.lblMora_Pagos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMora_Pagos.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMora_Pagos.Location = new System.Drawing.Point(157, 191);
            this.lblMora_Pagos.Name = "lblMora_Pagos";
            this.lblMora_Pagos.Size = new System.Drawing.Size(2, 21);
            this.lblMora_Pagos.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(15, 193);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 19);
            this.label7.TabIndex = 14;
            this.label7.Text = "Mora total:";
            // 
            // lblPendiente
            // 
            this.lblPendiente.AutoSize = true;
            this.lblPendiente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPendiente.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPendiente.Location = new System.Drawing.Point(157, 162);
            this.lblPendiente.Name = "lblPendiente";
            this.lblPendiente.Size = new System.Drawing.Size(2, 21);
            this.lblPendiente.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(15, 164);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(132, 19);
            this.label10.TabIndex = 12;
            this.label10.Text = "Total pendiente:";
            // 
            // lblCancelado_Pagos
            // 
            this.lblCancelado_Pagos.AutoSize = true;
            this.lblCancelado_Pagos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCancelado_Pagos.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCancelado_Pagos.Location = new System.Drawing.Point(157, 131);
            this.lblCancelado_Pagos.Name = "lblCancelado_Pagos";
            this.lblCancelado_Pagos.Size = new System.Drawing.Size(2, 21);
            this.lblCancelado_Pagos.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(15, 133);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(135, 19);
            this.label8.TabIndex = 10;
            this.label8.Text = "Total cancelado:";
            // 
            // lblMontoTotal_Pagos
            // 
            this.lblMontoTotal_Pagos.AutoSize = true;
            this.lblMontoTotal_Pagos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMontoTotal_Pagos.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontoTotal_Pagos.Location = new System.Drawing.Point(157, 101);
            this.lblMontoTotal_Pagos.Name = "lblMontoTotal_Pagos";
            this.lblMontoTotal_Pagos.Size = new System.Drawing.Size(2, 21);
            this.lblMontoTotal_Pagos.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 19);
            this.label6.TabIndex = 8;
            this.label6.Text = "Monto total:";
            // 
            // lblConsumidor_Pagos
            // 
            this.lblConsumidor_Pagos.AutoSize = true;
            this.lblConsumidor_Pagos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblConsumidor_Pagos.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsumidor_Pagos.Location = new System.Drawing.Point(157, 38);
            this.lblConsumidor_Pagos.Name = "lblConsumidor_Pagos";
            this.lblConsumidor_Pagos.Size = new System.Drawing.Size(2, 21);
            this.lblConsumidor_Pagos.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 19);
            this.label5.TabIndex = 6;
            this.label5.Text = "Consumidor:";
            // 
            // lblNumRegistros_Pagos
            // 
            this.lblNumRegistros_Pagos.AutoSize = true;
            this.lblNumRegistros_Pagos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNumRegistros_Pagos.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumRegistros_Pagos.Location = new System.Drawing.Point(157, 69);
            this.lblNumRegistros_Pagos.Name = "lblNumRegistros_Pagos";
            this.lblNumRegistros_Pagos.Size = new System.Drawing.Size(2, 21);
            this.lblNumRegistros_Pagos.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "No. de registros:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Año:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tipo de reporte:";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(12, 6);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(230, 21);
            this.guna2HtmlLabel1.TabIndex = 0;
            this.guna2HtmlLabel1.Text = "Sistema de reportes de pagos";
            // 
            // FrmReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 289);
            this.Controls.Add(this.pnlControlesPagos);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmReportes";
            this.Text = "FrmReportes";
            this.pnlControlesPagos.ResumeLayout(false);
            this.pnlControlesPagos.PerformLayout();
            this.pnlDetallesPagos.ResumeLayout(false);
            this.pnlDetallesPagos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlControlesPagos;
        private System.Windows.Forms.Panel pnlDetallesPagos;
        private System.Windows.Forms.Label lblConsumidor_Pagos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblNumRegistros_Pagos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private System.Windows.Forms.Label lblPendiente;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblCancelado_Pagos;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblMontoTotal_Pagos;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2Button btnBusrcarConsumidor_Pagos;
        private System.Windows.Forms.ComboBox cbConsumidor_Pagos;
        private System.Windows.Forms.Label Consumidor;
        private Guna.UI2.WinForms.Guna2Button btnImprimir_Pagos;
        private Guna.UI2.WinForms.Guna2Button btnCargarDatos;
        private System.Windows.Forms.Label lblMora_Pagos;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox txtYear_Pagos;
        private System.Windows.Forms.Label lblIdConsumidor;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2RadioButton rbReporteGeneral;
        private Guna.UI2.WinForms.Guna2RadioButton rbReportePorConsumidor;
    }
}