
namespace SIDAC.VISTA
{
    partial class VisualizarFactura
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
            this.pnlPrincipal = new Guna.UI2.WinForms.Guna2Panel();
            this.ptrVisualizarFactura = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pnlBotonesControl = new System.Windows.Forms.Panel();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.pnlPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptrVisualizarFactura)).BeginInit();
            this.pnlBotonesControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.BackColor = System.Drawing.SystemColors.HighlightText;
            this.pnlPrincipal.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnlPrincipal.BorderRadius = 14;
            this.pnlPrincipal.BorderThickness = 2;
            this.pnlPrincipal.Controls.Add(this.ptrVisualizarFactura);
            this.pnlPrincipal.Controls.Add(this.pnlBotonesControl);
            this.pnlPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPrincipal.Location = new System.Drawing.Point(10, 10);
            this.pnlPrincipal.Name = "pnlPrincipal";
            this.pnlPrincipal.ShadowDecoration.Parent = this.pnlPrincipal;
            this.pnlPrincipal.Size = new System.Drawing.Size(880, 700);
            this.pnlPrincipal.TabIndex = 0;
            // 
            // ptrVisualizarFactura
            // 
            this.ptrVisualizarFactura.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ptrVisualizarFactura.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ptrVisualizarFactura.Location = new System.Drawing.Point(0, 30);
            this.ptrVisualizarFactura.Name = "ptrVisualizarFactura";
            this.ptrVisualizarFactura.ShadowDecoration.Parent = this.ptrVisualizarFactura;
            this.ptrVisualizarFactura.Size = new System.Drawing.Size(880, 670);
            this.ptrVisualizarFactura.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptrVisualizarFactura.TabIndex = 1;
            this.ptrVisualizarFactura.TabStop = false;
            // 
            // pnlBotonesControl
            // 
            this.pnlBotonesControl.Controls.Add(this.guna2Button1);
            this.pnlBotonesControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBotonesControl.Location = new System.Drawing.Point(0, 0);
            this.pnlBotonesControl.Name = "pnlBotonesControl";
            this.pnlBotonesControl.Size = new System.Drawing.Size(880, 30);
            this.pnlBotonesControl.TabIndex = 0;
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 19;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.guna2Button1.FillColor = System.Drawing.Color.Red;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(847, 0);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(33, 30);
            this.guna2Button1.TabIndex = 0;
            this.guna2Button1.Text = "X";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // VisualizarFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(900, 720);
            this.Controls.Add(this.pnlPrincipal);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "VisualizarFactura";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VisualizarFactura";
            this.pnlPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptrVisualizarFactura)).EndInit();
            this.pnlBotonesControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlPrincipal;
        private System.Windows.Forms.Panel pnlBotonesControl;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        public Guna.UI2.WinForms.Guna2PictureBox ptrVisualizarFactura;
    }
}