using SIDAC.DAO;
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
    public partial class FrmInventario : Form
    {
        public FrmInventario()
        {
            InitializeComponent();
            MostrarInventario(0);
            txtFecha.Text = DateTime.Today.ToString();

        }
        CDInventarios clsD_inventario = new CDInventarios();
        private void MostrarInventario(int valor)
        {
            //0=> inventario en stock
            if (valor == 0)
            {
                // rdAgregarInventario.Enabled = false;
                //rdAgregarInventario.Checked = false;
                rdRetirarInventario.Checked = true;
                rdRetirarInventario.Enabled = true;
                clsD_inventario.MostrarInventarios_EnStock(this.dtgInventario, this.lblTotal, "En Stock");
            }
            else if (valor == 1)
            {

                    rdAgregarInventario.Enabled = true;
                    rdAgregarInventario.Checked = true;
                    rdRetirarInventario.Checked = false;
                    rdRetirarInventario.Enabled = false;
                clsD_inventario.MostrarInventario_Agotado(this.dtgInventario, this.lblTotal, "Agotados");
            }
        }

        

        private void btnDesplagarMenu_Click(object sender, EventArgs e)
        {
            if (pnlRetiroInventario.Width==10)
            {
                pnlRetiroInventario.Enabled = true;
                pnlRetiroInventario.Width = 400;
            }
            else if (pnlRetiroInventario.Width == 400)
            {
                pnlRetiroInventario.Width = 10;
                pnlRetiroInventario.Enabled = false;
                txtCantidad.Enabled = false;
            }
        }

        private void dtgInventario_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (rdRetirarInventario.Checked==true)
            {
                txtCantidad.Maximum = Convert.ToDecimal(dtgInventario.CurrentRow.Cells[2].Value) - Convert.ToDecimal(dtgInventario.CurrentRow.Cells[6].Value);
                txtMaterial.Text = dtgInventario.CurrentRow.Cells[3].Value.ToString();
                txtValor.Text = "$" + dtgInventario.CurrentRow.Cells[4].Value.ToString();
                txtTotal.Text = "$" + dtgInventario.CurrentRow.Cells[4].Value.ToString();
                txtCantidad.Enabled = true;
            }
            else if (rdAgregarInventario.Checked==true)
            {
                txtCantidad.Maximum = Convert.ToDecimal(dtgInventario.CurrentRow.Cells[6].Value);
                txtMaterial.Text = dtgInventario.CurrentRow.Cells[3].Value.ToString();
                txtValor.Text = "$" + dtgInventario.CurrentRow.Cells[4].Value.ToString();
                txtTotal.Text = "$" + dtgInventario.CurrentRow.Cells[4].Value.ToString();
                txtCantidad.Enabled = true;
            }
        }

        private void txtCantidad_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (!txtMaterial.Text.Equals(""))
                {
                    txtTotal.Text = "$" + ((decimal)dtgInventario.CurrentRow.Cells[4].Value * (decimal)txtCantidad.Value).ToString();
                }

            }
            catch (Exception)
            {

            }
        }

        private void btnRealizarRetiro_Click(object sender, EventArgs e)
        {
            if (rdRetirarInventario.Checked==true)
            {
                if (dtgInventario.SelectedRows.Count > 0)
                {
                    if (!txtMaterial.Text.Equals(""))
                    {
                        try
                        {
                            int id = Convert.ToInt32(dtgInventario.CurrentRow.Cells[0].Value);
                            using (SIDACEntities db = new SIDACEntities())
                            {
                                var item = db.Inventarios.Where(x => x.Idinventario == id).FirstOrDefault();
                                item.Utilizado = Convert.ToInt32(dtgInventario.CurrentRow.Cells[6].Value) + Convert.ToInt32(txtCantidad.Text);
                                db.SaveChanges();
                                RetiroInventarioRegistro();
                                MostrarInventario(0);
                            }

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error a retirar el material.\n\n" + ex.ToString());
                        }
                    }
                    else
                    {
                        MessageBox.Show("Elija el material a retirar.");
                    }
                }
            }
            else if (rdAgregarInventario.Checked==true)
            {
                if (dtgInventario.SelectedRows.Count > 0)
                {
                    if (!txtMaterial.Text.Equals(""))
                    {
                        try
                        {
                            int id = Convert.ToInt32(dtgInventario.CurrentRow.Cells[0].Value);
                            using (SIDACEntities db = new SIDACEntities())
                            {
                                var item = db.Inventarios.Where(x => x.Idinventario == id).FirstOrDefault();
                                item.Utilizado = Convert.ToInt32(dtgInventario.CurrentRow.Cells[6].Value) - Convert.ToInt32(txtCantidad.Text);
                                db.SaveChanges();
                                AgregarInventarioRegistro();
                                MostrarInventario(0);
                            }

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error a agregar nuevo material.\n\n" + ex.ToString());
                        }
                    }
                    else
                    {
                        MessageBox.Show("Elija el material a agregar.");
                       
                    }
                }
            }

            limpiar();

        }

        private void limpiar()
        {
            txtCantidad.Minimum = 1;
            txtCantidad.Value = 1;
            txtCantidad.Enabled = false;
            txtMaterial.Clear();
            txtMotivo.Clear();
            txtValor.Clear();
            txtTotal.Clear();
            txtFecha.Text = DateTime.Today.ToString();
        }
        private void RetiroInventarioRegistro()
        {
            try
            {

                using (SIDACEntities db = new SIDACEntities())
                {
                    RetirosInventario retiro = new RetirosInventario();
                    retiro.cantidad = "(-)" + txtCantidad.Value.ToString();
                    retiro.descripcion = txtMaterial.Text;
                    retiro.precioUnidad = txtValor.Text;
                    retiro.subtotal = txtTotal.Text;
                    retiro.motivo = "Retiro: " + txtMotivo.Text;
                    retiro.date = txtFecha.Text;
                    db.RetirosInventario.Add(retiro);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al archivar registro de retiro de material.\n\n" + ex.ToString());
            }


        }

        private void AgregarInventarioRegistro()
        {
            string material = txtMaterial.Text;
            try
            {

                using (SIDACEntities db = new SIDACEntities())
                {
                    RetirosInventario retiro = new RetirosInventario();
                    retiro.cantidad = "(+)"+txtCantidad.Value.ToString();
                    retiro.descripcion =txtMaterial.Text;
                    retiro.precioUnidad = txtValor.Text;
                    retiro.subtotal = txtTotal.Text;
                    retiro.motivo = "Agregar: " + txtMotivo.Text;
                    retiro.date = txtFecha.Text;
                    db.RetirosInventario.Add(retiro);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al archivar registro de ingreso de material.\n\n" + ex.ToString());
            }

        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            MostrarInventario(0);
            btnRealizarRetiro.Text = "Retirar material";
        }

        private void btnAgotados_Click(object sender, EventArgs e)
        {
            MostrarInventario(1);
            btnRealizarRetiro.Text = "Agregar material";
        }

        private void rdRetirarInventario_CheckedChanged(object sender, EventArgs e)
        {
            limpiar();
        }

        private void rdAgregarInventario_CheckedChanged(object sender, EventArgs e)
        {
            limpiar();
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            FrmRegistrosInventario registros = new FrmRegistrosInventario();
            registros.ShowDialog();
        }
    }
}
