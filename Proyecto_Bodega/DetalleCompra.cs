using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace Proyecto_Bodega


{
    public class DetalleCompra
    {

        public int Id { get; set; }
        public Articulo Articulo { get; set; }
        public int Cantidad { get; set; }
        public int PrecioUnitario { get; set; }
        public string MontoTotal { get; set; }

        public static List<DetalleCompra> listaDetalleCompra = new List<DetalleCompra>();

        public static void AgregarDetalleCompra(DetalleCompra dc)
        {
            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))

            {
                con.Open();
                string textoCmd = "INSERT INTO DetalleCompra (articulo, Cantidad, PrecioUnitario, MontoTotal)VALUES (@Articulo, @Cantidad, @PrecioUnitario,@FechaDevolucion)";
                SqlCommand cmd = new SqlCommand(textoCmd, con);
                cmd = dc.ObtenerParametros(cmd);
                cmd.ExecuteNonQuery();
            }
        }

        public static void EliminarDetalleCompra(DetalleCompra detalleCompra)
        {
            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))

            {
                con.Open();
                string SENTENCIA_SQL = "delete from DetalleCompra where Id = @Id";

                SqlCommand cmd = new SqlCommand(SENTENCIA_SQL, con);
                SqlParameter p1 = new SqlParameter("@Id", detalleCompra.Id);
                p1.SqlDbType = SqlDbType.Int;
                cmd.Parameters.Add(p1);

                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        public static List<DetalleCompra> ObtenerDetalleCompra()
        {
            DetalleCompra DetalleCompra;

            listaDetalleCompra.Clear();

            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
            {
                con.Open();
                string tectoCMD = "select * from DetalleCompra";
                SqlCommand cmd = new SqlCommand(tectoCMD, con);

                SqlDataReader elLectorDeDatos = cmd.ExecuteReader();

                while (elLectorDeDatos.Read())
                {
                    DetalleCompra = new DetalleCompra();
                    DetalleCompra.Id = elLectorDeDatos.GetInt32(0);
                    DetalleCompra.Articulo = Articulo.ObtenerArticulo(elLectorDeDatos.GetInt32(1));
                    DetalleCompra.MontoTotal = elLectorDeDatos.GetString(2);
                    DetalleCompra.Cantidad = elLectorDeDatos.GetInt32(3);
                    DetalleCompra.PrecioUnitario = elLectorDeDatos.GetInt32(4);

                    listaDetalleCompra.Add(DetalleCompra);

                }
            }

            return listaDetalleCompra;
        }



        public override string ToString()
        {
            return this.MontoTotal;
        }



        private SqlCommand ObtenerParametros(SqlCommand cmd, Boolean id = false)

        {
            SqlParameter p1 = new SqlParameter("@Cantidad", this.Cantidad);
            SqlParameter p2 = new SqlParameter("@Articulo", this.Articulo.Id);
            SqlParameter p3 = new SqlParameter("@PrecioUnitario", this.PrecioUnitario);
            SqlParameter p4 = new SqlParameter("@MontoTotal", this.MontoTotal);

            p1.SqlDbType = SqlDbType.Int;
            p2.SqlDbType = SqlDbType.Int;
            p3.SqlDbType = SqlDbType.Int;
            p4.SqlDbType = SqlDbType.VarChar;

            cmd.Parameters.Add(p1);
            cmd.Parameters.Add(p2);
            cmd.Parameters.Add(p2);
            cmd.Parameters.Add(p3);

            if (id == true)
            {
                cmd = ObtenerParametrosId(cmd);
            }
            return cmd;

        }
        private SqlCommand ObtenerParametrosId(SqlCommand cmd)
        {

            SqlParameter p4 = new SqlParameter("@id", this.Id);
            p4.SqlDbType = SqlDbType.Int;
            cmd.Parameters.Add(p4);
            return cmd;
        }
    }
}
