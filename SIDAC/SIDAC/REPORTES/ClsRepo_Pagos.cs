using SIDAC.MODELO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIDAC.REPORTES.Pagos
{
    class ClsRepo_Pagos
    {
        public string CargarDatos_ReporteGeneral(Guna.UI2.WinForms.Guna2TextBox txtYear_Pagos)
        {
            String paginaHtml = String.Empty;
            string Filas = string.Empty;
            double MontoBase = 0;
            double Cancelado = 0;
            double Pendiente = 0;
            double Mora = 0;
            int num = 1;
            using (SIDACEntities dB = new SIDACEntities())
            {

                var consumidores = (from t in dB.Consumidores
                                    select t.idConsumidor).ToList();


                foreach (var i in consumidores)
                {

                    using (SIDACEntities DB = new SIDACEntities())
                    {
                        var pagos = DB.sp_MostrarPagos_Year_Consumidor(i, txtYear_Pagos.Text).ToList();


                        foreach (var item in pagos)
                        {
                            Filas += "<tr>";
                            Filas += "<td style='text-align: left; border:1px solid gray;height:1cm; padding-left:0.5cm;'>" + num + "</td>";
                            Filas += "<td style='text-align: left; border:1px solid gray;height:1cm; padding-left:0.5cm;'>" + item.nombre.ToString() + "</td>";
                            Filas += "<td class='celda'>$" + item.montoBase.ToString() + "</td>";
                            Filas += "<td class='celda'>$" + item.montoCancelado.ToString() + "</td>";
                            Filas += "<td class='celda'>$" + item.montoPendiente.ToString() + "</td>";
                            Filas += "<td class='celda'>$" + item.mora.ToString() + "</td>";
                            //filas += "<td class='celda'>" + x.estado + "</td>";
                            Filas += "</tr>";
                            MontoBase += (double)item.montoBase;
                            Cancelado += (double)item.montoCancelado;
                            Pendiente += (double)item.montoPendiente;
                            Mora += (double)item.mora;
                            num += 1;
                        }

                        String pagina = Properties.Resources.ReporteGeneralPagos.ToString();
                        pagina = pagina.Replace("@NombreSistema", "Sistema Comunal de Agua");
                        pagina = pagina.Replace("@Comunidad", "Las Lomas");
                        pagina = pagina.Replace("@Year", txtYear_Pagos.Text);
                        pagina = pagina.Replace("@Fecha", DateTime.Today.ToString("dd/MM/yyyy"));

                        pagina = pagina.Replace("<tr>@Filas</tr>", Filas);
                        pagina = pagina.Replace("@Monto", "$" + MontoBase.ToString());
                        pagina = pagina.Replace("@Cancelado", "$" + Cancelado.ToString());
                        pagina = pagina.Replace("@Pendiente", "$" + Pendiente.ToString());
                        pagina = pagina.Replace("@Mora", "$" + Mora.ToString());

                        paginaHtml = pagina;

                        //MessageBox.Show(Filas.ToString());

                    }
                }

            }
            return paginaHtml;
        }


    }
}
