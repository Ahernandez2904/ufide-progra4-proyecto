using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Proyecto.ActionFilters;
using Proyecto.Entidades;

namespace Proyecto.Controllers
{
    public class ProductosController : Controller
    {
        public ActionResult Categorias() 
        {
            return View(); 
        }

        public ActionResult Productos() 
        {

            using (var contexto = new CrazyTechEntities())
            {
                //antes productoes
                var resultado = (from x in contexto.Producto
                                 select x).ToList();

                return View(resultado);
            }
            
        }
        [VerificarLogin]
        public ActionResult ActualizarProducto() 
        
        { 
            
            return View(); 
        
        
        }

        [VerificarLogin]
        public ActionResult InsertarProducto(Producto modelo)
        {
     
            using (var contexto = new CrazyTechEntities())
       

            {
                //antes productoes
                Producto producti = new Producto();
                producti.NombreProducto = modelo.NombreProducto;
                producti.Cantidad = modelo.Cantidad;
                producti.Precio = modelo.Precio;
           
                producti.PorcentajeDescuento = modelo.PorcentajeDescuento;
                producti.Descripcion = modelo.Descripcion;
                contexto.Producto.Add(producti);
                contexto.SaveChanges();
                return RedirectToAction("Productos", "Productos");
            }

        }

        public ActionResult ConsultarID(Producto modelo)
        {
            //Select del producto para conocer el saldo... y si el saldo == al abono (precio)
            // update al producto

            //insert al abonos
            using (var contexto = new CrazyTechEntities())


            {
                //antes productoes
                var resultado = (from x in contexto.Producto
                                 where x.ProductoID == modelo.ProductoID
                                 select x).FirstOrDefault();

                
                return View(resultado);
            }

        }

        public ActionResult EliminarUsuario(Producto modelo)
        {
            using (var contexto = new CrazyTechEntities())
            {
                //antes productoes
                var resultado = (from x in contexto.Producto
                                 where x.ProductoID == modelo.ProductoID
                                 select x).FirstOrDefault();
               if (resultado != null)
                {
                    //antes productoes
                    contexto.Producto.Remove(resultado);
                    contexto.SaveChanges();
                    return RedirectToAction("Productos", "Productos");
                }
                else
                {
                    return View();
                }
                
            }
           
        }
    }
}