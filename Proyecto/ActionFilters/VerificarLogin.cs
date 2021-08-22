using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Proyecto.ActionFilters
{
    public class VerificarLogin : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            var sesionUsuario = filterContext.HttpContext;
            if (sesionUsuario.Session["Datos"] == null)
            {
                filterContext.Result = new RedirectToRouteResult(new System.Web.Routing.RouteValueDictionary(new { action = "IngresoUsuarios", Controller = "Usuario" }));
            }
            base.OnActionExecuting(filterContext);
        }
    }
}