//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Proyecto
{
    using System;
    using System.Collections.Generic;
    
    public partial class Ticket
    {
        public int TicketID { get; set; }
        public int Usuario_Empleado_Asig { get; set; }
        public int Usuario_Cliente { get; set; }
        public int Estado_Ticket { get; set; }
        public System.DateTime Fecha { get; set; }
        public int Presupuesto { get; set; }
        public string Detalles { get; set; }
    }
}
