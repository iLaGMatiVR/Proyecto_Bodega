using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;

namespace Proyecto_Bodega
{
    public class Usuario
    {

            user User = new user();
            public bool LoginUser(string user, string pass) { 
            
                return user.Login(user, pass);
            }

        
    }
}
