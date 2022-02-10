using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using SIDAC.MODELO;
using SIDAC.REPORTES.Pagos;
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

namespace SIDAC.VISTA
{
    public partial class FrmReportes : Form
    {
        public FrmReportes()
        {
            InitializeComponent();

        }


        #region Carga de datos

        #endregion

        private void cbTipoReporte_Pagos_SelectedIndexChanged(object sender, EventArgs e)
        {
/*
                //reporte por consumidor
                if (cbTipoReporte_Pagos.SelectedIndex == 0)
                {
                    txtYear_Pagos.Enabled = true;
                    cbConsumidor_Pagos.Enabled = true;
                    btnBusrcarConsumidor_Pagos.Enabled = true;

                    //Se desabilita porque al cambiar de tipo de reporte se habilita
                    btnCargarDatos.Enabled = false;
                    LimpiarDetalles_Pagos();
                }
                else
                {
                    txtYear_Pagos.Enabled = true;
                    cbConsumidor_Pagos.Enabled = false;
                    btnBusrcarConsumidor_Pagos.Enabled = false;
                    btnCargarDatos.Enabled = true;

                    lblIdConsumidor.Text = "-";
                    lblConsumidor_Pagos.Text = "Todos";
                }
           */ 
            
        }

        private void btnBusrcarConsumidor_Pagos_Click(object sender, EventArgs e)
        {
            using (SIDACEntities db = new SIDACEntities())
            {
                var consumidor = (from t in db.Consumidores
                                  where (t.nombres.ToLower() + " " + t.apellidos.ToLower()).Contains(cbConsumidor_Pagos.Text.ToLower())
                                  select new
                                  {
                                      t.idConsumidor,
                                      nombre = t.nombres + " " + t.apellidos
                                  }).ToList();
                if (consumidor.Count > 0)
                {
                    cbConsumidor_Pagos.DataSource = consumidor;
                    cbConsumidor_Pagos.DisplayMember = "nombre";
                    cbConsumidor_Pagos.ValueMember = "idConsumidor";

                    cbConsumidor_Pagos.SelectedIndex = -1;
                }
            }
        }

