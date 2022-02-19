using SIDAC.MODELO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using System.Drawing;

namespace SIDAC.DAO
{
    class CDDetallesCompras
    {
        #region CRUD
        //mostrar Detalles
        public void MostrarDetallesCompra(int id, Guna2DataGridView dtgDetallesCompras, Guna2TextBox txtValor, Label lblTotal)
        {
            dtgDetallesCompras.Rows.Clear();
            using (SIDACEntities db = new SIDACEntities())
            {
                var detalles = db.DetallesCompras.Where(x => x.FK_compra == id);

                foreach (var i in detalles)
                {
                    dtgDetallesCompras.Rows.Add(i.idDetalleCompras, i.cantidad, i.descripcion, i.precioUnitario, i.total);
                }

                var total = (from a in db.DetallesCompras
                             where a.FK_compra == id
                             select a.total).ToList();

                if (total.Sum() > Convert.ToDecimal(txtValor.Text))
                {
                    lblTotal.ForeColor = Color.Red;
                    lblTotal.Text = "Las cantidades ingresadas exceden en valor total declarado en la factura. Revise los datos.";
                }
                else
                {
                    lblTotal.ForeColor = Color.Black;
                    lblTotal.Text = "$" + total.Sum().ToString() + "  |" + "  Total establecido: $" + txtValor.Text + "  |" + "  Diferencia: $" +
                        (Convert.ToDecimal(txtValor.Text) - total.Sum()).ToString();
                }

            }
        }
        //agregar dettale a la compra
        public void AgregarDetalleDeCompra(DetallesCompras detalles)
        {
            try
            {
                using (SIDACEntities db = new SIDACEntities())
                {
                    db.DetallesCompras.Add(detalles);
                    db.SaveChanges();
                    //CargarDatos();
                    //Limpiar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar los detalles a la compra.\n\n" + ex.ToString());

            }
        }

        //Eliminar
        public void EliminarDetalleCompra(Guna2DataGridView dtgDetallesCompras)
        {
            try
            {
                //Eliminar primero en el inventario
                int id = Convert.ToInt32(dtgDetallesCompras.CurrentRow.Cells[0].Value.ToString());
                using (SIDACEntities db = new SIDACEntities())
                {

                    //eliminando detalle en inventario
                    var eliminarInventario = db.Inventarios.Where(x => x.FK_DetalleCompra == id).FirstOrDefault();
                    db.Inventarios.Remove(eliminarInventario);
                    db.SaveChanges();
                }

                //Luego eliminando en el detalle de compra
                using (SIDACEntities db = new SIDACEntities())
                {
                    //eliminando detalle en las compras
                    var eliminar = db.DetallesCompras.Where(x => x.idDetalleCompras == id).FirstOrDefault();
                    db.DetallesCompras.Remove(eliminar);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar detalle de compra.\n\n" + ex.ToString());
            }
        }
        #endregion

        #region Otros

        public void VerificarDetallesAlCerrar(Form form, Guna2DataGridView dtgDetallesCompras, Guna2TextBox txtValor)
        {
            decimal total = 0;
            for (int i = 0; i < dtgDetallesCompras.RowCount; i++)
            {
                total += Convert.ToDecimal(dtgDetallesCompras.Rows[i].Cells[4].Value);
            }

            if (Convert.ToDecimal(txtValor.Text) == total)
            {
                form.Close();
            }
            else
            {
                try
                {
                    for (int i = 0; i < dtgDetallesCompras.RowCount; i++)
                    {
                        //eliminar los detalles en el inventario
                        int id = Convert.ToInt32(dtgDetallesCompras.Rows[i].Cells[0].Value.ToString());
                        using (SIDACEntities db = new SIDACEntities())
                        {

                            //eliminando detalle en inventario
                            var eliminarInventario = db.Inventarios.Where(x => x.FK_DetalleCompra == id).FirstOrDefault();
                            db.Inventarios.Remove(eliminarInventario);
                            db.SaveChanges();
                        }
                    }

                    for (int i = 0; i < dtgDetallesCompras.RowCount; i++)
                    {
                        //eliminar los detalles de compras
                        int ID = Convert.ToInt32(dtgDetallesCompras.Rows[i].Cells[0].Value);
                        using (SIDACEntities db = new SIDACEntities())
                        {
                            var eliminarDetalles = db.DetallesCompras.Where(x => x.idDetalleCompras == ID).FirstOrDefault();
                            db.DetallesCompras.Remove(eliminarDetalles);
                            db.SaveChanges();
                        }
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Error al eliminar detalles no válidos.\n\n" + ex.ToString());
                }

                form.Close();
            }
        }

        #endregion

        #region Otros
        #endregion
    }
}
