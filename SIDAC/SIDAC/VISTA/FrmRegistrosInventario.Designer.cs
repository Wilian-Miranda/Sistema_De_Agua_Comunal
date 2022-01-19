
namespace SIDAC.VISTA
{
    partial class FrmRegistrosInventario
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlCompras = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlNuevaCompra = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlFactura = new Guna.UI2.WinForms.Guna2Panel();
            this.primero = new System.Windows.Forms.Panel();
            this.dtgRegistros = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tercero = new System.Windows.Forms.Panel();
            this.lblTotal = new System.Windows.Forms.Label();
            this.segundo = new System.Windows.Forms.Panel();
            this.lblNombreTabla = new System.Windows.Forms.Label();
            this.pnlSeleccioFormulario = new Guna.UI2.WinForms.Guna2Panel();
            this.btnImprimir = new Guna.UI2.WinForms.Guna2Button();
            this.btnCerrarVentana = new Guna.UI2.WinForms.Guna2Button();
            this.pnlCompras.SuspendLayout();
            this.pnlNuevaCompra.SuspendLayout();
            this.pnlFactura.SuspendLayout();
            this.primero.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgRegistros)).BeginInit();
            this.tercero.SuspendLayout();
            this.segundo.SuspendLayout();
            this.pnlSeleccioFormulario.SuspendLayout();
            this.SuspendLayout();
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
            this.pnlCompras.Size = new System.Drawing.Size(1000, 570);
            this.pnlCompras.TabIndex = 5;
            // 
            // pnlNuevaCompra
            // 
            this.pnlNuevaCompra.Controls.Add(this.pnlFactura);
            this.pnlNuevaCompra.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlNuevaCompra.Location = new System.Drawing.Point(10, 10);
            this.pnlNuevaCompra.Name = "pnlNuevaCompra";
            this.pnlNuevaCompra.ShadowDecoration.Parent = this.pnlNuevaCompra;
            this.pnlNuevaCompra.Size = new System.Drawing.Size(980, 550);
            this.pnlNuevaCompra.TabIndex = 1;
            // 
            // pnlFactura
            // 
            this.pnlFactura.BackColor = System.Drawing.Color.White;
            this.pnlFactura.Controls.Add(this.primero);
            this.pnlFactura.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFactura.Location = new System.Drawing.Point(0, 0);
            this.pnlFactura.Name = "pnlFactura";
            this.pnlFactura.ShadowDecoration.Parent = this.pnlFactura;
            this.pnlFactura.Size = new System.Drawing.Size(980, 550);
            this.pnlFactura.TabIndex = 1;
            // 
            // primero
            // 
            this.primero.Controls.Add(this.dtgRegistros);
            this.primero.Controls.Add(this.tercero);
            this.primero.Controls.Add(this.segundo);
            this.primero.Dock = System.Windows.Forms.DockStyle.Fill;
            this.primero.Location = new System.Drawing.Point(0, 0);
            this.primero.Name = "primero";
            this.primero.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.primero.Size = new System.Drawing.Size(980, 550);
            this.primero.TabIndex = 36;
            // 
            // dtgRegistros
            // 
            this.dtgRegistros.AllowUserToAddRows = false;
            this.dtgRegistros.AllowUserToDeleteRows = false;
            this.dtgRegistros.AllowUserToOrderColumns = true;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            this.dtgRegistros.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dtgRegistros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgRegistros.BackgroundColor = System.Drawing.Color.White;
            this.dtgRegistros.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgRegistros.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgRegistros.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgRegistros.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dtgRegistros.ColumnHeadersHeight = 38;
            this.dtgRegistros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.Column1,
            this.Column6,
            this.Column2,
            this.Column7,
            this.Column8,
            this.Column4});
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgRegistros.DefaultCellStyle = dataGridViewCellStyle18;
            this.dtgRegistros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgRegistros.EnableHeadersVisualStyles = false;
            this.dtgRegistros.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgRegistros.Location = new System.Drawing.Point(0, 35);
            this.dtgRegistros.Name = "dtgRegistros";
            this.dtgRegistros.ReadOnly = true;
            this.dtgRegistros.RowHeadersVisible = false;
            this.dtgRegistros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgRegistros.Size = new System.Drawing.Size(970, 477);
            this.dtgRegistros.TabIndex = 19;
            this.dtgRegistros.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dtgRegistros.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgRegistros.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dtgRegistros.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dtgRegistros.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dtgRegistros.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dtgRegistros.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dtgRegistros.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgRegistros.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtgRegistros.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgRegistros.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgRegistros.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtgRegistros.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dtgRegistros.ThemeStyle.HeaderStyle.Height = 38;
            this.dtgRegistros.ThemeStyle.ReadOnly = true;
            this.dtgRegistros.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgRegistros.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgRegistros.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgRegistros.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dtgRegistros.ThemeStyle.RowsStyle.Height = 22;
            this.dtgRegistros.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgRegistros.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // Column3
            // 
            dataGridViewCellStyle12.Format = "N0";
            dataGridViewCellStyle12.NullValue = null;
            this.Column3.DefaultCellStyle = dataGridViewCellStyle12;
            this.Column3.HeaderText = "Id";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Visible = false;
            // 
            // Column1
            // 
            dataGridViewCellStyle13.Format = "N0";
            dataGridViewCellStyle13.NullValue = null;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle13;
            this.Column1.FillWeight = 30F;
            this.Column1.HeaderText = "Cantidad";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column6
            // 
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.NullValue = null;
            this.Column6.DefaultCellStyle = dataGridViewCellStyle14;
            this.Column6.FillWeight = 60F;
            this.Column6.HeaderText = "Descripcion";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Motivo";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column7
            // 
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.Format = "C4";
            dataGridViewCellStyle15.NullValue = "-";
            this.Column7.DefaultCellStyle = dataGridViewCellStyle15;
            this.Column7.FillWeight = 30F;
            this.Column7.HeaderText = "P/U";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.Format = "C4";
            dataGridViewCellStyle16.NullValue = "-";
            this.Column8.DefaultCellStyle = dataGridViewCellStyle16;
            this.Column8.FillWeight = 30F;
            this.Column8.HeaderText = "Subtotal";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column4
            // 
            dataGridViewCellStyle17.Format = "d";
            dataGridViewCellStyle17.NullValue = "-";
            this.Column4.DefaultCellStyle = dataGridViewCellStyle17;
            this.Column4.FillWeight = 30F;
            this.Column4.HeaderText = "Fecha";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // tercero
            // 
            this.tercero.Controls.Add(this.lblTotal);
            this.tercero.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tercero.Location = new System.Drawing.Point(0, 512);
            this.tercero.Name = "tercero";
            this.tercero.Padding = new System.Windows.Forms.Padding(5);
            this.tercero.Size = new System.Drawing.Size(970, 38);
            this.tercero.TabIndex = 34;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTotal.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(5, 5);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(57, 18);
            this.lblTotal.TabIndex = 29;
            this.lblTotal.Text = "0.0000";
            // 
            // segundo
            // 
            this.segundo.Controls.Add(this.lblNombreTabla);
            this.segundo.Dock = System.Windows.Forms.DockStyle.Top;
            this.segundo.Location = new System.Drawing.Point(0, 0);
            this.segundo.Name = "segundo";
            this.segundo.Padding = new System.Windows.Forms.Padding(0, 5, 5, 5);
            this.segundo.Size = new System.Drawing.Size(970, 35);
            this.segundo.TabIndex = 33;
            // 
            // lblNombreTabla
            // 
            this.lblNombreTabla.AutoSize = true;
            this.lblNombreTabla.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblNombreTabla.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreTabla.Location = new System.Drawing.Point(0, 5);
            this.lblNombreTabla.Name = "lblNombreTabla";
            this.lblNombreTabla.Size = new System.Drawing.Size(401, 19);
            this.lblNombreTabla.TabIndex = 20;
            this.lblNombreTabla.Text = "REGISTROS DE ENTRADA Y SALIDA DE MATERIAL";
            // 
            // pnlSeleccioFormulario
            // 
            this.pnlSeleccioFormulario.BackColor = System.Drawing.Color.Silver;
            this.pnlSeleccioFormulario.Controls.Add(this.btnCerrarVentana);
            this.pnlSeleccioFormulario.Controls.Add(this.btnImprimir);
            this.pnlSeleccioFormulario.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSeleccioFormulario.Location = new System.Drawing.Point(0, 0);
            this.pnlSeleccioFormulario.Name = "pnlSeleccioFormulario";
            this.pnlSeleccioFormulario.Padding = new System.Windows.Forms.Padding(5);
            this.pnlSeleccioFormulario.ShadowDecoration.Parent = this.pnlSeleccioFormulario;
            this.pnlSeleccioFormulario.Size = new System.Drawing.Size(1000, 30);
            this.pnlSeleccioFormulario.TabIndex = 4;
            // 
            // btnImprimir
            // 
            this.btnImprimir.CheckedState.Parent = this.btnImprimir;
            this.btnImprimir.CustomImages.Parent = this.btnImprimir;
            this.btnImprimir.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnImprimir.FillColor = System.Drawing.Color.Gray;
            this.btnImprimir.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnImprimir.ForeColor = System.Drawing.Color.White;
            this.btnImprimir.HoverState.Parent = this.btnImprimir;
            this.btnImprimir.Location = new System.Drawing.Point(5, 5);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.ShadowDecoration.Parent = this.btnImprimir;
            this.btnImprimir.Size = new System.Drawing.Size(120, 20);
            this.btnImprimir.TabIndex = 36;
            this.btnImprimir.Text = "Imprimir";
            // 
            // btnCerrarVentana
            // 
            this.btnCerrarVentana.BorderRadius = 12;
            this.btnCerrarVentana.CheckedState.Parent = this.btnCerrarVentana;
            this.btnCerrarVentana.CustomImages.Parent = this.btnCerrarVentana;
            this.btnCerrarVentana.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCerrarVentana.FillColor = System.Drawing.Color.Red;
            this.btnCerrarVentana.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCerrarVentana.ForeColor = System.Drawing.Color.White;
            this.btnCerrarVentana.HoverState.Parent = this.btnCerrarVentana;
            this.btnCerrarVentana.Location = new System.Drawing.Point(966, 5);
            this.btnCerrarVentana.Name = "btnCerrarVentana";
            this.btnCerrarVentana.ShadowDecoration.Parent = this.btnCerrarVentana;
            this.btnCerrarVentana.Size = new System.Drawing.Size(29, 20);
            this.btnCerrarVentana.TabIndex = 37;
            this.btnCerrarVentana.Text = "X";
            this.btnCerrarVentana.Click += new System.EventHandler(this.btnCerrarVentana_Click);
            // 
            // FrmRegistrosInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.pnlCompras);
            this.Controls.Add(this.pnlSeleccioFormulario);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmRegistrosInventario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Entrada y Salida de Material";
            this.pnlCompras.ResumeLayout(false);
            this.pnlNuevaCompra.ResumeLayout(false);
            this.pnlFactura.ResumeLayout(false);
            this.primero.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgRegistros)).EndInit();
            this.tercero.ResumeLayout(false);
            this.tercero.PerformLayout();
            this.segundo.ResumeLayout(false);
            this.segundo.PerformLayout();
            this.pnlSeleccioFormulario.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlCompras;
        private Guna.UI2.WinForms.Guna2Panel pnlNuevaCompra;
        private Guna.UI2.WinForms.Guna2Panel pnlFactura;
        private System.Windows.Forms.Panel primero;
        private Guna.UI2.WinForms.Guna2DataGridView dtgRegistros;
        private System.Windows.Forms.Panel tercero;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Panel segundo;
        private System.Windows.Forms.Label lblNombreTabla;
        private Guna.UI2.WinForms.Guna2Panel pnlSeleccioFormulario;
        private Guna.UI2.WinForms.Guna2Button btnImprimir;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private Guna.UI2.WinForms.Guna2Button btnCerrarVentana;
    }
}