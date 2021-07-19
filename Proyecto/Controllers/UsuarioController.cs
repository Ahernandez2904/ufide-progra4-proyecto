using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Proyecto.Entidades;

namespace Proyecto.Controllers
{
    public class UsuarioController : Controller
    {
        // GET: Usuario
        [HttpGet] // Nos sirve para entrar a las vistas
        public ActionResult ConsultaUsuarios()
        {

            return View();
        }

        public ActionResult IngresoUsuarios()
        {
            return View();
        }
        [HttpPost]
        public ActionResult RegistrarUsuario(UsuarioObj obj)
        {

            return RedirectToAction("IngresoUsuarios", "Usuario");
        }

        public ActionResult RegistrarUsuarioJS()
        {

            return View();
        }
    }
}