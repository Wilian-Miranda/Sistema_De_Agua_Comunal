
namespace SIDAC
{
    partial class FrmHome
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.pnlEncabezado = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlMenu = new Guna.UI2.WinForms.Guna2Panel();
            this.btnAjustes = new Guna.UI2.WinForms.Guna2Button();
            this.btnReportes = new Guna.UI2.WinForms.Guna2Button();
            this.btnInventarios = new Guna.UI2.WinForms.Guna2Button();
            this.btnCompras = new Guna.UI2.WinForms.Guna2Button();
            this.btnPagos = new Guna.UI2.WinForms.Guna2Button();
            this.btnConsumidores = new Guna.UI2.WinForms.Guna2Button();
            this.btnDashboard = new Guna.UI2.WinForms.Guna2Button();
            this.pbLogo = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pnlPadre = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlEncabezado
            // 
            this.pnlEncabezado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlEncabezado.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEncabezado.ForeColor = System.Drawing.Color.Black;
            this.pnlEncabezado.Location = new System.Drawing.Point(0, 0);
            this.pnlEncabezado.Name = "pnlEncabezado";
            this.pnlEncabezado.ShadowDecoration.Parent = this.pnlEncabezado;
            this.pnlEncabezado.Size = new System.Drawing.Size(1200, 30);
            this.pnlEncabezado.TabIndex = 0;
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnlMenu.Controls.Add(this.btnAjustes);
            this.pnlMenu.Controls.Add(this.btnReportes);
            this.pnlMenu.Controls.Add(this.btnInventarios);
            this.pnlMenu.Controls.Add(this.btnCompras);
            this.pnlMenu.Controls.Add(this.btnPagos);
            this.pnlMenu.Controls.Add(this.btnConsumidores);
            this.pnlMenu.Controls.Add(this.btnDashboard);
            this.pnlMenu.Controls.Add(this.pbLogo);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 30);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.ShadowDecoration.Parent = this.pnlMenu;
            this.pnlMenu.Size = new System.Drawing.Size(200, 620);
            this.pnlMenu.TabIndex = 1;
            // 
            // btnAjustes
            // 
            this.btnAjustes.CheckedState.Parent = this.btnAjustes;
            this.btnAjustes.CustomImages.Parent = this.btnAjustes;
            this.btnAjustes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnAjustes.FillColor = System.Drawing.Color.Gray;
            this.btnAjustes.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjustes.ForeColor = System.Drawing.Color.White;
            this.btnAjustes.HoverState.Parent = this.btnAjustes;
            this.btnAjustes.Location = new System.Drawing.Point(0, 585);
            this.btnAjustes.Name = "btnAjustes";
            this.btnAjustes.ShadowDecoration.Parent = this.btnAjustes;
            this.btnAjustes.Size = new System.Drawing.Size(200, 35);
            this.btnAjustes.TabIndex = 8;
            this.btnAjustes.Text = "Ajustes";
            // 
            // btnReportes
            // 
            this.btnReportes.BorderRadius = 3;
            this.btnReportes.BorderThickness = 1;
            this.btnReportes.CheckedState.Parent = this.btnReportes;
            this.btnReportes.CustomImages.Parent = this.btnReportes;
            this.btnReportes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReportes.FillColor = System.Drawing.Color.Gray;
            this.btnReportes.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportes.ForeColor = System.Drawing.Color.Black;
            this.btnReportes.HoverState.Parent = this.btnReportes;
            this.btnReportes.Location = new System.Drawing.Point(0, 375);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.ShadowDecoration.Parent = this.btnReportes;
            this.btnReportes.Size = new System.Drawing.Size(200, 35);
            this.btnReportes.TabIndex = 7;
            this.btnReportes.Text = "Reportes";
            this.btnReportes.Click += new System.EventHandler(this.btnReportes_Click);
            // 
            // btnInventarios
            // 
            this.btnInventarios.BorderRadius = 3;
            this.btnInventarios.BorderThickness = 1;
            this.btnInventarios.CheckedState.Parent = this.btnInventarios;
            this.btnInventarios.CustomImages.Parent = this.btnInventarios;
            this.btnInventarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInventarios.FillColor = System.Drawing.Color.Gray;
            this.btnInventarios.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventarios.ForeColor = System.Drawing.Color.Black;
            this.btnInventarios.HoverState.Parent = this.btnInventarios;
            this.btnInventarios.Location = new System.Drawing.Point(0, 340);
            this.btnInventarios.Name = "btnInventarios";
            this.btnInventarios.ShadowDecoration.Parent = this.btnInventarios;
            this.btnInventarios.Size = new System.Drawing.Size(200, 35);
            this.btnInventarios.TabIndex = 6;
            this.btnInventarios.Text = "Inventarios";
            this.btnInventarios.Click += new System.EventHandler(this.btnInventarios_Click);
            // 
            // btnCompras
            // 
            this.btnCompras.BorderRadius = 3;
            this.btnCompras.BorderThickness = 1;
            this.btnCompras.CheckedState.Parent = this.btnCompras;
            this.btnCompras.CustomImages.Parent = this.btnCompras;
            this.btnCompras.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCompras.FillColor = System.Drawing.Color.Gray;
            this.btnCompras.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompras.ForeColor = System.Drawing.Color.Black;
            this.btnCompras.HoverState.Parent = this.btnCompras;
            this.btnCompras.Location = new System.Drawing.Point(0, 305);
            this.btnCompras.Name = "btnCompras";
            this.btnCompras.ShadowDecoration.Parent = this.btnCompras;
            this.btnCompras.Size = new System.Drawing.Size(200, 35);
            this.btnCompras.TabIndex = 5;
            this.btnCompras.Text = "Compras";
            this.btnCompras.Click += new System.EventHandler(this.btnCompras_Click);
            // 
            // btnPagos
            // 
            this.btnPagos.BorderRadius = 3;
            this.btnPagos.BorderThickness = 1;
            this.btnPagos.CheckedState.Parent = this.btnPagos;
            this.btnPagos.CustomImages.Parent = this.btnPagos;
            this.btnPagos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPagos.FillColor = System.Drawing.Color.Gray;
            this.btnPagos.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagos.ForeColor = System.Drawing.Color.Black;
            this.btnPagos.HoverState.Parent = this.btnPagos;
            this.btnPagos.Location = new System.Drawing.Point(0, 270);
            this.btnPagos.Name = "btnPagos";
            this.btnPagos.ShadowDecoration.Parent = this.btnPagos;
            this.btnPagos.Size = new System.Drawing.Size(200, 35);
            this.btnPagos.TabIndex = 4;
            this.btnPagos.Text = "Pagos";
            this.btnPagos.Click += new System.EventHandler(this.btnPagos_Click);
            // 
            // btnConsumidores
            // 
            this.btnConsumidores.BorderRadius = 3;
            this.btnConsumidores.BorderThickness = 1;
            this.btnConsumidores.CheckedState.Parent = this.btnConsumidores;
            this.btnConsumidores.CustomImages.Parent = this.btnConsumidores;
            this.btnConsumidores.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConsumidores.FillColor = System.Drawing.Color.Gray;
            this.btnConsumidores.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsumidores.ForeColor = System.Drawing.Color.Black;
            this.btnConsumidores.HoverState.Parent = this.btnConsumidores;
            this.btnConsumidores.Location = new System.Drawing.Point(0, 235);
            this.btnConsumidores.Name = "btnConsumidores";
            this.btnConsumidores.ShadowDecoration.Parent = this.btnConsumidores;
            this.btnConsumidores.Size = new System.Drawing.Size(200, 35);
            this.btnConsumidores.TabIndex = 3;
            this.btnConsumidores.Text = "Consumidores";
            this.btnConsumidores.Click += new System.EventHandler(this.btnConsumidores_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.BorderRadius = 3;
            this.btnDashboard.BorderThickness = 1;
            this.btnDashboard.CheckedState.Parent = this.btnDashboard;
            this.btnDashboard.CustomImages.Parent = this.btnDashboard;
            this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboard.FillColor = System.Drawing.Color.Gray;
            this.btnDashboard.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.Black;
            this.btnDashboard.HoverState.Parent = this.btnDashboard;
            this.btnDashboard.Location = new System.Drawing.Point(0, 200);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.ShadowDecoration.Parent = this.btnDashboard;
            this.btnDashboard.Size = new System.Drawing.Size(200, 35);
            this.btnDashboard.TabIndex = 2;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // pbLogo
            // 
            this.pbLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pbLogo.BorderRadius = 14;
            this.pbLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pbLogo.Image = global::SIDAC.Properties.Resources._3;
            this.pbLogo.Location = new System.Drawing.Point(0, 0);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.ShadowDecoration.Parent = this.pbLogo;
            this.pbLogo.Size = new System.Drawing.Size(200, 200);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbLogo.TabIndex = 1;
            this.pbLogo.TabStop = false;
            // 
            // pnlPadre
            // 
            this.pnlPadre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPadre.Location = new System.Drawing.Point(200, 30);
            this.pnlPadre.Name = "pnlPadre";
            this.pnlPadre.ShadowDecoration.Parent = this.pnlPadre;
            this.pnlPadre.Size = new System.Drawing.Size(1000, 620);
            this.pnlPadre.TabIndex = 2;
            // 
            // FrmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 650);
            this.Controls.Add(this.pnlPadre);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.pnlEncabezado);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.pnlMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlEncabezado;
        private Guna.UI2.WinForms.Guna2Panel pnlMenu;
        private Guna.UI2.WinForms.Guna2Button btnReportes;
        private Guna.UI2.WinForms.Guna2Button btnInventarios;
        private Guna.UI2.WinForms.Guna2Button btnCompras;
        private Guna.UI2.WinForms.Guna2Button btnPagos;
        private Guna.UI2.WinForms.Guna2Button btnConsumidores;
        private Guna.UI2.WinForms.Guna2Button btnDashboard;
        private Guna.UI2.WinForms.Guna2PictureBox pbLogo;
        private Guna.UI2.WinForms.Guna2Button btnAjustes;
        private Guna.UI2.WinForms.Guna2Panel pnlPadre;
    }
}

