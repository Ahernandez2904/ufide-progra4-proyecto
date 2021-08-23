using Proyecto.ActionFilters;
using Proyecto.Entidades;
using Proyecto.Models;
using System.Linq;
using System.Web.Mvc;
using System;
using System.Collections.Generic;
using System.Dynamic;

namespace Proyecto.Controllers
{
    public class UsuarioController : Controller
    {

        UsuarioModel modelillo = new UsuarioModel();

        // GET: Usuario
        [HttpGet] // Nos sirve para entrar a las vistas
        public ActionResult ConsultaUsuarios()
        {
            var listaUsuarios = modelillo.ConsultarUsuarios();
            return View(listaUsuarios);
        }

        public ActionResult IngresoUsuarios()
        {
            UsuarioObj user = new UsuarioObj();
            return View(user);
        }

        public ActionResult RegistroUsuarios()
        {
            return View();
        }

        [HttpGet]
        [VerificarLogin]
        public ActionResult Perfil()
        {
            int estado_t = 2; //Ya fue aprobado por el técnico
            var s = this.Session["Datos"] as Usuarios;
            dynamic mymodel = new ExpandoObject();
            TicketModel tm = new TicketModel();
            mymodel.ctau = tm.ConsultarTiquetesActivosUsuario(s.UsuarioID, estado_t);
            mymodel.cpt = tm.ConsultarProductoTicket2();
            //Agregar model por aquí, si tienen una pregunta me avisan
            return View(mymodel);
        }

        [HttpPost]
        public ActionResult ActualizarTiqueteJS(int Usuario_Empleado_Asig, int Usuario_Cliente, int Estado_Ticket, int Presupuesto,
            string Detalles, int TicketID) {
            TicketModel tm = new TicketModel();
            tm.ActualizarTicket(Usuario_Empleado_Asig, Usuario_Cliente, Estado_Ticket, DateTime.Today, Presupuesto, Detalles, TicketID);
            if(Estado_Ticket == 3)
            {
                modelillo.RegistrarFactura(Usuario_Cliente, TicketID, DateTime.Today);
            }
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


        [HttpPost]
        [VerificarLogin]
        public ActionResult Perfil(int Usuario_Empleado_Asig, int Usuario_Cliente, int Estado_Ticket, int Presupuesto, 
            string Detalles, int TicketID) {

            var Fecha = DateTime.Today;
            int estado_t = 2; //Ya fue aprobado por el técnico
            var s = this.Session["Datos"] as Usuarios;
            dynamic mymodel = new ExpandoObject();
            TicketModel tm = new TicketModel();
            tm.ActualizarTicket(Usuario_Empleado_Asig, Usuario_Cliente, Estado_Ticket, Fecha, Presupuesto, Detalles, TicketID);
            mymodel.ctau = tm.ConsultarTiquetesActivosUsuario(s.UsuarioID, estado_t);
            return View(mymodel);
        }

        //[HttpPost]

        //public ActionResult RegistrarUsuario(UsuarioObj obj)
        //{
        //    using (var contexto = new CrazyTechEntities())
        //    { 


        //    }


        //    //    UsuarioModel modelillo = new UsuarioModel();
        //    //modelillo.RegistrarUsuario(obj.nombre, obj.apellido1, obj.apellido2, obj.email, obj., obj.activo);
        //    return View("Perfil", "Usuario");

        //}

        [HttpPost]
        public ActionResult RegistroUsuarioJS(string nombre, string apellido1, string apellido2, string password, string email)
        {
            modelillo.RegistrarUsuario(nombre, apellido1, apellido2, 2, true, password, email);
            return RedirectToAction("Perfil", "Usuario");
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
                    return Json(JsonRequestBehavior.AllowGet);
                }
                else
                {
                    return Content("<script language='javascript' type='text/javascript'>alert('Usuario no encontrado');</script>");
                }
            }
        }

        [HttpPost]
        public ActionResult IngresoUsuarios(UsuarioObj usuario)
        {
            //Anterior
            /*using (var contexto = new CrazyTechEntities())
            {
                var resultado = (from x in contexto.Usuarios
                                 where x.Email == usuario.email && x.Password == usuario.password
                                 select x).FirstOrDefault();
                if (resultado != null)
                {
                    if (resultado.PermisosID == 2)
                    {
                        Session["Datos"] = resultado.PermisosID;
                        return RedirectToAction("Index", "Home");
                    }
                    else
                    {
                        Session["Datos"] = resultado.PermisosID;
                        return RedirectToAction("Index", "Home");
                    }
                }
                else
                {
                    ViewBag.ErrorVista = "Verifique sus credenciales";
                    return View();
                }
            }*/

            using (var contexto = new CrazyTechEntities())
            {
                var resultado = (from x in contexto.Usuarios
                                 where x.Email == usuario.email && x.Password == usuario.password
                                 select x).FirstOrDefault();
                if (resultado != null)
                {
                    List<Usuarios> usuarioRespuesta = new List<Usuarios>();
                    usuarioRespuesta.Add(new Usuarios
                    {
                        UsuarioID = resultado.UsuarioID,
                        PermisosID = resultado.PermisosID
                    });
                    Session["Datos"] = resultado;
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ViewBag.FirstNameError = "Contraseña o Usuario incorrecto";
                    return View();
                   
                }
            }
        }

        public ActionResult RegistrarUsuario(Usuarios modelo)
        {
            using (var contexto = new CrazyTechEntities())
            {
                Usuarios usuari = new Usuarios();
                usuari.Nombre = modelo.Nombre;
                usuari.Apellido1 = modelo.Apellido1;
                usuari.Apellido2 = modelo.Apellido2;
                usuari.PermisosID = 1;
                usuari.Activos = true;
                usuari.Password = modelo.Password;
                usuari.Email = modelo.Email;
                contexto.Usuarios.Add(usuari);
                contexto.SaveChanges();
                return RedirectToAction("", "Usuario");
            }
        }

    }
}