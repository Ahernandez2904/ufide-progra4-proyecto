using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto.Models
{
    public class UsuarioModel
    {

        public void RegistrarUsuario(string nombre, string apellido1, string apellido2, int permisosID, int activos, string password, string email)
        {
            using (var contextoBD = new CrazyTechEntities())
            {
                contextoBD.Registrar_Usuarios(nombre, apellido1, apellido2, permisosID, activos, password, email);
            }
        }


        public void IngresarUsuario(string email, string password)
        {
            using (var contextoBD = new CrazyTechEntities())
            {

                contextoBD.Ingresar_Usuario(password, email);
            }
        }
    }
}