        private void cbConsumidor_Pagos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbConsumidor_Pagos.SelectedValue != null)
            {
                pnlDetallesPagos.Enabled = true;
                btnCargarDatos.Enabled = true;

                lblIdConsumidor.Text = cbConsumidor_Pagos.SelectedValue.ToString();
                lblConsumidor_Pagos.Text = cbConsumidor_Pagos.Text;
            }
        }

        private void btnCargarDatos_Click(object sender, EventArgs e)
        {

                btnImprimir_Pagos.Enabled = true;
                using (SIDACEntities db = new SIDACEntities())
                {
                    if (rbReportePorConsumidor.Checked)
                    {
                        var pagosConsumidor = (from t in db.sp_MostrarPagoPorYear(Convert.ToInt32(cbConsumidor_Pagos.SelectedValue), txtYear_Pagos.Text)
                                               select new
                                               {
                                                   t.mes,
                                                   t.montoBase,
                                                   t.montoCancelado,
                                                   t.montoPendiente,
                                                   t.mora,
                                                   t.estado
                                               }).ToList();

                        if (pagosConsumidor.Count > 0)
                        {
                            decimal monto = 0;
                            decimal cancelado = 0;
                            decimal pendiente = 0;
                            decimal? mora = 0;
                            foreach (var i in pagosConsumidor)
                            {
                                monto += i.montoBase;
                                cancelado += i.montoCancelado;
                                pendiente += i.montoPendiente;
                                mora += i.mora;
                            }
                            lblMontoTotal_Pagos.Text = "$" + monto.ToString();
                            lblCancelado_Pagos.Text = "$" + cancelado.ToString();
                            lblPendiente.Text = "$" + pendiente.ToString();
                            lblMora_Pagos.Text = "$" + mora.ToString();
                            lblNumRegistros_Pagos.Text = pagosConsumidor.Count.ToString();
                        }
                        else
                        {
                            MessageBox.Show("No se encontraron registros de pagos de: " + cbConsumidor_Pagos.Text + ", en el año: " + txtYear_Pagos.Text + ".");
                        }
                    }

                    if(rbReporteGeneral.Checked)
                    {
                        var consumidores = (from t in db.Consumidores select t.idConsumidor).ToList();

                        decimal? monto = 0;
                        decimal? cancelado = 0;
                        decimal? pendiente = 0;
                        decimal? mora = 0;
                        int num = 0;

                        foreach (var i in consumidores)
                        {
                            var pagosGeneral = (from t in db.sp_MostrarPagos_Year_Consumidor(i, txtYear_Pagos.Text)
                                                select new
                                                {
                                                    t.nombre,
                                                    t.montoBase,
                                                    t.montoCancelado,
                                                    t.montoPendiente,
                                                    t.mora
                                                }).ToList();
                            if (pagosGeneral.Count > 0)
                            {

                                foreach (var x in pagosGeneral)
                                {
                                    monto += x.montoBase;
                                    cancelado += x.montoCancelado;
                                    pendiente += x.montoPendiente;
                                    mora += x.mora;
                                    
                                }
                                num += 1;
                            }

                        }

                            
                            lblMontoTotal_Pagos.Text = "$" + monto.ToString();
                            lblCancelado_Pagos.Text = "$" + cancelado.ToString();
                            lblPendiente.Text = "$" + pendiente.ToString();
                            lblMora_Pagos.Text = "$" + mora.ToString();
                            lblNumRegistros_Pagos.Text = num.ToString();

                        if (monto==0)
                        {
                            MessageBox.Show("No se encontraron registros de pagos en el año: " + txtYear_Pagos.Text + ".");
                        }

                    }

                }
        }
        

        private void btnImprimir_Pagos_Click(object sender, EventArgs e)
        {
            CrearReportePorConsumidor();
            CrearReporteGeneral();

        }
        private void CrearReporteGeneral()
        {

            ClsRepo_Pagos reportePagos = new ClsRepo_Pagos();

            if (rbReporteGeneral.Checked)
            {

                if (lblIdConsumidor.Text == "-" &&
                    lblConsumidor_Pagos.Text == "Todos" &&
                    lblNumRegistros_Pagos.Text != "" &&
                    lblMontoTotal_Pagos.Text != "" &&
                    lblCancelado_Pagos.Text != "" &&
                    lblPendiente.Text != "" &&
                    lblMora_Pagos.Text != "")
                {
                    SaveFileDialog guardar = new SaveFileDialog();
                    guardar.FileName = DateTime.Today.ToString("dd//MM//yyyy") + ".pdf";


                    
                    if (guardar.ShowDialog() == DialogResult.OK)
                    {

                        using (FileStream strm = new FileStream(guardar.FileName, FileMode.Create))
                        {
                            Document pdf = new Document(PageSize.A4, 25, 25, 25, 25);

                            PdfWriter writter = PdfWriter.GetInstance(pdf, strm);

                            pdf.Open();
                            pdf.Add(new Phrase(""));

                            String paginaHtml = reportePagos.CargarDatos_ReporteGeneral(this.txtYear_Pagos);

                            using (StringReader stringReader = new StringReader(paginaHtml))
                            {
                                XMLWorkerHelper.GetInstance().ParseXHtml(writter, pdf, stringReader);
                            }
                            pdf.Close();

                        }
                    }

                }


                else
                {
                    MessageBox.Show("Antes de crear el reporte se deben cargar los datos.");
                }
            }


            
        }
        private void CrearReportePorConsumidor()
        {
            using (SIDACEntities db = new SIDACEntities())
            {
                if (rbReportePorConsumidor.Checked)
                {


                    var pagosConsumidor = (from t in db.sp_MostrarPagoPorYear(Convert.ToInt32(cbConsumidor_Pagos.SelectedValue), txtYear_Pagos.Text)
                                           select new
                                           {
                                               t.mes,
                                               t.montoBase,
                                               t.montoCancelado,
                                               t.montoPendiente,
                                               t.mora,
                                               t.estado
                                           }).ToList();

                    if (pagosConsumidor.Count > 0)
                    {
                        if (lblIdConsumidor.Text != "" &&
                            lblConsumidor_Pagos.Text != "" &&
                            lblNumRegistros_Pagos.Text != "" &&
                            lblMontoTotal_Pagos.Text != "" &&
                            lblCancelado_Pagos.Text != "" &&
                            lblPendiente.Text != "" &&
                            lblMora_Pagos.Text != "")
                        {
                            SaveFileDialog guardarDoc = new SaveFileDialog();
                            guardarDoc.FileName = DateTime.Today.ToString("dd//MM//yyyy") + ".pdf";

                            String paginaHtml = Properties.Resources.ReportePagosConsumidor.ToString();
                            paginaHtml = paginaHtml.Replace("@NombreSistema", "Sistema Comunal de Agua");
                            paginaHtml = paginaHtml.Replace("@Comunidad", "Las Lomas");
                            paginaHtml = paginaHtml.Replace("@Year", txtYear_Pagos.Text);
                            paginaHtml = paginaHtml.Replace("@Fecha", DateTime.Today.ToString("dd/MM/yyyy"));
                            paginaHtml = paginaHtml.Replace("@NombreConsumidor", cbConsumidor_Pagos.Text);

                            //var img = Properties.Resources._3;
                            //paginaHtml = paginaHtml.Replace("@IMAGEN", img);

                            string filas = string.Empty;
                            decimal totalMontoBase = 0;
                            decimal totalCancelado = 0;
                            decimal totalPendiente = 0;
                            decimal? totalMora = 0;
                            foreach (var i in pagosConsumidor)
                            {
                                filas += "<tr>";
                                filas += "<td style='text-align: left; border:1px solid gray;height:1cm; padding-left:0.5cm;'>" + i.mes.ToString() + "</td>";
                                filas += "<td class='celda'>$" + i.montoBase.ToString() + "</td>";
                                filas += "<td class='celda'>$" + i.montoCancelado.ToString() + "</td>";
                                filas += "<td class='celda'>$" + i.montoPendiente.ToString() + "</td>";
                                filas += "<td class='celda'>$" + i.mora.ToString() + "</td>";
                                filas += "<td class='celda'>" + i.estado + "</td>";
                                filas += "</tr>";
                                totalMontoBase += i.montoBase;
                                totalCancelado += i.montoCancelado;
                                totalPendiente += i.montoPendiente;
                                totalMora += i.mora;
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
                        else
                        {
                            MessageBox.Show("Debe realizar la cargar de datos previamente para poder imprimir el reporte.");
                        }
                    }

                }
            }

        }

        private void cbConsumidor_Pagos_Enter(object sender, EventArgs e)
        {
            LimpiarDetalles_Pagos();
        }

        private void LimpiarDetalles_Pagos()
        {
            lblIdConsumidor.Text = "";
            lblConsumidor_Pagos.Text = "";
            lblCancelado_Pagos.Text = "";
            lblMontoTotal_Pagos.Text = "";
            lblCancelado_Pagos.Text = "";
            lblPendiente.Text = "";
            lblMora_Pagos.Text = "";
            lblNumRegistros_Pagos.Text = "";

            pnlDetallesPagos.Enabled = false;
            btnCargarDatos.Enabled = false;
            btnImprimir_Pagos.Enabled = false;
        }

        private void txtYear_Pagos_Enter(object sender, EventArgs e)
        {
            if (rbReportePorConsumidor.Checked)
            {
                LimpiarDetalles_Pagos();
            }
            else
            {
                LimpiarDetalles_Pagos();
                lblIdConsumidor.Text = "-";
                lblConsumidor_Pagos.Text = "Todos";
                btnCargarDatos.Enabled = true;
            }
            
        }

        private void cbReportePorConsumidor_CheckedChanged(object sender, EventArgs e)
        {
            txtYear_Pagos.Enabled = true;
            cbConsumidor_Pagos.Enabled = true;
            btnBusrcarConsumidor_Pagos.Enabled = true;

            //Se desabilita porque al cambiar de tipo de reporte se habilita
            btnCargarDatos.Enabled = false;
            LimpiarDetalles_Pagos();
        }

        private void rbReporteGeneral_CheckedChanged(object sender, EventArgs e)
        {
            txtYear_Pagos.Enabled = true;
            cbConsumidor_Pagos.Enabled = false;
            btnBusrcarConsumidor_Pagos.Enabled = false;
            btnCargarDatos.Enabled = true;

            lblIdConsumidor.Text = "-";
            lblConsumidor_Pagos.Text = "Todos";
        }
    }
}
