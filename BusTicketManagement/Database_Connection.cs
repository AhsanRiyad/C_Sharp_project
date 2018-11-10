using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusTicketManagement
{



    public class Database_Connection
    {
        public static SqlConnection con;
        public static string DBString;
        public Database_Connection()
        {
            


        }

        public static SqlConnection OpenCon()
        {
            con = new SqlConnection(@DBString);
            con.Open();
            return con;
        }
        public static SqlConnection CloseCon()
        {
            con.Close();
            return con;
        }


    }
}
