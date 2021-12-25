﻿using System;
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
            CargarDatosCBEstado();
        }
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

            }
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
                    dtgConsumidores.Rows.Add(i.idConsumidor, i.nombres, i.apellidos, i.telefono, i.correo, i.nombre);
                   
                }
                lblCantidadConsumidores.Text = consumidores.MostrarConsumidoresDefault().Count().ToString() + " consumidores";
                txtID.Text = (consumidores.MostrarConsumidores().Count() + 1).ToString();

            }
            else if (rbInactivos.Checked)
            {
                //cargando datos a la tabla de consumidores
                dtgConsumidores.Rows.Clear();
                foreach (var i in consumidores.MostrarConsumidores())
                {
                    dtgConsumidores.Rows.Add(i.idConsumidor, i.nombres, i.apellidos, i.telefono, i.correo, i.nombre);

                }
                txtID.Text = (consumidores.MostrarConsumidores().Count() + 1).ToString();
                lblCantidadConsumidores.Text = consumidores.MostrarConsumidores().Count().ToString() + " consumidores";


            }
        }

        //Agregar consumidor
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            CDConsumidores consumidores = new CDConsumidores();

            //cargando datos al objeto consumidor
            Consumidores consumidores1 = new Consumidores();
            consumidores1.nombres = txtNombres.Text;
            consumidores1.apellidos = txtApellidos.Text;
            consumidores1.telefono = txtTelefono.Text;
            consumidores1.correo = txtCorreo.Text;
            consumidores1.Fk_estado = Convert.ToInt32(cbEstado.SelectedValue.ToString());

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
            consumidores1.Fk_estado = Convert.ToInt32(cbEstado.SelectedValue.ToString());
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
            if (dtgConsumidores.SelectedRows.Count>0)
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
            else
            {
                MessageBox.Show("Seleccione un registro");
            }
        }

        private void pnlNuevoConsumidor_DoubleClick(object sender, EventArgs e)
        {
            Limpiar();
        }

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
