using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SIDAC.DAO;
using SIDAC.MODELO;
using SIDAC.VALIDACIONES;

using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;

namespace SIDAC.VISTA
{
    public partial class FrmControlPagos : Form
    {
        public FrmControlPagos()
        {
            InitializeComponent();
            txtFecha.Text = DateTime.Now.ToString();
            CargarDatosFiltroPrincipal();
        }

        CDControlPagos pago = new CDControlPagos();
        VsFrmPagos validacion = new VsFrmPagos();
        static String accionEnPagos = "Agregar";

        private void FrmControlPagos_Load(object sender, EventArgs e)
        {
            pago.MostrarPagos(cbFiltroPrincipal.Text, this.dtgPagos);
            CargarEstados();
            CargarReportes();
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
        //carga de items del menu de reportes
        private void CargarReportes()
        {
            //cbMenuFiltro.Items.Add("Estado");
            cbMenuFiltro.Items.Add("Reporte General por Año");
            //cbMenuFiltro.Items.Add("Estado-Año-Mes");
            cbMenuFiltro.Items.Add("Pagos por Consumidor");
        }
        #endregion

        #region CRUD PAGOS
        //AGREGAR
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //llamando al metodo que valida las cajas
            Boolean validarCajas = false;
            validarCajas = validacion.ValidarCajas(0,this.txtID,this.txtNombres,this.txtApellidos, this.txtMontoBase,this.txtCancelado,this.txtMora,cbConsumidor.SelectedValue, this.Validacion);

            if (validarCajas==true)
            {
                Pagos CrNuevoPago = new Pagos();
                CrNuevoPago.montoBase = Convert.ToDecimal(txtMontoBase.Text);
                CrNuevoPago.montoCancelado = Convert.ToDecimal(txtCancelado.Text);
                CrNuevoPago.descripcion = txtDescripcion.Text;
                CrNuevoPago.mora = Convert.ToDecimal(txtMora.Text);
                CrNuevoPago.fecha = Convert.ToDateTime(txtFecha.Text);
                CrNuevoPago.FK_estado = Convert.ToInt32(cbEstado.SelectedValue.ToString());
                CrNuevoPago.FK_consumidor = Convert.ToInt32(txtID.Text);

                pago.RegistrarPago(CrNuevoPago);

                MantenerFiltroElegidos();
                Limpiar();
            }

        }
        //modificar
        private void btnModificar_Click(object sender, EventArgs e)
        {
            //llamando al metodo que valida las cajas
            Boolean validarCajas = false;
            validarCajas = validacion.ValidarCajas(1, this.txtID, this.txtNombres, this.txtApellidos, this.txtMontoBase, this.txtCancelado, this.txtMora, cbConsumidor.SelectedValue, this.Validacion);

            if (validarCajas==true)
            {
                Pagos CrModificarPago = new Pagos();
                CrModificarPago.montoCancelado = Convert.ToDecimal(txtCancelado.Text);
                CrModificarPago.descripcion = txtDescripcion.Text;
                CrModificarPago.mora = Convert.ToDecimal(txtMora.Text);
                CrModificarPago.FK_estado = Convert.ToInt32(cbEstado.SelectedValue.ToString());
                CrModificarPago.idPago = Convert.ToInt32(txtIdPago.Text);

                pago.ActualizarPago(CrModificarPago);

                MantenerFiltroElegidos();
                Limpiar();
            }

        }
        //eliminar
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            pago.EliminarPago(Convert.ToInt32(txtIdPago.Text));
            MantenerFiltroElegidos();
            Limpiar();

        }
        #endregion

        #region RELLENAR CAJAS DEL PANEL-FORMULARIO
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

