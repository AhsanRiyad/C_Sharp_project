using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BusTicketAdmin
{
    public partial class UserControlAdminFront : UserControl
    {
        string full_name;
        string user_id;
        Panel p;
        public UserControlAdminFront(string full_name ,string user_id , Panel p )
        {
            InitializeComponent();
            this.full_name = full_name;
            this.user_id = user_id;
            this.p = p;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void buttonlogout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Buttonaddoperator_Click(object sender, EventArgs e)
        {
            
        }

        private void UserControlAdminFront_Load(object sender, EventArgs e)
        {

        }

        private void Buttonmanagertrio_Click(object sender, EventArgs e)
        {
            //NewFolder1.UserControlManageTrip nu = new NewFolder1.UserControlManageTrip(user_id , full_name , panel1);
            //panel1.Controls.Clear();
            //panel1.Controls.Add(nu);

            FormManageTrip fm = new FormManageTrip(user_id, full_name);
            fm.Show();
        }

        private void Buttoncreateadmin_Click(object sender, EventArgs e)
        {
            FormCreateInfo fr = new FormCreateInfo();
            fr.Show();
        }
    }
}
