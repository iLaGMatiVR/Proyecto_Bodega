using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Bodega
{
    public class Factura
    {
        private int NroFactura { get; set; }
        private int Timbrado { get; set; }
        private Cliente CodCliente { get; set; }
        private string TipoPago { get; set; }
        private DateTime FechaFactura { get; set; }

    }
}
