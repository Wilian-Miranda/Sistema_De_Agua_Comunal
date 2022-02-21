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
using SIDAC.VALIDACIONES;

namespace SIDAC.VISTA
{
    public partial class FrmConsumidores : Form
    {
        public FrmConsumidores()
        {
            InitializeComponent();
            CargarDatosCBEstado();
            rbActivos.Checked = true;
        }

        private void FrmConsumidores_Load(object sender, EventArgs e)
        {
            MostrarConsumidores();
        }

        #region METODOS DE CARGA DE DATOS
        //rellenar el combobox de estados del formulario
        private void CargarDatosCBEstado()
        {
            using (SIDACEntities db = new SIDACEntities())
            {
                var estados = (from t in db.Estados
                               where t.identificador == 3
                               select t).ToList();
                cbEstado.DataSource = estados;
                cbEstado.DisplayMember = "nombre";
                cbEstado.ValueMember = "idEstado";
                cbEstado.SelectedIndex = -1;

            }
        }
        #endregion

        #region Metodos CRUD
        CDConsumidores clsD_consumidor = new CDConsumidores();
        Consumidores consumidor = new Consumidores();
        VsFrmConsumidores validador = new VsFrmConsumidores();
        //mostrar
        private void MostrarConsumidores()
        {
            if (rbActivos.Checked) {
                //cargando datos a la tabla de consumidores
                clsD_consumidor.MostrarConsumidoresActivos(this.dtgConsumidores, this.txtID, this.lblCantidadConsumidores);

            }

            if (rbInactivos.Checked)
            {
                //cargando datos a la tabla de consumidores
                clsD_consumidor.MostrarConsumidoresInactivos(this.dtgConsumidores, this.txtID, this.lblCantidadConsumidores);
            }
        }

        //Agregar consumidor
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (validador.ValidarCajas(validacion,this.txtApellidos,this.cbEstado,this.txtNombres))
            {
                //cargando datos al objeto consumidor
                consumidor.nombres = txtNombres.Text;
                consumidor.apellidos = txtApellidos.Text;
                consumidor.telefono = txtTelefono.Text;
                consumidor.correo = txtCorreo.Text;
                consumidor.Fk_estado = Convert.ToInt32(cbEstado.SelectedValue.ToString());

                //guardando datos
                clsD_consumidor.AgregarConsumidor(consumidor);
                Limpiar();
                LimpiarEntidad(consumidor);
            }


        }

        //MODIFICAR
        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (validador.ValidarCajas(validacion, this.txtApellidos, this.cbEstado, this.txtNombres))
            {
                //cargando datos al objeto consumidor
                consumidor.idConsumidor = Convert.ToInt32(txtID.Text);
                consumidor.nombres = txtNombres.Text;
                consumidor.apellidos = txtApellidos.Text;
                consumidor.telefono = txtTelefono.Text;
                consumidor.correo = txtCorreo.Text;
                consumidor.Fk_estado = Convert.ToInt32(cbEstado.SelectedValue.ToString());
                //guardando datos
                clsD_consumidor.ActualizarConsumidor(consumidor);

                Limpiar();
                LimpiarEntidad(consumidor);
            }
            
        }

        //ELIMINAR
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dtgConsumidores.Rows.Count>0)
            {
                clsD_consumidor.EliminarConsumidor(Convert.ToInt32(txtID.Text));
                Limpiar();
            }
            
        }
        #endregion

        #region RADIO_BOTONES
        private void rbActivos_CheckedChanged(object sender, EventArgs e)
        {
            MostrarConsumidores();
            Visible_Invisible_CajasFormulario();
        }

        private void rbTodos_CheckedChanged(object sender, EventArgs e)
        {
            MostrarConsumidores();
            Visible_Invisible_CajasFormulario();


        }
        #endregion

        #region RELLENAR CAJAS
        private void dtgConsumidores_DoubleClick(object sender, EventArgs e)
        {
            if (dtgConsumidores.SelectedRows.Count > 0)
            {
                txtID.Text = dtgConsumidores.CurrentRow.Cells[0].Value.ToString();
                txtNombres.Text = dtgConsumidores.CurrentRow.Cells[1].Value.ToString();
                txtApellidos.Text = dtgConsumidores.CurrentRow.Cells[2].Value.ToString();
                txtTelefono.Text = dtgConsumidores.CurrentRow.Cells[3].Value.ToString();
                txtCorreo.Text = dtgConsumidores.CurrentRow.Cells[4].Value.ToString();
                cbEstado.Text = dtgConsumidores.CurrentRow.Cells[5].Value.ToString();

                lblId.Visible = true;
                txtID.Visible = true;
                btnModificar.Enabled = true;
                btnEliminar.Enabled = true;
                btnAgregar.Enabled = false;

                if (pnlNuevoConsumidor.Width == 10)
                {
                    pnlNuevoConsumidor.Visible = true;
                    pnlNuevoConsumidor.Enabled = true;
                    pnlNuevoConsumidor.Width = 300;
                }
            }
            else
            {
                MessageBox.Show("Seleccione un registro");
            }
        }
        #endregion

        #region MOSTRAR FORMULARIO
        private void btnAbrirFormulario_Click(object sender, EventArgs e)
        {
            if (pnlNuevoConsumidor.Width == 10)
            {
                pnlNuevoConsumidor.Enabled = true;
                pnlNuevoConsumidor.Width = 300;
            }
            else if (pnlNuevoConsumidor.Width == 300)
            {
                pnlNuevoConsumidor.Enabled = true;
                pnlNuevoConsumidor.Width = 10;
            }
        }

        private void Visible_Invisible_CajasFormulario()
        {
            if (rbActivos.Checked)
            {
                txtID.Enabled = true;
                txtNombres.Enabled = true;
                txtApellidos.Enabled = true;
                txtTelefono.Enabled = true;
                txtCorreo.Enabled = true;

                btnAgregar.Enabled = true;
            }
            else
            {
                txtID.Enabled = false;
                txtNombres.Enabled = false;
                txtApellidos.Enabled = false;
                txtTelefono.Enabled = false;
                txtCorreo.Enabled = false;

                btnAgregar.Enabled = false;
            }

        }

        #endregion

        #region OTROS METODOS
        private void Limpiar()
        {
            MostrarConsumidores();
            txtApellidos.Clear();
            txtNombres.Clear();
            txtCorreo.Clear();
            txtTelefono.Clear();
            cbEstado.SelectedIndex = -1;

            lblId.Visible = false;
            txtID.Visible = false;
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
            btnAgregar.Enabled = true;

        }

        private void LimpiarEntidad(Consumidores consumidor)
        {
            consumidor.idConsumidor = 0;
            consumidor.nombres = string.Empty;
            consumidor.apellidos = string.Empty;
            consumidor.correo = string.Empty;
            consumidor.Fk_estado = 0;
            consumidor.telefono = string.Empty;

        }
        private void pnlNuevoConsumidor_DoubleClick(object sender, EventArgs e)
        {
            Limpiar();
        }
        #endregion

        private void dtgConsumidores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
