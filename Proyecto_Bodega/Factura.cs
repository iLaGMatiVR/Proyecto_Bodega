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
    public enum TipoPago
    {
        Contado,
        Credito
    }

    public class Factura
    {
        public int Id { get; set; }
        public int NroFactura { get; set; }
        public int Timbrado { get; set; }
        public Cliente Cliente { get; set; }
        public TipoPago TipoPago { get; set; }
        public DateTime FechaFactura { get; set; }
        public double MontoTotal { get; set; }

        public Articulo articulo { get; set; }

        public List<DetalleFactura> detalle_factura = new List<DetalleFactura>();

        public static List<Factura> listaFactura = new List<Factura>();


        public static void AgregarFactura(Factura fac)
        {
            //listaFactura.Add(fac);
            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))

            {
                con.Open(); //Abrimos la conex con la BD
                string textoCmd = @"insert into Factura (NroFactura, Timbrado, Cliente, TipoPago, FechaFactura, MontoTotal) output INSERTED.id VALUES (@NroFactura, @Timbrado, @Cliente, @TipoPago,  @FechaFactura, @MontoTotal)";

                SqlCommand cmd = new SqlCommand(textoCmd, con);
                SqlParameter p1 = new SqlParameter("@NroFactura", fac.NroFactura);
                SqlParameter p2 = new SqlParameter("@Timbrado", fac.Timbrado);
                SqlParameter p3 = new SqlParameter("@Cliente", fac.Cliente.CodCliente);
                SqlParameter p4 = new SqlParameter("@TipoPago", fac.TipoPago);
                SqlParameter p5 = new SqlParameter("@FechaFactura", fac.FechaFactura);
                SqlParameter p6 = new SqlParameter("@MontoTotal", fac.MontoTotal);
                p1.SqlDbType = SqlDbType.Int;
                p2.SqlDbType = SqlDbType.Int;
                p3.SqlDbType = SqlDbType.Int;
                p4.SqlDbType = SqlDbType.Int;
                p5.SqlDbType = SqlDbType.DateTime;
                p6.SqlDbType = SqlDbType.Int;
                cmd.Parameters.Add(p1);
                cmd.Parameters.Add(p2);
                cmd.Parameters.Add(p3);
                cmd.Parameters.Add(p4);
                cmd.Parameters.Add(p5);
                cmd.Parameters.Add(p6);

                int factura_id = (int)cmd.ExecuteScalar();

                foreach (DetalleFactura df in fac.detalle_factura)
                {
                    string textoCmd2 = "INSERT INTO DetalleFactura (factura_id, Cantidad, Articulo, Precio)VALUES (@id, @Cantidad, @Articulo, @Precio)";
                    SqlCommand cmd2 = new SqlCommand(textoCmd2, con);

                    SqlParameter p7 = new SqlParameter("@id", factura_id);
                    SqlParameter p8 = new SqlParameter("@Cantidad", df.Cantidad);
                    SqlParameter p9 = new SqlParameter("@Articulo", df.Articulo.Id);
                    SqlParameter p10 = new SqlParameter("@Precio", df.Precio);
                    p7.SqlDbType = SqlDbType.Int;
                    p8.SqlDbType = SqlDbType.Float;
                    p9.SqlDbType = SqlDbType.Int;
                    p10.SqlDbType = SqlDbType.Float;
                    cmd2.Parameters.Add(p7);
                    cmd2.Parameters.Add(p8);
                    cmd2.Parameters.Add(p9);
                    cmd2.Parameters.Add(p10);

                    cmd2.ExecuteNonQuery();
                }

            }
        }

        public static void EliminarFactura(Factura fact)
        {
            listaFactura.Remove(fact);

            
        }
       

        public static List<Factura> ObtenerFactura()
        {
            return listaFactura;
           
        }



        public override string ToString()
        {
            return this.Cliente.Nombre;
        }

    }
}
