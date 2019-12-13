using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace AccesoDatos
{
    public class user:ConexionSQL
    {
        public bool Login(string user, string pass)
        {
            using (var connection = GetConnection()) { 
                connection.Open();

            using (var command = new SqlCommand())
                {

                    command.Connection = connection;
                    command.CommandText = "select * from Usuarios where LoginName =@user and Password=@pass";
                    command.Parameters.AddWithValue("@user", user);
                    command.Parameters.AddWithValue("@pass", pass);
                    command.CommandType = System.Data.CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        return true;

                    }
                    else
                        return false;

                }

            }
        }
    }
}
