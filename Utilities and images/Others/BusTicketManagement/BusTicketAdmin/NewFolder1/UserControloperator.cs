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

namespace BusTicketAdmin
{
    public partial class UserControloperator : UserControl
    {
        public UserControloperator()
        {
            InitializeComponent();
        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UserControloperator_Load(object sender, EventArgs e)
        {
            display();
            //SqlConnection con = BusTicketManagement.Database_Connection.OpenCon();

            
            //string query = "select * from operator_info";
            //SqlCommand cmd = new SqlCommand(query,con);
            //cmd.ExecuteNonQuery();
            //BusTicketManagement.Database_Connection.CloseCon();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Buttoninsert_Click(object sender, EventArgs e)
        {
            
            SqlConnection con = Database_Connection.OpenCon();
            string query = "insert into operator_info(id,name,fare) values (@id,@name,@fare)";
            SqlCommand cmd = new SqlCommand(query,con);
            cmd.Parameters.Add("@id", bunifuMaterialTextboxid.Text);
            cmd.Parameters.Add("@name", bunifuMaterialTextboxname.Text);
            cmd.Parameters.Add("@fare", bunifuMaterialTextboxfare.Text);

            cmd.ExecuteNonQuery();
            MessageBox.Show("insert successfully");
            display();
            Database_Connection.CloseCon();
        }

        public void display()
        {
            SqlConnection con = Database_Connection.OpenCon();
            string query = "select * from operator_info";
            SqlCommand cmd = new SqlCommand(query, con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            cmd.ExecuteNonQuery();
            Database_Connection.CloseCon();
        }

        private void Buttonupdate_Click(object sender, EventArgs e)
        {
            SqlConnection con = Database_Connection.OpenCon();
            string query = "update operator_info set name='"+bunifuMaterialTextboxname.Text+"',fare='"+bunifuMaterialTextboxfare.Text+"' where id='"+bunifuMaterialTextboxid.Text+"'";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.Add("@id", bunifuMaterialTextboxid.Text);
            cmd.Parameters.Add("@name", bunifuMaterialTextboxname.Text);
            cmd.Parameters.Add("@fare", bunifuMaterialTextboxfare.Text);

            cmd.ExecuteNonQuery();
            MessageBox.Show("update successfully");
            display();
            Database_Connection.CloseCon();
        }

        private void Buttondelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = Database_Connection.OpenCon();
            string query = "delete from operator_info where id='" + bunifuMaterialTextboxid.Text + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.Add("@id", bunifuMaterialTextboxid.Text);
            cmd.Parameters.Add("@name", bunifuMaterialTextboxname.Text);
            cmd.Parameters.Add("@fare", bunifuMaterialTextboxfare.Text);

            cmd.ExecuteNonQuery();
            MessageBox.Show("delete successfully");
            display();
            Database_Connection.CloseCon();
        }

        private void buttonsearch_Click(object sender, EventArgs e)
        {
            SqlConnection con = Database_Connection.OpenCon();
            string query = "select * from operator_info where id='"+bunifuMaterialTextboxid.Text+"'";
            SqlCommand cmd = new SqlCommand(query, con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            cmd.ExecuteNonQuery();
            Database_Connection.CloseCon();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
