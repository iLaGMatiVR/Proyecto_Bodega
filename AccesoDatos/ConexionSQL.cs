using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace AccesoDatos
{
    public abstract class ConexionSQL
    {
        private readonly String conexionString;
        public ConexionSQL()
        {
            conexionString = "Server=SGO-03; Database=AguilaCurda; user id=sa; password = MatiVR98";
        }
        protected SqlConnection GetConnection()
        {
            return new SqlConnection(conexionString);
        }
    }
}
