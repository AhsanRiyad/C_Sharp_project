using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BusTicketManagement
{
    public partial class UserControlUserTransaction : UserControl
    {

        string user_id;

        public UserControlUserTransaction(string user_id)
        {
            InitializeComponent();
            this.user_id = user_id;
        }

        private void ButtonSignUp_Click(object sender, EventArgs e)
        {

        }

        private void ButtonSignIn_Click(object sender, EventArgs e)
        {

        }

        private void UserControlUserTransaction_Load(object sender, EventArgs e)
        {
           display();
        }
        public void display()
        {
            SqlConnection con = Database_Connection.OpenCon();
            string query = "select trip_id,seat_no,date,price from user_history where user_id='" + user_id + "'";
            SqlCommand cmd = new SqlCommand(query,con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            cmd.ExecuteNonQuery();
            Database_Connection.CloseCon();

        
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}
