using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Proyecto.Entidades;
using Proyecto.Models;

namespace Proyecto.Controllers
{
    public class UsuarioController : Controller
    {

        UsuarioModel modelillo = new UsuarioModel();

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
        public ActionResult RegistroUsuarios()
        {

            return View();

        }


        [HttpPost]
        public ActionResult RegistrarUsuario(UsuarioObj obj)
        {

            UsuarioModel modelillo = new UsuarioModel();
            // modelillo.RegistrarUsuario(obj.nombre, obj.apellido1, obj.apellido2, obj.email, obj., obj.activo);
            return View("IngresoUsuarios", "Usuario");

        }
        [HttpPost]

        public ActionResult RegistroUsuarioJS(string nombre, string apellido1, string apellido2, string password, string email)
        {
            modelillo.RegistrarUsuario(nombre, apellido1, apellido2, 1, 1, password, email);
            return Json(JsonRequestBehavior.AllowGet);
        }

        public ActionResult IngresoUsuarioJS(UsuarioObj usuario)
        {

            using (var contexto = new CrazyTechEntities())
            {
                var resultado = (from x in contexto.Usuarios
                                 where x.Email == usuario.email && x.Password == usuario.password
                                 select x).FirstOrDefault();


                if (resultado != null)
                {
                    
                    return RedirectToAction ("RegistroUsuarios");

                }
                else
                {
                    return View();
                }
            }

        }
    }
}