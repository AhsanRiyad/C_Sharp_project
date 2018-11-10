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

namespace BusTicketAdmin.NewFolder1
{
    public partial class UserControlCreate : UserControl
    {
        public UserControlCreate()
        {
            InitializeComponent();
        }

        private void labelusername_Click(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextboxfare_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void labelusertype_Click(object sender, EventArgs e)
        {

        }


        private void labelfullname_Click(object sender, EventArgs e)
        {

        }

        private void labelemail_Click(object sender, EventArgs e)
        {

        }

        private void UserControlCreate_Load(object sender, EventArgs e)
        {
            display();
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewShow_RowHeaderMouseClick);
        }

        private void Buttoninsert_Click(object sender, EventArgs e)
        {

            if (bunifuMaterialTextboxfullname.Text == string.Empty)
            {
                MessageBox.Show("enter your fullname");

            }
            else if (bunifuMaterialTextboxusername.Text == string.Empty)
            {
                MessageBox.Show("enter your username");

            }
            else if (bunifuMaterialTextboxpassword.Text == string.Empty)
            {
                MessageBox.Show("enter your password");

            }
            else if (bunifuMaterialTextboxemail.Text == string.Empty)
            {
                MessageBox.Show("enter your email");

            }
            else if (bunifuMaterialTextboxusertype.Text == string.Empty)
            {
                MessageBox.Show("enter your usertype");

            }
            else
            {
                try
                {
                    SqlConnection con = Database_Connection.OpenCon();

                    string query = "insert into user_info (full_name,user_name,password,email,user_type) values (@fullname,@username,@password,@email,@usertype)";
                    SqlCommand cmd = new SqlCommand(query, con);

                    cmd.Parameters.Add("@fullname", bunifuMaterialTextboxfullname.Text);
                    cmd.Parameters.Add("@username", bunifuMaterialTextboxusername.Text);
                    cmd.Parameters.Add("@password", bunifuMaterialTextboxpassword.Text);
                    cmd.Parameters.Add("@email", bunifuMaterialTextboxemail.Text);
                    cmd.Parameters.Add("@usertype", bunifuMaterialTextboxusertype.Text);


                    cmd.ExecuteNonQuery();


                    MessageBox.Show("insert successfully");
                    display();
                    Database_Connection.CloseCon();
                }
                catch (Exception ex)
                {

                    MessageBox.Show("check");
                }

            }

        }

        public void display()
        {

            SqlConnection con = Database_Connection.OpenCon();

            string query = "select * from user_info";
            SqlCommand cmd = new SqlCommand(query, con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            //cmd.Parameters.Add("@fullname", bunifuMaterialTextboxfullname.Text);
            //cmd.Parameters.Add("@username", bunifuMaterialTextboxusername.Text);
            //cmd.Parameters.Add("@password", bunifuMaterialTextboxpassword.Text);
            //cmd.Parameters.Add("@email", bunifuMaterialTextboxemail.Text);
            //cmd.Parameters.Add("@usertype", bunifuMaterialTextboxusertype.Text);

            cmd.ExecuteNonQuery();
            Database_Connection.CloseCon();
        }

        private void Buttonupdate_Click(object sender, EventArgs e)
        {
            if (bunifuMaterialTextboxusername.Text == string.Empty)
            {

                MessageBox.Show("For update enter username");
            }
            else
            {
                try
                {
                    SqlConnection con = Database_Connection.OpenCon();

                    string query = "update user_info set full_name='" + bunifuMaterialTextboxfullname.Text + "',password='" + bunifuMaterialTextboxpassword.Text + "',email='" + bunifuMaterialTextboxemail.Text + "',user_type='" + bunifuMaterialTextboxusertype.Text + "' where user_name='" + bunifuMaterialTextboxusername.Text + "'";
                    SqlCommand cmd = new SqlCommand(query, con);

                    //cmd.Parameters.Add("@fullname", bunifuMaterialTextboxfullname.Text);
                    //cmd.Parameters.Add("@username", bunifuMaterialTextboxusername.Text);
                    //cmd.Parameters.Add("@password", bunifuMaterialTextboxpassword.Text);
                    //cmd.Parameters.Add("@email", bunifuMaterialTextboxemail.Text);
                    //cmd.Parameters.Add("@usertype", bunifuMaterialTextboxusertype.Text);


                    cmd.ExecuteNonQuery();


                    MessageBox.Show("update successfully");
                    display();
                    Database_Connection.CloseCon();
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Check");
                }
            }
        }

        private void Buttondelete_Click(object sender, EventArgs e)
        {
            if (bunifuMaterialTextboxusername.Text == string.Empty)
            {
                MessageBox.Show("For delete enter username");

            }
            else
            {
                try
                {
                    SqlConnection con = Database_Connection.OpenCon();

                    string query = "delete from user_info where user_name='" + bunifuMaterialTextboxusername.Text + "'";
                    SqlCommand cmd = new SqlCommand(query, con);




                    cmd.ExecuteNonQuery();


                    MessageBox.Show("delete successfully");
                    display();
                    Database_Connection.CloseCon();
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Check");
                }
            }
        }

        private void buttonsearch_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = Database_Connection.OpenCon();

                string query = "select * from user_info where user_name='" + bunifuMaterialTextboxusername.Text + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;

                //cmd.Parameters.Add("@fullname", bunifuMaterialTextboxfullname.Text);
                //cmd.Parameters.Add("@username", bunifuMaterialTextboxusername.Text);
                //cmd.Parameters.Add("@password", bunifuMaterialTextboxpassword.Text);
                //cmd.Parameters.Add("@email", bunifuMaterialTextboxemail.Text);
                //cmd.Parameters.Add("@usertype", bunifuMaterialTextboxusertype.Text);

                cmd.ExecuteNonQuery();
                Database_Connection.CloseCon();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Check");

            }
        }

        private void buttonlogout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridViewShow_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            string fullnameB = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            string usernameB = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            string passwordB = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            string emailB = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            string usertypeB = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();


            bunifuMaterialTextboxfullname.Text = fullnameB;
            bunifuMaterialTextboxusername.Text = usernameB;
            bunifuMaterialTextboxemail.Text = emailB;
            bunifuMaterialTextboxusertype.Text = usertypeB;
        }

        private void bunifuMaterialTextboxpassword_OnValueChanged(object sender, EventArgs e)
        {
            

        }
    }
}
