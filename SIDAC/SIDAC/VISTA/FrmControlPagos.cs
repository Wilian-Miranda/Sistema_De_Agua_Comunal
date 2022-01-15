using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SIDAC.DAO;
using SIDAC.MODELO;

namespace SIDAC.VISTA
{
    public partial class FrmControlPagos : Form
    {
        public FrmControlPagos()
        {
            InitializeComponent();
            txtFecha.Text = DateTime.Now.ToString();
            //CargarDatosCBYear("Pendiente");
            CargarDatosFiltroPrincipal();
        }
        
        private void CargarDatosFiltroPrincipal()
        {
            cbFiltroPrincipal.Items.Add("Pendiente");
            cbFiltroPrincipal.Items.Add("Cancelado");
            cbFiltroPrincipal.Items.Add("Con Retraso");

            cbFiltroPrincipal.SelectedIndex = 0;

        }

        private void CargarEstados()
        {
            using (SIDACEntities db = new SIDACEntities())
            {
                var consulta = (from a in db.Estados
                                where a.identificador == 1
                                select a).ToList();

                cbEstado.DataSource = consulta.ToList();
                cbEstado.DisplayMember = "nombre";
                cbEstado.ValueMember = "idEstado";
            }
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (pnlNuevoPago.Width == 400)
            {
                pnlNuevoPago.Width = 10;
                pnlNuevoPago.Visible = false;
            }
            else
            {
                pnlNuevoPago.Width = 400;
                pnlNuevoPago.Visible = true;
            }
        }

        private void FrmControlPagos_Load(object sender, EventArgs e)
        {
            MostrarPagos(cbFiltroPrincipal.Text);
            CargarEstados();
        }

        #region CRUD PAGOS
        public void MostrarPagos(string estado)
        {
            CDControlPagos pago = new CDControlPagos();

            using (SIDACEntities db = new SIDACEntities())
            {
                var pagos = (from t in db.sp_MostrarPagos()
                             where t.estado == estado
                             select t).ToList();


                dtgPagos.Rows.Clear();
                foreach (var i in pagos)
                {
                    dtgPagos.Rows.Add(i.idPago, i.nombre, i.mes, i.montoBase, i.montoCancelado,
                                        i.montoPendiente, i.mora, i.descripcion, i.estado, i.fecha);
                }
            }
  
        }
        CDControlPagos pago = new CDControlPagos();
        //AGREGAR
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Pagos pago1 = new Pagos();
            pago1.montoBase = Convert.ToDecimal(txtMontoBase.Text);
            pago1.montoCancelado = Convert.ToDecimal(txtCancelado.Text);
            pago1.descripcion = txtDescripcion.Text;
            pago1.mora = Convert.ToDecimal(txtMora.Text);
            pago1.fecha = Convert.ToDateTime(txtFecha.Text);
            pago1.FK_estado = Convert.ToInt32(cbEstado.SelectedValue.ToString());
            pago1.FK_consumidor = Convert.ToInt32(txtID.Text);

            pago.RegistrarPago(pago1);

            if (cbConsumidor.Enabled == true)
            {
                btnFiltrar.PerformClick();
                cbYear.SelectedIndex = 0;
            }
            else
            {
                MostrarPagos(cbFiltroPrincipal.Text);
            }

            Limpiar();
        }
        //modificar
        private void btnModificar_Click(object sender, EventArgs e)
        {
            Pagos pago1 = new Pagos();
            pago1.montoCancelado = Convert.ToDecimal(txtCancelado.Text);
            pago1.descripcion = txtDescripcion.Text;
            pago1.mora = Convert.ToDecimal(txtMora.Text);
            pago1.FK_estado = Convert.ToInt32(cbEstado.SelectedValue.ToString());
            pago1.idPago = Convert.ToInt32(txtIdPago.Text);

            pago.ActualizarPago(pago1);

            if (cbConsumidor.Enabled == true)
            {
                btnFiltrar.PerformClick();
                cbYear.SelectedIndex = 0;
            }
            else
            {
                MostrarPagos(cbFiltroPrincipal.Text);
            }

            Limpiar();
        }
        //eliminar
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            pago.EliminarPago(Convert.ToInt32(txtIdPago.Text));

            if (cbConsumidor.Enabled==true)
            {
                btnFiltrar.PerformClick();
                cbYear.SelectedIndex = 0;
            }
            else
            {
                MostrarPagos(cbFiltroPrincipal.Text);
            }

