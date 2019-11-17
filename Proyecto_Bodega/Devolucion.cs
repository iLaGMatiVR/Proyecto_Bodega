﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Proyecto_Bodega
{
    public class Devolucion
    {
        public int Id { set; get; }
        public string Motivo_Devolucion { get; set; }
        public Articulo Descripcion { set; get; }
        public DateTime FechaDevolucion { get; set; }

        public static List<Devolucion> listaDevoluciones = new List<Devolucion>();

        public static void AgregarDevolucion(Devolucion d)
        {
            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))

            {
                con.Open();
                string textoCmd = "INSERT INTO Devolucion (Motivo_Devolucion, Descripcion, FechaDevol)VALUES (@Motivo_Devolucion, @Descripcion,@FechaDevolucion)";
                SqlCommand cmd = new SqlCommand(textoCmd, con);
                cmd = d.ObtenerParametros(cmd);
                cmd.ExecuteNonQuery();
            }
        }
        public static void EliminarDevolucion(Devolucion devolucion)
        {
            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))

            {
                con.Open();
                string SENTENCIA_SQL = "delete from Devolucion where Id = @Id";

                SqlCommand cmd = new SqlCommand(SENTENCIA_SQL, con);
                SqlParameter p1 = new SqlParameter("@Id", devolucion.Id);
                p1.SqlDbType = SqlDbType.Int;
                cmd.Parameters.Add(p1);

                cmd.ExecuteNonQuery();
                con.Close();
            }
        }




        public static List<Devolucion> ObtenerDevoluciones()
        {
            Devolucion devolucion;

            listaDevoluciones.Clear();

            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
            {
                con.Open();
                string tectoCMD = "select * from Devolucion";
                SqlCommand cmd = new SqlCommand(tectoCMD, con);

                SqlDataReader elLectorDeDatos = cmd.ExecuteReader();

                while (elLectorDeDatos.Read())
                {
                    devolucion = new Devolucion();
                    devolucion.Id = elLectorDeDatos.GetInt32(0);
                    devolucion.Motivo_Devolucion = elLectorDeDatos.GetString(1);
                    devolucion.articulo = Articulo.ObtenerArticulos(elLectorDeDatos.GetInt32(2));
                    devolucion.FechaDevolucion = elLectorDeDatos.GetDateTime(3);

                    listaDevoluciones.Add(devolucion);

                }
            }

            return listaDevoluciones;
        }



        public override string ToString()
        {
            return this.Motivo_Devolucion;
        }



        private SqlCommand ObtenerParametros(SqlCommand cmd, Boolean id = false)

        {
            SqlParameter p1 = new SqlParameter("@Motivo", this.Motivo_Devolucion);
            SqlParameter p2 = new SqlParameter("@Descripcion", this.Descripcion.Id);
            SqlParameter p3 = new SqlParameter("@FechaDevol", this.FechaDevolucion);

            p1.SqlDbType = SqlDbType.VarChar;
            p2.SqlDbType = SqlDbType.Int;
            p3.SqlDbType = SqlDbType.DateTime;

            cmd.Parameters.Add(p1);
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
