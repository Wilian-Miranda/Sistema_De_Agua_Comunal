﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SIDAC.MODELO;

namespace SIDAC.DAO
{
    class CDConsumidores
    {
        //mostrar consumidores activos
        public List<sp_MostrarConsumidoresDefault_Result> MostrarConsumidoresDefault()
        {
            using(SIDACEntities db = new SIDACEntities())
            {
                return db.sp_MostrarConsumidoresDefault().ToList();
            }
        }
        //mostrar consumidores inactivos
        public List<sp_MostrarConsumidores_Result> MostrarConsumidores()
        {
            using (SIDACEntities db = new SIDACEntities())
            {
                return db.sp_MostrarConsumidores().ToList();
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

    }
}
