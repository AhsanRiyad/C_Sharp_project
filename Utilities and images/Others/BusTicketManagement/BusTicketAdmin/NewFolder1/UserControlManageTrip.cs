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
    public partial class UserControlManageTrip : UserControl
    {
        string id;
        string full_name;
        Panel p;
        public UserControlManageTrip(string id , string full_name , Panel p )
        {
            InitializeComponent();
            this.id = id;
            this.full_name = full_name;
            this.p = p;

        }

        private void labeladdid_Click(object sender, EventArgs e)
        {

        }

        private void labelfare_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuDatepicker1_onValueChanged(object sender, EventArgs e)
        {

        }
         
        private void Buttoninsert_Click(object sender, EventArgs e)
        {
            if (bunifuMaterialTextboxname.Text == string.Empty)
            {
                MessageBox.Show("enter your name");
            }
            else if (bunifuMaterialTextboxid.Text == string.Empty)
            {
                MessageBox.Show("enter your id");
            }
            else if (bunifuDropdownto.selectedValue == string.Empty)
            {
                MessageBox.Show("enter your value");
            }
            else if (bunifuDropdownfrom.selectedValue == string.Empty)
            {
                MessageBox.Show("enter your value");
            }
            else if (bunifuDropdowntime.selectedValue == string.Empty)
            {
                MessageBox.Show("enter your time");
            }
            else if (bunifuMaterialTextboxfare.Text == string.Empty)
            {
                MessageBox.Show("enter your fare");
            }
         

            else
            {
                
                try
                {

                    SqlConnection con = Database_Connection.OpenCon();
                
                    string query = "insert into Bus_info (Name,ID,To_1,From_1,Date,Time,Fare,Type,seat) values (@name,@id,@to,@from,@date,@time,@fare,@type,@seat)";
                    SqlCommand cmd = new SqlCommand(query, con);

                    cmd.Parameters.Add("@name", bunifuMaterialTextboxname.Text);
                    cmd.Parameters.Add("@id", bunifuMaterialTextboxid.Text);
                    cmd.Parameters.Add("@to", bunifuDropdownto.selectedValue);
                    cmd.Parameters.Add("@from", bunifuDropdownfrom.selectedValue);
                    cmd.Parameters.Add("@time", bunifuDropdowntime.selectedValue);
                    cmd.Parameters.Add("@date", bunifuDatepickerdate.Value);
                    cmd.Parameters.Add("@fare", bunifuMaterialTextboxfare.Text);
                    cmd.Parameters.Add("@type", bunifuMaterialTextboxtype.Text);
                    cmd.Parameters.Add("@seat", bunifuMaterialTextboxseat.Text);


                    cmd.ExecuteNonQuery();
                    

                    MessageBox.Show("insert successfully");
                    display();
                    Database_Connection.CloseCon();
                    Ss();



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
            string query = "select * from Bus_info";
            SqlCommand cmd = new SqlCommand(query, con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            cmd.ExecuteNonQuery();
            Database_Connection.CloseCon();
        
        }

        private void UserControlManageTrip_Load(object sender, EventArgs e)
        {
            display();
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewShow_RowHeaderMouseClick);

        }

        private void Buttondelete_Click(object sender, EventArgs e)
        {
            if (bunifuMaterialTextboxid.Text == string.Empty)
            {
                MessageBox.Show("for delete please enter your id");
            }
            else
            {
                try
                {
                    SqlConnection con = Database_Connection.OpenCon();
                    string query = "delete from Bus_info where Id='" + bunifuMaterialTextboxid.Text + "'";
                    SqlCommand cmd = new SqlCommand(query, con);
                    //cmd.Parameters.Add("@id", bunifuMaterialTextboxid.Text);
                    //cmd.Parameters.Add("@name", bunifuMaterialTextboxname.Text);
                    //cmd.Parameters.Add("@to", bunifuDropdownto.selectedValue);
                    //cmd.Parameters.Add("@from", bunifuDropdownfrom.selectedValue);
                    //cmd.Parameters.Add("@time", bunifuDropdowntime.selectedValue);
                    //cmd.Parameters.Add("@date", bunifuDatepickerdate.Value);
                    //cmd.Parameters.Add("@fare", bunifuMaterialTextboxfare.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("delete successfully");
                    display();
                    
                    Database_Connection.CloseCon();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("exception");
                }
            }
        }

        private void Buttonupdate_Click(object sender, EventArgs e)
        {
            if (bunifuMaterialTextboxid.Text == string.Empty)
            {
                MessageBox.Show("For update information please enter your id");
            }
            try
            {
                SqlConnection con = Database_Connection.OpenCon();
                string query = "update Bus_info set Name='" + bunifuMaterialTextboxname.Text + "',To_1='" + bunifuDropdownto.selectedValue + "',From_1='" + bunifuDropdownfrom.selectedValue + "',Time='" + bunifuDropdowntime.selectedValue + "',Date='" + bunifuDatepickerdate.Value + "',Fare='" + bunifuMaterialTextboxfare.Text + "' where ID='" + bunifuMaterialTextboxid.Text + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.Add("@id", bunifuMaterialTextboxid.Text);
                cmd.Parameters.Add("@name", bunifuMaterialTextboxname.Text);
                cmd.Parameters.Add("@to", bunifuDropdownto.selectedValue);
                cmd.Parameters.Add("@from", bunifuDropdownfrom.selectedValue);
                cmd.Parameters.Add("@time", bunifuDropdowntime.selectedValue);
                cmd.Parameters.Add("@date", bunifuDatepickerdate.Value);
                cmd.Parameters.Add("@fare", bunifuMaterialTextboxfare.Text);

                cmd.ExecuteNonQuery();
               
                display();
                MessageBox.Show("Update successfully");
                Database_Connection.CloseCon();
            }
            catch (Exception ex)
            {
                MessageBox.Show("you r missed values");
            }
           
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dataGridViewShow_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
           
            string nameB = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            string idB = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            string toB = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            string fromB = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            string timeB = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            string fareB = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            string typeB = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            string seatB = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();

            bunifuMaterialTextboxid.Text = idB;
            bunifuMaterialTextboxname.Text = nameB;
           
            bunifuMaterialTextboxfare.Text = fareB;
            bunifuMaterialTextboxtype.Text = typeB;
            bunifuMaterialTextboxseat.Text = seatB;

          

        
        }

        private void bunifuDropdownto_onItemSelected(object sender, EventArgs e)
        {
            
        }

        private void labelfrom_Click(object sender, EventArgs e)
        {

        }

        private void buttonlogout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public void Ss()
        {
            string s = bunifuMaterialTextboxid.Text;
            int i_id = Int32.Parse(s);


            SqlConnection con = Database_Connection.OpenCon();
            string query1 = "insert into seat_status (seat_no , status, trip_id) values ('a1' , 'free' , '"+i_id+"' )";
            SqlCommand cmd = new SqlCommand(query1, con);
            //cmd.Parameters.Add("@tip", s);
            cmd.ExecuteNonQuery();
            Database_Connection.CloseCon();

            con = Database_Connection.OpenCon();
            string query2 = "insert into seat_status (seat_no , status, trip_id) values ('a2' , 'free' , '"+i_id+"' )";
            cmd = new SqlCommand(query2, con);
            //cmd.Parameters.Add("@tip", s);
            cmd.ExecuteNonQuery();
            Database_Connection.CloseCon();

            con = Database_Connection.OpenCon();
            string query3 = "insert into seat_status (seat_no , status, trip_id) values ('a3' , 'free' , '"+i_id+"' )";
            cmd = new SqlCommand(query3, con);
            //cmd.Parameters.Add("@tip", s);
            cmd.ExecuteNonQuery();
            Database_Connection.CloseCon();


            con = Database_Connection.OpenCon();
            string query4 = "insert into seat_status (seat_no , status, trip_id) values ('a4' , 'free' , '" +i_id+"' )";
            cmd = new SqlCommand(query4, con);
            cmd.Parameters.Add("@tip", s);
            cmd.ExecuteNonQuery();
            Database_Connection.CloseCon();

            con = Database_Connection.OpenCon();
            string query5 = "insert into seat_status (seat_no , status, trip_id) values ('b1' , 'free' , @tip )";
            cmd = new SqlCommand(query5, con);
            cmd.Parameters.Add("@tip", bunifuMaterialTextboxid.Text);
            cmd.ExecuteNonQuery();
            Database_Connection.CloseCon();

            con = Database_Connection.OpenCon();
            string query6 = "insert into seat_status (seat_no , status, trip_id) values ('b2' , 'free' , @tip )";
            cmd = new SqlCommand(query6, con);
            cmd.Parameters.Add("@tip", bunifuMaterialTextboxid.Text);
            cmd.ExecuteNonQuery();
            Database_Connection.CloseCon();

            con = Database_Connection.OpenCon();
            string query7 = "insert into seat_status (seat_no , status, trip_id) values ('b3' , 'free' , @tip )";
            cmd = new SqlCommand(query7, con);
            cmd.Parameters.Add("@tip", bunifuMaterialTextboxid.Text);
            cmd.ExecuteNonQuery();
            Database_Connection.CloseCon();


            con = Database_Connection.OpenCon();
            string query8 = "insert into seat_status (seat_no , status, trip_id) values ('b4' , 'free' , @tip )";
            cmd = new SqlCommand(query8, con);
            cmd.Parameters.Add("@tip", bunifuMaterialTextboxid.Text);
            cmd.ExecuteNonQuery();
            Database_Connection.CloseCon();

            con = Database_Connection.OpenCon();
            string query9 = "insert into seat_status (seat_no , status, trip_id) values ('c1' , 'free' , @tip )";
            cmd = new SqlCommand(query9, con);
            cmd.Parameters.Add("@tip", bunifuMaterialTextboxid.Text);
            cmd.ExecuteNonQuery();
            Database_Connection.CloseCon();

            con = Database_Connection.OpenCon();
            string query10 = "insert into seat_status (seat_no , status, trip_id) values ('c2' , 'free' , @tip )";
            cmd = new SqlCommand(query10, con);
            cmd.Parameters.Add("@tip", bunifuMaterialTextboxid.Text);
            cmd.ExecuteNonQuery();
            Database_Connection.CloseCon();

            con = Database_Connection.OpenCon();
            string query11 = "insert into seat_status (seat_no , status, trip_id) values ('c3' , 'free' , @tip )";
            cmd = new SqlCommand(query11, con);
            cmd.Parameters.Add("@tip", bunifuMaterialTextboxid.Text);
            cmd.ExecuteNonQuery();
            Database_Connection.CloseCon();

            con = Database_Connection.OpenCon();
            string query12 = "insert into seat_status (seat_no , status, trip_id) values ('c4' , 'free' , @tip )";
            cmd = new SqlCommand(query12, con);
            cmd.Parameters.Add("@tip", bunifuMaterialTextboxid.Text);
            cmd.ExecuteNonQuery();
            Database_Connection.CloseCon();

            con = Database_Connection.OpenCon();
            string query13 = "insert into seat_status (seat_no , status, trip_id) values ('d1' , 'free' , @tip )";
            cmd = new SqlCommand(query13, con);
            cmd.Parameters.Add("@tip", bunifuMaterialTextboxid.Text);
            cmd.ExecuteNonQuery();
            Database_Connection.CloseCon();

            con = Database_Connection.OpenCon();
            string query14 = "insert into seat_status (seat_no , status, trip_id) values ('d2' , 'free' , @tip )";
            cmd = new SqlCommand(query14, con);
            cmd.Parameters.Add("@tip", bunifuMaterialTextboxid.Text);
            cmd.ExecuteNonQuery();
            Database_Connection.CloseCon();

            con = Database_Connection.OpenCon();
            string query15 = "insert into seat_status (seat_no , status, trip_id) values ('d3' , 'free' , @tip )";
            cmd = new SqlCommand(query15, con);
            cmd.Parameters.Add("@tip", bunifuMaterialTextboxid.Text);
            cmd.ExecuteNonQuery();
            Database_Connection.CloseCon();

            con = Database_Connection.OpenCon();
            string query16 = "insert into seat_status (seat_no , status, trip_id) values ('d4' , 'free' , @tip )";
            cmd = new SqlCommand(query16, con);
            cmd.Parameters.Add("@tip", bunifuMaterialTextboxid.Text);
            cmd.ExecuteNonQuery();
            Database_Connection.CloseCon();

            con = Database_Connection.OpenCon();
            string query17 = "insert into seat_status (seat_no , status, trip_id) values ('e1' , 'free' , @tip )";
            cmd = new SqlCommand(query17, con);
            cmd.Parameters.Add("@tip", bunifuMaterialTextboxid.Text);
            cmd.ExecuteNonQuery();
            Database_Connection.CloseCon();

            con = Database_Connection.OpenCon();
            string query18 = "insert into seat_status (seat_no , status, trip_id) values ('e2' , 'free' , @tip )";
            cmd = new SqlCommand(query18, con);
            cmd.Parameters.Add("@tip", bunifuMaterialTextboxid.Text);
            cmd.ExecuteNonQuery();
            Database_Connection.CloseCon();

            con = Database_Connection.OpenCon();
            string query19 = "insert into seat_status (seat_no , status, trip_id) values ('e3' , 'free' , @tip )";
            cmd = new SqlCommand(query19, con);
            cmd.Parameters.Add("@tip", bunifuMaterialTextboxid.Text);
            cmd.ExecuteNonQuery();
            Database_Connection.CloseCon();

            con = Database_Connection.OpenCon();
            string query20 = "insert into seat_status (seat_no , status, trip_id) values ('e4' , 'free' , @tip )";
            cmd = new SqlCommand(query20, con);
            cmd.Parameters.Add("@tip", bunifuMaterialTextboxid.Text);
            cmd.ExecuteNonQuery();
            Database_Connection.CloseCon();

            con = Database_Connection.OpenCon();
            string query21 = "insert into seat_status (seat_no , status, trip_id) values ('f1' , 'free' , @tip )";
            cmd = new SqlCommand(query21, con);
            cmd.Parameters.Add("@tip", bunifuMaterialTextboxid.Text);
            cmd.ExecuteNonQuery();
            Database_Connection.CloseCon();

            con = Database_Connection.OpenCon();
            string query22 = "insert into seat_status (seat_no , status, trip_id) values ('f2' , 'free' , @tip )";
            cmd = new SqlCommand(query22, con);
            cmd.Parameters.Add("@tip", bunifuMaterialTextboxid.Text);
            cmd.ExecuteNonQuery();
            Database_Connection.CloseCon();

            con = Database_Connection.OpenCon();
            string query23 = "insert into seat_status (seat_no , status, trip_id) values ('f3' , 'free' , @tip )";
            cmd = new SqlCommand(query23, con);
            cmd.Parameters.Add("@tip", bunifuMaterialTextboxid.Text);
            cmd.ExecuteNonQuery();
            Database_Connection.CloseCon();

            con = Database_Connection.OpenCon();
            string query24 = "insert into seat_status (seat_no , status, trip_id) values ('f4' , 'free' , @tip )";
            cmd = new SqlCommand(query24, con);
            cmd.Parameters.Add("@tip", bunifuMaterialTextboxid.Text);
            cmd.ExecuteNonQuery();
            Database_Connection.CloseCon();
        }


        public void seatStts() {
            string s = bunifuMaterialTextboxid.Text;
            int i_id = Int32.Parse(s);


            SqlConnection con = Database_Connection.OpenCon();
            string query1 = "insert into seat_status (seat_no , status, trip_id) values ('a1' , 'free' , '"+i_id+"' )";
            SqlCommand cmd = new SqlCommand(query1, con);
            //cmd.Parameters.Add("@tip", s);
            cmd.ExecuteNonQuery();

            query1 = "insert into seat_status (seat_no , status, trip_id) values ('a2' , 'free' , '"+i_id+"' )";
            cmd = new SqlCommand(query1, con);
            //cmd.Parameters.Add("@tip", s);
            cmd.ExecuteNonQuery();

            query1 = "insert into seat_status (seat_no , status, trip_id) values ('a3' , 'free' , '"+i_id+"' )";
            cmd = new SqlCommand(query1, con);
            //cmd.Parameters.Add("@tip", s);
            cmd.ExecuteNonQuery();


            query1 = "insert into seat_status (seat_no , status, trip_id) values ('a4' , 'free' , '"+i_id+"' )";
            cmd = new SqlCommand(query1, con);
            //cmd.Parameters.Add("@tip", s);
            cmd.ExecuteNonQuery();


            query1 = "insert into seat_status (seat_no , status, trip_id) values ('b1' , 'free' , '"+i_id+"' )";
            cmd = new SqlCommand(query1, con);
            //cmd.Parameters.Add("@tip", s);
            cmd.ExecuteNonQuery();

            query1 = "insert into seat_status (seat_no , status, trip_id) values ('b2' , 'free' , '" + i_id + "' )";
            cmd = new SqlCommand(query1, con);
            //cmd.Parameters.Add("@tip", s);
            cmd.ExecuteNonQuery();

            query1 = "insert into seat_status (seat_no , status, trip_id) values ('b3' , 'free' , '" + i_id + "' )";
            cmd = new SqlCommand(query1, con);
            //cmd.Parameters.Add("@tip", s);
            cmd.ExecuteNonQuery();

            query1 = "insert into seat_status (seat_no , status, trip_id) values ('b4' , 'free' , '" + i_id + "' )";
            cmd = new SqlCommand(query1, con);
            //cmd.Parameters.Add("@tip", s);
            cmd.ExecuteNonQuery();


            query1 = "insert into seat_status (seat_no , status, trip_id) values ('c1' , 'free' , '" + i_id + "' )";
            cmd = new SqlCommand(query1, con);
            //cmd.Parameters.Add("@tip", s);
            cmd.ExecuteNonQuery();


            query1 = "insert into seat_status (seat_no , status, trip_id) values ('c2' , 'free' , '" + i_id + "' )";
            cmd = new SqlCommand(query1, con);
            //cmd.Parameters.Add("@tip", s);
            cmd.ExecuteNonQuery();



            query1 = "insert into seat_status (seat_no , status, trip_id) values ('c3' , 'free' , '" + i_id + "' )";
            cmd = new SqlCommand(query1, con);
            //cmd.Parameters.Add("@tip", s);
            cmd.ExecuteNonQuery();


            query1 = "insert into seat_status (seat_no , status, trip_id) values ('c4' , 'free' , '" + i_id + "' )";
            cmd = new SqlCommand(query1, con);
            //cmd.Parameters.Add("@tip", s);
            cmd.ExecuteNonQuery();



            query1 = "insert into seat_status (seat_no , status, trip_id) values ('d1' , 'free' , '" + i_id + "' )";
            cmd = new SqlCommand(query1, con);
            //cmd.Parameters.Add("@tip", s);
            cmd.ExecuteNonQuery();





            query1 = "insert into seat_status (seat_no , status, trip_id) values ('d2' , 'free' , '" + i_id + "' )";
            cmd = new SqlCommand(query1, con);
            //cmd.Parameters.Add("@tip", s);
            cmd.ExecuteNonQuery();




            query1 = "insert into seat_status (seat_no , status, trip_id) values ('d3' , 'free' , '" + i_id + "' )";
            cmd = new SqlCommand(query1, con);
            //cmd.Parameters.Add("@tip", s);
            cmd.ExecuteNonQuery();




            query1 = "insert into seat_status (seat_no , status, trip_id) values ('d4' , 'free' , '" + i_id + "' )";
            cmd = new SqlCommand(query1, con);
            //cmd.Parameters.Add("@tip", s);
            cmd.ExecuteNonQuery();





            query1 = "insert into seat_status (seat_no , status, trip_id) values ('e1' , 'free' , '" + i_id + "' )";
            cmd = new SqlCommand(query1, con);
            //cmd.Parameters.Add("@tip", s);
            cmd.ExecuteNonQuery();





            query1 = "insert into seat_status (seat_no , status, trip_id) values ('e2' , 'free' , '" + i_id + "' )";
            cmd = new SqlCommand(query1, con);
            //cmd.Parameters.Add("@tip", s);
            cmd.ExecuteNonQuery();




            query1 = "insert into seat_status (seat_no , status, trip_id) values ('e3' , 'free' , '" + i_id + "' )";
            cmd = new SqlCommand(query1, con);
            //cmd.Parameters.Add("@tip", s);
            cmd.ExecuteNonQuery();






            query1 = "insert into seat_status (seat_no , status, trip_id) values ('e4' , 'free' , '" + i_id + "' )";
            cmd = new SqlCommand(query1, con);
            //cmd.Parameters.Add("@tip", s);
            cmd.ExecuteNonQuery();





            query1 = "insert into seat_status (seat_no , status, trip_id) values ('f1' , 'free' , '" + i_id + "' )";
            cmd = new SqlCommand(query1, con);
            //cmd.Parameters.Add("@tip", s);
            cmd.ExecuteNonQuery();



            query1 = "insert into seat_status (seat_no , status, trip_id) values ('f2' , 'free' , '" + i_id + "' )";
            cmd = new SqlCommand(query1, con);
            //cmd.Parameters.Add("@tip", s);
            cmd.ExecuteNonQuery();


            query1 = "insert into seat_status (seat_no , status, trip_id) values ('f3' , 'free' , '" + i_id + "' )";
            cmd = new SqlCommand(query1, con);
            //cmd.Parameters.Add("@tip", s);
            cmd.ExecuteNonQuery();


            ////query1 = "insert into seat_status (seat_no , status, trip_id) values ('f4' , 'free' , '" + i_id + "' )";
            cmd = new SqlCommand(query1, con);
            //cmd.Parameters.Add("@tip", s);
            cmd.ExecuteNonQuery();




            Database_Connection.CloseCon();



        }





        private void bunifuDropdowntime_onItemSelected(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextboxtype_OnValueChanged(object sender, EventArgs e)
        {
            bunifuMaterialTextboxtype.Text = "NonAc";
        }

        private void bunifuMaterialTextboxseat_OnValueChanged(object sender, EventArgs e)
        {
           
           this.bunifuMaterialTextboxseat.Text = "24";
        }
    }
}
