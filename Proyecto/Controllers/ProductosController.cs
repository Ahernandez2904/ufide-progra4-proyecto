using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Proyecto.Entidades;

namespace Proyecto.Controllers
{
    public class ProductosController : Controller
    {
        public ActionResult Categorias() { return View(); }

        public ActionResult Productos() { return View(); }

        public ActionResult ActualizarProducto() { return View(); }
    }
}