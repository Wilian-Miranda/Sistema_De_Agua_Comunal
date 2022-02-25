using SIDAC.MODELO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Guna.UI2.WinForms;
using System.Windows.Forms;

namespace SIDAC.DAO
{
    internal class CDInventarios
    {
        //inventario en el almacen
        public void MostrarInventarios_EnStock(Guna2DataGridView dtgInventario, Label lblTotal, string filtro)
        {
            try
            {
                using (SIDACEntities db = new SIDACEntities())
                {
                    var inventario = db.sp_MostrarInventarios().Where(x => x.nombre == filtro).ToList();

                    dtgInventario.Rows.Clear();
                    foreach (var i in inventario)
                    {
                        dtgInventario.Rows.Add(i.Idinventario, i.compra, i.cantidad, i.descripcion, i.precioUnitario, i.total, i.Utilizado, i.nombre);
                    }

                    var totalMateriales = (from a in db.Inventarios
                                           join c in db.DetallesCompras on a.FK_DetalleCompra equals c.idDetalleCompras
                                           where a.FK_estado == 4
                                           select c.cantidad).ToList();

                    var totalValorMateriales = (from a in db.Inventarios
                                                join c in db.DetallesCompras on a.FK_DetalleCompra equals c.idDetalleCompras
                                                where a.FK_estado == 4
                                                select c.total).ToList();


                    lblTotal.Text = "TOTAL: Materiales: " + totalMateriales.Sum().ToString() + "  |  " + "Valor: $" + totalValorMateriales.Sum().ToString() + " || ACTUAL: " + "Materiales: " + CalculoInventarioActual(dtgInventario).ToString() + "  |  " + "Valor: $" + CalculoValorInventarioActual(dtgInventario).ToString(); ;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al mostrar el inventario disponible.\n\n" + ex.ToString());
            }
            
        }
        private double CalculoValorInventarioActual(Guna2DataGridView dtgInventario)
        {
            double valor = 0;

            for (int i = 0; i < dtgInventario.Rows.Count; i++)
            {
                valor += ((Convert.ToDouble(dtgInventario.Rows[i].Cells[2].Value)) - (Convert.ToDouble(dtgInventario.Rows[i].Cells[6].Value))) * Convert.ToDouble(dtgInventario.Rows[i].Cells[4].Value);
            }

            return valor;
        }
        private int CalculoInventarioActual(Guna2DataGridView dtgInventario)
        {
            int cantidad = 0;

            for (int i = 0; i < dtgInventario.Rows.Count; i++)
            {
                int num = Convert.ToInt32(dtgInventario.Rows[i].Cells[2].Value.ToString());
                int num2 = Convert.ToInt32(dtgInventario.Rows[i].Cells[6].Value.ToString());

                cantidad += (num) - (num2);
            }

            return cantidad;
        }

        //inventario agotado
        public void MostrarInventario_Agotado(Guna2DataGridView dtgInventario, Label lblTotal, string filtro)
        {
            try
            {

                using (SIDACEntities db = new SIDACEntities())
                {
                    var inventario = db.sp_MostrarInventarios().Where(x => x.nombre == filtro).ToList();

                    dtgInventario.Rows.Clear();
                    foreach (var i in inventario)
                    {
                        dtgInventario.Rows.Add(i.Idinventario, i.compra, i.cantidad, i.descripcion, i.precioUnitario, i.total, i.Utilizado, i.nombre);
                    }

                    var totalMateriales = (from a in db.Inventarios
                                           join c in db.DetallesCompras on a.FK_DetalleCompra equals c.idDetalleCompras
                                           where a.FK_estado == 3
                                           select c.cantidad).ToList();

                    var totalValorMateriales = (from a in db.Inventarios
                                                join c in db.DetallesCompras on a.FK_DetalleCompra equals c.idDetalleCompras
                                                where a.FK_estado == 3
                                                select c.total).ToList();


                    lblTotal.Text = "TOTAL: Materiales: " + totalMateriales.Sum().ToString() + "  |  " + "Valor: $" + totalValorMateriales.Sum().ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al mostrar el inventario utilizado.\n\n" + ex.ToString());
            }
        }
    }
    }
}
