using System;
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

namespace SIDAC.VISTA
{
    public partial class FrmControlPagos : Form
    {
        public FrmControlPagos()
        {
            InitializeComponent();
            txtFecha.Text = DateTime.Now.ToString();
        }
        private void CargarEstados()
        {
            using (SIDACEntities db = new SIDACEntities())
            {
                var consulta = (from a in db.Estados
                                select a).ToList();

                cbEstado.DataSource = consulta.ToList();
                cbEstado.DisplayMember = "nombre";
                cbEstado.ValueMember = "idEstado";
            }
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (pnlNuevoPago.Width==400)
            {
                pnlNuevoPago.Width= 30;
                pnlNuevoPago.Visible = false;
            }
            else
            {
                pnlNuevoPago.Width = 400;
                pnlNuevoPago.Visible = true;
            }
        }

        private void FrmControlPagos_Load(object sender, EventArgs e)
        {
            MostrarPagos();
            CargarEstados();
        }

        #region CRUD PAGOS
        public void MostrarPagos()
        {
            CDControlPagos pago = new CDControlPagos();
            if (rbPendientes.Checked)
            {
                dtgPagos.Rows.Clear();
                foreach (var i in pago.MostrarPagosDefault())
                {
                    dtgPagos.Rows.Add(i.Código,i.Nombre,i.Mes,i.Monto_base,i.Cancelado,
                                        i.Pendiente,i.Descripción,i.Estado,i.Fecha);
                }
            }
            else if (rbTodos.Checked)
            {
                dtgPagos.Rows.Clear();
                foreach (var i in pago.MostrarPagos())
                {
                    dtgPagos.Rows.Add(i.Código, i.Nombre, i.Mes, i.Monto_base, i.Cancelado,
                                        i.Pendiente, i.Descripción, i.Estado, i.Fecha);
                }
            }
        }
        CDControlPagos pago = new CDControlPagos();
        //AGREGAR
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Pagos pago1 = new Pagos();
            pago1.montoBase = Convert.ToDecimal(txtMontoBase.Text);
            pago1.montoCancelado = Convert.ToDecimal(txtCancelado.Text);
            pago1.descripcion = txtDescripcion.Text;
            pago1.fecha = Convert.ToDateTime(txtFecha.Text);
            pago1.FK_estado = Convert.ToInt32(cbEstado.SelectedValue.ToString());
            pago1.FK_consumidor = Convert.ToInt32(txtID.Text);

            pago.RegistrarPago(pago1);

            MostrarPagos();
            Limpiar();
        }
        //modificar
        private void btnModificar_Click(object sender, EventArgs e)
        {
            Pagos pago1 = new Pagos();
            pago1.montoCancelado = Convert.ToDecimal(txtCancelado.Text);
            pago1.descripcion = txtDescripcion.Text;
            pago1.FK_estado = Convert.ToInt32(cbEstado.SelectedValue.ToString());
            pago1.idPago = Convert.ToInt32(txtIdPago.Text);

            pago.ActualizarPago(pago1);
            MostrarPagos();
            Limpiar();
        }
        //eliminar
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            pago.EliminarPago(Convert.ToInt32(txtIdPago.Text));
            MostrarPagos();
            Limpiar();

        }
        #endregion

        private void rbTodos_CheckedChanged(object sender, EventArgs e)
        {
            MostrarPagos();
            pnlNuevoPago.Enabled = false;
            //cbEstado.Enabled = true;
            //btnAgregar.Visible = false;
            //btnEliminar.Visible = false;
        }

        private void rbPendientes_CheckedChanged(object sender, EventArgs e)
        {
            MostrarPagos();
            pnlNuevoPago.Enabled = true;
            //cbEstado.Enabled = true;
            //btnAgregar.Visible = true;
            //btnEliminar.Visible = true;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            BuscarConsumidor(cbConsumidor.Text);
        }
        private void BuscarConsumidor(String nombre)
        {
            using (SIDACEntities db = new SIDACEntities())
            {
                var consulta = (from a in db.Consumidores
                                where a.nombres.ToLower().Contains(nombre) 
                                      || a.apellidos.ToLower().Contains(nombre)
                                      || (a.nombres + " " + a.apellidos).Contains(nombre)
                                select new
                                {
                                    a.idConsumidor,
                                    nombreCompleto = a.nombres + " " + a.apellidos
                                }
                                 ).ToList();

                cbConsumidor.DataSource = consulta.ToList();
                cbConsumidor.DisplayMember = "nombreCompleto";
                cbConsumidor.ValueMember = "idConsumidor";
            }

        }

        private void cbConsumidor_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarConsumidorBuscado();
        }

        private void CargarConsumidorBuscado()
        {
            if (cbConsumidor.SelectedValue != null)
            {
                String id = cbConsumidor.SelectedValue.ToString();
                using (SIDACEntities db = new SIDACEntities())
                {
                    var consulta = (from a in db.Consumidores
                                    where a.idConsumidor.ToString() == id
                                    select a).ToList();

                    foreach (var i in consulta)
                    {
                        txtID.Text = i.idConsumidor.ToString();
                        txtApellidos.Text = i.apellidos;
                        txtNombres.Text = i.nombres;
                    }
                }
            }
        }
        private void txtCancelado_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPendiente.Text = (Convert.ToDecimal(txtMontoBase.Text)- Convert.ToDecimal(txtCancelado.Text)).ToString();
            }
        }

        private void dtgPagos_DoubleClick(object sender, EventArgs e)
        {
            cbConsumidor.Text = dtgPagos.CurrentRow.Cells[1].Value.ToString();
            btnBuscar.PerformClick();
            txtIdPago.Text = dtgPagos.CurrentRow.Cells[0].Value.ToString();
            txtMontoBase.Text = dtgPagos.CurrentRow.Cells[3].Value.ToString();
            txtCancelado.Text = dtgPagos.CurrentRow.Cells[4].Value.ToString();
            txtPendiente.Text = dtgPagos.CurrentRow.Cells[5].Value.ToString();
            txtDescripcion.Text = dtgPagos.CurrentRow.Cells[6].Value.ToString();
            cbEstado.Text = dtgPagos.CurrentRow.Cells[7].Value.ToString();
            txtFecha.Text = dtgPagos.CurrentRow.Cells[8].Value.ToString();

            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;
            btnAgregar.Enabled = false;
            lblIdPago.Visible = true;
            txtIdPago.Visible = true;

            txtMontoBase.Enabled = false;
            txtFecha.Enabled = false;
            cbConsumidor.Enabled = false;
            txtNombres.Enabled = false;
            txtApellidos.Enabled = false;

        }

        private void pnlEncabezadoNuevoPago_DoubleClick(object sender, EventArgs e)
        {
            Limpiar();
        }
        private void Limpiar()
        {
            cbConsumidor.ResetText();
            txtID.Clear();
            txtNombres.Clear();
            txtApellidos.Clear();
            txtIdPago.Clear();
            txtMontoBase.Clear();
            txtCancelado.Clear();
            txtPendiente.Clear();
            txtDescripcion.Clear();
            cbEstado.ResetText();
            txtFecha.Text = DateTime.Now.ToString();

            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
            btnAgregar.Enabled = true;
            lblIdPago.Visible = false;
            txtIdPago.Visible = false;

            txtMontoBase.Enabled = true;
            txtFecha.Enabled = true;
            cbConsumidor.Enabled = true;
            txtNombres.Enabled = true;
            txtApellidos.Enabled = true;
        }


    }
}
