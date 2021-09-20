using SIDAC.MODELO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIDAC.DAO
{
    class CDControlPagos
    {
        //mostrar pagos pendientes
        public List<sp_MostrarPagosDefault_Result> MostrarPagosDefault()
        {
            using (SIDACEntities db = new SIDACEntities())
            {
                return db.sp_MostrarPagosDefault().ToList();
            }
        }
        //mostrar consumidores1
        public List<sp_MostrarPagos_Result> MostrarPagos()
        {
            using (SIDACEntities db = new SIDACEntities())
            {
                return db.sp_MostrarPagos().ToList();
            }
        }

        //Insertar
        public void RegistrarPago(Pagos pago)
        {
            try
            {
                using (SIDACEntities db = new SIDACEntities())
                {
                    db.sp_InsertarPago(pago.montoBase, pago.montoCancelado, pago.descripcion, pago.fecha, pago.FK_estado,
                                        pago.FK_consumidor) ;
                    db.SaveChanges();
                    MessageBox.Show("Pago agregado existosamente.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar.\n\n" + ex.ToString());
            }
        }

        //actualizar
        public void ActualizarPago(Pagos pago)
        {
            try
            {
                using (SIDACEntities db = new SIDACEntities())
                {
                    db.sp_ActualizarPago(pago.idPago, pago.montoCancelado, pago.descripcion, pago.FK_estado);
                    db.SaveChanges();
                    MessageBox.Show("Pago modificado existosamente.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar.\n\n" + ex.ToString());
            }
        }

        //eliminar
        public void EliminarPago(int id)
        {
            try
            {
                using (SIDACEntities db = new SIDACEntities())
                {
                    db.sp_EliminarPago(id);
                    db.SaveChanges();
                    MessageBox.Show("Pago eliminado existosamente.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar.\n\n" + ex.ToString());
            }
        }
        
    }
}

