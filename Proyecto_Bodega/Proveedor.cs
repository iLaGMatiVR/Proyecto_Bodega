using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Proyecto_Bodega
{
    public class Proveedor : Persona
    {
		
		public int CodProveedor { get; set; }
        public string PersonaContacto { get; set; } 

        public void CambiarPersonaContacto() {}

    

    public static List<Proveedor> listaProveedores = new List<Proveedor>();

    public static void AgregarProveedor(Proveedor p)
    {
			//listaProveedor.Add(pro);


			using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))

			{
				con.Open(); //Abrimos la conex con la BD
				string textoCmd = "insert into Proveedor (Nombre, NroDocumento, Telefono, Direccion, PersonaContacto) " +
					"VALUES (@Nombre, @NroDocumento, @Telefono, @Direccion, @PersonaContacto)";
				SqlCommand cmd = new SqlCommand(textoCmd, con);

				//PARAMETROS	
				SqlParameter p1 = new SqlParameter("@Nombre", p.Nombre);
				SqlParameter p2 = new SqlParameter("@NroDocumento", p.NroDocumento);
				SqlParameter p3 = new SqlParameter("@Telefono", p.Telefono);
				SqlParameter p4 = new SqlParameter("@Direccion", p.Direccion);
				SqlParameter p5 = new SqlParameter("@PersonaContacto", p.PersonaContacto);

				//Le decimos a los parametros de que tipo de datos son
				p1.SqlDbType = SqlDbType.VarChar;
				p2.SqlDbType = SqlDbType.VarChar;
				p3.SqlDbType = SqlDbType.VarChar;
				p4.SqlDbType = SqlDbType.VarChar;
				p5.SqlDbType = SqlDbType.VarChar;

				//Agragamos los parametros al command
				cmd.Parameters.Add(p1);
				cmd.Parameters.Add(p2);
				cmd.Parameters.Add(p3);
				cmd.Parameters.Add(p4);
				cmd.Parameters.Add(p5);

				cmd.ExecuteNonQuery();

			}

		}

    public static void EliminarProveedor(Proveedor p)
    {
			//listaProveedor.Remove(pro);

			using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))

			{
				con.Open();
				string SENTENCIA_SQL = "delete from Proveedor where CodProveedor = @CodProveedor";

				SqlCommand cmd = new SqlCommand(SENTENCIA_SQL, con);
				SqlParameter p6 = new SqlParameter("@CodProveedor", p.CodProveedor);
				p6.SqlDbType = SqlDbType.Int;
				cmd.Parameters.Add(p6);

				cmd.ExecuteNonQuery();
			}
		}
    public static void ModificarProveedor(int index, Proveedor p)
    {
			//Proveedor.listaProveedor[indice] = pro;

			using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
			{
				con.Open();
				string textoCMD = "UPDATE Proveedor SET Nombre = @Nombre, NroDocumento = @NroDocumento, Telefono = @Telefono, Direccion = @Direccion, PersonaContacto = @PersonaContacto where CodProveedor = @CodProveedor";

				SqlCommand cmd = new SqlCommand(textoCMD, con);

				//DEFINICION DE PARAMETROS
				SqlParameter p1 = new SqlParameter("@Nombre", p.Nombre);
				SqlParameter p2 = new SqlParameter("@NroDocumento", p.NroDocumento);
				SqlParameter p3 = new SqlParameter("@Telefono", p.Telefono);
				SqlParameter p4 = new SqlParameter("@Direccion", p.Direccion);
				SqlParameter p5 = new SqlParameter("@PersonaContacto", p.PersonaContacto);
				SqlParameter p6 = new SqlParameter("@CodProveedor", p.CodProveedor);

				//Le decimos a los parametros de que tipo de datos son
				p1.SqlDbType = SqlDbType.VarChar;
				p2.SqlDbType = SqlDbType.VarChar;
				p3.SqlDbType = SqlDbType.VarChar;
				p4.SqlDbType = SqlDbType.VarChar;
				p5.SqlDbType = SqlDbType.VarChar;
				p6.SqlDbType = SqlDbType.Int;

				cmd.Parameters.Add(p1);
				cmd.Parameters.Add(p2);
				cmd.Parameters.Add(p3);
				cmd.Parameters.Add(p4);
				cmd.Parameters.Add(p5);
				cmd.Parameters.Add(p6);

				cmd.ExecuteNonQuery();
			}
		}

		public static Proveedor ObtenerProveedor(int CodProveedor)
		{
			Proveedor proveedor = null;

			if (listaProveedores.Count == 0)
			{
				Proveedor.ObtenerProveedores();
			}

			foreach (Proveedor p in listaProveedores)
			{
				if (p.CodProveedor == CodProveedor)
				{
					proveedor = p;
					break;
				}
			}

			return proveedor;
		}

		public static List<Proveedor> ObtenerProveedores()
    {
			//return listaProveedor;
			Proveedor proveedor;
			listaProveedores.Clear();
			using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))

			{
				con.Open();
				string textoCMD = "Select * from Proveedor";

				SqlCommand cmd = new SqlCommand(textoCMD, con);

				SqlDataReader LeerDatos = cmd.ExecuteReader();

				while (LeerDatos.Read())
				{
					proveedor = new Proveedor();
					proveedor.CodProveedor = LeerDatos.GetInt32(0);
					proveedor.Nombre = LeerDatos.GetString(1);
					proveedor.NroDocumento = LeerDatos.GetString(2);
					proveedor.Telefono = LeerDatos.GetString(3);
					proveedor.Direccion = LeerDatos.GetString(4);
					proveedor.PersonaContacto = LeerDatos.GetString(5);

					listaProveedores.Add(proveedor);
				}

				return listaProveedores;

			}
		}

    public override string ToString()
    {
        return this.Nombre;
    }
    }

}
