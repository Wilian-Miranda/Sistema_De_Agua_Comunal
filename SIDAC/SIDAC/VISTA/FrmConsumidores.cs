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
    public partial class FrmConsumidores : Form
    {
        public FrmConsumidores()
        {
            InitializeComponent();
            cbEstado.Items.Add("1");
            cbEstado.Items.Add("0");
        }

        private void FrmConsumidores_Load(object sender, EventArgs e)
        {
            MostrarConsumidores();
        }
        #region Metodos CRUD
        //mostrar
        private void MostrarConsumidores()
        {
            CDConsumidores consumidores = new CDConsumidores();
            if (rbActivos.Checked) {
                //cargando datos a la tabla de consumidores
                dtgConsumidores.Rows.Clear();
                foreach (var i in consumidores.MostrarConsumidoresDefault())
                {
                    dtgConsumidores.Rows.Add(i.Código, i.Nombre, i.Apellido, i.Teléfono, i.Correo_Electrónico, i.Estado);
                }
                txtID.Text = (consumidores.MostrarConsumidores().Count() + 1).ToString();
            }
            else if (rbTodos.Checked)
            {
                //cargando datos a la tabla de consumidores
                dtgConsumidores.Rows.Clear();
                foreach (var i in consumidores.MostrarConsumidores())
                {
                    dtgConsumidores.Rows.Add(i.idConsumidor, i.nombres, i.apellidos, i.telefono, i.correo, i.estado);
                }
                txtID.Text = (consumidores.MostrarConsumidores().Count() + 1).ToString();
            }
        }

        //Agregar consumidor
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            CDConsumidores consumidores = new CDConsumidores();

            //cargando datos al objeto consumidor
            Consumidores consumidores1 = new Consumidores();
            consumidores1.idConsumidor = Convert.ToInt32(txtID.Text);
            consumidores1.nombres = txtNombres.Text;
            consumidores1.apellidos = txtApellidos.Text;
            consumidores1.telefono = txtTelefono.Text;
            consumidores1.correo = txtCorreo.Text;
            consumidores1.estado = Convert.ToInt32(cbEstado.Text);

            //guardando datos
            consumidores.AgregarConsumidor(consumidores1);
            Limpiar();

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            CDConsumidores consumidores = new CDConsumidores();

            //cargando datos al objeto consumidor
            Consumidores consumidores1 = new Consumidores();
            consumidores1.idConsumidor = Convert.ToInt32(txtID.Text);
            consumidores1.nombres = txtNombres.Text;
            consumidores1.apellidos = txtApellidos.Text;
            consumidores1.telefono = txtTelefono.Text;
            consumidores1.correo = txtCorreo.Text;
            consumidores1.estado = Convert.ToInt32(cbEstado.Text);

            //guardando datos
            consumidores.ActualizarConsumidor(consumidores1);
            Limpiar();
        }
        //eliminar
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dtgConsumidores.Rows.Count>0)
            {
                CDConsumidores consumidores = new CDConsumidores();
                consumidores.EliminarConsumidor(Convert.ToInt32(txtID.Text));
            }
            Limpiar();
        }
        #endregion
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
            btnAgregar.Enabled =true;

        }

        private void dtgConsumidores_DoubleClick(object sender, EventArgs e)
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
        }

        private void pnlNuevoConsumidor_DoubleClick(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void rbActivos_CheckedChanged(object sender, EventArgs e)
        {
            MostrarConsumidores();
        }

        private void rbTodos_CheckedChanged(object sender, EventArgs e)
        {
            MostrarConsumidores();
        }

        private void pnlTablaConsumidores_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlConsumidores_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlEncabezadoNuevoConsumidor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pnlEncabezadoConsumidores_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pnlNuevoConsumidor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlEliminar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblId_Click(object sender, EventArgs e)
        {

        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombres_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtApellidos_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtCorreo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void cbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
