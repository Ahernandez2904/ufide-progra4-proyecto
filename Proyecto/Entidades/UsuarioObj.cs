using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto.Entidades
{
    public class UsuarioObj
    {
        public int id { get; set; }
        public string username { get; set; }
        public string email { get; set; }
        public string password { get; set; }

        public string nombre { get; set; }

        public string apellido1 { get; set; }

        public string apellido2 { get; set; }

        public bool activo { get; set; }
    }
}