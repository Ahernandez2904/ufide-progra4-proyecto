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
        public ActionResult Solicitud(int Usuario_Empleado_Asig, int Usuario_Cliente, int Presupuesto, string Detalles)
        {
            var estado_t = 1; //activo
            var fecha = System.DateTime.Now;
            modelillo.RegistrarTicket(Usuario_Empleado_Asig, Usuario_Cliente, estado_t, fecha, Presupuesto, Detalles);
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
    }
}