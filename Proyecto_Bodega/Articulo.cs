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
        public string Proveedor { set; get; }

        public Articulo()
        {

        }
        public Articulo(int id, string descripcion, string marca, int costo, int precio_unit)
        {
            this.Id = id;
            this.Descripcion = descripcion;
            this.Marca = marca;
            this.Costo = costo;
            this.Precio_Unit = precio_unit;
            Proveedor proveedor = new Proveedor();
            

        }

        public void ActualizarPrecio () {}
    }
}
