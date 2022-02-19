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

        CDCompras ClsD_Compras = new CDCompras();
        private void FrmCompras_Load(object sender, EventArgs e)
        {
            ClsD_Compras.MostrarCompras(this.dtgCompras, this.txtNumeroCompra);
            ClsD_Compras.TotalCompras(this.lblTotalCompras);
        }
        #region Validaciones
        private Boolean ValidarCajas()
        {
            Boolean validacion = true;

            validadorCampos.SetError(txtProveedor, "");
            validadorCampos.SetError(txtIdProyecto, "");
            validadorCampos.SetError(txtNombreProyecto, "");
            validadorCampos.SetError(txtValor, "");
            validadorCampos.SetError(txtFecha, "");
            validadorCampos.SetError(ptrFactura, "");

            if (txtProveedor.Text.Equals(""))
            {
                validadorCampos.SetError(txtProveedor, "Este campo es obligatorio.");
                validacion = false;
            }

            if (txtIdProyecto.Text.Equals(""))
            {
                validadorCampos.SetError(txtIdProyecto, "Este campo es obligatorio.");
                validacion = false;
            }

            if (txtNombreProyecto.Text.Equals(""))
            {
                validadorCampos.SetError(txtNombreProyecto, "Este campo es obligatorio.");
                validacion = false;
            }

            if (txtValor.Text.Equals(""))
            {
                validadorCampos.SetError(txtValor, "Este campo es obligatorio.");
                validacion = false;
            }
            else
            {
                try
                {
                    decimal valor = Convert.ToDecimal(txtValor.Text);
                    if (valor <= 0)
                    {
                        validadorCampos.SetError(txtValor, "Solo valores positivos son permitidos.");
                        validacion = false;
                    }
                    //validadorCampos.SetError(txtValor, "");
                    //validacion = true;
                }
                catch (Exception ex)
                {
                    validadorCampos.SetError(txtValor, "Valor no válido.");
                    validacion = false;
                }
            }

            if (txtFecha.Text.Equals(""))
            {
                validadorCampos.SetError(txtFecha, "Este campo es obligatorio.");
                validacion = false;
            }

            if (ptrFactura.Image == null)
            {
                validadorCampos.SetError(ptrFactura, "La imagen de factura es obligatoria.");
                validacion = false;
            }

            return validacion; 
        }

        #endregion 

        #region CRUD COMPRAS

        private void btnRealizarCompra_Click(object sender, EventArgs e)
        {

            if (btnGuardar.Text.Equals("Guardar") && ValidarCajas() == true)
            {
                Compras guardar = new Compras();
                guardar.compra = Convert.ToInt32(txtNumeroCompra.Text);
                guardar.proveedor = txtProveedor.Text;
                guardar.Fk_idProyecto = Convert.ToInt32(cbYear.SelectedValue.ToString());
                guardar.valor = Convert.ToDecimal(txtValor.Text);
                guardar.fecha = Convert.ToDateTime(txtFecha.Text);
                guardar.foto = ConvertirImagen();

                ClsD_Compras.GuardarRegistroCompra(guardar, this.dtgCompras, this.txtNumeroCompra, this.lblTotalCompras);

                Limpiar();

            }
            else if (btnGuardar.Text.Equals("Actualizar") && ValidarCajas() == true)
            {
                Compras actualizar = new Compras();

                actualizar.compra = Convert.ToInt32(txtNumeroCompra.Text);
                actualizar.proveedor = txtProveedor.Text;
                actualizar.Fk_idProyecto = Convert.ToInt32(txtIdProyecto.Text);
                actualizar.valor = Convert.ToDecimal(txtValor.Text);
                actualizar.fecha = Convert.ToDateTime(txtFecha.Text);
                actualizar.foto = ConvertirImagen();

                ClsD_Compras.ActualizarRegistroCompra(actualizar, this.dtgCompras, this.txtNumeroCompra, this.lblTotalCompras);

                Limpiar();
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dtgCompras.SelectedRows.Count > 0)
            {
                ClsD_Compras.EliminarRegistroCompra(this.dtgCompras, this.txtNumeroCompra, this.lblTotalCompras);
            }
            else
            {
                MessageBox.Show("Para eliminar un registro de compra, debe anteriormente seleccionar uno.");
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

                pnlNuevoCompra.Enabled = true;
                pnlNuevoCompra.Width = 400;
                lblCompras.Visible = false;
                lblTotalCompras.Visible = false;


                btnGuardar.Text = "Actualizar";
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

            btnGuardar.Text = "Guardar";

            ClsD_Compras.NumeroCompra(this.txtNumeroCompra);
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
                lblCompras.Visible = true;
                lblTotalCompras.Visible = true;
            }
            else
            {
                //pnlNuevoCompra.Visible = true;
                pnlNuevoCompra.Enabled = true;
                pnlNuevoCompra.Width = 400;
                lblCompras.Visible = false;
                lblTotalCompras.Visible = false;
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
