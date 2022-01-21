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

namespace SIDAC.VISTA
{
    public partial class FrmCompras : Form
    {
        public FrmCompras()
        {
            InitializeComponent();
            txtFecha.Value = DateTime.Today;
        }

        private void FrmCompras_Load(object sender, EventArgs e)
        {
            MostrarCompras();
            TotalCompras();
        }

        #region CRUD COMPRAS
        private void MostrarCompras()
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
                            dtgCompras.Rows.Add(i.idCompra,i.compra, i.proveedor, i.valor, i.fecha, i.foto, i.idProyecto, i.nombre);
                        }
                    }

                    var noCompras = (from a in db.Compras
                                   select a.compra).ToList();
                    if (compras.Count == 0)
                    {
                        txtNumeroCompra.Text = (0 + 1).ToString();
                    }
                    else
                    {
                        txtNumeroCompra.Text = (noCompras.Last() + 1).ToString();
                    }
                    

                    //dtgCompras.DataSource = compras.ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la lista de compras.\n\n" + ex.ToString());
            }

        }

        private void TotalCompras()
        {
            try
            {
                using(SIDACEntities db = new SIDACEntities())
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
        private void btnRealizarCompra_Click(object sender, EventArgs e)
        {
            try
            {
                using (SIDACEntities db = new SIDACEntities())
                {
                    if (btnRealizarCompra.Text.Equals("Agregar compra"))
                    {

                        Compras guardar = new Compras();
                        guardar.compra = Convert.ToInt32(txtNumeroCompra.Text);
                        guardar.proveedor = txtProveedor.Text;
                        guardar.Fk_idProyecto = Convert.ToInt32(cbYear.SelectedValue.ToString());
                        guardar.valor = Convert.ToDecimal(txtValor.Text);
                        guardar.fecha = Convert.ToDateTime(txtFecha.Text);
                        guardar.foto = ConvertirImagen();
                        db.Compras.Add(guardar);
                        db.SaveChanges();
                        MostrarCompras();
                        TotalCompras();
                        Limpiar();
                        MessageBox.Show("Guardado");

                    }
                    else if (btnRealizarCompra.Text.Equals("Actualizar"))
                    {
                        int id = Convert.ToInt32(dtgCompras.CurrentRow.Cells[0].Value);

                        var guardar = db.Compras.Where(x => x.idCompra == id).SingleOrDefault();

                        guardar.compra = Convert.ToInt32(txtNumeroCompra.Text);
                        guardar.proveedor = txtProveedor.Text;
                        guardar.Fk_idProyecto = Convert.ToInt32(cbYear.SelectedValue.ToString());
                        guardar.valor = Convert.ToDecimal(txtValor.Text);
                        guardar.fecha = Convert.ToDateTime(txtFecha.Text);
                        guardar.foto = ConvertirImagen();
                        db.SaveChanges();

                        MostrarCompras();
                        TotalCompras();
                        Limpiar();
                        MessageBox.Show("Actualizado");
                    }
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar/guardar compra\n\n", ex.ToString());
            }
        }
        private byte[] ConvertirImagen()
        {
            System.IO.MemoryStream imagenByte = new System.IO.MemoryStream();
            ptrFactura.Image.Save(imagenByte, System.Drawing.Imaging.ImageFormat.Png);
            return imagenByte.GetBuffer();
        }
        #endregion


        private void guna2DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                byte[] imagenFactura = (byte[])dtgCompras.CurrentRow.Cells[5].Value;

                VisualizarFactura visualizar = new VisualizarFactura();
                visualizar.ptrVisualizarFactura.Image = ByteAImagen(imagenFactura);
                visualizar.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al visualizar imagen.\n\n" + ex.ToString());
            }

        }

        private void ptrFactura_Click(object sender, EventArgs e)
        {
            OpenFileDialog buscarImagen = new OpenFileDialog();

            //Abrir el explorador de archivos.
            if (buscarImagen.ShowDialog() == DialogResult.OK)
            {
                ptrFactura.ImageLocation = buscarImagen.FileName;
                ptrFactura.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private void dtgCompras_DoubleClick(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
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
                    MostrarCompras();
                    TotalCompras();
                    MessageBox.Show("Eliminado");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar compra\n\n", ex.ToString());
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (dtgCompras.SelectedRows.Count>0)
            {
                txtNumeroCompra.Text = dtgCompras.CurrentRow.Cells[1].Value.ToString();
                txtProveedor.Text = dtgCompras.CurrentRow.Cells[2].Value.ToString();
                txtValor.Text = dtgCompras.CurrentRow.Cells[3].Value.ToString();
                byte[] img = (byte[])dtgCompras.CurrentRow.Cells[5].Value;
                ptrFactura.Image = ByteAImagen(img);
                txtIdProyecto.Text = dtgCompras.CurrentRow.Cells[6].Value.ToString();
                txtNombreProyecto.Text = dtgCompras.CurrentRow.Cells[7].Value.ToString();


                btnRealizarCompra.Text = "Actualizar";
            }
            else
            {
                MessageBox.Show("Seleccione una fila.");
            }
        }

        private Image ByteAImagen(byte[] img)
        {
            Image image = null;
            try
            {
                MemoryStream imagen = new MemoryStream(img);
                image= Image.FromStream(imagen);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al convertir los bytes en imagen.\n\n" + ex.ToString());
            }
            return image;
        }

        private void Limpiar()
        {
            txtFecha.Text = DateTime.Now.ToString();
            txtProveedor.Text = "";
            txtValor.Text = "";
            ptrFactura.Image = null;
            txtIdProyecto.Clear();
            txtNombreProyecto.Clear();
            cbYear.ResetText();
        }

        private void pnlEncabezadoNuevoCompra_DoubleClick(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnDesplagarMenu_Click(object sender, EventArgs e)
        {
            if (pnlNuevoCompra.Width==400)
            {
                //pnlNuevoCompra.Visible = false;
                pnlNuevoCompra.Width = 10;
                pnlNuevoCompra.Enabled = false;
            }
            else
            {
                //pnlNuevoCompra.Visible = true;
                pnlNuevoCompra.Enabled = true;
                pnlNuevoCompra.Width = 400;
            }
        }

        private void btnActualizar_DoubleClick(object sender, EventArgs e)
        {

        }

        private void btnAgregarDetalles_Click(object sender, EventArgs e)
        {
            FrmDetallesCompras detalles = new FrmDetallesCompras();

            detalles.ID = Convert.ToInt32(dtgCompras.CurrentRow.Cells[0].Value);
            detalles.txtNumeroCompra.Text = dtgCompras.CurrentRow.Cells[1].Value.ToString();
            detalles.txtProveedor.Text = dtgCompras.CurrentRow.Cells[2].Value.ToString();
            detalles.txtValor.Text = dtgCompras.CurrentRow.Cells[3].Value.ToString();
            detalles.txtFecha.Text = dtgCompras.CurrentRow.Cells[4].Value.ToString();


            detalles.ShowDialog();
        }

        CDProyectos ClsDProyectos = new CDProyectos();

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ClsDProyectos.MostrarProyectos_Year(cbYear.Text, this.cbYear);
        }

        private void cbYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbYear.SelectedIndex >=0)
            {
                txtNombreProyecto.Text = cbYear.Text;
                txtIdProyecto.Text = cbYear.SelectedValue.ToString();
            }
        }
    }
}
