using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Bodega
{
    public class Cliente : Persona
    {
        public string CodCliente { get; set; }
        public string Sexo { get; set; }
        public DateTime FechaNacimiento { get; set; }

        public void ActualizarDatosCliente() { }
    

    public static List<Cliente> listaCliente = new List<Cliente>();

    public static void AgregarCliente(Cliente cli)
    {
        listaCliente.Add(cli);
    }

    public static void EliminarCliente(Cliente cli)
    {
        listaCliente.Remove(cli);
    }
    public static void ModificarCliente(Cliente cli, int indice)
    {
        Cliente.listaCliente[indice] = cli;
    }

    public static List<Cliente> ObtenerCliente()
    {
        return listaCliente;
    }

    public override string ToString()
    {
        return this.CodCliente;
    }
}
}

