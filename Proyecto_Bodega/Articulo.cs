using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Bodega
{
    class Articulo
    {
        public int Id { set; get; }
        public string Descripcion { set; get; }
        public string Marca { set; get; }
        public double Costo { set; get; }
        public double Precio_Unit { set; get; }
        public DateTime Fecha_Venc { set; get; }
        public Proveedor Proveedor { set; get; }
        public static List<Articulo> ListaArticulos = new List<Articulo>();

        public override string ToString()
        {
            return Descripcion;
        }

        //metodo para obtener articulo
        public static List<Articulo> ObtenerArticulos()
        {
            return ListaArticulos;
        }

        //metodo para agregar articulo
        public static void AgregarArticulo(Articulo a)
        {
            ListaArticulos.Add(a);
        }

        //Metodo para eliminar articulo
        public static void EliminarArticulo(Articulo a)
        {
            ListaArticulos.Remove(a);
        }

        //metodo para modificar articulo
        public static void ModificarArticulo(Articulo a, int indice)
        {
            Articulo.ListaArticulos[indice] = a;
        }
    }
}
