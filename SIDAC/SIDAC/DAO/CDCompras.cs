using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIDAC.MODELO;

namespace SIDAC.DAO
{
    class CDCompras
    {
        //mostrar
        public List<sp_MostrarCompras_Result> MostrarCompras()
        {
            using(SIDACEntities db = new SIDACEntities())
            {
                return db.sp_MostrarCompras().ToList();
            }
        }
    }
}
