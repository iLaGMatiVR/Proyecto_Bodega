using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Bodega
{
    class Devolucion
    {
        public string Motivo_Devolucion { get; set; }

        public string Descripcion_Producto { set; get; }

        public string Precio_Venta { set; get; }


        public DateTime FechaDevolucion { get; set; }
    }
}
