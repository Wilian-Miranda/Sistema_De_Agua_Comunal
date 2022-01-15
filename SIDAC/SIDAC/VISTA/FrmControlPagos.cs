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
        private void FrmControlPagos_Load(object sender, EventArgs e)
        {
            MostrarPagos(cbFiltroPrincipal.Text);
            CargarEstados();
        }
        #region METODOS DE CARGA DE DATOS

        //se carga los datos del filtro por estados en los pagos
        private void CargarDatosFiltroPrincipal()
        {
            cbFiltroPrincipal.Items.Add("Pendiente");
            cbFiltroPrincipal.Items.Add("Cancelado");
            cbFiltroPrincipal.Items.Add("Con Retraso");

            cbFiltroPrincipal.SelectedIndex = 0;

        }

        //se cargan los estados al ComboB del formulario
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
        #endregion

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
            if (ValidarCajas(0)==true)
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

                if (txtNombreABuscar.SelectedValue != null || txtNombreABuscar.Text != "")
                {
                    btnFiltrar.PerformClick();
                    cbYear.SelectedIndex = 0;
                }
                else
                {
                    if (cbFiltroPrincipal.Text != "" && cbYears.Text.Equals("") && cbMes.Text.Equals(""))
                    {
                        MostrarPagos(cbFiltroPrincipal.Text);
                    }
                    else if (cbFiltroPrincipal.Text != "" && cbYears.Text != "" && cbMes.Text.Equals(""))
                    {
                        FiltrarPagos_Estado_Year(cbFiltroPrincipal.Text, cbYears.Text);
                    }
                    else if(cbFiltroPrincipal.Text != "" && cbYears.Text != "" && cbMes.Text != "")
                    {
                        MostrarPagos_Estado_Year_Mes(cbFiltroPrincipal.Text, cbYears.Text, cbMes.Text);
                    }

                }

                Limpiar();
            }

        }
        //modificar
        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (ValidarCajas(1)==true)
            {
                Pagos pago1 = new Pagos();
                pago1.montoCancelado = Convert.ToDecimal(txtCancelado.Text);
                pago1.descripcion = txtDescripcion.Text;
                pago1.mora = Convert.ToDecimal(txtMora.Text);
                pago1.FK_estado = Convert.ToInt32(cbEstado.SelectedValue.ToString());
                pago1.idPago = Convert.ToInt32(txtIdPago.Text);

                pago.ActualizarPago(pago1);

                if (txtNombreABuscar.SelectedValue != null || txtNombreABuscar.Text != "")
                {
                    btnFiltrar.PerformClick();
                    cbYear.SelectedIndex = 0;
                }
                else
                {
                    if (cbFiltroPrincipal.Text != "" && cbYears.Text.Equals("") && cbMes.Text.Equals(""))
                    {
                        MostrarPagos(cbFiltroPrincipal.Text);
                    }
                    else if (cbFiltroPrincipal.Text != "" && cbYears.Text != "" && cbMes.Text.Equals(""))
                    {
                        FiltrarPagos_Estado_Year(cbFiltroPrincipal.Text, cbYears.Text);
                    }
                    else if (cbFiltroPrincipal.Text != "" && cbYears.Text != "" && cbMes.Text != "")
                    {
                        MostrarPagos_Estado_Year_Mes(cbFiltroPrincipal.Text, cbYears.Text, cbMes.Text);
                    }

                }

                Limpiar();
            }

        }
        //eliminar
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            pago.EliminarPago(Convert.ToInt32(txtIdPago.Text));

            if (txtNombreABuscar.SelectedValue != null || txtNombreABuscar.Text != "")
            {
                btnFiltrar.PerformClick();
                cbYear.SelectedIndex = 0;
            }
            else
            {
                if (cbFiltroPrincipal.Text != "" && cbYears.Text.Equals("") && cbMes.Text.Equals(""))
                {
                    MostrarPagos(cbFiltroPrincipal.Text);
                }
                else if (cbFiltroPrincipal.Text != "" && cbYears.Text != "" && cbMes.Text.Equals(""))
                {
                    FiltrarPagos_Estado_Year(cbFiltroPrincipal.Text, cbYears.Text);
                }
                else if (cbFiltroPrincipal.Text != "" && cbYears.Text != "" && cbMes.Text != "")
                {
                    MostrarPagos_Estado_Year_Mes(cbFiltroPrincipal.Text, cbYears.Text, cbMes.Text);
                }

            }

            Limpiar();

        }
        #endregion

        #region VALIDACIONES
        private Boolean ValidarCajas(int filtro)
        {
            Boolean validar = true;

            Validacion.SetError(txtID, "");
            Validacion.SetError(txtNombres, "");
            Validacion.SetError(txtApellidos, "");
            Validacion.SetError(txtMontoBase, "");
            Validacion.SetError(txtCancelado, "");
            Validacion.SetError(txtMora, "");


            if (filtro==0)
            {
                if (cbConsumidor.SelectedValue == null || txtID.Text.Equals(""))
                {
                    Validacion.SetError(txtID, "Este campo es obligatorio");
                    Validacion.SetError(txtNombres, "Este campo es obligatorio");
                    Validacion.SetError(txtApellidos, "Este campo es obligatorio");
                    validar = false;
                }
            }
            else
            {
                if (txtID.Text.Equals(""))
                {
                    Validacion.SetError(txtID, "Este campo es obligatorio");
                    Validacion.SetError(txtNombres, "Este campo es obligatorio");
                    Validacion.SetError(txtApellidos, "Este campo es obligatorio");
                    validar = false;
                }
            }


            if (txtMontoBase.Text.Equals(""))
            {
                Validacion.SetError(txtMontoBase, "Este campo es obligatorio");
                validar = false;
            }

            if (txtCancelado.Text.Equals(""))
            {
                Validacion.SetError(txtCancelado, "Este campo es obligatorio");
                validar = false;
            }

            if (txtMora.Text.Equals(""))
            {
                Validacion.SetError(txtMora, "Este campo es obligatorio");
                validar = false;
            }

            return validar;
        }
        #endregion

        #region RELLENAR CAJAS
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

        #endregion

        #region FILTRO DE PAGOS ESTADO-YEAR-MES
        private void cbFiltroPrincipal_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFiltroPrincipal.SelectedIndex >= 0)
            {
                //buscar  y muestra los pagos segun un estado
                MostrarPagos(cbFiltroPrincipal.Text);
                //buscar  y muestra en comboB cbYears los años en los que se tienen registros de pagos segun un estado
                CargarDatosCBYear_Estado(cbFiltroPrincipal.Text);

                //se le indica que no se seleccione ninguno por defecto
                cbMes.SelectedIndex = -1;
                cbYears.SelectedIndex = -1;
            }

        }
        //metodo para cargar los años segun el estado
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

        //cuando ya se tienen cargados los años, aqui se llama al metodo para buscar y mostrar los pagos segun estado-year
        private void cbYears_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbYears.SelectedIndex >= 0
                && cbFiltroPrincipal.SelectedIndex >= 0)
            {
                int year = Convert.ToInt32(cbYears.Text);
                using (SIDACEntities db = new SIDACEntities())
                {
                    FiltrarPagos_Estado_Year(cbFiltroPrincipal.Text, cbYears.Text);

                    //cargar los datos de los meses que se tienen registros en la db en la combobox, que ya estan filtrados 
                    //por estado y año

                    var meses = db.sp_MesesInYearsInPagos(year, cbFiltroPrincipal.Text).ToList();

                    cbMes.ResetText();
                    cbMes.DataSource = meses;
                    cbMes.DisplayMember = "mes";
                    cbMes.ValueMember = "valor";

                    if (meses.Count > 0)
                    {
                        cbMes.SelectedIndex = 0;
                    }
                }
            }
        }
        //metodo para buscar y mostrar los pagos segun un estado y año
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

        //cuando ya estan cargados los meses de los registros que ya estan filtrados por estado-year
        //aqui se llama al metodo para filtrar los pagos por estado-year-mes
        private void cbMes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbMes.SelectedIndex >= 0 && cbYears.SelectedIndex >= 0 && cbFiltroPrincipal.SelectedIndex >= 0)
            {
                MostrarPagos_Estado_Year_Mes(cbFiltroPrincipal.Text, cbYears.Text, cbMes.Text);
            }

        }
        
        //metodo para filtrar los pagos segun un estado-year-mes
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
        #region otros metodos relacionados
        //cuando se de click en comboB del los filtros por estado, se borraran los filtros por años y meses y se muestarn 
        //todos los pagos segun un estado
        private void cbFiltroPrincipal_MouseClick(object sender, MouseEventArgs e)
        {

            MostrarPagos(cbFiltroPrincipal.Text);

            cbMes.DataSource = null;
            cbMes.ResetText();

            cbYears.SelectedIndex = -1;
        }

        //cuando se da click en el comboB de CbYears, se eliminan los meses seleccionados en cbMes
        //y se muestran todos los pagos segun un estado-year
        private void cbYears_MouseClick(object sender, MouseEventArgs e)
        {
            FiltrarPagos_Estado_Year(cbFiltroPrincipal.Text, cbYears.Text);
            cbMes.SelectedIndex = -1;
        }

        #endregion
        #endregion

        #region FILTRO DE PAGOS CONSUMIDOR-YEAR
        //Metodo para realizar una busqueda segun un nombre que se ingrese y luego se cargan las 
        //coincidencias en el comboB 
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

        //cada vez que se seleccione otro consumidor de la lista agregada de la busqueda 
        //al comboB, se borraran los años cargados al comboB cbYear para evitar errores y obligar
        //a filtrar los datos nuevamente
        private void txtNombreABuscar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtNombreABuscar.SelectedValue != null)
            {
                cbYear.DataSource = null;
            }
        }

        //una vez elegido el consumidor se toma el id de value del comboB seleccionado y se hace una busqueda
        //y se muestran los datos, luego se cargan los años en los que esa persona ha pagado en el comboB cbYear
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
                    }
                }
            }

        }

        //una vez cargados los años al comboB, cada vez que se eliga uno se aplicara un filtro que buscara 
        //los pagos realizados por una persona en un año en especifico
        private void cbYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbYear.SelectedValue != null && txtNombreABuscar.SelectedValue != null)
            {
                int id = Convert.ToInt32(txtNombreABuscar.SelectedValue.ToString());
                using (SIDACEntities db = new SIDACEntities())
                {
                    var pagosFiltradosPorYear = db.sp_MostrarPagoPorYear(id, cbYear.Text);

                    dtgPagos.Rows.Clear();
                    foreach (var i in pagosFiltradosPorYear)
                    {
                        dtgPagos.Rows.Add(i.idPago, i.nombre, i.mes, i.montoBase, i.montoCancelado, i.montoPendiente, i.mora, i.descripcion, i.estado, i.fecha);
                    }
                }
            }
        }
        #endregion

        #region PANEL-FORMULARIO DE PAGOS
        //se llama al metodo que realiza la busqueda y agrega al comboB las coincidencias
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BuscarConsumidor(cbConsumidor.Text);
        }

        //metodo para realizar busqueda de los consumidores
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

                cbConsumidor.SelectedIndex = -1;
            }
        }

        //cuando se seleccione un consumidor realizara una busqueda segun ese id para
        //colocar por separado el id, nombre y apellido de la persona
        private void cbConsumidor_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarConsumidorBuscado();
        }

        //metodo que realiza una busqueda de un consumidor por su id, y coloca en cajas por separado
        //el id, nombre y apellidos
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

        //cuando se dan Enter en la caja de cancelado, se hace una resta: al monto base se le quita lo acncelado,
        //y se agrega en la caja de pendiente lo que falta
        private void txtCancelado_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPendiente.Text = (Convert.ToDecimal(txtMontoBase.Text) - Convert.ToDecimal(txtCancelado.Text)).ToString();
            }
        }

        //si se han cargado datos a las cajas desde la tabla, se puede limpiar solo dando doble click en
        //el encabezado del panel-formulario
        private void pnlEncabezadoNuevoPago_DoubleClick(object sender, EventArgs e)
        {
            Limpiar();
        }
        #region otros metodos relacionados
        //cuando se de click en el combo de buscar se quitarn los datos previamente cargados a las cajas
        //de id, nombre y apellidos. Tambien se selecinara todo el texto para solo escribir una nueva busqueda
        private void cbConsumidor_Enter(object sender, EventArgs e)
        {
            cbConsumidor.SelectAll();
            Limpiar();
        }
        #endregion
        #endregion

        #region ABRIR VENTANAS-PANELES
        //filtro 1: donde se filtran pagos segun estado-año-mes
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

        //filtro dos: donde se buscar pagos segun consumidor-year
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

        //Abrir ventana para agregar-actualizar-eliminar registros de pagos
        private void btnAbrirVentanaPagos_Click(object sender, EventArgs e)
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
        #endregion
        
        #region OTROS 
        private void Limpiar()
        {
            cbConsumidor.ResetText();
            txtID.Clear();
            txtNombres.Clear();
            txtApellidos.Clear();
            txtIdPago.Clear();
            txtMontoBase.Clear();
            txtCancelado.Clear();
            txtMora.Clear();
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
        }
        #endregion

    }
}
