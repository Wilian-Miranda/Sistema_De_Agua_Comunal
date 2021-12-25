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

        private Form currentFrmConsumidores;
        private Form currentFrmPagos = null;
        private Form currentFrmCompras = null;
        private Form currentFrmInventarios = null;
        private Form currentFrmReportes = null;

        private void btnDashboard_Click(object sender, EventArgs e)
        {

        }

        private void btnConsumidores_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanelPadre(new FrmConsumidores(), currentFrmConsumidores);
            //if (currentFrmConsumidores != null)
            //{
            //    currentFrmConsumidores.Close();
            //    currentFrmConsumidores = null;
            //}

            ////formulario = panelPadre.Controls.OfType<Miform>().FirstOrDefault();

            //else if (currentFrmConsumidores == null)
            //{
            //    //formulario = new Miform();
            //    currentFrmConsumidores = new FrmConsumidores();
            //    currentFrmConsumidores.TopLevel = false;
            //    currentFrmConsumidores.Dock = DockStyle.Fill;
            //    pnlPadre.Controls.Add(currentFrmConsumidores);
            //    pnlPadre.Tag = currentFrmConsumidores;
            //    currentFrmConsumidores.Show();
            //    currentFrmConsumidores.BringToFront();
            //}
        }

        private void AbrirFormularioEnPanelPadre(Form ObjetoFormulario, Form CurrentVariable)
        {
            if (CurrentVariable != null)
            {
                CurrentVariable = null;
                CurrentVariable.Close();
                
            }

            //formulario = panelPadre.Controls.OfType<Miform>().FirstOrDefault();

            else if (CurrentVariable == null)
            {
                //formulario = new Miform();
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
            AbrirFormularioEnPanelPadre(new FrmControlPagos(), currentFrmPagos);
        }

        private void btnCompras_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanelPadre(new FrmCompras(), currentFrmCompras);
        }

        private void btnInventarios_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanelPadre(new FrmInventario(), currentFrmInventarios);
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {

        }
    }
}
