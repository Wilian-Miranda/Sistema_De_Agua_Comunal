
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHome));
            this.pnlEncabezado = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlControlesWindow = new System.Windows.Forms.Panel();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnMaximizar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.pnlMenu = new Guna.UI2.WinForms.Guna2Panel();
            this.btnAjustes = new Guna.UI2.WinForms.Guna2Button();
            this.btnInventarios = new Guna.UI2.WinForms.Guna2Button();
            this.btnCompras = new Guna.UI2.WinForms.Guna2Button();
            this.btnPagos = new Guna.UI2.WinForms.Guna2Button();
            this.btnConsumidores = new Guna.UI2.WinForms.Guna2Button();
            this.btnDashboard = new Guna.UI2.WinForms.Guna2Button();
            this.pbLogo = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pnlPadre = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlEncabezado.SuspendLayout();
            this.pnlControlesWindow.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlEncabezado
            // 
            this.pnlEncabezado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(108)))), ((int)(((byte)(212)))));
            this.pnlEncabezado.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.pnlEncabezado.Controls.Add(this.pnlControlesWindow);
            this.pnlEncabezado.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEncabezado.ForeColor = System.Drawing.Color.Black;
            this.pnlEncabezado.Location = new System.Drawing.Point(0, 0);
            this.pnlEncabezado.Name = "pnlEncabezado";
            this.pnlEncabezado.ShadowDecoration.Parent = this.pnlEncabezado;
            this.pnlEncabezado.Size = new System.Drawing.Size(1200, 30);
            this.pnlEncabezado.TabIndex = 0;
            // 
            // pnlControlesWindow
            // 
            this.pnlControlesWindow.Controls.Add(this.btnMinimizar);
            this.pnlControlesWindow.Controls.Add(this.btnMaximizar);
            this.pnlControlesWindow.Controls.Add(this.btnCerrar);
            this.pnlControlesWindow.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlControlesWindow.Location = new System.Drawing.Point(1055, 0);
            this.pnlControlesWindow.Name = "pnlControlesWindow";
            this.pnlControlesWindow.Padding = new System.Windows.Forms.Padding(3);
            this.pnlControlesWindow.Size = new System.Drawing.Size(145, 30);
            this.pnlControlesWindow.TabIndex = 0;
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(108)))), ((int)(((byte)(212)))));
            this.btnMinimizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.BackgroundImage")));
            this.btnMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMinimizar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Location = new System.Drawing.Point(55, 3);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Padding = new System.Windows.Forms.Padding(2);
            this.btnMinimizar.Size = new System.Drawing.Size(29, 24);
            this.btnMinimizar.TabIndex = 2;
            this.btnMinimizar.UseVisualStyleBackColor = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(108)))), ((int)(((byte)(212)))));
            this.btnMaximizar.BackgroundImage = global::SIDAC.Properties.Resources.expandir;
            this.btnMaximizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMaximizar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMaximizar.FlatAppearance.BorderSize = 0;
            this.btnMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximizar.Location = new System.Drawing.Point(84, 3);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Padding = new System.Windows.Forms.Padding(2);
            this.btnMaximizar.Size = new System.Drawing.Size(29, 24);
            this.btnMaximizar.TabIndex = 1;
            this.btnMaximizar.UseVisualStyleBackColor = false;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(108)))), ((int)(((byte)(212)))));
            this.btnCerrar.BackgroundImage = global::SIDAC.Properties.Resources.cerrar;
            this.btnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCerrar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Location = new System.Drawing.Point(113, 3);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Padding = new System.Windows.Forms.Padding(2);
            this.btnCerrar.Size = new System.Drawing.Size(29, 24);
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlMenu.Controls.Add(this.btnAjustes);
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
            this.btnAjustes.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnAjustes.BorderRadius = 3;
            this.btnAjustes.BorderThickness = 3;
            this.btnAjustes.CheckedState.Parent = this.btnAjustes;
            this.btnAjustes.CustomImages.Parent = this.btnAjustes;
            this.btnAjustes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnAjustes.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(108)))), ((int)(((byte)(212)))));
            this.btnAjustes.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjustes.ForeColor = System.Drawing.Color.White;
            this.btnAjustes.HoverState.Parent = this.btnAjustes;
            this.btnAjustes.Image = global::SIDAC.Properties.Resources.ajustes;
            this.btnAjustes.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAjustes.Location = new System.Drawing.Point(0, 570);
            this.btnAjustes.Name = "btnAjustes";
            this.btnAjustes.ShadowDecoration.Parent = this.btnAjustes;
            this.btnAjustes.Size = new System.Drawing.Size(200, 50);
            this.btnAjustes.TabIndex = 8;
            this.btnAjustes.Text = "Ajustes";
            // 
            // btnInventarios
            // 
            this.btnInventarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnInventarios.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnInventarios.BorderRadius = 3;
            this.btnInventarios.BorderThickness = 3;
            this.btnInventarios.CheckedState.FillColor = System.Drawing.Color.Magenta;
            this.btnInventarios.CheckedState.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventarios.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnInventarios.CheckedState.Parent = this.btnInventarios;
            this.btnInventarios.CustomImages.Parent = this.btnInventarios;
            this.btnInventarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInventarios.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(108)))), ((int)(((byte)(212)))));
            this.btnInventarios.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventarios.ForeColor = System.Drawing.Color.White;
            this.btnInventarios.HoverState.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventarios.HoverState.Parent = this.btnInventarios;
            this.btnInventarios.Image = global::SIDAC.Properties.Resources.inventario;
            this.btnInventarios.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnInventarios.Location = new System.Drawing.Point(0, 400);
            this.btnInventarios.Name = "btnInventarios";
            this.btnInventarios.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnInventarios.ShadowDecoration.Parent = this.btnInventarios;
            this.btnInventarios.Size = new System.Drawing.Size(200, 50);
            this.btnInventarios.TabIndex = 6;
            this.btnInventarios.Text = "Inventarios";
            this.btnInventarios.Click += new System.EventHandler(this.btnInventarios_Click);
            // 
            // btnCompras
            // 
            this.btnCompras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnCompras.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnCompras.BorderRadius = 3;
            this.btnCompras.BorderThickness = 3;
            this.btnCompras.CheckedState.FillColor = System.Drawing.Color.Magenta;
            this.btnCompras.CheckedState.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompras.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnCompras.CheckedState.Parent = this.btnCompras;
            this.btnCompras.CustomImages.Parent = this.btnCompras;
            this.btnCompras.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCompras.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(108)))), ((int)(((byte)(212)))));
            this.btnCompras.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompras.ForeColor = System.Drawing.Color.White;
            this.btnCompras.HoverState.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompras.HoverState.Parent = this.btnCompras;
            this.btnCompras.Image = global::SIDAC.Properties.Resources.compras;
            this.btnCompras.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCompras.Location = new System.Drawing.Point(0, 350);
            this.btnCompras.Name = "btnCompras";
            this.btnCompras.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnCompras.ShadowDecoration.Parent = this.btnCompras;
            this.btnCompras.Size = new System.Drawing.Size(200, 50);
            this.btnCompras.TabIndex = 5;
            this.btnCompras.Text = "Compras";
            this.btnCompras.Click += new System.EventHandler(this.btnCompras_Click);
            // 
            // btnPagos
            // 
            this.btnPagos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnPagos.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnPagos.BorderRadius = 3;
            this.btnPagos.BorderThickness = 3;
            this.btnPagos.CheckedState.FillColor = System.Drawing.Color.Magenta;
            this.btnPagos.CheckedState.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagos.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnPagos.CheckedState.Parent = this.btnPagos;
            this.btnPagos.CustomImages.Parent = this.btnPagos;
            this.btnPagos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPagos.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(108)))), ((int)(((byte)(212)))));
            this.btnPagos.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagos.ForeColor = System.Drawing.Color.White;
            this.btnPagos.HoverState.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagos.HoverState.Parent = this.btnPagos;
            this.btnPagos.Image = global::SIDAC.Properties.Resources.pago_en_efectivo;
            this.btnPagos.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnPagos.Location = new System.Drawing.Point(0, 300);
            this.btnPagos.Name = "btnPagos";
            this.btnPagos.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnPagos.ShadowDecoration.Parent = this.btnPagos;
            this.btnPagos.Size = new System.Drawing.Size(200, 50);
            this.btnPagos.TabIndex = 4;
            this.btnPagos.Text = "Pagos";
            this.btnPagos.Click += new System.EventHandler(this.btnPagos_Click);
            // 
            // btnConsumidores
            // 
            this.btnConsumidores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnConsumidores.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnConsumidores.BorderRadius = 3;
            this.btnConsumidores.BorderThickness = 3;
            this.btnConsumidores.CheckedState.FillColor = System.Drawing.Color.Magenta;
            this.btnConsumidores.CheckedState.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsumidores.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnConsumidores.CheckedState.Parent = this.btnConsumidores;
            this.btnConsumidores.CustomImages.Parent = this.btnConsumidores;
            this.btnConsumidores.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConsumidores.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(108)))), ((int)(((byte)(212)))));
            this.btnConsumidores.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsumidores.ForeColor = System.Drawing.Color.White;
            this.btnConsumidores.HoverState.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsumidores.HoverState.Parent = this.btnConsumidores;
            this.btnConsumidores.Image = global::SIDAC.Properties.Resources.cliente;
            this.btnConsumidores.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnConsumidores.Location = new System.Drawing.Point(0, 250);
            this.btnConsumidores.Name = "btnConsumidores";
            this.btnConsumidores.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnConsumidores.ShadowDecoration.Parent = this.btnConsumidores;
            this.btnConsumidores.Size = new System.Drawing.Size(200, 50);
            this.btnConsumidores.TabIndex = 3;
            this.btnConsumidores.Text = "Consumidores";
            this.btnConsumidores.Click += new System.EventHandler(this.btnConsumidores_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnDashboard.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnDashboard.BorderRadius = 3;
            this.btnDashboard.BorderThickness = 3;
            this.btnDashboard.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnDashboard.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnDashboard.CheckedState.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnDashboard.CheckedState.Parent = this.btnDashboard;
            this.btnDashboard.CustomImages.Parent = this.btnDashboard;
            this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboard.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(108)))), ((int)(((byte)(212)))));
            this.btnDashboard.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.HoverState.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.HoverState.Parent = this.btnDashboard;
            this.btnDashboard.Image = global::SIDAC.Properties.Resources.dashboard;
            this.btnDashboard.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDashboard.Location = new System.Drawing.Point(0, 200);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnDashboard.ShadowDecoration.Parent = this.btnDashboard;
            this.btnDashboard.Size = new System.Drawing.Size(200, 50);
            this.btnDashboard.TabIndex = 2;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // pbLogo
            // 
            this.pbLogo.BackColor = System.Drawing.Color.WhiteSmoke;
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
            this.pnlPadre.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.pnlPadre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPadre.FillColor = System.Drawing.Color.WhiteSmoke;
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
            this.BackColor = System.Drawing.Color.Gainsboro;
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
            this.pnlEncabezado.ResumeLayout(false);
            this.pnlControlesWindow.ResumeLayout(false);
            this.pnlMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlEncabezado;
        private Guna.UI2.WinForms.Guna2Panel pnlMenu;
        private Guna.UI2.WinForms.Guna2Button btnInventarios;
        private Guna.UI2.WinForms.Guna2Button btnCompras;
        private Guna.UI2.WinForms.Guna2Button btnPagos;
        private Guna.UI2.WinForms.Guna2Button btnConsumidores;
        private Guna.UI2.WinForms.Guna2Button btnDashboard;
        private Guna.UI2.WinForms.Guna2PictureBox pbLogo;
        private Guna.UI2.WinForms.Guna2Button btnAjustes;
        private Guna.UI2.WinForms.Guna2Panel pnlPadre;
        private System.Windows.Forms.Panel pnlControlesWindow;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnMaximizar;
        private System.Windows.Forms.Button btnCerrar;
    }
}

