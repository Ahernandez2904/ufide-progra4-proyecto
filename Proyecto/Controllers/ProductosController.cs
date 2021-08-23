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
        [VerificarLogin]
        public ActionResult Categorias()
        {
            using (var contexto = new CrazyTechEntities())
            {
                var resultado = (from x in contexto.CategoriaProducto
                                 select x).ToList();
                return View(resultado);
            }
        }

        [VerificarLogin]
        public ActionResult Productos(Producto producto, String procesarFormulario)
        {

            if (procesarFormulario == "Procesador")
            {
                using (var contexto = new CrazyTechEntities())
                {
                    //antes productoes
                    var resultado = (from x in contexto.Producto
                                     where x.CategoriaProductoID == 1
                                     select x).ToList();

                    return View(resultado);
                }
            }
            else if (procesarFormulario == "Tarjeta madre")
            {
                using (var contexto = new CrazyTechEntities())
                {
                    //antes productoes
                    var resultado = (from x in contexto.Producto
                                     where x.CategoriaProductoID == 2
                                     select x).ToList();

                    return View(resultado);
                }
            }
            else if (procesarFormulario == "Tarjeta gráfica")
            {
                using (var contexto = new CrazyTechEntities())
                {
                    //antes productoes
                    var resultado = (from x in contexto.Producto
                                     where x.CategoriaProductoID == 3
                                     select x).ToList();

                    return View(resultado);
                }
            }
            else if (procesarFormulario == "RAM")
            {
                using (var contexto = new CrazyTechEntities())
                {
                    //antes productoes
                    var resultado = (from x in contexto.Producto
                                     where x.CategoriaProductoID == 4
                                     select x).ToList();

                    return View(resultado);
                }
            }
            else if (procesarFormulario == "Almacenamiento")
            {
                using (var contexto = new CrazyTechEntities())
                {
                    //antes productoes
                    var resultado = (from x in contexto.Producto
                                     where x.CategoriaProductoID == 5
                                     select x).ToList();

                    return View(resultado);
                }
            }
            else if (procesarFormulario == "Enfriamiento")
            {
                using (var contexto = new CrazyTechEntities())
                {
                    //antes productoes
                    var resultado = (from x in contexto.Producto
                                     where x.CategoriaProductoID == 6
                                     select x).ToList();

                    return View(resultado);
                }
            }
            else if (procesarFormulario == "Fuente de poder")
            {
                using (var contexto = new CrazyTechEntities())
                {
                    //antes productoes
                    var resultado = (from x in contexto.Producto
                                     where x.CategoriaProductoID == 7
                                     select x).ToList();

                    return View(resultado);
                }
            }
            else if (procesarFormulario == "Case")
            {
                using (var contexto = new CrazyTechEntities())
                {
                    //antes productoes
                    var resultado = (from x in contexto.Producto
                                     where x.CategoriaProductoID == 8
                                     select x).ToList();

                    return View(resultado);
                }
            }
            else
            {
                return View();
            }
        }
        [VerificarLogin]
        public ActionResult ActualizarProducto(Producto producto, int procesarFormulario)
        {
            using (var contexto = new CrazyTechEntities())
            {
                var resultado = (from x in contexto.Producto
                                 where x.ProductoID == procesarFormulario
                                 select x).FirstOrDefault();

                return View(resultado);
            }
        }

        [VerificarLogin]
        public ActionResult InsertarProducto(Producto modelo)
        {

            using (var contexto = new CrazyTechEntities())


            {
                var resultado = (from x in contexto.Producto
                                 where x.ProductoID == modelo.ProductoID
                                 select x).FirstOrDefault();

                resultado.NombreProducto = modelo.NombreProducto;
                resultado.Precio = modelo.Precio;
                resultado.PorcentajeDescuento = modelo.PorcentajeDescuento;
                resultado.Descripcion = modelo.Descripcion;
                resultado.Cantidad = modelo.Cantidad;
                contexto.SaveChanges();


            }

            using (var contexto = new CrazyTechEntities())
            {
                var resultadoRespuesta = (from x in contexto.Producto
                                          where x.CategoriaProductoID == modelo.ProductoID
                                          select x).ToList();
                return RedirectToAction("Categorias", "Productos", resultadoRespuesta);
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

        public ActionResult EliminarJS(Producto producto)
        {
            using (var contexto = new CrazyTechEntities())
            {


                var resultado = (from x in contexto.Producto
                                 where x.ProductoID == producto.ProductoID
                                 select x).FirstOrDefault();
                if (resultado != null)
                {

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

        public ActionResult ActualizarJS(Producto producto)
        {
            using (var contexto = new CrazyTechEntities())
            {


                var resultado = (from x in contexto.Producto
                                 where x.ProductoID == producto.ProductoID
                                 select x).FirstOrDefault();
                return Json(JsonRequestBehavior.AllowGet);

            }

        }



    }
}
