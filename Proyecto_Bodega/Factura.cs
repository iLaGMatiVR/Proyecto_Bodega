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
        public string NroFactura { get; set; }
        public string Timbrado { get; set; }
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
                p1.SqlDbType = SqlDbType.VarChar;
                p2.SqlDbType = SqlDbType.VarChar;
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

            //using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))

            //{
            //    con.Open();
            //    string SENTENCIA_SQL = "delete from Factura where Id = @Id";

            //    SqlCommand cmd = new SqlCommand(SENTENCIA_SQL, con);
            //    SqlParameter p6 = new SqlParameter("@Id", f.Id);
            //    p6.SqlDbType = SqlDbType.Int;
            //    cmd.Parameters.Add(p6);

            //    cmd.ExecuteNonQuery();
            //    con.Close();
            //}
        }
        public static void ModificarFactura(Factura f, int indice)
        {
            //Factura.listaFactura[indice] = pre;

            //using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
            //{
            //    con.Open();
            //    string textoCMD = "UPDATE Factura SET NroFactura =@NroFactura, Timbrado= @Timbrado,Cliente=  @Cliente, TipoPago= @TipoPago, FechaFactura= @FechaFactura where Id = @Id";

            //    SqlCommand cmd = new SqlCommand(textoCMD, con);
            //    cmd = f.ObtenerParametros(cmd, true);

            //    cmd.ExecuteNonQuery();

            //}
        }

        public static List<Factura> ObtenerFactura()
        {
            return listaFactura;
            //Factura factura;
            //listaFactura.Clear();
            //using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))

            //{
            //    con.Open();
            //    string textoCMD = "Select * from Factura";

            //    SqlCommand cmd = new SqlCommand(textoCMD, con);

            //    SqlDataReader elLectorDeDatos = cmd.ExecuteReader();

            //    while (elLectorDeDatos.Read())
            //    {
            //        factura = new Factura();
            //        factura.Id = elLectorDeDatos.GetInt32(0);
            //        factura.NroFactura = elLectorDeDatos.GetString(1);
            //        factura.Timbrado = elLectorDeDatos.GetString(2);
            //        factura.Cliente = Cliente.ObtenerCliente(elLectorDeDatos.GetInt32(3));
            //        factura.TipoPago = (TipoPago)elLectorDeDatos.GetInt32(4);
            //        factura.FechaFactura = elLectorDeDatos.GetDateTime(5);
            //        listaFactura.Add(factura);
            //    }

            //    return listaFactura;

            //}
        }



        //private SqlCommand ObtenerParametros(SqlCommand cmd, Boolean id = false)
        //{
        //    //PARAMETROS
        //    SqlParameter p1 = new SqlParameter("@NroFactura", this.NroFactura);
        //    SqlParameter p2 = new SqlParameter("@Timbrado", this.Timbrado);
        //    SqlParameter p3 = new SqlParameter("@Cliente", this.Cliente.CodCliente);
        //    SqlParameter p4 = new SqlParameter("@TipoPago", this.TipoPago);
        //    SqlParameter p5 = new SqlParameter("@FechaFactura", this.FechaFactura);

        //    //Le decimos a los parametros de que tipo de datos son
        //    p1.SqlDbType = SqlDbType.VarChar;
        //    p2.SqlDbType = SqlDbType.VarChar;
        //    p3.SqlDbType = SqlDbType.Int;
        //    p4.SqlDbType = SqlDbType.Int;
        //    p5.SqlDbType = SqlDbType.DateTime;

        //    //Agragamos los parametros al command
        //    cmd.Parameters.Add(p1);
        //    cmd.Parameters.Add(p2);
        //    cmd.Parameters.Add(p3);
        //    cmd.Parameters.Add(p4);
        //    cmd.Parameters.Add(p5);

        //    if (id == true)
        //    {
        //        cmd = ObtenerParametrosId(cmd);
        //    }
        //    return cmd;
        //}

        //private SqlCommand ObtenerParametrosId(SqlCommand cmd)
        //{
        //    SqlParameter p8 = new SqlParameter("@id", this.Id);
        //    p8.SqlDbType = SqlDbType.Int;
        //    cmd.Parameters.Add(p8);
        //    return cmd;

        //}

        public override string ToString()
        {
            return this.NroFactura;
        }

    }
}
