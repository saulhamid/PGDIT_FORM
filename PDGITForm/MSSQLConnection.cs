using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDGIT1730
{
    public static class MSSQLConnection
    {
        public static SqlConnection MSSQLConn()
        {
            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection("Server=(localdb)\\StudentInfoDB;Integrated Security=true;AttachDbFileName= StudentInfoDB".ToString());
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return conn;
        }
    }
}
