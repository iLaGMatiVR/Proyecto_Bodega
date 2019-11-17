using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Proyecto_Bodega
{
    public enum TipoPago
    {
        Contado,
        Credito
    }

    public class Factura
    {
        public int Id { get; set; }
        public string NroFactura { get; set; }
        public string Timbrado { get; set; }
        public Cliente Cliente { get; set; }
        public TipoPago TipoPago { get; set; }
        public DateTime FechaFactura { get; set; }

        public static List<Factura> listaFactura = new List<Factura>();

        public static void AgregarFactura(Factura fac)
        {
            //listaFactura.Add(fac);
            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))

            {
                con.Open(); //Abrimos la conex con la BD
                string textoCmd = "insert into Factura (NroFactura, Timbrado, Cliente, TipoPago, FechaFactura) VALUES (@NroFactura, @Timbrado, @Cliente, @TipoPago,  @FechaFactura)";
                SqlCommand cmd = new SqlCommand(textoCmd, con);
                cmd = fac.ObtenerParametros(cmd);

                cmd.ExecuteNonQuery();

            }
        }

        public static void EliminarFactura(Factura f)
        {
            //listaFactura.Remove(fact);

            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))

            {
                con.Open();
                string SENTENCIA_SQL = "delete from Factura where Id = @Id";

                SqlCommand cmd = new SqlCommand(SENTENCIA_SQL, con);
                SqlParameter p6 = new SqlParameter("@Id", f.Id);
                p6.SqlDbType = SqlDbType.Int;
                cmd.Parameters.Add(p6);

                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
        public static void ModificarFactura(Factura f, int indice)
        {
            //Factura.listaFactura[indice] = pre;

            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
            {
                con.Open();
                string textoCMD = "UPDATE Factura SET NroFactura =@NroFactura, Timbrado= @Timbrado,Cliente=  @Cliente, TipoPago= @TipoPago, FechaFactura= @FechaFactura where Id = @Id";

                SqlCommand cmd = new SqlCommand(textoCMD, con);
                cmd = f.ObtenerParametros(cmd, true);

                cmd.ExecuteNonQuery();

            }
        }

        public static List<Factura> ObtenerFactura()
        {
            //return listaFactura;
            Factura factura;
            listaFactura.Clear();
            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))

            {
                con.Open();
                string textoCMD = "Select * from Factura";

                SqlCommand cmd = new SqlCommand(textoCMD, con);

                SqlDataReader elLectorDeDatos = cmd.ExecuteReader();

                while (elLectorDeDatos.Read())
                {
                    factura = new Factura();
                    factura.Id = elLectorDeDatos.GetInt32(0);
                    factura.NroFactura = elLectorDeDatos.GetString(1);
                    factura.Timbrado = elLectorDeDatos.GetString(2);
                    factura.Cliente = Cliente.ObtenerCliente(elLectorDeDatos.GetInt32(3));
                    factura.TipoPago = (TipoPago)elLectorDeDatos.GetInt16(4);
                    factura.FechaFactura = elLectorDeDatos.GetDateTime(5);
                    listaFactura.Add(factura);
                }

                return listaFactura;

            }
        }
        private SqlCommand ObtenerParametros(SqlCommand cmd, Boolean id = false)
        {
            //PARAMETROS
            SqlParameter p1 = new SqlParameter("@NroFactura", this.NroFactura);
            SqlParameter p2 = new SqlParameter("@Timbrado", this.Timbrado);
            SqlParameter p3 = new SqlParameter("@Cliente", this.Cliente);
            SqlParameter p4 = new SqlParameter("@TipoPago", this.TipoPago);
            SqlParameter p5 = new SqlParameter("@FechaFactura", this.FechaFactura);

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
