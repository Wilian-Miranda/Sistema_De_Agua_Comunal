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
    
    public partial class DetallesCompras
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DetallesCompras()
        {
            this.Inventarios = new HashSet<Inventarios>();
        }
    
        public int idDetalleCompras { get; set; }
        public int cantidad { get; set; }
        public string descripcion { get; set; }
        public decimal precioUnitario { get; set; }
        public decimal total { get; set; }
        public int FK_compra { get; set; }
    
        public virtual Compras Compras { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Inventarios> Inventarios { get; set; }
    }
}
