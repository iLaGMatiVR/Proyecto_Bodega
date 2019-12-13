using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaComun.Cache
{
    public static class UserLoginCache
    {
        public static int UserID { get; set; }
        public static string Nombre { get; set; }
        public static string Apellido { get; set; }
        public static string Cargo { get; set; }
        public static string Email { get; set; }
    }
}
