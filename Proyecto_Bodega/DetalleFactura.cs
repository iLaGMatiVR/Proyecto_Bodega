using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace Proyecto_Bodega
{
    public class DetalleFactura
    {
        public double Cantidad { get; set; }
        public Articulo Articulo { get; set; }
        public double Precio { get; set; }

       

    }
}
