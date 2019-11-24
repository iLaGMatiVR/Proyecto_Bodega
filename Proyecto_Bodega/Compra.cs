using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Proyecto_Bodega
{

    public enum MedioPago
    {
        Efectivo,
        Tarjeta
    }
    public class Compra
    {

        public int Id { get; set; }
        public string NroFactura { get; set; }
        public Proveedor Proveedor { get; set; }
        public string Direccion { get; set; }
        public MedioPago MedioPago { get; set; }
        public DateTime FechaCompra { get; set; }

        public static List<Compra> listaCompra = new List<Compra>();

        public static void AgregarCompra(Compra com)
        {
            //listaFactura.Add(fac);
            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))

            {
                con.Open(); //Abrimos la conex con la BD
                string textoCmd = "insert into Compra (NroFactura, Proveedor, Direccion, MedioPago, FechaCompra) VALUES (@NroFactura, @Proveedor, @Direccion, @TipoPago,  @FechaCompra)";
                SqlCommand cmd = new SqlCommand(textoCmd, con);
                cmd = com.ObtenerParametros(cmd);

                cmd.ExecuteNonQuery();

            }
        }

        public static void EliminarCompra(Compra c)
        {


            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))

            {
                con.Open();
                string SENTENCIA_SQL = "delete from Compra where Id = @Id";

                SqlCommand cmd = new SqlCommand(SENTENCIA_SQL, con);
                SqlParameter p6 = new SqlParameter("@Id", c.Id);
                p6.SqlDbType = SqlDbType.Int;
                cmd.Parameters.Add(p6);

                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
        public static void ModificarCompra(Compra c, int indice)
        {


            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
            {
                con.Open();
                string textoCMD = "UPDATE Compra SET NroFactura =@NroFactura, Cliente=  @Cliente, Direccion= @Direccion, MedioPago= @MedioPago, FechaCompra= @FechaCompra where Id = @Id";

                SqlCommand cmd = new SqlCommand(textoCMD, con);
                cmd = c.ObtenerParametros(cmd, true);

                cmd.ExecuteNonQuery();

            }
        }

        public static List<Compra> ObtenerCompra()
        {

            Compra compra;
            listaCompra.Clear();
            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))

            {
                con.Open();
                string textoCMD = "Select * from Factura";

                SqlCommand cmd = new SqlCommand(textoCMD, con);

                SqlDataReader elLectorDeDatos = cmd.ExecuteReader();

                while (elLectorDeDatos.Read())
                {
                    compra = new Compra();
                    compra.Id = elLectorDeDatos.GetInt32(0);
                    compra.NroFactura = elLectorDeDatos.GetString(1);
                    compra.Proveedor = Proveedor.ObtenerProveedor(elLectorDeDatos.GetInt32(2));
                    compra.Direccion = elLectorDeDatos.GetString(3);
                    compra.MedioPago = (MedioPago)elLectorDeDatos.GetInt16(4);
                    compra.FechaCompra = elLectorDeDatos.GetDateTime(5);
                    listaCompra.Add(compra);
                }

                return listaCompra;

            }
        }
        private SqlCommand ObtenerParametros(SqlCommand cmd, Boolean id = false)
        {
            //PARAMETROS
            SqlParameter p1 = new SqlParameter("@NroFactura", this.NroFactura);
            SqlParameter p3 = new SqlParameter("@Proveedor", this.Proveedor);
            SqlParameter p2 = new SqlParameter("@Timbrado", this.Direccion);
            SqlParameter p4 = new SqlParameter("@MedioPago", this.MedioPago);
            SqlParameter p5 = new SqlParameter("@FechaCompra", this.FechaCompra);

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

            if (id == true)
            {
                cmd = ObtenerParametrosId(cmd);
            }
            return cmd;
        }

        private SqlCommand ObtenerParametrosId(SqlCommand cmd)
        {
            SqlParameter p8 = new SqlParameter("@id", this.Id);
            p8.SqlDbType = SqlDbType.Int;
            cmd.Parameters.Add(p8);
            return cmd;

        }

        public override string ToString()
        {
            return this.NroFactura;
        }

    }
}
