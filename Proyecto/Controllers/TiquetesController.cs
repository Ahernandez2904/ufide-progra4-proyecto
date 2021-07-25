using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Proyecto.Entidades;

namespace Proyecto.Controllers
{
    public class TiquetesController : Controller
    {
        public ActionResult Solicitud() { return View(); }

        public ActionResult Solicitudes() { return View(); }
    }
}