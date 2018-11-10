using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusTicketManagement
{
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Database_Connection.DBString = @"Data Source=DESKTOP-IBAJJID;Initial Catalog=BusTicket;Integrated Security=True";
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            FormBusTicketBD f1 = new FormBusTicketBD();
            Application.Run(f1);
            
        }
    }
}
