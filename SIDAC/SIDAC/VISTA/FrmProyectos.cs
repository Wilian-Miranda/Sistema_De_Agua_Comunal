using SIDAC.DAO;
using SIDAC.MODELO;
using SIDAC.VALIDACIONES;
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
        VsFrmProyectos ClsValidacion = new VsFrmProyectos();
        private void FrmProyectos_Load(object sender, EventArgs e)
        {
            clsD_Proyectos.MostrarProyectos(this.dtgProyectos);
            clsD_Proyectos.Ryears_Proyectos(this.cbFiltroYear);
        }
        #region CRUD
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (ValidarCajas())
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


                if (Convert.ToDateTime(txtFechaInicio.Text) >= Convert.ToDateTime(txtFechaFinalizado.Text))
                {
                    MessageBox.Show("La fecha de finalizacion del proyecto, no debe ser menor o igual a la fecha de inicio.");
                }
                else
                {
                    clsD_Proyectos.InsertarProyecto(proyecto);
                    clsD_Proyectos.MostrarProyectos(this.dtgProyectos);

                    clsD_Proyectos.Ryears_Proyectos(this.cbFiltroYear);

                    Limpiar();
                    LimpiarInstancia();
                }
            }

        }

        //actualizar
        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (ValidarCajas())
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

                if (Convert.ToDateTime(txtFechaInicio.Text) >= Convert.ToDateTime(txtFechaFinalizado.Text))
                {
                    MessageBox.Show("La fecha de finalizacion del proyecto, \n no debe ser menor o igual a la fecha de inicio.");
                }
                else
                {
                    clsD_Proyectos.ActualizarProyecto(proyecto);
                    clsD_Proyectos.MostrarProyectos(this.dtgProyectos);

                    clsD_Proyectos.Ryears_Proyectos(this.cbFiltroYear);

                    Limpiar();
                    LimpiarInstancia();
                }

            }

        }

        //eliminar
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            clsD_Proyectos.EliminarProyecto(Convert.ToInt32(txtID.Text));
            clsD_Proyectos.MostrarProyectos(this.dtgProyectos);

            clsD_Proyectos.Ryears_Proyectos(this.cbFiltroYear);

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
                cbFiltroYear.Visible = true;

                pnlControlesDeFiltros.Width = 150;
            }
            else if (pnlControlesDeFiltros.Width == 150)
            {
                pnlControlesDeFiltros.Width = 33;

                cbFiltroYear.Visible = false;

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

                accion = "Modificar";

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
            txtPresupuesto.Text = "0.0";
            txtCosto.Text = "0.00";
            txtCostoMateriales.Text = "0.00"; ;
            txtDiasTrabajo.Text = "0";
            txtNumTrabajadores.Text = "0";
            txtPagoTrabajadores.Text = "0.00"; ;
            txtFechaInicio.Text = DateTime.Today.ToString();
            txtFechaFinalizado.Text = DateTime.Today.ToString();
            txtDescripcion.Clear();

            btnAgregar.Enabled = true;
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;

            accion = "Agregar";
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

        #region FILTRO POR AÑOS
        private void cbFiltroYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFiltroYear.SelectedIndex >= 0)
            {
                clsD_Proyectos.MostrarProyectos_Year(cbFiltroYear.Text, this.dtgProyectos);
            }
        }

        //para mostrar de nuevo todos los proyectos al dar click en la caja, cuando se hallan filtrado por años
        private void cbFiltroYear_MouseClick(object sender, MouseEventArgs e)
        {
            clsD_Proyectos.MostrarProyectos(this.dtgProyectos);

        }
        #endregion

        #region VALIDACION CAJAS VACIAS
        private Boolean ValidarCajas()
        {
            Boolean validacion = true;
            Validacion.SetError(txtNombre, "");
            Validacion.SetError(txtPresupuesto, "");

            if (txtNombre.Text == "")
            {
                Validacion.SetError(txtNombre, "Este valor es obligatorio.");
                validacion = false;
            }
            if (txtPresupuesto.Text=="")
            {
                Validacion.SetError(txtPresupuesto, "Este valor es obligatorio.");
                validacion = false;
            }

            return validacion;
        }

        #endregion

        #region VALIDACION DE NUMEROS EN LAS CAJAS

        static String accion = "Agregar";
        

        //se evalua cada tecla presionada para permitir solo numeros
        //si es entero se bloquea el punto
        private void txtPresupuesto_KeyPress(object sender, KeyPressEventArgs e)
        {
           ClsValidacion.SoloNumeros(e, "Decimal");
        }

        //se verifica en la caja que el tipo de dato tenga la estructura correcta, si no se bloquea la opcion
        //de agregar y/o eliminar
        private void txtPresupuesto_TextChanged(object sender, EventArgs e)
        {
            if (accion.Equals("Agregar"))
            {
                ClsValidacion.ValidarNumEnCajas(txtPresupuesto, "Decimal", accion, this.btnAgregar);
            }
            else
            {
                ClsValidacion.ValidarNumEnCajas(txtPresupuesto, "Decimal", accion, this.btnModificar);
            }
        }

        //caja costo
        private void txtCosto_KeyPress(object sender, KeyPressEventArgs e)
        {
            ClsValidacion.SoloNumeros(e, "Decimal");
        }

        private void txtCosto_TextChanged(object sender, EventArgs e)
        {
            if (accion.Equals("Agregar"))
            {
                ClsValidacion.ValidarNumEnCajas(txtCosto, "Decimal", accion, this.btnAgregar);
            }
            else
            {
                ClsValidacion.ValidarNumEnCajas(txtCosto, "Decimal", accion, this.btnModificar);
            }
        }

        //caja dias de trabajo
        private void txtDiasTrabajo_KeyPress(object sender, KeyPressEventArgs e)
        {
            ClsValidacion.SoloNumeros(e, "Entero");
        }

        private void txtDiasTrabajo_TextChanged(object sender, EventArgs e)
        {
            if (accion.Equals("Agregar"))
            {
                ClsValidacion.ValidarNumEnCajas(txtDiasTrabajo, "Entero", accion, this.btnAgregar);
            }
            else
            {
                ClsValidacion.ValidarNumEnCajas(txtDiasTrabajo, "Entero", accion, this.btnModificar);
            }
        }

        //caja pago a trbajadores
        private void txtPagoTrabajadores_KeyPress(object sender, KeyPressEventArgs e)
        {
            ClsValidacion.SoloNumeros(e, "Decimal");
        }

        private void txtPagoTrabajadores_TextChanged(object sender, EventArgs e)
        {
            if (accion.Equals("Agregar"))
            {
                ClsValidacion.ValidarNumEnCajas(txtPagoTrabajadores, "Decimal", accion, this.btnAgregar);
            }
            else
            {
                ClsValidacion.ValidarNumEnCajas(txtPagoTrabajadores, "Decimal", accion, this.btnModificar);
            }
        }

        //caja numero de trabajadores
        private void txtNumTrabajadores_KeyPress(object sender, KeyPressEventArgs e)
        {
            ClsValidacion.SoloNumeros(e, "Entero");
        }

        private void txtNumTrabajadores_TextChanged(object sender, EventArgs e)
        {
            if (accion.Equals("Agregar"))
            {
                ClsValidacion.ValidarNumEnCajas(txtNumTrabajadores, "Entero", accion, this.btnAgregar);
            }
            else
            {
                ClsValidacion.ValidarNumEnCajas(txtNumTrabajadores, "Entero", accion, this.btnModificar);
            }
        }
        #endregion


    }
}
