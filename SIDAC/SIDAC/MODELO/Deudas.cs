//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SIDAC.MODELO
{
    using System;
    using System.Collections.Generic;
    
    public partial class Deudas
    {
        public int idDeuda { get; set; }
        public string descripcion { get; set; }
        public System.DateTime fecha { get; set; }
        public decimal monto { get; set; }
        public decimal cancelado { get; set; }
        public decimal pendiente { get; set; }
        public int Fk_Consumidor { get; set; }
    
        public virtual Consumidores Consumidores { get; set; }
    }
}
