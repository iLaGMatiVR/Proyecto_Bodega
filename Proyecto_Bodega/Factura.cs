using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Bodega
{
    class Factura
    {
        public DateTime FechaEmision { get; set; }
        public int Timbrado { get; set; }
        public int NroFactura { get; set; }
        public int TimbradoVenta { get; set; }
        public int Iva { get; set; }
    }
}
