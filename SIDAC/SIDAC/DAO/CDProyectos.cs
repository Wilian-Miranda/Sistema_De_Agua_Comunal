using SIDAC.MODELO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIDAC.DAO
{
    class CDProyectos
    {
        #region CRUD
        //mostrar
        public void MostrarProyectos(System.Windows.Forms.DataGridView dtgProyectos)
        {
            try
            {
                using (SIDACEntities db = new SIDACEntities())
                {
                    var proyectos = db.Proyectos.ToList();

                    dtgProyectos.Rows.Clear();
                    foreach (var i in proyectos)
                    {
                        dtgProyectos.Rows.Add(i.idProyecto, i.nombre, i.presupuesto, i.costo, i.costoMateriales,
                                                i.diasTrabajo, i.numeroTrabajadores, i.pagoTotalTrabajadores,
                                                i.fechaInicio, i.fechaFinalizado, i.descripcion);
                    }
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error al mostrar los Proyectos. \n\n" + ex.ToString());
            }
 
        }

        //guardar
        public void InsertarProyecto(Proyectos proyecto)
        {
            try
            {
                using (SIDACEntities db = new SIDACEntities())
                {
                    db.sp_InsertarProyecto(proyecto.nombre, proyecto.presupuesto, proyecto.costo, proyecto.costoMateriales,
                                            proyecto.diasTrabajo, proyecto.numeroTrabajadores, proyecto.pagoTotalTrabajadores,
                                            proyecto.fechaInicio, proyecto.fechaFinalizado, proyecto.descripcion);
                    db.SaveChanges();
                }

                System.Windows.Forms.MessageBox.Show("Proyecto agregado exitosamente.");

            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error al agregar nuevo proyecto. \n\n"+ ex.ToString());
            }

        }
        //actualizar
        public void ActualizarProyecto(Proyectos proyecto)
        {
            try
            {
                using (SIDACEntities db = new SIDACEntities())
                {
                    db.sp_ActualizarProyecto(proyecto.idProyecto,proyecto.nombre, proyecto.presupuesto,proyecto.costo,
                        proyecto.costoMateriales,proyecto.diasTrabajo, proyecto.numeroTrabajadores, 
                        proyecto.pagoTotalTrabajadores,proyecto.fechaInicio, proyecto.fechaFinalizado, proyecto.descripcion);
                    db.SaveChanges();
                }

                System.Windows.Forms.MessageBox.Show("Proyecto actualizado exitosamente.");

            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error al actualizar datos del proyecto. \n\n" + ex.ToString());
            }

        }
        public void EliminarProyecto(int idProyecto)
        {
            try
            {
                using (SIDACEntities db = new SIDACEntities())
                {
                    db.sp_EliminarProyecto(idProyecto);
                    db.SaveChanges();
                }

                System.Windows.Forms.MessageBox.Show("Proyecto eliminado exitosamente.");

            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error al eliminar proyecto. \n\n" + ex.ToString());
            }
        }
        #endregion

        #region Filtro por Años
        public void Ryears_Proyectos(Guna.UI2.WinForms.Guna2ComboBox cbFiltroYears)
        {
            using (SIDACEntities db = new SIDACEntities())
            {
                var years = db.sp_Ryear_Proyectos().ToList();

                if (years.Count > 0)
                {
                    cbFiltroYears.DataSource = years;
                    cbFiltroYears.DisplayMember = "years";
                    
                }
            }
        }

        //filtrar los proyectos por un año en específico
        public void MostrarProyectos_Year(String year,System.Windows.Forms.DataGridView dtgProyectos)
        {
            try
            {
                using (SIDACEntities db = new SIDACEntities())
                {
                    var proyectosInYears = db.sp_MostrarProyectos_year(year).ToList();

                    dtgProyectos.Rows.Clear();
                    foreach (var i in proyectosInYears)
                    {
                        dtgProyectos.Rows.Add(i.idProyecto, i.nombre, i.presupuesto, i.costo, i.costoMateriales,
                            i.diasTrabajo, i.numeroTrabajadores, i.pagoTotalTrabajadores,
                            i.fechaInicio, i.fechaFinalizado, i.descripcion);
                    }
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error al mostrar los Proyectos. \n\n" + ex.ToString());
            }

        }
        #endregion
    }
}
