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

    public enum MedioPago
    {
        Efectivo,
        Tarjeta
    }
    public class Compra
    {

        public int Id { get; set; }
        public int NroFactura { get; set; }
        public Proveedor Proveedor { get; set; }
        public string Direccion { get; set; }
        public MedioPago MedioPago { get; set; }
        public DateTime FechaCompra { get; set; }

        public double MontoTotal { get; set; }



        public List<DetalleCompra> detalle_compra = new List<DetalleCompra>();

        public static List<Compra> listaCompra = new List<Compra>();

        public static void AgregarCompra(Compra com)
        {
            //listaFactura.Add(fac);
            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))

            {
                con.Open(); //Abrimos la conex con la BD
                string textoCmd = "insert into Compra (NroFactura, Proveedor, Direccion, MedioPago, FechaCompra, MontoTotal) VALUES (@NroFactura, @Proveedor, @Direccion, @TipoPago,  @FechaCompra, @MontoTotal)";
                SqlCommand cmd = new SqlCommand(textoCmd, con);
                //PARAMETROS

                SqlParameter p1 = new SqlParameter("@NroFactura", com.NroFactura);
                SqlParameter p2 = new SqlParameter("@Proveedor", com.Proveedor.CodProveedor);
                SqlParameter p3 = new SqlParameter("@Direccion", com.Direccion);
                SqlParameter p4 = new SqlParameter("@MedioPago", com.MedioPago);
                SqlParameter p5 = new SqlParameter("@FechaCompra", com.FechaCompra);
                SqlParameter p6 = new SqlParameter("@MontoTotal", com.MontoTotal);


                //Le decimos a los parametros de que tipo de datos son
                p1.SqlDbType = SqlDbType.Int;
                p2.SqlDbType = SqlDbType.Int;
                p3.SqlDbType = SqlDbType.Int;
                p4.SqlDbType = SqlDbType.Int;
                p5.SqlDbType = SqlDbType.DateTime;
                p6.SqlDbType = SqlDbType.Int;

                //Agragamos los parametros al command
                cmd.Parameters.Add(p1);
                cmd.Parameters.Add(p2);
                cmd.Parameters.Add(p3);
                cmd.Parameters.Add(p4);
                cmd.Parameters.Add(p5);
                cmd.Parameters.Add(p6);

                int CompraId = (int)cmd.ExecuteScalar();

                foreach (DetalleCompra dc in com.detalle_compra)
                {
                    string textoCmd2 = "INSERT INTO DetalleCompra (Articulo, Cantidad, Costo, CompraId)VALUES (@Articulo, @Cantidad, @Costo, @id)";
                    SqlCommand cmd2 = new SqlCommand(textoCmd2, con);

                    SqlParameter p7 = new SqlParameter("@Articulo", dc.Articulo);
                    SqlParameter p8 = new SqlParameter("@Cantidad", dc.Cantidad);
                    SqlParameter p9 = new SqlParameter("@Costo", dc.Costo);
                    SqlParameter p10 = new SqlParameter("@id", CompraId);
                    p7.SqlDbType = SqlDbType.Int;
                    p8.SqlDbType = SqlDbType.Float;
                    p9.SqlDbType = SqlDbType.Float;
                    p10.SqlDbType = SqlDbType.Int;
                    cmd2.Parameters.Add(p7);
                    cmd2.Parameters.Add(p8);
                    cmd2.Parameters.Add(p9);
                    cmd2.Parameters.Add(p10);

                    cmd2.ExecuteNonQuery();
                }

                cmd.ExecuteNonQuery();

            }
        }

        public static void EliminarCompra(Compra com)
        {

            listaCompra.Remove(com);
        }

        public static List<Compra> ObtenerCompra()
        {

            return listaCompra;

        }






        public override string ToString()
        {
            return this.Proveedor.Nombre;
        }

    }
}