            Limpiar();

        }
        #endregion

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            BuscarConsumidor(cbConsumidor.Text);
        }
        private void BuscarConsumidor(String nombre)
        {
            using (SIDACEntities db = new SIDACEntities())
            {
                var consulta = (from a in db.Consumidores
                                where a.nombres.ToLower().Contains(nombre)
                                      || a.apellidos.ToLower().Contains(nombre)
                                      || (a.nombres + " " + a.apellidos).Contains(nombre)
                                select new
                                {
                                    a.idConsumidor,
                                    nombreCompleto = a.nombres + " " + a.apellidos
                                }
                                 ).ToList();

                cbConsumidor.DataSource = consulta.ToList();
                cbConsumidor.DisplayMember = "nombreCompleto";
                cbConsumidor.ValueMember = "idConsumidor";
            }

        }

        private void cbConsumidor_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarConsumidorBuscado();
        }

        private void CargarConsumidorBuscado()
        {
            if (cbConsumidor.SelectedValue != null)
            {
                String id = cbConsumidor.SelectedValue.ToString();
                using (SIDACEntities db = new SIDACEntities())
                {
                    var consulta = (from a in db.Consumidores
                                    where a.idConsumidor.ToString() == id
                                    select a).ToList();

                    foreach (var i in consulta)
                    {
                        txtID.Text = i.idConsumidor.ToString();
                        txtApellidos.Text = i.apellidos;
                        txtNombres.Text = i.nombres;
                    }
                }
            }
        }
        private void txtCancelado_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPendiente.Text = (Convert.ToDecimal(txtMontoBase.Text) - Convert.ToDecimal(txtCancelado.Text)).ToString();
            }
        }

        private void dtgPagos_DoubleClick(object sender, EventArgs e)
        {
            if (dtgPagos.SelectedRows.Count > 0)
            {
                cbConsumidor.Text = dtgPagos.CurrentRow.Cells[1].Value.ToString();
                btnBuscar.PerformClick();
                txtIdPago.Text = dtgPagos.CurrentRow.Cells[0].Value.ToString();
                txtMontoBase.Text = dtgPagos.CurrentRow.Cells[3].Value.ToString();
                txtCancelado.Text = dtgPagos.CurrentRow.Cells[4].Value.ToString();
                txtPendiente.Text = dtgPagos.CurrentRow.Cells[5].Value.ToString();
                txtMora.Text = dtgPagos.CurrentRow.Cells[6].Value.ToString();
                txtDescripcion.Text = dtgPagos.CurrentRow.Cells[7].Value.ToString();
                cbEstado.Text = dtgPagos.CurrentRow.Cells[8].Value.ToString();
                txtFecha.Text = dtgPagos.CurrentRow.Cells[9].Value.ToString();

                btnModificar.Enabled = true;
                btnEliminar.Enabled = true;
                btnAgregar.Enabled = false;
                lblIdPago.Visible = true;
                txtIdPago.Visible = true;

                txtMontoBase.Enabled = false;
                txtFecha.Enabled = false;
                cbConsumidor.Enabled = false;
                txtNombres.Enabled = false;
                txtApellidos.Enabled = false;
            }
            

        }

        private void pnlEncabezadoNuevoPago_DoubleClick(object sender, EventArgs e)
        {
            Limpiar();
        }
        private void Limpiar()
        {
            cbConsumidor.ResetText();
            txtID.Clear();
            txtNombres.Clear();
            txtApellidos.Clear();
            txtIdPago.Clear();
            txtMontoBase.Clear();
            txtCancelado.Clear();
            txtPendiente.Clear();
            txtDescripcion.Clear();
            cbEstado.ResetText();
            txtFecha.Text = DateTime.Now.ToString();

            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
            btnAgregar.Enabled = true;
            lblIdPago.Visible = false;
            txtIdPago.Visible = false;

            txtMontoBase.Enabled = true;
            txtFecha.Enabled = true;
            cbConsumidor.Enabled = true;
            txtNombres.Enabled = true;
            txtApellidos.Enabled = true;
        }

        private void btnMostrarControlesFiltros2_Click(object sender, EventArgs e)
        {
            if (pnlControlesDeFiltros2.Width == 33)
            {
                cbConsumidor.Visible = true;
                cbYear.Visible = true;
                txtNombreABuscar.Visible = true;
                btnBuscarConsumidor.Visible = true;
                btnFiltrar.Visible = true;

                //btnMostrarControlesFiltros1.PerformClick();
                cbConsumidor.Enabled = true;
                cbYear.Enabled = true;

                pnlControlesDeFiltros2.Width = 382;
            }
            else if (pnlControlesDeFiltros2.Width == 382)
            {
                pnlControlesDeFiltros2.Width = 33;

                cbConsumidor.Visible = false;
                cbYear.Visible = false;
                txtNombreABuscar.Visible = false;
                btnBuscarConsumidor.Visible = false;
                btnFiltrar.Visible = false;

                cbConsumidor.DataSource = null;
                cbYear.DataSource = null;
                cbConsumidor.ResetText();
                cbYear.ResetText();

                cbConsumidor.Enabled = true;
                cbYear.Enabled = true;

            }

            if (pnlControlesDeFiltros1.Width == 360 || pnlControlesDeFiltros1.Width == 33)
            {
                cbFiltroPrincipal.Visible = false;
                cbYears.Visible = false;
                cbMes.Visible = false;

                pnlControlesDeFiltros1.Width = 33;
            }
        }

        private void btnBuscarConsumidor_Click(object sender, EventArgs e)
        {
            if (txtNombreABuscar.Text != "")
            {
                using (SIDACEntities db = new SIDACEntities())
                {
                    var personas = (from t in db.Consumidores
                                    where (t.nombres + " " + t.apellidos).ToLower().Contains(txtNombreABuscar.Text.ToLower())
                                    select new
                                    {
                                        t.idConsumidor,
                                        nombre = t.nombres + " " + t.apellidos
                                    }).ToList();

                    txtNombreABuscar.DataSource = personas;
                    txtNombreABuscar.DisplayMember = "nombre";
                    txtNombreABuscar.ValueMember = "idConsumidor";

                    txtNombreABuscar.SelectedIndex = -1;
                }
            }
        }

        private void txtNombreABuscar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtNombreABuscar.SelectedValue != null)
            {
                cbYear.DataSource = null;
            }
        }

        private void txtNombreABuscar_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            int idconsumidor = 0;
            if (txtNombreABuscar.SelectedValue != null)
            {
                int id = Convert.ToInt32(txtNombreABuscar.SelectedValue.ToString());
                //idconsumidor = Convert.ToInt32(id);
                idconsumidor = id;
            }
            //MessageBox.Show(txtNombreABuscar.SelectedValue.ToString() + cbYear.Text);
            if (txtNombreABuscar.Text != "" && txtNombreABuscar.SelectedIndex != -1)
            {
                using (SIDACEntities db = new SIDACEntities())
                {
                    var pagos = db.sp_MostrarPagoPorId(idconsumidor).ToList();

                    dtgPagos.Rows.Clear();
                    foreach (var i in pagos)
                    {
                        dtgPagos.Rows.Add(i.idPago, i.nombre, i.mes, i.montoBase, i.montoCancelado, i.montoPendiente, i.mora, i.descripcion, i.estado, i.fecha);
                    }



                }
            }
            if (txtNombreABuscar.Text != "" && txtNombreABuscar.SelectedValue != null)
            {
                using (SIDACEntities db = new SIDACEntities())
                {
                    var YearPagos = db.sp_MostrarYearsPorPagosPorId(idconsumidor).ToList();

                    if (YearPagos.Count > 0)
                    {
                        cbYear.DataSource = YearPagos;
                        cbYear.DisplayMember = "year";

                        cbYear.SelectedIndex = -1;
                        //cbYear.ValueMember = "idPago";
                    }
                }
            }

        }

        private void cbYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbYear.SelectedValue!=null && txtNombreABuscar.SelectedValue != null)
            {
                int id = Convert.ToInt32(txtNombreABuscar.SelectedValue.ToString());
                using (SIDACEntities db = new SIDACEntities())
                {
                    var pagosFiltradosPorYear = db.sp_MostrarPagoPorYear(id, cbYear.Text);

                    dtgPagos.Rows.Clear();
                    foreach (var i in pagosFiltradosPorYear)
                    {
                        dtgPagos.Rows.Add(i.idPago, i.nombre, i.mes, i.montoBase, i.montoCancelado, i.montoPendiente,i.mora, i.descripcion, i.estado, i.fecha);
                    }
                }
            }
        }

        private void btnMostrarControlesFiltros1_Click(object sender, EventArgs e)
        {
            if (pnlControlesDeFiltros1.Width == 33)
            {
                cbFiltroPrincipal.Visible = true;
                cbYears.Visible = true;
                cbMes.Visible = true;

                pnlControlesDeFiltros1.Width = 360;

                cbConsumidor.Enabled = false;
                cbYear.Enabled = false;
            }
            else if (pnlControlesDeFiltros1.Width == 360)
            {
                pnlControlesDeFiltros1.Width = 33;

                cbFiltroPrincipal.Visible = false;
                cbYears.Visible = false;
                cbMes.Visible = false;

                cbConsumidor.Enabled = false;
                cbYear.Enabled = false;
            }

            if (pnlControlesDeFiltros2.Width == 382 || pnlControlesDeFiltros2.Width == 33)
            {
                cbConsumidor.Visible = false;
                cbYear.Visible = false;
                txtNombreABuscar.Visible = false;
                btnBuscarConsumidor.Visible = false;
                btnFiltrar.Visible = false;

                pnlControlesDeFiltros2.Width = 33;
            }
        }

        private void pnlDatosPagos_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CargarDatosCBYear_Estado(String estado)
        {
            using (SIDACEntities db = new SIDACEntities())
            {
                var years = db.sp_YearsInPagos(estado).ToList();



                if (years.Count > 0)
                {
                    cbYears.DataSource = years;
                    cbYears.DisplayMember = "mes";
                    cbYears.ValueMember = "value";

                    cbYears.SelectedIndex = 0;
                }
                else
                {
                    cbYears.DataSource = null;
                    cbYears.ResetText();
                }


            }
        }
        private void cbYears_SelectedValueChanged(object sender, EventArgs e)
        {


            
        }

        private void cbYears_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbYears.SelectedIndex >= 0 
                && cbFiltroPrincipal.SelectedIndex >= 0)
            {
                int year = Convert.ToInt32(cbYears.Text);
                using (SIDACEntities db = new SIDACEntities())
                {
                        FiltrarPagos_Estado_Year(cbFiltroPrincipal.Text, cbYears.Text);
                    
                    //cargar los datos de los meses que se tienen registros en la db en la combobox

                    var meses =db.sp_MesesInYearsInPagos(year, cbFiltroPrincipal.Text).ToList();

                    cbMes.ResetText();
                    cbMes.DataSource = meses;
                    cbMes.DisplayMember = "mes";
                    cbMes.ValueMember = "valor";

                    cbMes.SelectedIndex = 0;
                }


            }
        }

        private void FiltrarPagos_Estado_Year(String estado, String year)
        {

            using (SIDACEntities db = new SIDACEntities())
            {
                //realizar  busqueda de los pagos pendientes en un año determinado
                var pagos = (from t in db.sp_MostrarPagos()
                             where t.estado == estado && (t.fecha.Year).ToString() == year
                             select t).ToList();


                dtgPagos.Rows.Clear();
                foreach (var i in pagos)
                {
                    dtgPagos.Rows.Add(i.idPago, i.nombre, i.mes, i.montoBase, i.montoCancelado, 
                                        i.montoPendiente, i.mora, i.descripcion, i.estado, i.fecha);
                }
            }


        }

        private void cbFiltroPrincipal_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFiltroPrincipal.SelectedIndex >= 0)
            {
                MostrarPagos(cbFiltroPrincipal.Text);
                CargarDatosCBYear_Estado(cbFiltroPrincipal.Text);

                cbMes.SelectedIndex = -1;
                cbYears.SelectedIndex = -1;
            }

        }

        private void btnFiltroPrincipal_Click(object sender, EventArgs e)
        {


            //cbYears.Enabled = true;
        }
        private void MostrarPagos_Estado_Year_Mes(String estado, String year, String mes)
        {
            using (SIDACEntities db = new SIDACEntities())
            {
                

                    FiltrarPagos_Estado_Year(cbFiltroPrincipal.Text, cbYears.Text);

                    var pago = db.sp_MostrarPagos_Estado_Year_Mes(estado, year, mes);

                    dtgPagos.Rows.Clear();
                    foreach (var i in pago)
                    {
                        dtgPagos.Rows.Add(i.idPago, i.nombre, i.mes, i.montoBase, i.montoCancelado,
                                            i.montoPendiente, i.mora, i.descripcion, i.estado, i.fecha);
                    }
                

            }
        }


        private void cbMes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbMes.SelectedIndex >= 0 && cbYears.SelectedIndex >= 0 && cbFiltroPrincipal.SelectedIndex >= 0)
            {
                MostrarPagos_Estado_Year_Mes(cbFiltroPrincipal.Text, cbYears.Text, cbMes.Text);
            }

        }

        private void pnlControlesDeFiltros1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cbYears_Enter(object sender, EventArgs e)
        {
            

            
            

        }

        private void cbFiltroPrincipal_Enter(object sender, EventArgs e)
        {


            
        }

        private void cbFiltroPrincipal_MouseClick(object sender, MouseEventArgs e)
        {

            MostrarPagos(cbFiltroPrincipal.Text);

            cbMes.DataSource = null;
            cbMes.ResetText();

            cbYears.SelectedIndex = -1;
        }

        private void cbYears_MouseClick(object sender, MouseEventArgs e)
        {
            FiltrarPagos_Estado_Year(cbFiltroPrincipal.Text, cbYears.Text);
            cbMes.SelectedIndex = -1;
        }

        private void pnlEliminar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dtgPagos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
