using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using CapaComun.Cache;
namespace AccesoDatos
{
    public class user : ConexionSQL
    {
        public bool Login(string user, string pass)
        {
            using (var connection = GetConnection())
            {
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

                        while (reader.Read())
                        {
                            UserLoginCache.UserID = reader.GetInt32(0);
                            UserLoginCache.Nombre = reader.GetString(3);
                            UserLoginCache.Apellido = reader.GetString(4);
                            UserLoginCache.Cargo = reader.GetString(5);
                            UserLoginCache.Email = reader.GetString(6);
                        }
                        return true;

                    }
                    else
                        return false;

                }

            }
        }
        public string recoverPassword(string userRequesting)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "Select * from Usuarios where LoginName=@user or Email=@mail ";

                    command.Parameters.AddWithValue("@user", userRequesting);
                    command.Parameters.AddWithValue("@mail", userRequesting);
                    command.CommandType = System.Data.CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read() == true)
                    {
                        string userName = reader.GetString(3) + ", " + reader.GetString(4);
                        string userMail = reader.GetString(6);
                        string accountPassword = reader.GetString(2);


                        var mailService = new MailServices.SystemSupportMail();
                        mailService.sendMail(
                            subject: "SYSTEM : Password recovery request",
                            body: "Hi, " + userName + "\nYou Requested to Recover your password.\n" +
                            "your current password is: " + accountPassword +
                            "\nHowever, we ask that you change your password inmediately once you enter the system.",
                            recipienteMail: new List<string> { userMail }

                            );
                        return "Hi, " + userName + "\nYou Request to Recover your password.\n" +
                            "Please check your mail: " + userMail +
                            "\nHowever, we ask that you change your password inmediately once you enter the system. ";
                    }
                    else
                        return "Sorry, you do not have an account with that mail or username";

                }
            }
        }


        public void AnyMethod()
        {
            if (UserLoginCache.Cargo == Cargos.Administrador)
            {
                //
            }
            if(UserLoginCache.Cargo== Cargos.Cajero)
            {
                //
            }


        }
    }
}
