using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Proyecto.ActionFilters;
using Proyecto.Entidades;
using Proyecto.Models;

namespace Proyecto.Controllers
{
    public class TiquetesController : Controller
    {
        TicketModel modelillo = new TicketModel();

        [VerificarLogin]
        [HttpGet]
        public ActionResult Solicitud() {
            return View();
        }

        [VerificarLogin]
        [HttpPost]
        public ActionResult Solicitud(int Presupuesto, string Detalles)
        {
            var s = this.Session["Datos"] as Usuarios;
            var estado_t = 1; //activo
            var fecha = System.DateTime.Now;
            modelillo.RegistrarTicket(2, s.UsuarioID, estado_t, fecha, Presupuesto, Detalles);
            return View();
        }

        [VerificarLogin]
        [HttpGet]
        public ActionResult Solicitudes() { 
            int estado_t = 1;
            var s = this.Session["Datos"] as Usuarios;
            dynamic mymodel = new ExpandoObject();
            mymodel.cta = modelillo.ConsultarTiquetesActivos(estado_t);
            mymodel.cp = modelillo.ConsultarProductos();
            mymodel.ccp = modelillo.ConsultarCategoriaProducto();
            return View(mymodel);
        }

        [HttpPost]
        public ActionResult ActualizarTiqueteJS(int Usuario_Empleado_Asig, int Usuario_Cliente, int Estado_Ticket, int Presupuesto,
            string Detalles, int TicketID, int pid1, int pid2, int pid3, int pid4, int pid5, int pid6, int pid7, int pid8) 
        {
            modelillo.RegistrarProductoTicket(pid1, TicketID, 1);
            modelillo.RegistrarProductoTicket(pid2, TicketID, 1);
            modelillo.RegistrarProductoTicket(pid3, TicketID, 1);
            modelillo.RegistrarProductoTicket(pid4, TicketID, 1);
            modelillo.RegistrarProductoTicket(pid5, TicketID, 1);
            modelillo.RegistrarProductoTicket(pid6, TicketID, 1);
            modelillo.RegistrarProductoTicket(pid7, TicketID, 1);
            modelillo.RegistrarProductoTicket(pid8, TicketID, 1);
            modelillo.ActualizarTicket(Usuario_Empleado_Asig, Usuario_Cliente, Estado_Ticket, DateTime.Today, Presupuesto, Detalles, TicketID);
            return View();
        }

        [VerificarLogin]
        [HttpGet]
        public ActionResult logoutJS()
        {
            Session.Abandon();
            //return RedirectToAction("IngresoUsuarios", "Usuario");
            return View();
        }

        [VerificarLogin]
        [HttpGet]
        public ActionResult TiqueteProducto()
        {
            //var s = this.Session["Datos"] as Usuarios;
            dynamic mymodel = new ExpandoObject();
            mymodel.cp = modelillo.ConsultarProductos();
            mymodel.ccp = modelillo.ConsultarCategoriaProducto();
            mymodel.cpt = modelillo.ConsultarProductoTicket2();
            return View(mymodel);
        }
    }
}