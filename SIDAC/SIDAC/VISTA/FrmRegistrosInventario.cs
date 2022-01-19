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
    public partial class FrmRegistrosInventario : Form
    {
        public FrmRegistrosInventario()
        {
            InitializeComponent();
            MostrarRegistros();
        }

        private void MostrarRegistros()
        {
            try
            {
                using (SIDACEntities db = new SIDACEntities())
                {
                    var registros = db.RetirosInventario.ToList();

                    foreach (var i in registros)
                    {
                        dtgRegistros.Rows.Add(i.idRetiro,i.cantidad,i.descripcion,i.motivo,i.precioUnidad,i.subtotal,i.date);
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al mostrar los registros.\n\n" + ex.ToString());
            }
        }


        private void btnCerrarVentana_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
