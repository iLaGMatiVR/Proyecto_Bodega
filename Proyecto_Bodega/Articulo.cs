using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Bodega
{
    class Articulo
    {
        public int Id { set; get;}
        public string Descripcion { set; get; }
        public string Marca { set; get; }
        public int Costo { set; get; }
        public int Precio_Unit { set; get; }
        public Proveedor Proveedor { set; get; }
        public static List<Articulo> ListaArticulos = new List<Articulo>();

        public Articulo()
        {
            
        }
        

        public static void AgregarArticulo(Articulo a)
        {
            ListaArticulos.Add(a);
        }
    }
}
