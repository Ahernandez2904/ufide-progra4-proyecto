using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Proyecto.ActionFilters;
using Proyecto.Entidades;

namespace Proyecto.Controllers
{
    public class TiquetesController : Controller
    {
        [VerificarLogin]
        public ActionResult Solicitud() { return View(); }
        [VerificarLogin]
        public ActionResult Solicitudes() { return View(); }
    }
}