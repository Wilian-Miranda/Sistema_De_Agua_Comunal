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
    
    public partial class sp_MostrarInventarios_Result
    {
        public int idInventario { get; set; }
        public int cantidad { get; set; }
        public string descripcion { get; set; }
        public decimal precioUnitario { get; set; }
        public decimal total { get; set; }
        public int estado { get; set; }
        public int FK_compra { get; set; }
    }
}