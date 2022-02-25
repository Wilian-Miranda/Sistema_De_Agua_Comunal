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
    public partial class pruebas_graficas : Form
    {
        public pruebas_graficas()
        {
            InitializeComponent();
        }

        private void pruebas_graficas_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            using(SIDACEntities db = new SIDACEntities())
            {
                var serie1 = db.sp_Grafico_PagosCancelados(txtYear.Text).ToList();

                var mes = (from m in serie1
                           select m.mes).ToList();
                var monto = (from m in serie1
                           select m.monto).ToList();

                chart1.Series[1].Points.DataBindXY(mes,monto);

                
                var serie2 = db.sp_Grafico_PagosBase(txtYear.Text).ToList();

                var mes2 = (from m in serie2
                           select m.mes).ToList();
                var monto2 = (from m in serie2
                             select m.monto).ToList();

                chart1.Series[0].Points.DataBindXY(mes2, monto2);
            }
        }
    }
}
