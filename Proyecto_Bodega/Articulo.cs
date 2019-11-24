using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Proyecto_Bodega;

namespace Proyecto_Bodega
{
    public class Articulo
    {
        public int Id { set; get; }
        public string Descripcion { set; get; }
        public string Marca { set; get; }
        public double Costo { set; get; }
        public double Precio_Unit { set; get; }
        public DateTime Fecha_Venc { set; get; }
        public Proveedor Proveedor { set; get; }


        public Articulo articulo { set; get; }
        public static List<Articulo> ListaArticulos = new List<Articulo>();


        //metodo para obtener articulo
        public static List<Articulo> ObtenerArticulos()
        {
            Articulo articulo;
            ListaArticulos.Clear();
            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))

            {
                con.Open();
                string textoCMD = "Select * from Articulo";

                SqlCommand cmd = new SqlCommand(textoCMD, con);

                SqlDataReader elLectorDeDatos = cmd.ExecuteReader();

                while (elLectorDeDatos.Read())
                {
                    articulo = new Articulo();
                    articulo.Id = elLectorDeDatos.GetInt32(0);
                    articulo.Descripcion = elLectorDeDatos.GetString(1);
                    articulo.Marca = elLectorDeDatos.GetString(2);
                    articulo.Costo = elLectorDeDatos.GetDouble(3);
                    articulo.Precio_Unit = elLectorDeDatos.GetDouble(4);
                    articulo.Proveedor = Proveedor.ObtenerProveedor(elLectorDeDatos.GetInt32(5));
                    articulo.Fecha_Venc = elLectorDeDatos.GetDateTime(6);

                    ListaArticulos.Add(articulo);
                }

                return ListaArticulos;

            }
        }

        public static Articulo ObtenerArticulo(int id)
        {
            Articulo articulo = null;

            if (ListaArticulos.Count == 0)
            {
                Articulo.ObtenerArticulos();
            }

            foreach (Articulo a in ListaArticulos)
            {
                if (a.Id == id)
                {
                    articulo = a;
                    break;
                }
            }

            return articulo;
        }
        //metodo para agregar articulo
        public static void AgregarArticulo(Articulo a)
        {
            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))

            {
                con.Open();
                string textoCmd = "INSERT INTO Articulo (Descripcion, Marca, Costo, Precio_Unitario, Proveedor, Vencimiento) VALUES (@Descripcion, @Marca, @Costo, @Precio_Unitario, @Proveedor, @Vencimiento)";
                SqlCommand cmd = new SqlCommand(textoCmd, con);
                cmd = a.ObtenerParametros(cmd);

                cmd.ExecuteNonQuery();
            }
        }

        private SqlCommand ObtenerParametros(SqlCommand cmd, Boolean id = false)
        {
            SqlParameter p1 = new SqlParameter("@Descripcion", this.Descripcion);
            SqlParameter p2 = new SqlParameter("@Marca", this.Marca);
            SqlParameter p3 = new SqlParameter("@Costo", this.Costo);
            SqlParameter p4 = new SqlParameter("@Precio_Unitario", this.Precio_Unit);
            SqlParameter p5 = new SqlParameter("@Proveedor", this.Proveedor.CodProveedor);//es el id del proveedor para obtener dicho valor
            SqlParameter p6 = new SqlParameter("@Vencimiento", this.Fecha_Venc);

            p1.SqlDbType = SqlDbType.VarChar;
            p2.SqlDbType = SqlDbType.VarChar;
            p3.SqlDbType = SqlDbType.Float;
            p4.SqlDbType = SqlDbType.Float;
            p5.SqlDbType = SqlDbType.Int;
            p6.SqlDbType = SqlDbType.DateTime;


            cmd.Parameters.Add(p1);
            cmd.Parameters.Add(p2);
            cmd.Parameters.Add(p3);
            cmd.Parameters.Add(p4);
            cmd.Parameters.Add(p5);
            cmd.Parameters.Add(p6);

            if (id == true)
            {
                cmd = ObtenerParametrosId(cmd);
            }
            return cmd;
        }

        private SqlCommand ObtenerParametrosId(SqlCommand cmd)
        {
            SqlParameter p7 = new SqlParameter("@Id_Articulo", this.Id);
            p7.SqlDbType = SqlDbType.Int;
            cmd.Parameters.Add(p7);
            return cmd;
        }

        //Metodo para eliminar articulo
        public static void EliminarArticulo(Articulo a)
        {
            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))

            {
                con.Open();
                string SENTENCIA_SQL = "delete from Articulo where Id_Articulo = @Id_Articulo";

                SqlCommand cmd = new SqlCommand(SENTENCIA_SQL, con);
                SqlParameter p1 = new SqlParameter("@Id_Articulo", a.Id);
                p1.SqlDbType = SqlDbType.Int;
                cmd.Parameters.Add(p1);

                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        //metodo para modificar articulo
        public static void ModificarArticulo(int index, Articulo articulo)
        {
            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
            {
                con.Open();
                string textoCMD = "UPDATE Articulo SET Descripcion = @Descripcion, Marca = @Marca, Costo = @Costo, Precio_Unitario = @Precio_Unitario, Proveedor = @Proveedor, Vencimiento = @Vencimiento where Id_Articulo = @Id_Articulo";

                SqlCommand cmd = new SqlCommand(textoCMD, con);
                cmd = articulo.ObtenerParametros(cmd, true);

                cmd.ExecuteNonQuery();
            }
        }

        public override string ToString()
        {
            return Descripcion;
        }
    }
}

