using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SIDAC.MODELO;

namespace SIDAC.VISTA
{
    public partial class FrmDetallesCompras : Form
    {
        public FrmDetallesCompras()
        {
            InitializeComponent();
            
        }
        public int ID;
        private void CargarDatos()
        {
            dtgDetallesCompras.Rows.Clear();
            using (SIDACEntities db = new SIDACEntities())
            {
                int id = ID;
                var detalles = db.DetallesCompras.Where(x => x.FK_compra == id);

                foreach (var i in detalles)
                {
                    dtgDetallesCompras.Rows.Add(i.idDetalleCompras,i.cantidad,i.descripcion,i.precioUnitario,i.total);
                }

                var total = (from a in db.DetallesCompras
                             where a.FK_compra == id
                             select a.total).ToList();

                if (total.Sum()>Convert.ToDecimal(txtValor.Text))
                {
                    lblTotal.ForeColor = Color.Red;
                    lblTotal.Text = "Las cantidades ingresadas exceden en valor total declarado en la factura. Revise los datos.";
                }
                else
                {
                    lblTotal.ForeColor = Color.Black;
                    lblTotal.Text = "$" + total.Sum().ToString()+"  |" + "  Total establecido: $"+txtValor.Text + "  |" + "  Diferencia: $" + 
                        (Convert.ToDecimal(txtValor.Text)-total.Sum()).ToString();
                }
                
            }
        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dtgDetallesCompras.SelectedRows.Count>0)
            {
                try
                {
                    int id = Convert.ToInt32(dtgDetallesCompras.CurrentRow.Cells[0].Value.ToString());
                    using (SIDACEntities db = new SIDACEntities())
                    {

                        //eliminando detalle en inventario
                        var eliminarInventario = db.Inventarios.Where(x => x.FK_DetalleCompra == id).FirstOrDefault();
                        db.Inventarios.Remove(eliminarInventario);
                        db.SaveChanges();
                    }

                    using (SIDACEntities db = new SIDACEntities())
                    {
                        //eliminando detalle en las compras
                        var eliminar = db.DetallesCompras.Where(x => x.idDetalleCompras == id).FirstOrDefault();
                        db.DetallesCompras.Remove(eliminar);
                        db.SaveChanges();
                        CargarDatos();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar detalle de compra.\n\n" + ex.ToString());
                }
            }
        }

        private void pnlDatosPagos_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            int id = ID;

            try
            {
                using (SIDACEntities db = new SIDACEntities())
                {
                    DetallesCompras detalles = new DetallesCompras();

                    detalles.cantidad = Convert.ToInt32(txtCantidad.Text);
                    detalles.descripcion = txtDescripcion.Text;
                    detalles.precioUnitario = Convert.ToDecimal(txtPrecioUnitario.Text);
                    detalles.total = Convert.ToInt32(txtCantidad.Text)* Convert.ToDecimal(txtPrecioUnitario.Text);
                    detalles.FK_compra = id;

                    db.DetallesCompras.Add(detalles);
                    db.SaveChanges();
                    CargarDatos();
                    Limpiar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar los detalles a la compra.\n\n" + ex.ToString());

            }
        }

        private void Limpiar()
        {
            txtCantidad.Clear();
            txtPrecioUnitario.Clear();
            txtDescripcion.Clear();
        }

        private void FrmDetallesCompras_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void btnCerrarAplicacion_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
