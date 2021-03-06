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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class SIDACEntities : DbContext
    {
        public SIDACEntities()
            : base("name=SIDACEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Compras> Compras { get; set; }
        public virtual DbSet<Consumidores> Consumidores { get; set; }
        public virtual DbSet<DetallesCompras> DetallesCompras { get; set; }
        public virtual DbSet<Deudas> Deudas { get; set; }
        public virtual DbSet<Estados> Estados { get; set; }
        public virtual DbSet<Inventarios> Inventarios { get; set; }
        public virtual DbSet<Pagos> Pagos { get; set; }
        public virtual DbSet<Proyectos> Proyectos { get; set; }
        public virtual DbSet<RetirosInventario> RetirosInventario { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
    
        public virtual int sp_ActualizarCompra(Nullable<int> id, string proveedor, Nullable<System.DateTime> fecha, Nullable<decimal> valor, byte[] foto)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            var proveedorParameter = proveedor != null ?
                new ObjectParameter("proveedor", proveedor) :
                new ObjectParameter("proveedor", typeof(string));
    
            var fechaParameter = fecha.HasValue ?
                new ObjectParameter("fecha", fecha) :
                new ObjectParameter("fecha", typeof(System.DateTime));
    
            var valorParameter = valor.HasValue ?
                new ObjectParameter("valor", valor) :
                new ObjectParameter("valor", typeof(decimal));
    
            var fotoParameter = foto != null ?
                new ObjectParameter("foto", foto) :
                new ObjectParameter("foto", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_ActualizarCompra", idParameter, proveedorParameter, fechaParameter, valorParameter, fotoParameter);
        }
    
        public virtual int sp_ActualizarConsumidor(Nullable<int> id, string nombre, string apellido, string telefono, string correo, Nullable<int> estado)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            var nombreParameter = nombre != null ?
                new ObjectParameter("nombre", nombre) :
                new ObjectParameter("nombre", typeof(string));
    
            var apellidoParameter = apellido != null ?
                new ObjectParameter("apellido", apellido) :
                new ObjectParameter("apellido", typeof(string));
    
            var telefonoParameter = telefono != null ?
                new ObjectParameter("telefono", telefono) :
                new ObjectParameter("telefono", typeof(string));
    
            var correoParameter = correo != null ?
                new ObjectParameter("correo", correo) :
                new ObjectParameter("correo", typeof(string));
    
            var estadoParameter = estado.HasValue ?
                new ObjectParameter("estado", estado) :
                new ObjectParameter("estado", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_ActualizarConsumidor", idParameter, nombreParameter, apellidoParameter, telefonoParameter, correoParameter, estadoParameter);
        }
    
        public virtual int sp_ActualizarInventarios(Nullable<int> id, Nullable<int> cantidad, string descripcion, Nullable<decimal> precioUnitario, Nullable<decimal> total, Nullable<int> estado, Nullable<int> fK_compra)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            var cantidadParameter = cantidad.HasValue ?
                new ObjectParameter("cantidad", cantidad) :
                new ObjectParameter("cantidad", typeof(int));
    
            var descripcionParameter = descripcion != null ?
                new ObjectParameter("descripcion", descripcion) :
                new ObjectParameter("descripcion", typeof(string));
    
            var precioUnitarioParameter = precioUnitario.HasValue ?
                new ObjectParameter("precioUnitario", precioUnitario) :
                new ObjectParameter("precioUnitario", typeof(decimal));
    
            var totalParameter = total.HasValue ?
                new ObjectParameter("total", total) :
                new ObjectParameter("total", typeof(decimal));
    
            var estadoParameter = estado.HasValue ?
                new ObjectParameter("estado", estado) :
                new ObjectParameter("estado", typeof(int));
    
            var fK_compraParameter = fK_compra.HasValue ?
                new ObjectParameter("FK_compra", fK_compra) :
                new ObjectParameter("FK_compra", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_ActualizarInventarios", idParameter, cantidadParameter, descripcionParameter, precioUnitarioParameter, totalParameter, estadoParameter, fK_compraParameter);
        }
    
        public virtual int sp_ActualizarPago(Nullable<int> id, Nullable<decimal> montoCancelado, Nullable<decimal> mora, string descripcion, Nullable<int> fK_estado)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            var montoCanceladoParameter = montoCancelado.HasValue ?
                new ObjectParameter("montoCancelado", montoCancelado) :
                new ObjectParameter("montoCancelado", typeof(decimal));
    
            var moraParameter = mora.HasValue ?
                new ObjectParameter("mora", mora) :
                new ObjectParameter("mora", typeof(decimal));
    
            var descripcionParameter = descripcion != null ?
                new ObjectParameter("descripcion", descripcion) :
                new ObjectParameter("descripcion", typeof(string));
    
            var fK_estadoParameter = fK_estado.HasValue ?
                new ObjectParameter("FK_estado", fK_estado) :
                new ObjectParameter("FK_estado", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_ActualizarPago", idParameter, montoCanceladoParameter, moraParameter, descripcionParameter, fK_estadoParameter);
        }
    
        public virtual int sp_ActualizarProyecto(Nullable<int> id, string nombre, Nullable<decimal> presupuesto, Nullable<decimal> costo, Nullable<decimal> costoMateriales, Nullable<int> diasTrabajo, Nullable<int> numTrabajadores, Nullable<decimal> pagoTrabajadores, Nullable<System.DateTime> fechaInicio, Nullable<System.DateTime> fechaFinalizado, string descripcion)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            var nombreParameter = nombre != null ?
                new ObjectParameter("nombre", nombre) :
                new ObjectParameter("nombre", typeof(string));
    
            var presupuestoParameter = presupuesto.HasValue ?
                new ObjectParameter("presupuesto", presupuesto) :
                new ObjectParameter("presupuesto", typeof(decimal));
    
            var costoParameter = costo.HasValue ?
                new ObjectParameter("costo", costo) :
                new ObjectParameter("costo", typeof(decimal));
    
            var costoMaterialesParameter = costoMateriales.HasValue ?
                new ObjectParameter("costoMateriales", costoMateriales) :
                new ObjectParameter("costoMateriales", typeof(decimal));
    
            var diasTrabajoParameter = diasTrabajo.HasValue ?
                new ObjectParameter("diasTrabajo", diasTrabajo) :
                new ObjectParameter("diasTrabajo", typeof(int));
    
            var numTrabajadoresParameter = numTrabajadores.HasValue ?
                new ObjectParameter("numTrabajadores", numTrabajadores) :
                new ObjectParameter("numTrabajadores", typeof(int));
    
            var pagoTrabajadoresParameter = pagoTrabajadores.HasValue ?
                new ObjectParameter("pagoTrabajadores", pagoTrabajadores) :
                new ObjectParameter("pagoTrabajadores", typeof(decimal));
    
            var fechaInicioParameter = fechaInicio.HasValue ?
                new ObjectParameter("fechaInicio", fechaInicio) :
                new ObjectParameter("fechaInicio", typeof(System.DateTime));
    
            var fechaFinalizadoParameter = fechaFinalizado.HasValue ?
                new ObjectParameter("fechaFinalizado", fechaFinalizado) :
                new ObjectParameter("fechaFinalizado", typeof(System.DateTime));
    
            var descripcionParameter = descripcion != null ?
                new ObjectParameter("descripcion", descripcion) :
                new ObjectParameter("descripcion", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_ActualizarProyecto", idParameter, nombreParameter, presupuestoParameter, costoParameter, costoMaterialesParameter, diasTrabajoParameter, numTrabajadoresParameter, pagoTrabajadoresParameter, fechaInicioParameter, fechaFinalizadoParameter, descripcionParameter);
        }
    
        public virtual int sp_alterdiagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_alterdiagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_creatediagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_creatediagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_dropdiagram(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_dropdiagram", diagramnameParameter, owner_idParameter);
        }
    
        public virtual int sp_EliminarCompra(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_EliminarCompra", idParameter);
        }
    
        public virtual int sp_EliminarConsumidor(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_EliminarConsumidor", idParameter);
        }
    
        public virtual int sp_EliminarInventario(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_EliminarInventario", idParameter);
        }
    
        public virtual int sp_EliminarPago(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_EliminarPago", idParameter);
        }
    
        public virtual int sp_EliminarProyecto(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_EliminarProyecto", idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagramdefinition_Result> sp_helpdiagramdefinition(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagramdefinition_Result>("sp_helpdiagramdefinition", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagrams_Result> sp_helpdiagrams(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagrams_Result>("sp_helpdiagrams", diagramnameParameter, owner_idParameter);
        }
    
        public virtual int sp_InsertarCompra(Nullable<int> id, string proveedor, Nullable<System.DateTime> fecha, Nullable<decimal> valor, byte[] foto, Nullable<int> fK_Admin)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            var proveedorParameter = proveedor != null ?
                new ObjectParameter("proveedor", proveedor) :
                new ObjectParameter("proveedor", typeof(string));
    
            var fechaParameter = fecha.HasValue ?
                new ObjectParameter("fecha", fecha) :
                new ObjectParameter("fecha", typeof(System.DateTime));
    
            var valorParameter = valor.HasValue ?
                new ObjectParameter("valor", valor) :
                new ObjectParameter("valor", typeof(decimal));
    
            var fotoParameter = foto != null ?
                new ObjectParameter("foto", foto) :
                new ObjectParameter("foto", typeof(byte[]));
    
            var fK_AdminParameter = fK_Admin.HasValue ?
                new ObjectParameter("FK_Admin", fK_Admin) :
                new ObjectParameter("FK_Admin", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_InsertarCompra", idParameter, proveedorParameter, fechaParameter, valorParameter, fotoParameter, fK_AdminParameter);
        }
    
        public virtual int sp_InsertarConsumidor(string nombre, string apellido, string telefono, string correo, Nullable<int> estado)
        {
            var nombreParameter = nombre != null ?
                new ObjectParameter("nombre", nombre) :
                new ObjectParameter("nombre", typeof(string));
    
            var apellidoParameter = apellido != null ?
                new ObjectParameter("apellido", apellido) :
                new ObjectParameter("apellido", typeof(string));
    
            var telefonoParameter = telefono != null ?
                new ObjectParameter("telefono", telefono) :
                new ObjectParameter("telefono", typeof(string));
    
            var correoParameter = correo != null ?
                new ObjectParameter("correo", correo) :
                new ObjectParameter("correo", typeof(string));
    
            var estadoParameter = estado.HasValue ?
                new ObjectParameter("estado", estado) :
                new ObjectParameter("estado", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_InsertarConsumidor", nombreParameter, apellidoParameter, telefonoParameter, correoParameter, estadoParameter);
        }
    
        public virtual int sp_InsertarItemInventario(Nullable<int> cantidad, string descripcion, Nullable<decimal> precioUnitario, Nullable<decimal> total, Nullable<int> estado, Nullable<int> fK_compra)
        {
            var cantidadParameter = cantidad.HasValue ?
                new ObjectParameter("cantidad", cantidad) :
                new ObjectParameter("cantidad", typeof(int));
    
            var descripcionParameter = descripcion != null ?
                new ObjectParameter("descripcion", descripcion) :
                new ObjectParameter("descripcion", typeof(string));
    
            var precioUnitarioParameter = precioUnitario.HasValue ?
                new ObjectParameter("precioUnitario", precioUnitario) :
                new ObjectParameter("precioUnitario", typeof(decimal));
    
            var totalParameter = total.HasValue ?
                new ObjectParameter("total", total) :
                new ObjectParameter("total", typeof(decimal));
    
            var estadoParameter = estado.HasValue ?
                new ObjectParameter("estado", estado) :
                new ObjectParameter("estado", typeof(int));
    
            var fK_compraParameter = fK_compra.HasValue ?
                new ObjectParameter("FK_compra", fK_compra) :
                new ObjectParameter("FK_compra", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_InsertarItemInventario", cantidadParameter, descripcionParameter, precioUnitarioParameter, totalParameter, estadoParameter, fK_compraParameter);
        }
    
        public virtual int sp_InsertarPago(Nullable<decimal> montoBase, Nullable<decimal> montoCancelado, Nullable<decimal> mora, string descripcion, Nullable<System.DateTime> fecha, Nullable<int> fK_estado, Nullable<int> fK_consumidor)
        {
            var montoBaseParameter = montoBase.HasValue ?
                new ObjectParameter("montoBase", montoBase) :
                new ObjectParameter("montoBase", typeof(decimal));
    
            var montoCanceladoParameter = montoCancelado.HasValue ?
                new ObjectParameter("montoCancelado", montoCancelado) :
                new ObjectParameter("montoCancelado", typeof(decimal));
    
            var moraParameter = mora.HasValue ?
                new ObjectParameter("mora", mora) :
                new ObjectParameter("mora", typeof(decimal));
    
            var descripcionParameter = descripcion != null ?
                new ObjectParameter("descripcion", descripcion) :
                new ObjectParameter("descripcion", typeof(string));
    
            var fechaParameter = fecha.HasValue ?
                new ObjectParameter("fecha", fecha) :
                new ObjectParameter("fecha", typeof(System.DateTime));
    
            var fK_estadoParameter = fK_estado.HasValue ?
                new ObjectParameter("FK_estado", fK_estado) :
                new ObjectParameter("FK_estado", typeof(int));
    
            var fK_consumidorParameter = fK_consumidor.HasValue ?
                new ObjectParameter("FK_consumidor", fK_consumidor) :
                new ObjectParameter("FK_consumidor", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_InsertarPago", montoBaseParameter, montoCanceladoParameter, moraParameter, descripcionParameter, fechaParameter, fK_estadoParameter, fK_consumidorParameter);
        }
    
        public virtual int sp_InsertarProyecto(string nombre, Nullable<decimal> presupuesto, Nullable<decimal> costo, Nullable<decimal> costoMateriales, Nullable<int> diasTrabajo, Nullable<int> numTrabajadores, Nullable<decimal> pagoTrabajadores, Nullable<System.DateTime> fechaInicio, Nullable<System.DateTime> fechaFinalizado, string descripcion)
        {
            var nombreParameter = nombre != null ?
                new ObjectParameter("nombre", nombre) :
                new ObjectParameter("nombre", typeof(string));
    
            var presupuestoParameter = presupuesto.HasValue ?
                new ObjectParameter("presupuesto", presupuesto) :
                new ObjectParameter("presupuesto", typeof(decimal));
    
            var costoParameter = costo.HasValue ?
                new ObjectParameter("costo", costo) :
                new ObjectParameter("costo", typeof(decimal));
    
            var costoMaterialesParameter = costoMateriales.HasValue ?
                new ObjectParameter("costoMateriales", costoMateriales) :
                new ObjectParameter("costoMateriales", typeof(decimal));
    
            var diasTrabajoParameter = diasTrabajo.HasValue ?
                new ObjectParameter("diasTrabajo", diasTrabajo) :
                new ObjectParameter("diasTrabajo", typeof(int));
    
            var numTrabajadoresParameter = numTrabajadores.HasValue ?
                new ObjectParameter("numTrabajadores", numTrabajadores) :
                new ObjectParameter("numTrabajadores", typeof(int));
    
            var pagoTrabajadoresParameter = pagoTrabajadores.HasValue ?
                new ObjectParameter("pagoTrabajadores", pagoTrabajadores) :
                new ObjectParameter("pagoTrabajadores", typeof(decimal));
    
            var fechaInicioParameter = fechaInicio.HasValue ?
                new ObjectParameter("fechaInicio", fechaInicio) :
                new ObjectParameter("fechaInicio", typeof(System.DateTime));
    
            var fechaFinalizadoParameter = fechaFinalizado.HasValue ?
                new ObjectParameter("fechaFinalizado", fechaFinalizado) :
                new ObjectParameter("fechaFinalizado", typeof(System.DateTime));
    
            var descripcionParameter = descripcion != null ?
                new ObjectParameter("descripcion", descripcion) :
                new ObjectParameter("descripcion", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_InsertarProyecto", nombreParameter, presupuestoParameter, costoParameter, costoMaterialesParameter, diasTrabajoParameter, numTrabajadoresParameter, pagoTrabajadoresParameter, fechaInicioParameter, fechaFinalizadoParameter, descripcionParameter);
        }
    
        public virtual ObjectResult<sp_MesesInYearsInPagos_Result> sp_MesesInYearsInPagos(Nullable<int> year, string estado)
        {
            var yearParameter = year.HasValue ?
                new ObjectParameter("year", year) :
                new ObjectParameter("year", typeof(int));
    
            var estadoParameter = estado != null ?
                new ObjectParameter("estado", estado) :
                new ObjectParameter("estado", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_MesesInYearsInPagos_Result>("sp_MesesInYearsInPagos", yearParameter, estadoParameter);
        }
    
        public virtual ObjectResult<sp_MostraInventario_Result> sp_MostraInventario()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_MostraInventario_Result>("sp_MostraInventario");
        }
    
        public virtual ObjectResult<sp_MostrarCompras_Result> sp_MostrarCompras()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_MostrarCompras_Result>("sp_MostrarCompras");
        }
    
        public virtual ObjectResult<sp_MostrarConsumidores_Result> sp_MostrarConsumidores()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_MostrarConsumidores_Result>("sp_MostrarConsumidores");
        }
    
        public virtual ObjectResult<sp_MostrarConsumidoresDefault_Result> sp_MostrarConsumidoresDefault()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_MostrarConsumidoresDefault_Result>("sp_MostrarConsumidoresDefault");
        }
    
        public virtual ObjectResult<sp_MostrarInventarios_Result> sp_MostrarInventarios()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_MostrarInventarios_Result>("sp_MostrarInventarios");
        }
    
        public virtual ObjectResult<sp_MostrarPagoPorId_Result> sp_MostrarPagoPorId(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_MostrarPagoPorId_Result>("sp_MostrarPagoPorId", idParameter);
        }
    
        public virtual ObjectResult<sp_MostrarPagoPorYear_Result> sp_MostrarPagoPorYear(Nullable<int> id, string year)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            var yearParameter = year != null ?
                new ObjectParameter("year", year) :
                new ObjectParameter("year", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_MostrarPagoPorYear_Result>("sp_MostrarPagoPorYear", idParameter, yearParameter);
        }
    
        public virtual ObjectResult<sp_MostrarPagos_Result> sp_MostrarPagos()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_MostrarPagos_Result>("sp_MostrarPagos");
        }
    
        public virtual ObjectResult<sp_MostrarPagos_Estado_Year_Mes_Result> sp_MostrarPagos_Estado_Year_Mes(string estado, string year, string mes)
        {
            var estadoParameter = estado != null ?
                new ObjectParameter("estado", estado) :
                new ObjectParameter("estado", typeof(string));
    
            var yearParameter = year != null ?
                new ObjectParameter("year", year) :
                new ObjectParameter("year", typeof(string));
    
            var mesParameter = mes != null ?
                new ObjectParameter("mes", mes) :
                new ObjectParameter("mes", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_MostrarPagos_Estado_Year_Mes_Result>("sp_MostrarPagos_Estado_Year_Mes", estadoParameter, yearParameter, mesParameter);
        }
    
        public virtual ObjectResult<sp_MostrarPagos_Year_Consumidor_Result> sp_MostrarPagos_Year_Consumidor(Nullable<int> idConsumidor, string year)
        {
            var idConsumidorParameter = idConsumidor.HasValue ?
                new ObjectParameter("idConsumidor", idConsumidor) :
                new ObjectParameter("idConsumidor", typeof(int));
    
            var yearParameter = year != null ?
                new ObjectParameter("Year", year) :
                new ObjectParameter("Year", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_MostrarPagos_Year_Consumidor_Result>("sp_MostrarPagos_Year_Consumidor", idConsumidorParameter, yearParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> sp_MostrarPagosPorYearPorId(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("sp_MostrarPagosPorYearPorId", idParameter);
        }
    
        public virtual ObjectResult<sp_MostrarProyectos_year_Result> sp_MostrarProyectos_year(string year)
        {
            var yearParameter = year != null ?
                new ObjectParameter("year", year) :
                new ObjectParameter("year", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_MostrarProyectos_year_Result>("sp_MostrarProyectos_year", yearParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> sp_MostrarYearsPorPagosPorId(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("sp_MostrarYearsPorPagosPorId", idParameter);
        }
    
        public virtual int sp_renamediagram(string diagramname, Nullable<int> owner_id, string new_diagramname)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var new_diagramnameParameter = new_diagramname != null ?
                new ObjectParameter("new_diagramname", new_diagramname) :
                new ObjectParameter("new_diagramname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_renamediagram", diagramnameParameter, owner_idParameter, new_diagramnameParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> sp_Ryear_Proyectos()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("sp_Ryear_Proyectos");
        }
    
        public virtual int sp_upgraddiagrams()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_upgraddiagrams");
        }
    
        public virtual ObjectResult<Nullable<int>> sp_YearsInPagos(string estado)
        {
            var estadoParameter = estado != null ?
                new ObjectParameter("estado", estado) :
                new ObjectParameter("estado", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("sp_YearsInPagos", estadoParameter);
        }
    
        public virtual ObjectResult<sp_Grafico_PagosBase_Result> sp_Grafico_PagosBase(string year)
        {
            var yearParameter = year != null ?
                new ObjectParameter("year", year) :
                new ObjectParameter("year", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_Grafico_PagosBase_Result>("sp_Grafico_PagosBase", yearParameter);
        }
    
        public virtual ObjectResult<sp_Grafico_PagosCancelados_Result> sp_Grafico_PagosCancelados(string year)
        {
            var yearParameter = year != null ?
                new ObjectParameter("year", year) :
                new ObjectParameter("year", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_Grafico_PagosCancelados_Result>("sp_Grafico_PagosCancelados", yearParameter);
        }
    
        public virtual ObjectResult<sp_Grafico_PagosPendientes_Result> sp_Grafico_PagosPendientes(string year)
        {
            var yearParameter = year != null ?
                new ObjectParameter("year", year) :
                new ObjectParameter("year", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_Grafico_PagosPendientes_Result>("sp_Grafico_PagosPendientes", yearParameter);
        }
    }
}
