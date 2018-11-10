using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusTicketAdmin
{
    public partial class Form1 : Form
    {
        string full_name;
        string user_id;
        public Form1(string full_name , string user_id)
        {
            InitializeComponent();
            this.full_name = full_name;
            this.user_id = user_id;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //  UserControloperator s = new UserControloperator();
            //s.panelSetUp(panelSignInForm);
            //  panel1.Controls.Add(s);

            // panel1.Controls.Add(new NewFolder1.UserControlManageTrip());
            Database_Connection.DBString = @"Data Source=DESKTOP-IBAJJID;Initial Catalog=BusTicket;Integrated Security=True";
            panel1.Controls.Clear();
            panel1.Controls.Add(new UserControlAdminFront(full_name , user_id , panel1));
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
