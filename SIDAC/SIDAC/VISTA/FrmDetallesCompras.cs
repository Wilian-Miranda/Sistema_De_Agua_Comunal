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
using SIDAC.DAO;
using SIDAC.MODELO;
using SIDAC.VALIDACIONES;

namespace SIDAC.VISTA
{
    public partial class FrmDetallesCompras : Form
    {
        public FrmDetallesCompras()
        {
            InitializeComponent();
            
        }
        public int ID;
        CDDetallesCompras ClsD_DetallesCompra = new CDDetallesCompras();
        DetallesCompras detalles = new DetallesCompras();
        CDDetallesCompras clsD_Detalles = new CDDetallesCompras();
        VsFrmDetallesCompras validador = new VsFrmDetallesCompras();
        #region CRUD

        //Actualizar
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (validador.ValidarCajas(validadorCajas,this.txtCantidad,this.txtPrecioUnitario,this.txtDescripcion))
            {
                int id = ID;//id de compra

                detalles.cantidad = Convert.ToInt32(txtCantidad.Text);
                detalles.descripcion = txtDescripcion.Text;
                detalles.precioUnitario = Convert.ToDecimal(txtPrecioUnitario.Text);
                detalles.total = Convert.ToInt32(txtCantidad.Text) * Convert.ToDecimal(txtPrecioUnitario.Text);
                detalles.FK_compra = id;

                clsD_Detalles.AgregarDetalleDeCompra(detalles);

                ClsD_DetallesCompra.MostrarDetallesCompra(ID, this.dtgDetallesCompras, this.txtValor, this.lblTotal);
                Limpiar();
            }

        }

        //eliminar
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dtgDetallesCompras.SelectedRows.Count > 0)
            {
                ClsD_DetallesCompra.EliminarDetalleCompra(this.dtgDetallesCompras);
                ClsD_DetallesCompra.MostrarDetallesCompra(ID, this.dtgDetallesCompras, this.txtValor, this.lblTotal);
            }
        }
        #endregion

        #region Carga de datos 
        private void FrmDetallesCompras_Load(object sender, EventArgs e)
        {
            ClsD_DetallesCompra.MostrarDetallesCompra(ID, this.dtgDetallesCompras, this.txtValor, this.lblTotal);
        }
        #endregion

        #region Otros
        private void Limpiar()
        {
            txtCantidad.Clear();
            txtPrecioUnitario.Clear();
            txtDescripcion.Clear();
        }

        private void btnCerrarAplicacion_Click(object sender, EventArgs e)
        {
            ClsD_DetallesCompra.VerificarDetallesAlCerrar(this, dtgDetallesCompras, txtValor);

        }

        int posicionX = 0;
        int posicionY = 0;
        private void pnlSeleccioFormulario_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                posicionX = e.X;
                posicionY = e.Y;
            }
            else
            {
                Left += e.X - posicionX;
                Top += e.Y - posicionY;
            }
        }
        #endregion

        #region Validaciones


        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtPrecioUnitario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar) || char.Parse(".")==e.KeyChar)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        #endregion
    }
}
