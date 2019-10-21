using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Bodega
{
    public enum TipoPago
    {
        Contado,
        Credito
    }

    public class Factura
    {
        public string NroFactura { get; set; }
        public string Timbrado { get; set; }
        public string Nombre { get; set; }
        public TipoPago TipoPago { get; set; }
        public DateTime FechaFactura { get; set; }

        public static List<Factura> listaFactura = new List<Factura>();

        public static void AgregarFactura(Factura fac)
        {
            listaFactura.Add(fac);
        }

        public static void EliminarFactura(Factura fact)
        {
            listaFactura.Remove(fact);
        }
        public static void ModificarFactura(Factura pre, int indice)
        {
            Factura.listaFactura[indice] = pre;
        }

        public static List<Factura> ObtenerFactura()
        {
            return listaFactura;
        }

        public override string ToString()
        {
            return this.NroFactura;
        }

    }
}
