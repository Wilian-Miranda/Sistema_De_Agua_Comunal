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
        #region OPERACIONES CRUD
        //mostrar todos los pagos
        public List<sp_MostrarPagos_Result> MostrarPagos()
        {
            using (SIDACEntities db = new SIDACEntities())
            {
                return db.sp_MostrarPagos().ToList();
            }
        }
        public void MostrarPagos(string estado, DataGridView dataGrid)
        {
            //CDControlPagos pago = new CDControlPagos();

            using (SIDACEntities db = new SIDACEntities())
            {
                var pagos = (from t in db.sp_MostrarPagos()
                             where t.estado == estado
                             select t).ToList();


                dataGrid.Rows.Clear();
                foreach (var i in pagos)
                {
                    dataGrid.Rows.Add(i.idPago, i.nombre, i.mes, i.montoBase, i.montoCancelado,
                                        i.montoPendiente, i.mora, i.descripcion, i.estado, i.fecha);
                }
            }

        }

        //Insertar
        public void RegistrarPago(Pagos pago)
        {
            try
            {
                using (SIDACEntities db = new SIDACEntities())
                {
                    db.sp_InsertarPago(pago.montoBase, pago.montoCancelado, pago.mora, pago.descripcion, pago.fecha, pago.FK_estado,
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
                    db.sp_ActualizarPago(pago.idPago, pago.montoCancelado, pago.mora, pago.descripcion, pago.FK_estado);
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

        #endregion

        #region METODOS PARA FILTRO DE PAGOS SEGUN ESTADO-YEAR-MES
        //metodo para cargar los años segun el estado
        public void CargarDatosCBYear_Estado(String estado, Guna.UI2.WinForms.Guna2ComboBox cbYears)
        {
            using (SIDACEntities db = new SIDACEntities())
            {
                var years = db.sp_YearsInPagos(estado).ToList();

                if (years.Count > 0)
                {
                    cbYears.DataSource = years;
                    cbYears.DisplayMember = "mes";
                    cbYears.ValueMember = "value";

                    cbYears.SelectedIndex = 0;
                }
                else
                {
                    cbYears.DataSource = null;
                    cbYears.ResetText();
                }
            }
        }

        //metodo para buscar y mostrar los pagos segun un estado y año
        public void FiltrarPagos_Estado_Year(String estado, String year, DataGridView dtgPagos)
        {
            using (SIDACEntities db = new SIDACEntities())
            {
                //realizar  busqueda de los pagos pendientes en un año determinado
                var pagos = (from t in db.sp_MostrarPagos()
                             where t.estado == estado && (t.fecha.Year).ToString() == year
                             select t).ToList();

                dtgPagos.Rows.Clear();
                foreach (var i in pagos)
                {
                    dtgPagos.Rows.Add(i.idPago, i.nombre, i.mes, i.montoBase, i.montoCancelado,
                                        i.montoPendiente, i.mora, i.descripcion, i.estado, i.fecha);
                }
            }
        }

        //metodo para filtrar los pagos segun un estado-year-mes
        public void MostrarPagos_Estado_Year_Mes(String estado, String year, String mes, DataGridView dtgPagos)
        {
            using (SIDACEntities db = new SIDACEntities())
            {
                //pago.FiltrarPagos_Estado_Year(cbFiltroPrincipal.Text, cbYears.Text, this.dtgPagos);

                var pagos = db.sp_MostrarPagos_Estado_Year_Mes(estado, year, mes);

                dtgPagos.Rows.Clear();
                foreach (var i in pagos)
                {
                    dtgPagos.Rows.Add(i.idPago, i.nombre, i.mes, i.montoBase, i.montoCancelado,
                                        i.montoPendiente, i.mora, i.descripcion, i.estado, i.fecha);
                }
            }
        }

        //metodo para buscar todos los pagos de un consumidor
        public void MostrarPagosPorId(int idconsumidor, DataGridView dtgPagos)
        {
            using (SIDACEntities db = new SIDACEntities())
            {
                var pagos = db.sp_MostrarPagoPorId(idconsumidor).ToList();

                dtgPagos.Rows.Clear();
                foreach (var i in pagos)
                {
                    dtgPagos.Rows.Add(i.idPago, i.nombre, i.mes, i.montoBase, i.montoCancelado, i.montoPendiente, i.mora, i.descripcion, i.estado, i.fecha);
                }
            }
        }
        public void MostrarPagos_Year_Id(String id, String Year, DataGridView dtgPagos)
        {
            int ID = Convert.ToInt32(id);
            using (SIDACEntities db = new SIDACEntities())
            {
                var pagosFiltradosPorYear = db.sp_MostrarPagoPorYear(ID, Year);

                dtgPagos.Rows.Clear();
                foreach (var i in pagosFiltradosPorYear)
                {
                    dtgPagos.Rows.Add(i.idPago, i.nombre, i.mes, i.montoBase, i.montoCancelado, i.montoPendiente, i.mora, i.descripcion, i.estado, i.fecha);
                }
            }
        }
        #endregion

    }
}

