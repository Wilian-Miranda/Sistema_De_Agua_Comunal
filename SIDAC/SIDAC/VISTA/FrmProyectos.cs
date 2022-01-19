using SIDAC.DAO;
using SIDAC.MODELO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIDAC.VISTA
{
    public partial class FrmProyectos : Form
    {
        public FrmProyectos()
        {
            InitializeComponent();
            txtFechaInicio.Text = DateTime.Today.ToString();
            txtFechaFinalizado.Text = DateTime.Today.ToString();
        }

        //instancias unicas a utilizar
        CDProyectos clsD_Proyectos = new CDProyectos();
        Proyectos proyecto = new Proyectos();
        private void FrmProyectos_Load(object sender, EventArgs e)
        {
            clsD_Proyectos.MostrarProyectos(this.dtgProyectos);
        }
        #region CRUD
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            proyecto.nombre = txtNombre.Text;
            proyecto.presupuesto = Convert.ToDecimal(txtPresupuesto.Text);
            proyecto.costo = Convert.ToDecimal(txtCosto.Text);
            proyecto.costoMateriales = 0;
            proyecto.diasTrabajo = Convert.ToInt32(txtDiasTrabajo.Text);
            proyecto.numeroTrabajadores = Convert.ToInt32(txtNumTrabajadores.Text);
            proyecto.pagoTotalTrabajadores = Convert.ToDecimal(txtPagoTrabajadores.Text);
            proyecto.fechaInicio = Convert.ToDateTime(txtFechaInicio.Text);
            proyecto.fechaFinalizado = Convert.ToDateTime(txtFechaFinalizado.Text);
            proyecto.descripcion = txtDescripcion.Text;

            clsD_Proyectos.InsertarProyecto(proyecto);
            clsD_Proyectos.MostrarProyectos(this.dtgProyectos);
            Limpiar();
            LimpiarInstancia();
        }

        //actualizar
        private void btnModificar_Click(object sender, EventArgs e)
        {
            proyecto.idProyecto = Convert.ToInt32(txtID.Text);
            proyecto.nombre = txtNombre.Text;
            proyecto.presupuesto = Convert.ToDecimal(txtPresupuesto.Text);
            proyecto.costo = Convert.ToDecimal(txtCosto.Text);
            proyecto.costoMateriales = 0;
            proyecto.diasTrabajo = Convert.ToInt32(txtDiasTrabajo.Text);
            proyecto.numeroTrabajadores = Convert.ToInt32(txtNumTrabajadores.Text);
            proyecto.pagoTotalTrabajadores = Convert.ToDecimal(txtPagoTrabajadores.Text);
            proyecto.fechaInicio = Convert.ToDateTime(txtFechaInicio.Text);
            proyecto.fechaFinalizado = Convert.ToDateTime(txtFechaFinalizado.Text);
            proyecto.descripcion = txtDescripcion.Text;

            clsD_Proyectos.ActualizarProyecto(proyecto);
            clsD_Proyectos.MostrarProyectos(this.dtgProyectos);
            Limpiar();
            LimpiarInstancia();
        }

        //eliminar
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            clsD_Proyectos.EliminarProyecto(Convert.ToInt32(txtID.Text));
            clsD_Proyectos.MostrarProyectos(this.dtgProyectos);
            Limpiar();
        }
        #endregion

        #region Abrir-Cerrar Paneles
        private void btnAbrirVentanaProyectos_Click(object sender, EventArgs e)
        {
            if (pnlDetallesProyecto.Width == 400)
            {
                pnlDetallesProyecto.Width = 10;
                pnlDetallesProyecto.Visible = false;
            }
            else
            {
                pnlDetallesProyecto.Width = 400;
                pnlDetallesProyecto.Visible = true;
            }
        }

        private void btnMostrarControlesFiltros_Click(object sender, EventArgs e)
        {
            if (pnlControlesDeFiltros.Width == 33)
            {
                cbFiltroPrincipal.Visible = true;
                cbYears.Visible = true;
                cbMes.Visible = true;

                pnlControlesDeFiltros.Width = 360;
            }
            else if (pnlControlesDeFiltros.Width == 360)
            {
                pnlControlesDeFiltros.Width = 33;

                cbFiltroPrincipal.Visible = false;
                cbYears.Visible = false;
                cbMes.Visible = false;

            }
        }

        #endregion

        #region RELLENAR DATOS DE LAS CAJAS

        private void dtgProyectos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgProyectos.SelectedRows.Count > 0)
            {
                txtID.Text = dtgProyectos.CurrentRow.Cells[0].Value.ToString();
                txtNombre.Text = dtgProyectos.CurrentRow.Cells[1].Value.ToString();
                txtPresupuesto.Text = dtgProyectos.CurrentRow.Cells[2].Value.ToString();
                txtCosto.Text = dtgProyectos.CurrentRow.Cells[3].Value.ToString();
                txtCostoMateriales.Text = dtgProyectos.CurrentRow.Cells[4].Value.ToString();
                txtDiasTrabajo.Text = dtgProyectos.CurrentRow.Cells[5].Value.ToString();
                txtNumTrabajadores.Text = dtgProyectos.CurrentRow.Cells[6].Value.ToString();
                txtPagoTrabajadores.Text = dtgProyectos.CurrentRow.Cells[7].Value.ToString();
                txtFechaInicio.Text = dtgProyectos.CurrentRow.Cells[8].Value.ToString();
                txtFechaFinalizado.Text = dtgProyectos.CurrentRow.Cells[9].Value.ToString();
                txtDescripcion.Text = dtgProyectos.CurrentRow.Cells[10].Value.ToString();

                btnAgregar.Enabled = false;
                btnModificar.Enabled = true;
                btnEliminar.Enabled = true;

                if (pnlDetallesProyecto.Width==10)
                {
                    btnAbrirVentana.PerformClick();
                }


            }
        }
        #endregion

        #region OTROS
        private void pnlEncabezadoProyecto_DoubleClick(object sender, EventArgs e)
        {
            Limpiar();
        }
        private void Limpiar()
        {
            txtID.Clear();
            txtNombre.Clear();
            txtPresupuesto.Clear();
            txtCosto.Clear();
            txtCostoMateriales.Clear();
            txtDiasTrabajo.Clear();
            txtNumTrabajadores.Clear();
            txtPagoTrabajadores.Clear();
            txtFechaInicio.ResetText();
            txtFechaFinalizado.ResetText();
            txtDescripcion.Clear();

            btnAgregar.Enabled = true;
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
        }
        private void LimpiarInstancia()
        {
            proyecto.idProyecto = 0;
            proyecto.nombre = "";
            proyecto.presupuesto = 0;
            proyecto.costo = 0;
            proyecto.costoMateriales = 0;
            proyecto.diasTrabajo = 0;
            proyecto.numeroTrabajadores = 0;
            proyecto.pagoTotalTrabajadores = 0;
            proyecto.fechaInicio = DateTime.Today;
            proyecto.fechaFinalizado = DateTime.Today;
            proyecto.descripcion = "";
        }



        #endregion

    }
}
