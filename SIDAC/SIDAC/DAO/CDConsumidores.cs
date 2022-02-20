using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using SIDAC.MODELO;

namespace SIDAC.DAO
{
    class CDConsumidores
    {
        #region CRUD  
        //mostrar consumidores activos
        public void MostrarConsumidoresActivos(Guna2DataGridView dtgConsumidores, Guna2TextBox txtID, Label lblCantidadConsumidores)
        {
            using(SIDACEntities db = new SIDACEntities())
            {
                dtgConsumidores.Rows.Clear();
                foreach (var i in db.sp_MostrarConsumidoresDefault().ToList())
                {
                    dtgConsumidores.Rows.Add(i.idConsumidor, i.nombres, i.apellidos, i.telefono, i.correo, i.nombre);

                }
                lblCantidadConsumidores.Text = db.sp_MostrarConsumidoresDefault().ToList().Count().ToString() + " consumidores";
                txtID.Text = (db.sp_MostrarConsumidoresDefault().Count() + 1).ToString();
            }
        }
        //mostrar consumidores inactivos
        public void MostrarConsumidoresInactivos(Guna2DataGridView dtgConsumidores, Guna2TextBox txtID, Label lblCantidadConsumidores)
        {
            using (SIDACEntities db = new SIDACEntities())
            {
                dtgConsumidores.Rows.Clear();
                foreach (var i in db.sp_MostrarConsumidores().ToList())
                {
                    dtgConsumidores.Rows.Add(i.idConsumidor, i.nombres, i.apellidos, i.telefono, i.correo, i.nombre);

                }
                txtID.Text = (db.sp_MostrarConsumidores().ToList().Count() + 1).ToString();
                lblCantidadConsumidores.Text = db.sp_MostrarConsumidores().ToList().Count().ToString() + " consumidores";
            }
        }

        //Insertar
        public void AgregarConsumidor(Consumidores consumidor)
        {
            try
            {
                using (SIDACEntities db = new SIDACEntities())
                {
                    db.sp_InsertarConsumidor(consumidor.nombres,consumidor.apellidos,consumidor.telefono,consumidor.correo,consumidor.Fk_estado);
                    db.SaveChanges();
                    MessageBox.Show("Consumidor agregado existosamente.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar.\n\n"+ex.ToString());
            }
        }

        //actualizar
        public void ActualizarConsumidor(Consumidores consumidor)
        {
            try
            {
                using (SIDACEntities db = new SIDACEntities())
                {
                    db.sp_ActualizarConsumidor(consumidor.idConsumidor, consumidor.nombres, consumidor.apellidos,
                                               consumidor.telefono, consumidor.correo, consumidor.Fk_estado);
                    db.SaveChanges();
                    MessageBox.Show("Consumidor modificado existosamente.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar.\n\n" + ex.ToString());
            }
        }

        //eliminar
        public void EliminarConsumidor(int id)
        {
            try
            {
                using (SIDACEntities db = new SIDACEntities())
                {
                    db.sp_EliminarConsumidor(id);
                    db.SaveChanges();
                    MessageBox.Show("Consumidor eliminado existosamente.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar.\n\n" + ex.ToString());
            }
        }
        #endregion

    }
}