                accionEnPagos = "Modificar";
            }
        }

        #endregion

        #region FILTRO DE PAGOS ESTADO-YEAR-MES
        private void cbFiltroPrincipal_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFiltroPrincipal.SelectedIndex >= 0)
            {
                //buscar  y muestra los pagos segun un estado
                pago.MostrarPagos(cbFiltroPrincipal.Text, this.dtgPagos);
                //buscar  y muestra en comboB cbYears los años en los que se tienen registros de pagos segun un estado
                pago.CargarDatosCBYear_Estado(cbFiltroPrincipal.Text, this.cbYears);

                //se le indica que no se seleccione ninguno por defecto
                cbMes.SelectedIndex = -1;
                cbYears.SelectedIndex = -1;
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
                    pago.FiltrarPagos_Estado_Year(cbFiltroPrincipal.Text, cbYears.Text,this.dtgPagos);

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

        //cuando ya estan cargados los meses de los registros que ya estan filtrados por estado-year
        //aqui se llama al metodo para filtrar los pagos por estado-year-mes
        private void cbMes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbMes.SelectedIndex >= 0 && cbYears.SelectedIndex >= 0 && cbFiltroPrincipal.SelectedIndex >= 0)
            {
                pago.MostrarPagos_Estado_Year_Mes(cbFiltroPrincipal.Text, cbYears.Text, cbMes.Text, this.dtgPagos);
            }

        }
        
        #region otros metodos relacionados
        //cuando se de click en comboB del los filtros por estado, se borraran los filtros por años y meses y se muestarn 
        //todos los pagos segun un estado
        private void cbFiltroPrincipal_MouseClick(object sender, MouseEventArgs e)
        {

            pago.MostrarPagos(cbFiltroPrincipal.Text, this.dtgPagos);

            cbMes.DataSource = null;
            cbMes.ResetText();

            cbYears.SelectedIndex = -1;
        }

        //cuando se da click en el comboB de CbYears, se eliminan los meses seleccionados en cbMes
        //y se muestran todos los pagos segun un estado-year
        private void cbYears_MouseClick(object sender, MouseEventArgs e)
        {
            pago.FiltrarPagos_Estado_Year(cbFiltroPrincipal.Text, cbYears.Text, this.dtgPagos);
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

            if (txtNombreABuscar.Text != "" && txtNombreABuscar.SelectedIndex != -1)
            {
                pago.MostrarPagosPorId(idconsumidor, this.dtgPagos);
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
                pago.MostrarPagos_Year_Id(txtNombreABuscar.SelectedValue.ToString(), cbYear.Text, this.dtgPagos);
            }
        }

        //metodo para mostrar todos los pagos de un consumidor si de da click
        //en la comboB cbYear 
        private void cbYear_Click(object sender, EventArgs e)
        {
            int idconsumidor = 0;
            if (txtNombreABuscar.SelectedValue != null)
            {
                int id = Convert.ToInt32(txtNombreABuscar.SelectedValue.ToString());
                //idconsumidor = Convert.ToInt32(id);
                idconsumidor = id;
            }
            if (txtNombreABuscar.Text != "" && txtNombreABuscar.SelectedIndex != -1)
            {
                pago.MostrarPagosPorId(idconsumidor, this.dtgPagos);
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

        #region VALIDACION DE DATOS NUMERICOS EN LAS CAJAS

        private void txtMontoBase_TextChanged(object sender, EventArgs e)
        {
            if (accionEnPagos.Equals("Modificar"))
            {
                validacion.VerificarValoresNumericos("", this.txtMontoBase, this.btnModificar, txtMontoBase.Text, txtCancelado.Text);
            }
            else
            {
                validacion.VerificarValoresNumericos("", this.txtMontoBase, this.btnAgregar, txtMontoBase.Text, txtCancelado.Text);
            }

        }

        private void txtCancelado_TextChanged(object sender, EventArgs e)
        {
            if (accionEnPagos.Equals("Modificar"))
            {
                validacion.VerificarValoresNumericos("montoCancelado", this.txtCancelado, this.btnModificar, txtMontoBase.Text, txtCancelado.Text);
            }
            else
            {
                validacion.VerificarValoresNumericos("montoCancelado", this.txtCancelado, this.btnAgregar, txtMontoBase.Text, txtCancelado.Text);
            }
        }

        private void txtMora_TextChanged(object sender, EventArgs e)
        {
            if (accionEnPagos.Equals("Modificar"))
            {
                validacion.VerificarValoresNumericos("mora", this.txtMora, this.btnModificar, txtMontoBase.Text, txtCancelado.Text);
            }
            else
            {
                validacion.VerificarValoresNumericos("mora", this.txtMora, this.btnAgregar, txtMontoBase.Text, txtCancelado.Text);
            }
        }
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

            txtMontoBase.FillColor = Color.White;
            txtCancelado.FillColor = Color.White;
            txtMora.FillColor = Color.White;

            accionEnPagos = "Agregar";
        }

        private void MantenerFiltroElegidos()
        {
            if ((txtNombreABuscar.SelectedValue != null || txtNombreABuscar.Text != "") && cbYear.Text != "" || cbYear.SelectedValue != null)
            {
                if (cbYear.SelectedValue != null && txtNombreABuscar.SelectedValue != null)
                {
                    pago.MostrarPagos_Year_Id(txtNombreABuscar.SelectedValue.ToString(),cbYear.Text,this.dtgPagos);
                }
            }
            else if (txtNombreABuscar.SelectedValue != null || txtNombreABuscar.Text != "")
            {
                int idconsumidor = 0;
                if (txtNombreABuscar.SelectedValue != null)
                {
                    int id = Convert.ToInt32(txtNombreABuscar.SelectedValue.ToString());
                    //idconsumidor = Convert.ToInt32(id);
                    idconsumidor = id;
                }
                if (txtNombreABuscar.Text != "" && txtNombreABuscar.SelectedIndex != -1)
                {
                    pago.MostrarPagosPorId(idconsumidor, this.dtgPagos);

                }
            }
            else
            {
                if (cbFiltroPrincipal.Text != "" && cbYears.Text.Equals("") && cbMes.Text.Equals(""))
                {
                    pago.MostrarPagos(cbFiltroPrincipal.Text, this.dtgPagos);
                }
                else if (cbFiltroPrincipal.Text != "" && cbYears.Text != "" && cbMes.Text.Equals(""))
                {
                    pago.FiltrarPagos_Estado_Year(cbFiltroPrincipal.Text, cbYears.Text, this.dtgPagos);
                }
                else if (cbFiltroPrincipal.Text != "" && cbYears.Text != "" && cbMes.Text != "")
                {
                    pago.MostrarPagos_Estado_Year_Mes(cbFiltroPrincipal.Text, cbYears.Text, cbMes.Text, this.dtgPagos);
                }

            }
        }
        #endregion

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (cbMenuFiltro.Text.Equals("Reporte General por Año"))
            {
                SaveFileDialog guardarDoc = new SaveFileDialog();
                guardarDoc.FileName = DateTime.Today.ToString("dd/MM/yyyy") + ".pdf";

                String paginaHtml = Properties.Resources.ReporteGeneralPagos.ToString();
                paginaHtml = paginaHtml.Replace("@NombreSistema", "Sistema Comunal de Agua");
                paginaHtml = paginaHtml.Replace("@Comunidad", "Las Lomas");
                paginaHtml = paginaHtml.Replace("@Year", cbYears.Text);
                paginaHtml = paginaHtml.Replace("@Fecha", DateTime.Today.ToString("dd/MM/yyyy"));
//                paginaHtml = paginaHtml.Replace("@NombreConsumidor", txtNombreABuscar.Text);

                //var img = Properties.Resources._3;
                //paginaHtml = paginaHtml.Replace("@IMAGEN", img);

                string filas = string.Empty;
                decimal totalMontoBase = 0;
                decimal totalCancelado = 0;
                decimal totalPendiente = 0;
                decimal totalMora = 0;
                foreach (DataGridViewRow i in dtgPagos.Rows)
                {
                    filas += "<tr>";
                    filas += "<td class='celda'>" + (i.Index + 1).ToString() + "</td>";
                    filas += "<td style='text-align: left; border:1px solid gray;height:1cm; padding-left:0.5cm;'>" + i.Cells[1].Value.ToString() + "</td>";
                    filas += "<td class='celda'>$" + i.Cells[3].Value.ToString() + "</td>";
                    filas += "<td class='celda'>$" + i.Cells[4].Value.ToString() + "</td>";
                    filas += "<td class='celda'>$" + i.Cells[5].Value.ToString() + "</td>";
                    filas += "<td class='celda'>$" + i.Cells[6].Value.ToString() + "</td>";
                    filas += "</tr>";
                    totalMontoBase += Convert.ToDecimal(i.Cells[3].Value.ToString());
                    totalCancelado += Convert.ToDecimal(i.Cells[4].Value.ToString());
                    totalPendiente += Convert.ToDecimal(i.Cells[5].Value.ToString());
                    totalMora += Convert.ToDecimal(i.Cells[6].Value.ToString());
                }
                paginaHtml = paginaHtml.Replace("@Filas", filas);
                paginaHtml = paginaHtml.Replace("@Monto", "$" + totalMontoBase.ToString());
                paginaHtml = paginaHtml.Replace("@Cancelado", "$" + totalCancelado.ToString());
                paginaHtml = paginaHtml.Replace("@Pendiente", "$" + totalPendiente.ToString());
                paginaHtml = paginaHtml.Replace("@Mora", "$" + totalMora.ToString());

                if (guardarDoc.ShowDialog() == DialogResult.OK)
                {

                    using (FileStream stream = new FileStream(guardarDoc.FileName, FileMode.Create))
                    {
                        Document pdf = new Document(PageSize.A4, 25, 25, 25, 25);

                        PdfWriter writter = PdfWriter.GetInstance(pdf, stream);

                        pdf.Open();
                        pdf.Add(new Phrase(""));

                        using (StringReader stringReader = new StringReader(paginaHtml))
                        {
                            XMLWorkerHelper.GetInstance().ParseXHtml(writter, pdf, stringReader);
                        }
                        pdf.Close();

                    }
                }
            }

            //reporte general
            if (cbMenuFiltro.Text.Equals("Pagos por Consumidor"))
            {
                SaveFileDialog guardarDoc = new SaveFileDialog();
                guardarDoc.FileName = DateTime.Today.ToString("dd//MM//yyyy") + ".pdf";

                String paginaHtml = Properties.Resources.ReportePagosConsumidor.ToString();
                paginaHtml = paginaHtml.Replace("@NombreSistema", "Sistema Comunal de Agua");
                paginaHtml = paginaHtml.Replace("@Comunidad", "Las Lomas");
                paginaHtml = paginaHtml.Replace("@Year", cbYear.Text);
                paginaHtml = paginaHtml.Replace("@Fecha", DateTime.Today.ToString("dd/MM/yyyy"));
                paginaHtml = paginaHtml.Replace("@NombreConsumidor", txtNombreABuscar.Text);

                //var img = Properties.Resources._3;
                //paginaHtml = paginaHtml.Replace("@IMAGEN", img);

                string filas = string.Empty;
                decimal totalMontoBase = 0;
                decimal totalCancelado = 0;
                decimal totalPendiente = 0;
                decimal totalMora = 0;
                foreach (DataGridViewRow i in dtgPagos.Rows)
                {
                    filas += "<tr>";
                    filas += "<td style='text-align: left; border:1px solid gray;height:1cm; padding-left:0.5cm;'>" + i.Cells[2].Value.ToString() + "</td>";
                    filas += "<td class='celda'>$" + i.Cells[3].Value.ToString() + "</td>";
                    filas += "<td class='celda'>$" + i.Cells[4].Value.ToString() + "</td>";
                    filas += "<td class='celda'>$" + i.Cells[5].Value.ToString() + "</td>";
                    filas += "<td class='celda'>$" + i.Cells[6].Value.ToString() + "</td>";
                    filas += "<td class='celda'>" + i.Cells[8].Value + "</td>";
                    filas += "</tr>";
                    totalMontoBase += Convert.ToDecimal(i.Cells[3].Value.ToString());
                    totalCancelado += Convert.ToDecimal(i.Cells[4].Value.ToString());
                    totalPendiente += Convert.ToDecimal(i.Cells[5].Value.ToString());
                    totalMora += Convert.ToDecimal(i.Cells[6].Value.ToString());
                }
                paginaHtml = paginaHtml.Replace("@Filas", filas);
                paginaHtml = paginaHtml.Replace("@Monto", "$" + totalMontoBase.ToString());
                paginaHtml = paginaHtml.Replace("@Cancelado", "$" + totalCancelado.ToString());
                paginaHtml = paginaHtml.Replace("@Pendiente", "$" + totalPendiente.ToString());
                paginaHtml = paginaHtml.Replace("@Mora", "$" + totalMora.ToString());

                if (guardarDoc.ShowDialog() == DialogResult.OK)
                {

                    using (FileStream stream = new FileStream(guardarDoc.FileName, FileMode.Create))
                    {
                        Document pdf = new Document(PageSize.A4, 25, 25, 25, 25);

                        PdfWriter writter = PdfWriter.GetInstance(pdf, stream);

                        pdf.Open();
                        pdf.Add(new Phrase(""));

                        using (StringReader stringReader = new StringReader(paginaHtml))
                        {
                            XMLWorkerHelper.GetInstance().ParseXHtml(writter, pdf, stringReader);
                        }
                        pdf.Close();

                    }
                }
            }
            
        }

        private void btnCargarReporte_Click(object sender, EventArgs e)
        {
            using (SIDACEntities db = new SIDACEntities())
            {

                var consumidores = (from t in db.Consumidores
                                    select t.idConsumidor).ToList();
                dtgPagos.Rows.Clear();
                foreach (var i in consumidores)
                {
                    using (SIDACEntities dB = new SIDACEntities())
                    {
                        var pagos = dB.sp_MostrarPagos_Year_Consumidor(i, cbYears.Text).ToList();

                        foreach (var x in pagos)
                        {
                            dtgPagos.Rows.Add(0, x.nombre,"-",x.montoBase, x.montoCancelado,
                                         x.montoPendiente, x.mora,"-","-","-");
                        }
                    }
                }

            }
        }
    }
}
