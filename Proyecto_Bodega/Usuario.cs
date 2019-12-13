using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;
using CapaComun.Cache;

namespace Proyecto_Bodega
{
    public class Usuario
    {

            user User = new user();
            public bool LoginUser(string user, string pass) { 
            
                return User.Login(user, pass);
            }
        public string recoverPassword(string userRequesting)
        {
            return User.recoverPassword(userRequesting);
        }

        // Permisos y seguridad
        public void AnyMethod()
        {
            if (UserLoginCache.Cargo == Cargos.Administrador)
            {
                //
            }
            if (UserLoginCache.Cargo == Cargos.Cajero)
            {
                //
            }


        }


    }
}
