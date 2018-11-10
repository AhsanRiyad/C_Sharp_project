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
    public partial class UserControlBuyTicket : UserControl
    {
        string userId;
        Panel panelSignInForm ;
        int i;
        int trip_id;
        List<string> l;
        string date1;

        public UserControlBuyTicket(string userId , Panel panelSignInForm , int i , int trip_id , List<string> l , string date1)
        {
            InitializeComponent();
            this.userId = userId;
            this.panelSignInForm = panelSignInForm;
            this.i = i;
            int taka = i * 500;
            labelTotalTicket.Text = Convert.ToString(i);
            labelFareTicket.Text = Convert.ToString(taka);
            this.trip_id = trip_id;
            this.l = l;
            this.date1 = date1;


        }

        private void labelSeatAvailable_Click(object sender, EventArgs e)
        {

        }

        private void UserControlBuyTicket_Load(object sender, EventArgs e)
        {

        }

        private void labelOperatorNameDb_Click(object sender, EventArgs e)
        {

        }

        private void labelFareTicket_Click(object sender, EventArgs e)
        {

        }

        private void ButtonSearchAgain_Click(object sender, EventArgs e)
        {
            panelSignInForm.Controls.Clear();
            panelSignInForm.Controls.Add(new UserControlSeat(trip_id , panelSignInForm, userId , date1));
        }

        private void ButtonConfirm_Click(object sender, EventArgs e)
        {
            try {

                
               
                foreach (string el in l)
                {
                    Console.WriteLine(el);
                    SqlConnection con = Database_Connection.OpenCon();
                    
                    string query = @"UPDATE seat_status SET status = 'sold' WHERE Seat_no='"+el+"' and trip_id="+trip_id+"";
                    SqlCommand cmd = new SqlCommand(query, con);
                    
                    cmd.ExecuteNonQuery();

                    Database_Connection.CloseCon();
                    

                }

                SqlConnection con1 = Database_Connection.OpenCon();

                MessageBox.Show("Successfull\n Thank You.");
                string query1 = @"update Bus_info set seat=(seat-" + i + ") where ID=" + trip_id + "";

                SqlCommand cmd1 = new SqlCommand(query1, con1);
                //MessageBox.Show("Successfull\n Thank You.");
                cmd1.ExecuteNonQuery();
                Database_Connection.CloseCon();

               



            }
            catch(Exception ex) {

                // MessageBox.Show(Convert.ToString(trip_id));
                MessageBox.Show(ex.ToString());



            }

            

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
