using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto.Entidades
{
    public class TicketObj
    {
        public int TicketID { get; set; }
        public int Usuario_Empleado_Asig { get; set; }
        public int Usuario_Cliente { get; set; }
        public int Estado_Ticket { get; set; }
        public DateTime Fecha { get; set; }
        public int Presupuesto { get; set; }
        public String Detalles { get; set; }
    }
}