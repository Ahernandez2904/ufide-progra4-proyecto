using System;
using System.Collections.Generic;
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
        public ActionResult Solicitud() { 
            return View(); 
        }
        
        /*[VerificarLogin]
        public ActionResult Solicitudes() { 
            int estado ticket = 1;
            var l = modelillo.ConsultarTiquetesActivosUsuario()
            return View();
        }*/
    }
}