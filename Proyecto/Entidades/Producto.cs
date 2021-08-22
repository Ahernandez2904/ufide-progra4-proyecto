using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto.Entidades
{
    public class Producto
    {
        public int ProductoID { get; set; }
        public string NombreProducto { get; set; }
        public string Descripcion { get; set; }
        public int Cantidad { get; set; }
        public Boolean Activo { get; set; }
        public int Precio { get; set; }
        public int PorcentajeDescuento { get; set; }
        public int CategoriaProductoID { get; set; }
    }
}