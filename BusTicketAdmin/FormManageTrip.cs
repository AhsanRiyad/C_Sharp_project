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
    public partial class FormManageTrip : Form
    {
        string full_name; string id;
        public FormManageTrip(string full_name, string id)
        {
            InitializeComponent();
            this.full_name = full_name;
            this.id = id;
            Database_Connection.DBString = @"Data Source=DESKTOP-U5U2H6N\SQLEXPRESS;Initial Catalog=BusTicketLatest;Integrated Security=True";

        }

        private void FormManageTrip_Load(object sender, EventArgs e)
        {
            NewFolder1.UserControlManageTrip f = new NewFolder1.UserControlManageTrip(id , full_name , panelManageTrip);
            panelManageTrip.Controls.Clear();
            panelManageTrip.Controls.Add(f);

        }
    }
}
