using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Bodega
{
    public class Proveedor : Persona
    {
        public string CodProveedor { get; set; }
        public string PersonaContacto { get; set; } 

        public void CambiarPersonaContacto() {}

    

    public static List<Proveedor> listaProveedor = new List<Proveedor>();

    public static void AgregarProveedor(Proveedor pro)
    {
        listaProveedor.Add(pro);
    }

    public static void EliminarProveedor(Proveedor pro)
    {
        listaProveedor.Remove(pro);
    }
    public static void ModificarProveedor(Proveedor pro, int indice)
    {
        Proveedor.listaProveedor[indice] = pro;
    }

    public static List<Proveedor> ObtenerProveedor()
    {
        return listaProveedor;
    }

    public override string ToString()
    {
        return this.CodProveedor;
    }
    }

}
