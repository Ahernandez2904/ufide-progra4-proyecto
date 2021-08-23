using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Proyecto.ActionFilters;
using Proyecto.Entidades;
using Proyecto.Models;
using System.Web.Mvc;

namespace Proyecto.Models
{
    public class TicketModel
    {

        public void RegistrarTicket(int Usuario_Empleado_Asig, int Usuario_Cliente, int Estado_Ticket, DateTime Fecha, int Presupuesto, string Detalles) {
            using (var contextoBD = new CrazyTechEntities())
            {
                contextoBD.Registrar_Ticket(Usuario_Empleado_Asig, Usuario_Cliente, Estado_Ticket, Fecha, Presupuesto, Detalles);
            }
        }


        public void ActualizarTicket(int Usuario_Empleado_Asig, int Usuario_Cliente, int Estado_Ticket, DateTime Fecha, int Presupuesto, string Detalles, int TicketID) {
            using (var contextoBD = new CrazyTechEntities())
            {
                contextoBD.Actualizar_Ticket(Usuario_Empleado_Asig, Usuario_Cliente, Estado_Ticket, Fecha, Presupuesto, Detalles, TicketID);
            }
        }

        public void EliminarProductoTicket(int ProductoID, int TicketID)
        {
            using (var contextoBD = new CrazyTechEntities())
            {
                contextoBD.Eliminar_Producto_Ticket(ProductoID, TicketID);
            }
        }

        public void RegistrarProductoTicket(int ProductoID, int TicketID, int Cantidad)
        {
            using (var contextoBD = new CrazyTechEntities())
            {
                contextoBD.Registrar_Producto_Ticket(ProductoID, TicketID, Cantidad);
            }
        }

        public List<ProductoTicket> ConsultarProductoTicket(int id)
        {
            List<ProductoTicket> usuarioRespuesta = new List<ProductoTicket>();

            using (var contexto = new CrazyTechEntities())
            {
                var resultado = contexto.Consultar_Producto_Ticket(id);

                foreach (var item in resultado)
                {
                    usuarioRespuesta.Add(new ProductoTicket
                    {
                        ProductoID = item.ProductoID,
                        TicketID = item.TicketID,
                        Cantidad = item.Cantidad
                    });
                }
            }
            return usuarioRespuesta;
        }

        public List<Ticket> ConsultarTiquetesActivosUsuario(int id, Boolean activo)
        {
            List<Ticket> usuarioRespuesta = new List<Ticket>();
            using (var contexto = new CrazyTechEntities())
            {
                var resultado = contexto.Consultar_Tiquetes_Activos_Usuario(id, activo);

                foreach (var item in resultado)
                {
                    usuarioRespuesta.Add(new Ticket
                    {
                        TicketID = item.TicketID,
                        Usuario_Empleado_Asig = item.Usuario_Empleado_Asig,
                        Usuario_Cliente = item.Usuario_Cliente,
                        Estado_Ticket = item.Estado_Ticket,
                        Fecha = item.Fecha,
                        Presupuesto = item.Presupuesto,
                        Detalles = item.Detalles
                    });
                }
            }
            return usuarioRespuesta;
        }
    }
}