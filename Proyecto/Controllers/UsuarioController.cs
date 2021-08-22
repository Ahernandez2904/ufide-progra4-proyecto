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
        [VerificarLogin]
        public ActionResult Perfil()
        {

           
            return View();
        }



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
                    return View();
                }
            }

        }
        [HttpPost]
        public ActionResult IngresoUsuarios(UsuarioObj usuario)
        {
            using (var contexto = new CrazyTechEntities())
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
           
            }
                
        }

        public ActionResult RegistrarUsuario(Usuarios modelo)
        {
   
            using (var contexto = new CrazyTechEntities())

            {
                Usuarios usuari= new Usuarios();
                usuari.Nombre = modelo.Nombre;
                usuari.Apellido1 = modelo.Apellido1;
                usuari.Apellido2 = modelo.Apellido2;
                usuari.PermisosID = 2;
                usuari.Activos = true;
                usuari.Password = modelo.Password;
                usuari.Email = modelo.Email;
                contexto.Usuarios.Add(usuari);
                contexto.SaveChanges();
                return RedirectToAction("IngresoUsuario", "Usuario");
            }

        }



    }
}