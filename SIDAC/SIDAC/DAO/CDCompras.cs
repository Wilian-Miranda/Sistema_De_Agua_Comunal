using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SIDAC.MODELO;
using Guna.UI2.WinForms;

namespace SIDAC.DAO
{
    class CDCompras
    {
        #region CRUD
        //mostrar
        public void MostrarCompras(Guna2DataGridView dtgCompras, Guna2TextBox txtNumeroCompra)
        {
            try
            {
                using (SIDACEntities db = new SIDACEntities())
                {
                    dtgCompras.Rows.Clear();
                    var compras = db.sp_MostrarCompras().ToList();

                    if (compras.Count > 0)
                    {
                        foreach (var i in compras)
                        {
                            dtgCompras.Rows.Add(i.idCompra, i.compra, i.proveedor, i.valor, i.fecha, i.foto, i.idProyecto, i.nombre);
                        }
                    }
                    NumeroCompra(txtNumeroCompra);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la lista de compras.\n\n" + ex.ToString());
            }
        }

        //Agregar
        public void GuardarRegistroCompra(Compras guardar, Guna2DataGridView dtgCompras, Guna2TextBox txtNumeroCompra, Label lblTotalCompras)
        {
            try
            {
                using (SIDACEntities db = new SIDACEntities())
                {
                    db.Compras.Add(guardar);
                    db.SaveChanges();
                    MostrarCompras(dtgCompras, txtNumeroCompra);
                    TotalCompras(lblTotalCompras);
                    MessageBox.Show("Guardado");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar compra\n\n", ex.ToString());
            }
            
        }

        //Actualizar
        public void ActualizarRegistroCompra(Compras compra, Guna2DataGridView dtgCompras, Guna2TextBox txtNumeroCompra, Label lblTotalCompras)
        {
            try
            {
                using (SIDACEntities db = new SIDACEntities()) {

                    int id = Convert.ToInt32(dtgCompras.CurrentRow.Cells[0].Value);

                    var guardar = db.Compras.Where(x => x.idCompra == id).SingleOrDefault();

                    guardar.compra = Convert.ToInt32(txtNumeroCompra.Text);
                    guardar.proveedor = compra.proveedor;
                    guardar.Fk_idProyecto = compra.Fk_idProyecto;
                    guardar.valor = compra.valor;
                    guardar.fecha = compra.fecha;
                    guardar.foto = compra.foto;
                    db.SaveChanges();

                    MostrarCompras(dtgCompras, txtNumeroCompra);
                    TotalCompras(lblTotalCompras);
                    MessageBox.Show("Actualizado");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar/guardar compra\n\n", ex.ToString());
            }
        }

        //Eliminar
        public void EliminarRegistroCompra(Guna2DataGridView dtgCompras, Guna2TextBox txtNumeroCompra, Label lblTotalCompras)
        {
            try
            {
                using (SIDACEntities db = new SIDACEntities())
                {
                    //encontrando el id de la fila seleccionada
                    int id = Convert.ToInt32(dtgCompras.CurrentRow.Cells[0].Value);

                    var eliminar = db.Compras.Where(x => x.idCompra == id).FirstOrDefault();
                    db.Compras.Remove(eliminar);
                    db.SaveChanges();
                    MostrarCompras(dtgCompras, txtNumeroCompra);
                    TotalCompras(lblTotalCompras);
                    MessageBox.Show("Eliminado");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar compra\n\n", ex.ToString());
            }
        }
        #endregion

        #region Otros
        public void TotalCompras(Label lblTotalCompras)
        {
            try
            {
                using (SIDACEntities db = new SIDACEntities())
                {
                    var totalCompras = (from a in db.Compras
                                        select a.valor).ToList();

                    var totalMateriales = (from a in db.DetallesCompras
                                           select a.cantidad).ToList();


                    lblTotalCompras.Text = "$" + totalCompras.Sum().ToString() + " | " + "Materiales: " + totalMateriales.Sum().ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el total de las compras.\n\n" + ex.ToString());
            }
        }

        public void NumeroCompra(Guna2TextBox txtNumeroCompra)
        {
            try
            {
                using (SIDACEntities db = new SIDACEntities())
                {
                    var noCompras = (from a in db.Compras select a.compra).ToList();
                    if (noCompras.Count == 0)
                    {
                        txtNumeroCompra.Text = (0 + 1).ToString();
                    }
                    else
                    {
                        txtNumeroCompra.Text = (noCompras.Last() + 1).ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el total de las compras.\n\n" + ex.ToString());
            }
        }
        #endregion
    }
}
