﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Proyecto
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class CrazyTechEntities : DbContext
    {
        public CrazyTechEntities()
            : base("name=CrazyTechEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Bitacora> Bitacora { get; set; }
        public virtual DbSet<CategoriaProducto> CategoriaProducto { get; set; }
        public virtual DbSet<EstadoTicket> EstadoTicket { get; set; }
        public virtual DbSet<Facturas> Facturas { get; set; }
        public virtual DbSet<Permisos> Permisos { get; set; }
        public virtual DbSet<Producto> Producto { get; set; }
        public virtual DbSet<Ticket> Ticket { get; set; }
        public virtual DbSet<Usuarios> Usuarios { get; set; }
        public virtual DbSet<ProductoTicket> ProductoTicket { get; set; }
    
        public virtual int Actualizar_Ticket(Nullable<int> usuario_Empleado_Asig, Nullable<int> usuario_Cliente, Nullable<int> estado_Ticket, Nullable<System.DateTime> fecha, Nullable<int> presupuesto, string detalles, Nullable<int> ticketID)
        {
            var usuario_Empleado_AsigParameter = usuario_Empleado_Asig.HasValue ?
                new ObjectParameter("Usuario_Empleado_Asig", usuario_Empleado_Asig) :
                new ObjectParameter("Usuario_Empleado_Asig", typeof(int));
    
            var usuario_ClienteParameter = usuario_Cliente.HasValue ?
                new ObjectParameter("Usuario_Cliente", usuario_Cliente) :
                new ObjectParameter("Usuario_Cliente", typeof(int));
    
            var estado_TicketParameter = estado_Ticket.HasValue ?
                new ObjectParameter("Estado_Ticket", estado_Ticket) :
                new ObjectParameter("Estado_Ticket", typeof(int));
    
            var fechaParameter = fecha.HasValue ?
                new ObjectParameter("Fecha", fecha) :
                new ObjectParameter("Fecha", typeof(System.DateTime));
    
            var presupuestoParameter = presupuesto.HasValue ?
                new ObjectParameter("Presupuesto", presupuesto) :
                new ObjectParameter("Presupuesto", typeof(int));
    
            var detallesParameter = detalles != null ?
                new ObjectParameter("Detalles", detalles) :
                new ObjectParameter("Detalles", typeof(string));
    
            var ticketIDParameter = ticketID.HasValue ?
                new ObjectParameter("TicketID", ticketID) :
                new ObjectParameter("TicketID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Actualizar_Ticket", usuario_Empleado_AsigParameter, usuario_ClienteParameter, estado_TicketParameter, fechaParameter, presupuestoParameter, detallesParameter, ticketIDParameter);
        }
    
        public virtual int Actualizar_Usuarios(string nombre, string apellido1, string apellido2, Nullable<int> permisosID, Nullable<bool> activos, string password, string email, Nullable<int> usuarioID)
        {
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            var apellido1Parameter = apellido1 != null ?
                new ObjectParameter("Apellido1", apellido1) :
                new ObjectParameter("Apellido1", typeof(string));
    
            var apellido2Parameter = apellido2 != null ?
                new ObjectParameter("Apellido2", apellido2) :
                new ObjectParameter("Apellido2", typeof(string));
    
            var permisosIDParameter = permisosID.HasValue ?
                new ObjectParameter("PermisosID", permisosID) :
                new ObjectParameter("PermisosID", typeof(int));
    
            var activosParameter = activos.HasValue ?
                new ObjectParameter("Activos", activos) :
                new ObjectParameter("Activos", typeof(bool));
    
            var passwordParameter = password != null ?
                new ObjectParameter("Password", password) :
                new ObjectParameter("Password", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("Email", email) :
                new ObjectParameter("Email", typeof(string));
    
            var usuarioIDParameter = usuarioID.HasValue ?
                new ObjectParameter("UsuarioID", usuarioID) :
                new ObjectParameter("UsuarioID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Actualizar_Usuarios", nombreParameter, apellido1Parameter, apellido2Parameter, permisosIDParameter, activosParameter, passwordParameter, emailParameter, usuarioIDParameter);
        }
    
        public virtual ObjectResult<Consultar_Categoria_Producto_Result> Consultar_Categoria_Producto()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Consultar_Categoria_Producto_Result>("Consultar_Categoria_Producto");
        }
    
        public virtual ObjectResult<Consultar_Factura_Result> Consultar_Factura()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Consultar_Factura_Result>("Consultar_Factura");
        }
    
        public virtual ObjectResult<Consultar_Producto_Result> Consultar_Producto()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Consultar_Producto_Result>("Consultar_Producto");
        }
    
        public virtual ObjectResult<Consultar_Producto_Ticket_Result> Consultar_Producto_Ticket(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Consultar_Producto_Ticket_Result>("Consultar_Producto_Ticket", idParameter);
        }
    
        public virtual ObjectResult<Consultar_Producto_Ticket2_Result> Consultar_Producto_Ticket2()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Consultar_Producto_Ticket2_Result>("Consultar_Producto_Ticket2");
        }
    
        public virtual ObjectResult<Consultar_Tiquetes_Activos_Result> Consultar_Tiquetes_Activos(Nullable<int> activo)
        {
            var activoParameter = activo.HasValue ?
                new ObjectParameter("activo", activo) :
                new ObjectParameter("activo", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Consultar_Tiquetes_Activos_Result>("Consultar_Tiquetes_Activos", activoParameter);
        }
    
        public virtual ObjectResult<Consultar_Tiquetes_Activos_Usuario_Result> Consultar_Tiquetes_Activos_Usuario(Nullable<int> id, Nullable<int> activo)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            var activoParameter = activo.HasValue ?
                new ObjectParameter("activo", activo) :
                new ObjectParameter("activo", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Consultar_Tiquetes_Activos_Usuario_Result>("Consultar_Tiquetes_Activos_Usuario", idParameter, activoParameter);
        }
    
        public virtual int Eliminar_Factura(Nullable<long> ticketIDFactura)
        {
            var ticketIDFacturaParameter = ticketIDFactura.HasValue ?
                new ObjectParameter("TicketIDFactura", ticketIDFactura) :
                new ObjectParameter("TicketIDFactura", typeof(long));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Eliminar_Factura", ticketIDFacturaParameter);
        }
    
        public virtual int Eliminar_Producto_Ticket(Nullable<long> productoID, Nullable<long> ticketID)
        {
            var productoIDParameter = productoID.HasValue ?
                new ObjectParameter("ProductoID", productoID) :
                new ObjectParameter("ProductoID", typeof(long));
    
            var ticketIDParameter = ticketID.HasValue ?
                new ObjectParameter("TicketID", ticketID) :
                new ObjectParameter("TicketID", typeof(long));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Eliminar_Producto_Ticket", productoIDParameter, ticketIDParameter);
        }
    
        public virtual int Eliminar_Usuarios(Nullable<long> usuarioID)
        {
            var usuarioIDParameter = usuarioID.HasValue ?
                new ObjectParameter("UsuarioID", usuarioID) :
                new ObjectParameter("UsuarioID", typeof(long));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Eliminar_Usuarios", usuarioIDParameter);
        }
    
        public virtual ObjectResult<Ingresar_Usuario_Result> Ingresar_Usuario(string email, string password)
        {
            var emailParameter = email != null ?
                new ObjectParameter("email", email) :
                new ObjectParameter("email", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("password", password) :
                new ObjectParameter("password", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Ingresar_Usuario_Result>("Ingresar_Usuario", emailParameter, passwordParameter);
        }
    
        public virtual int Registrar_Factura(Nullable<int> usuario_cliente_id, Nullable<int> ticket_ID, Nullable<System.DateTime> fecha)
        {
            var usuario_cliente_idParameter = usuario_cliente_id.HasValue ?
                new ObjectParameter("usuario_cliente_id", usuario_cliente_id) :
                new ObjectParameter("usuario_cliente_id", typeof(int));
    
            var ticket_IDParameter = ticket_ID.HasValue ?
                new ObjectParameter("ticket_ID", ticket_ID) :
                new ObjectParameter("ticket_ID", typeof(int));
    
            var fechaParameter = fecha.HasValue ?
                new ObjectParameter("fecha", fecha) :
                new ObjectParameter("fecha", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Registrar_Factura", usuario_cliente_idParameter, ticket_IDParameter, fechaParameter);
        }
    
        public virtual int Registrar_Producto_Ticket(Nullable<int> producto_ID, Nullable<int> id_Ticket, Nullable<int> cantidad)
        {
            var producto_IDParameter = producto_ID.HasValue ?
                new ObjectParameter("Producto_ID", producto_ID) :
                new ObjectParameter("Producto_ID", typeof(int));
    
            var id_TicketParameter = id_Ticket.HasValue ?
                new ObjectParameter("Id_Ticket", id_Ticket) :
                new ObjectParameter("Id_Ticket", typeof(int));
    
            var cantidadParameter = cantidad.HasValue ?
                new ObjectParameter("Cantidad", cantidad) :
                new ObjectParameter("Cantidad", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Registrar_Producto_Ticket", producto_IDParameter, id_TicketParameter, cantidadParameter);
        }
    
        public virtual int Registrar_Ticket(Nullable<int> usuario_Empleado_Asig, Nullable<int> usuario_Cliente, Nullable<int> estado_Ticket, Nullable<System.DateTime> fecha, Nullable<int> presupuesto, string detalles)
        {
            var usuario_Empleado_AsigParameter = usuario_Empleado_Asig.HasValue ?
                new ObjectParameter("Usuario_Empleado_Asig", usuario_Empleado_Asig) :
                new ObjectParameter("Usuario_Empleado_Asig", typeof(int));
    
            var usuario_ClienteParameter = usuario_Cliente.HasValue ?
                new ObjectParameter("Usuario_Cliente", usuario_Cliente) :
                new ObjectParameter("Usuario_Cliente", typeof(int));
    
            var estado_TicketParameter = estado_Ticket.HasValue ?
                new ObjectParameter("Estado_Ticket", estado_Ticket) :
                new ObjectParameter("Estado_Ticket", typeof(int));
    
            var fechaParameter = fecha.HasValue ?
                new ObjectParameter("Fecha", fecha) :
                new ObjectParameter("Fecha", typeof(System.DateTime));
    
            var presupuestoParameter = presupuesto.HasValue ?
                new ObjectParameter("Presupuesto", presupuesto) :
                new ObjectParameter("Presupuesto", typeof(int));
    
            var detallesParameter = detalles != null ?
                new ObjectParameter("Detalles", detalles) :
                new ObjectParameter("Detalles", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Registrar_Ticket", usuario_Empleado_AsigParameter, usuario_ClienteParameter, estado_TicketParameter, fechaParameter, presupuestoParameter, detallesParameter);
        }
    
        public virtual int Registrar_Usuarios(string nombre, string apellido1, string apellido2, Nullable<int> permisosID, Nullable<bool> activos, string password, string email)
        {
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            var apellido1Parameter = apellido1 != null ?
                new ObjectParameter("Apellido1", apellido1) :
                new ObjectParameter("Apellido1", typeof(string));
    
            var apellido2Parameter = apellido2 != null ?
                new ObjectParameter("Apellido2", apellido2) :
                new ObjectParameter("Apellido2", typeof(string));
    
            var permisosIDParameter = permisosID.HasValue ?
                new ObjectParameter("PermisosID", permisosID) :
                new ObjectParameter("PermisosID", typeof(int));
    
            var activosParameter = activos.HasValue ?
                new ObjectParameter("Activos", activos) :
                new ObjectParameter("Activos", typeof(bool));
    
            var passwordParameter = password != null ?
                new ObjectParameter("Password", password) :
                new ObjectParameter("Password", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("Email", email) :
                new ObjectParameter("Email", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Registrar_Usuarios", nombreParameter, apellido1Parameter, apellido2Parameter, permisosIDParameter, activosParameter, passwordParameter, emailParameter);
        }
    }
}
