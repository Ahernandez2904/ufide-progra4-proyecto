using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto.Entidades
{
    public class Factura
    {
        public int Facturas_ID { get; set; }
        public int usuario_cliente_id { get; set; }
        public int ticket_ID { get; set; }
        public DateTime fecha { get; set; }
    }
}