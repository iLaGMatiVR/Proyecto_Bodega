using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Proyecto_Bodega
{
    public class Cliente : Persona
    {

        public int CodCliente { get; set; }
        public string Sexo { get; set; }


        public void ActualizarDatosCliente() { }


        public static List<Cliente> listaClientes = new List<Cliente>();

        public static void AgregarCliente(Cliente c)
        {
            //listaCliente.Add(cli);

            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))

            {
                con.Open(); //Abrimos la conex con la BD
                string textoCmd = "insert into Cliente (Nombre, NroDocumento, Telefono, Direccion, Sexo) " +
                    "VALUES (@Nombre, @NroDocumento, @Telefono, @Direccion, @Sexo)";
                SqlCommand cmd = new SqlCommand(textoCmd, con);

                //PARAMETROS	
                SqlParameter c1 = new SqlParameter("@Nombre", c.Nombre);
                SqlParameter c2 = new SqlParameter("@NroDocumento", c.NroDocumento);
                SqlParameter c3 = new SqlParameter("@Telefono", c.Telefono);
                SqlParameter c4 = new SqlParameter("@Direccion", c.Direccion);
                SqlParameter c5 = new SqlParameter("@Sexo", c.Sexo);


                //Le decimos a los parametros de que tipo de datos son
                c1.SqlDbType = SqlDbType.VarChar;
                c2.SqlDbType = SqlDbType.VarChar;
                c3.SqlDbType = SqlDbType.VarChar;
                c4.SqlDbType = SqlDbType.VarChar;
                c5.SqlDbType = SqlDbType.VarChar;


                //Agragamos los parametros al command
                cmd.Parameters.Add(c1);
                cmd.Parameters.Add(c2);
                cmd.Parameters.Add(c3);
                cmd.Parameters.Add(c4);
                cmd.Parameters.Add(c5);


                cmd.ExecuteNonQuery();

            }

        }

        public static void EliminarCliente(Cliente c)
        {
            //listaCliente.Remove(cli);

            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))

            {
                con.Open();
                string SENTENCIA_SQL = "delete from Cliente where CodCliente = @CodCliente";

                SqlCommand cmd = new SqlCommand(SENTENCIA_SQL, con);
                SqlParameter c6 = new SqlParameter("@CodCliente", c.CodCliente);
                c6.SqlDbType = SqlDbType.Int;
                cmd.Parameters.Add(c6);

                cmd.ExecuteNonQuery();
            }

        }
        public static void ModificarCliente(int index, Cliente c)
        {
            //Cliente.listaCliente[indice] = cli;

            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
            {
                con.Open();
                string textoCMD = "UPDATE Cliente SET Nombre = @Nombre, NroDocumento = @NroDocumento, Telefono = @Telefono, Direccion = @Direccion, Sexo = @Sexo where CodCliente = @CodCliente";

                SqlCommand cmd = new SqlCommand(textoCMD, con);

                //DEFINICION DE PARAMETROS
                SqlParameter c1 = new SqlParameter("@Nombre", c.Nombre);
                SqlParameter c2 = new SqlParameter("@NroDocumento", c.NroDocumento);
                SqlParameter c3 = new SqlParameter("@Telefono", c.Telefono);
                SqlParameter c4 = new SqlParameter("@Direccion", c.Direccion);
                SqlParameter c5 = new SqlParameter("@Sexo", c.Sexo);
                SqlParameter c6 = new SqlParameter("@CodCliente", c.CodCliente);

                //Le decimos a los parametros de que tipo de datos son
                c1.SqlDbType = SqlDbType.VarChar;
                c2.SqlDbType = SqlDbType.VarChar;
                c3.SqlDbType = SqlDbType.VarChar;
                c4.SqlDbType = SqlDbType.VarChar;
                c5.SqlDbType = SqlDbType.VarChar;
                c6.SqlDbType = SqlDbType.Int;

                cmd.Parameters.Add(c1);
                cmd.Parameters.Add(c2);
                cmd.Parameters.Add(c3);
                cmd.Parameters.Add(c4);
                cmd.Parameters.Add(c5);
                cmd.Parameters.Add(c6);

                cmd.ExecuteNonQuery();
            }

        }



        public static Cliente ObtenerCliente(int CodCliente)
        {
            Cliente cliente = null;

            if (listaClientes.Count == 0)
            {
                Cliente.ObtenerClientes();
            }

            foreach (Cliente c in listaClientes)
            {
                if (c.CodCliente == CodCliente)
                {
                    cliente = c;
                    break;
                }
            }

            return cliente;
        }

        public static List<Cliente> ObtenerClientes()
        {
            //return listaCliente;

            Cliente cliente;
            listaClientes.Clear();
            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))

            {
                con.Open();
                string textoCMD = "Select * from Cliente";

                SqlCommand cmd = new SqlCommand(textoCMD, con);

                SqlDataReader LeerDatos = cmd.ExecuteReader();

                while (LeerDatos.Read())
                {
                    cliente = new Cliente();
                    cliente.CodCliente = LeerDatos.GetInt32(0);
                    cliente.Nombre = LeerDatos.GetString(1);
                    cliente.NroDocumento = LeerDatos.GetString(2);
                    cliente.Telefono = LeerDatos.GetString(3);
                    cliente.Direccion = LeerDatos.GetString(4);
                    cliente.Sexo = LeerDatos.GetString(5);

                    listaClientes.Add(cliente);
                }

                return listaClientes;

            }

        }

        public override string ToString()
        {
            return this.Nombre;
        }
    }
}

