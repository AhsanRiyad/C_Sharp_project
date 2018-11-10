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
    public partial class UserControlShowBusesGridView : UserControl
    {
        string date;
        string dateforquery;
        int trip_id;
        string userId;
        string to1;
        string from1;
        DateTime dateOrginal;
        System.Windows.Forms.Panel panelSignInForm;
        string full_name;


        public UserControlShowBusesGridView(string date , string sdateforquery , string to1 , string from1 , System.Windows.Forms.Panel panelSignInForm , string userId , DateTime dateOrginal , string full_name)
        {
            InitializeComponent();
            this.date = date;
            this.dateforquery = sdateforquery;
            this.userId = userId;
            this.panelSignInForm = panelSignInForm;
            labelDateText.Text = date;
            labelToFrom.Text = to1 + " to " + from1;
            this.to1 = to1;
            this.from1 = from1;
            this.dateOrginal = dateOrginal;
            this.full_name = full_name;
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UserControlShowBusesGridView_Load(object sender, EventArgs e)
        {
            try {

                SqlConnection con = Database_Connection.OpenCon();

                string query = @"select ID, name, time , fare , seat from Bus_info where date='"+dateforquery+"' and To_1='"+to1+"' and From_1='"+from1+"'";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@dd", dateforquery);
                cmd.Parameters.AddWithValue("@tt", to1);
                cmd.Parameters.AddWithValue("@frm", from1);

                //MessageBox.Show(query);
                //MessageBox.Show(to1);
                //MessageBox.Show(from1);



                SqlDataAdapter sqlDa = new SqlDataAdapter(cmd);

                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                dataGridViewBusAvailable.DataSource = dtbl;



            }
            catch (SqlException ex) {

                MessageBox.Show("You have made an database exception");

            }
            catch (Exception ex) {


                MessageBox.Show("You have made an database exception");

            }


            

            
        }

            private void dataGridViewShow_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {


            try {

                string tip = dataGridViewBusAvailable.Rows[e.RowIndex].Cells[0].Value.ToString();
                string NameB = dataGridViewBusAvailable.Rows[e.RowIndex].Cells[1].Value.ToString();
                string timeB = dataGridViewBusAvailable.Rows[e.RowIndex].Cells[2].Value.ToString();
                string fareB = dataGridViewBusAvailable.Rows[e.RowIndex].Cells[3].Value.ToString();
                string seatAv = dataGridViewBusAvailable.Rows[e.RowIndex].Cells[4].Value.ToString();


                trip_id = Int32.Parse(tip);

                labelBusName.Text = "Operator: " + NameB;
                labelTime.Text = "Time: " + timeB;
                labelFare.Text = "Fare: " + fareB;
                labelSeatAv.Text = "Seat Ava: " + seatAv;


            }
            catch (SqlException ex) {

                MessageBox.Show("You don't have any input");

            }
            catch (Exception ex) {

                MessageBox.Show("You don't have any input");

            }




            

            }

        private void dataGridViewBusAvailable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelSignInForm.Controls.Clear();
            panelSignInForm.Controls.Add(new UserControlUser(userId, full_name , panelSignInForm));
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ButtonSignIn_Click(object sender, EventArgs e)
        {
            if (trip_id != 0)
            {

                panelSignInForm.Controls.Clear();
                panelSignInForm.Controls.Add(new UserControlSeat(trip_id, panelSignInForm, userId , date));
            }
            else
            {
                MessageBox.Show("No Bus Available\n You have not selected any bus");

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dateOrginal = dateOrginal.AddDays(1);
            string s = dateOrginal.ToString("yyyy-MM-dd");
            string dates = dateOrginal.ToString("dd-MMMM-yyyy");
            labelDateText.Text = dates;

            try
            {

                SqlConnection con = Database_Connection.OpenCon();

                string query = @"select ID, name, time , fare , seat from Bus_info where date= @dd and To_1=@tt and From_1=@frm";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@dd", s);
                cmd.Parameters.AddWithValue("@tt", to1);
                cmd.Parameters.AddWithValue("@frm", from1);


                SqlDataAdapter sqlDa = new SqlDataAdapter(cmd);

                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                dataGridViewBusAvailable.DataSource = dtbl;



            }
            catch (SqlException ex)
            {

                MessageBox.Show("You have made an database exception");

            }
            catch (Exception ex)
            {


                MessageBox.Show("You have made an database exception");

            }



        }
    }

    


}

        
    

