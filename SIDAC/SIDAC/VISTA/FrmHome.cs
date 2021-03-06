using SIDAC.VISTA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIDAC
{
    public partial class FrmHome : Form
    {
        public FrmHome()
        {
            InitializeComponent();
        }

        private Form currentFrm = null;

        private void btnDashboard_Click(object sender, EventArgs e)
        {

        }

        private void btnConsumidores_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanelPadre(new FrmConsumidores(), currentFrm);

        }

        private void AbrirFormularioEnPanelPadre(Form ObjetoFormulario, Form CurrentVariable)
        {
            //Form formulario = pnlPadre.Controls.OfType<Form>().FirstOrDefault();
            //CurrentVariable = formulario;
            if (pnlPadre.Controls != null)
            {
                pnlPadre.Controls.Clear();
                CurrentVariable = null;
            }

            if (CurrentVariable == null)
            {
                CurrentVariable = ObjetoFormulario;
                CurrentVariable.TopLevel = false; 
                CurrentVariable.Dock = DockStyle.Fill;
                pnlPadre.Controls.Add(CurrentVariable);
                pnlPadre.Tag = CurrentVariable;
                CurrentVariable.Show();
                CurrentVariable.BringToFront();
            }

        }

        private void btnPagos_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanelPadre(new FrmControlPagos(), currentFrm);
        }

        private void btnCompras_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanelPadre(new FrmCompras(), currentFrm);
        }

        private void btnInventarios_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanelPadre(new FrmInventario(), currentFrm);
        }


        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
            }
            else
            {
                WindowState = FormWindowState.Maximized;
            }
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Minimized;
            }
        }

        int posicionX = 0;
        int posicionY = 0;
        private void pnlEncabezado_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                posicionX = e.X;
                posicionY = e.Y;
            }
            else
            {
                Left +=(e.X - posicionX);
                Top +=(e.Y - posicionY);
            }
        }
    }
}
