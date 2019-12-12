using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace Proyecto_Bodega
{
    public class DetalleFactura
    {
        public double Cantidad { get; set; }
        public Articulo Articulo { get; set; }
        public double Precio { get; set; }

        //    public static List<DetalleFactura> listaDetalleFactura = new List<DetalleFactura>();

        //    public static void AgregarDetalleFactura(DetalleFactura d)
        //    {
        //        using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))

        //        {
        //            con.Open();
        //            string textoCmd = "INSERT INTO DetalleFactura (Cantidad, Articulo, MontoTotal)VALUES (@Cantidad, @Articulo,@FechaDevolucion)";
        //            SqlCommand cmd = new SqlCommand(textoCmd, con);
        //            cmd = d.ObtenerParametros(cmd);
        //            cmd.ExecuteNonQuery();
        //        }
        //    }

        //    public static void EliminarDetalleFactura(DetalleFactura detallefactura)
        //    {
        //        using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))

        //        {
        //            con.Open();
        //            string SENTENCIA_SQL = "delete from DetalleFactura where Id = @Id";

        //            SqlCommand cmd = new SqlCommand(SENTENCIA_SQL, con);
        //            SqlParameter p1 = new SqlParameter("@Id", detallefactura.Id);
        //            p1.SqlDbType = SqlDbType.Int;
        //            cmd.Parameters.Add(p1);

        //            cmd.ExecuteNonQuery();
        //            con.Close();
        //        }
        //    }

        //    public static List<DetalleFactura> ObtenerDetalleFactura()
        //    {
        //        DetalleFactura DetalleFactura;

        //        listaDetalleFactura.Clear();

        //        using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
        //        {
        //            con.Open();
        //            string tectoCMD = "select * from DetalleFactura";
        //            SqlCommand cmd = new SqlCommand(tectoCMD, con);

        //            SqlDataReader elLectorDeDatos = cmd.ExecuteReader();

        //            while (elLectorDeDatos.Read())
        //            {
        //                DetalleFactura = new DetalleFactura();
        //                DetalleFactura.Id = elLectorDeDatos.GetInt32(0);
        //                DetalleFactura.MontoTotal = elLectorDeDatos.GetString(1);
        //                DetalleFactura.Cantidad = elLectorDeDatos.GetString(2);
        //                DetalleFactura.Articulo = Articulo.ObtenerArticulo(elLectorDeDatos.GetInt32(3));



        //                listaDetalleFactura.Add(DetalleFactura);

        //            }
        //        }

        //        return listaDetalleFactura;
        //    }



        //    public override string ToString()
        //    {
        //        return this.MontoTotal;
        //    }



        //    private SqlCommand ObtenerParametros(SqlCommand cmd, Boolean id = false)

        //    {
        //        SqlParameter p1 = new SqlParameter("@Cantidad", this.Cantidad);
        //        SqlParameter p2 = new SqlParameter("@Articulo", this.Articulo);
        //        SqlParameter p3 = new SqlParameter("@MontoTotal", this.MontoTotal);

        //        p1.SqlDbType = SqlDbType.VarChar;
        //        p2.SqlDbType = SqlDbType.Int;
        //        p3.SqlDbType = SqlDbType.VarChar;

        //        cmd.Parameters.Add(p1);
        //        cmd.Parameters.Add(p2);
        //        cmd.Parameters.Add(p3);

        //        if (id == true)
        //        {
        //            cmd = ObtenerParametrosId(cmd);
        //        }
        //        return cmd;

        //    }
        //    private SqlCommand ObtenerParametrosId(SqlCommand cmd)
        //    {

        //        SqlParameter p4 = new SqlParameter("@id", this.Id);
        //        p4.SqlDbType = SqlDbType.Int;
        //        cmd.Parameters.Add(p4);
        //        return cmd;
        //    }

    }
}
