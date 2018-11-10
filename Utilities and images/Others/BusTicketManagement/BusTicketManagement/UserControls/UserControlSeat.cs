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
    
    public partial class UserControlSeat : UserControl
    {
        
        
        int trip_id_number = 2207;
        string userId;
        List<string> seatList = new List<string>();
        //
        //buttonStatus
        //
        string statusA1 = "none";
        string statusA2 = "none";
        string statusA3 = "none";
        string statusA4 = "none";
        string statusB1 = "none";
        string statusB2 = "none";
        string statusB3 = "none";
        string statusB4 = "none";
        string statusC1 = "none";
        string statusC2 = "none";
        string statusC3 = "none";
        string statusC4 = "none";
        string statusD1 = "none";
        string statusD2 = "none";
        string statusD3 = "none";
        string statusD4 = "none";
        string statusE1 = "none";
        string statusE2 = "none";
        string statusE3 = "none";
        string statusE4 = "none";
        string statusF1 = "none";
        string statusF2 = "none";
        string statusF3 = "none";
        string statusF4 = "none";

        //
        //flag status
        //
        int buttonYellowA1 = 0;
        int buttonYellowA2 = 0;
        int buttonYellowA3 = 0;
        int buttonYellowA4 = 0;
        int buttonYellowB1 = 0;
        int buttonYellowB2 = 0;
        int buttonYellowB3 = 0;
        int buttonYellowB4 = 0;
        int buttonYellowC1 = 0;
        int buttonYellowC2 = 0;
        int buttonYellowC3 = 0;
        int buttonYellowC4 = 0;
        int buttonYellowD1 = 0;
        int buttonYellowD2 = 0;
        int buttonYellowD3 = 0;
        int buttonYellowD4 = 0;
        int buttonYellowE1 = 0;
        int buttonYellowE2 = 0;
        int buttonYellowE3 = 0;
        int buttonYellowE4 = 0;
        int buttonYellowF1 = 0;
        int buttonYellowF2 = 0;
        int buttonYellowF3 = 0;
        int buttonYellowF4 = 0;

        string date1;

        System.Windows.Forms.Panel panelSignInForm;
        public UserControlSeat(int trip_id_number , System.Windows.Forms.Panel panelSignInForm , string userId , string date1)
        {
            InitializeComponent();
            this.trip_id_number = trip_id_number;
            //MessageBox.Show(Convert.ToString(trip_id_number));
            this.panelSignInForm = panelSignInForm;
            this.userId = userId;
            this.date1 = date1; 
        }

        private void UserControlSeat_Load(object sender, EventArgs e)
        {
            buttonLoadStatusA1();
            buttonLoadStatusA2();
            buttonLoadStatusA3();
            buttonLoadStatusA4();
            buttonLoadStatusB1();
            buttonLoadStatusB2();
            buttonLoadStatusC1();
            buttonLoadStatusC2();
            buttonLoadStatusC3();
            buttonLoadStatusC4();
            buttonLoadStatusD1();
            buttonLoadStatusD2();
            buttonLoadStatusD3();
            buttonLoadStatusD4();
            buttonLoadStatusE1();
            buttonLoadStatusE2();
            buttonLoadStatusE3();
            buttonLoadStatusE4();
            buttonLoadStatusF1();
            buttonLoadStatusF2();
            buttonLoadStatusF3();
            buttonLoadStatusF4();
            





        }
       
        private void buttonA1_Click(object sender, EventArgs e)
        {

        }

        private void buttonA1_MouseClick(object sender, MouseEventArgs e)
        {



        }

        private void buttonA2_Click(object sender, EventArgs e)
        {

        }


        private void buttonLoadStatusA1()
        {

            SqlConnection con = Database_Connection.OpenCon();
            string query = @"select status from seat_status where trip_id=@tid and seat_no='a1'";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@tid", trip_id_number);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                statusA1 = Convert.ToString(reader[0]);
                // b = Int32.Parse(a);

            }
            if (statusA1 == "av")
            {
                buttonA1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));

            }
            else if (statusA1 == "booked")
            {

                buttonA1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(128)))), ((int)(((byte)(44)))));

            }
            else if (statusA1 == "sold")
            {

                buttonA1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));

            }

        }
        private void buttonLoadStatusA2()
        {
            SqlConnection con = Database_Connection.OpenCon();
            string query = @"select status from seat_status where trip_id=@tid and seat_no='a2'";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@tid", trip_id_number);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                statusA2 = Convert.ToString(reader[0]);
                // b = Int32.Parse(a);

            }
            if (statusA2 == "av")
            {
                buttonA2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));

            }
            else if (statusA2 == "booked")
            {

                buttonA2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(128)))), ((int)(((byte)(44)))));

            }
            else if (statusA2 == "sold")
            {

                buttonA2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));

            }

        }
        private void buttonLoadStatusA3()
        {
            SqlConnection con = Database_Connection.OpenCon();
            string query = @"select status from seat_status where trip_id=@tid and seat_no='a3'";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@tid", trip_id_number   );
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                statusA3 = Convert.ToString(reader[0]);
                // b = Int32.Parse(a);

            }
            if (statusA3 == "av")
            {
                buttonA3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));

            }
            else if (statusA3 == "booked")
            {

                buttonA3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(128)))), ((int)(((byte)(44)))));

            }
            else if (statusA3 == "sold")
            {

                buttonA3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));

            }

        }
        private void buttonLoadStatusA4()
        {
            SqlConnection con = Database_Connection.OpenCon();
            string query = @"select status from seat_status where trip_id=@tid and seat_no='a4'";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@tid", trip_id_number);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                statusA4 = Convert.ToString(reader[0]);
                // b = Int32.Parse(a);

            }
            if (statusA4 == "av")
            {
                buttonA4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));

            }
            else if (statusA4 == "booked")
            {

                buttonA4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(128)))), ((int)(((byte)(44)))));

            }
            else if (statusA4 == "sold")
            {

                buttonA4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));

            }

        }

        private void buttonLoadStatusB1()
        {
            SqlConnection con = Database_Connection.OpenCon();
            string query = @"select status from seat_status where trip_id=@tid and seat_no='b1'";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@tid", trip_id_number);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                statusB1 = Convert.ToString(reader[0]);
                // b = Int32.Parse(a);

            }
            if (statusB1 == "av")
            {
                buttonB1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));

            }
            else if (statusB1 == "booked")
            {

                buttonB1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(128)))), ((int)(((byte)(44)))));

            }
            else if (statusB1 == "sold")
            {

                buttonB1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));

            }

        }

        private void buttonLoadStatusB2()
        {
            SqlConnection con = Database_Connection.OpenCon();
            string query = @"select status from seat_status where trip_id=@tid and seat_no='b2'";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@tid", trip_id_number);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                statusB2 = Convert.ToString(reader[0]);
                // b = Int32.Parse(a);

            }
            if (statusB2 == "av")
            {
                buttonB2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));

            }
            else if (statusB2 == "booked")
            {

                buttonB2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(128)))), ((int)(((byte)(44)))));

            }
            else if (statusB2 == "sold")
            {

                buttonB2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));

            }

        }


        private void buttonLoadStatusC1()
        {
            SqlConnection con = Database_Connection.OpenCon();
            string query = @"select status from seat_status where trip_id=@tid and seat_no='c1'";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@tid", trip_id_number);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                statusC1 = Convert.ToString(reader[0]);
                // b = Int32.Parse(a);

            }
            if (statusC1 == "av")
            {
                buttonC1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));

            }
            else if (statusC1 == "booked")
            {

                buttonC1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(128)))), ((int)(((byte)(44)))));

            }
            else if (statusC1 == "sold")
            {

                buttonC1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));

            }

        }



        private void buttonLoadStatusC2()
        {
            SqlConnection con = Database_Connection.OpenCon();
            string query = @"select status from seat_status where trip_id=@tid and seat_no='c2'";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@tid", trip_id_number);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                statusC2 = Convert.ToString(reader[0]);
                // b = Int32.Parse(a);

            }
            if (statusC2 == "av")
            {
                buttonC2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));

            }
            else if (statusC2 == "booked")
            {

                buttonC2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(128)))), ((int)(((byte)(44)))));

            }
            else if (statusC2 == "sold")
            {

                buttonC2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));

            }

        }

        private void buttonLoadStatusC3()
        {
            SqlConnection con = Database_Connection.OpenCon();
            string query = @"select status from seat_status where trip_id=@tid and seat_no='c3'";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@tid", trip_id_number);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                statusC3 = Convert.ToString(reader[0]);
                // b = Int32.Parse(a);

            }
            if (statusC3 == "av")
            {
                buttonC3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));

            }
            else if (statusC3 == "booked")
            {

                buttonC3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(128)))), ((int)(((byte)(44)))));

            }
            else if (statusC3 == "sold")
            {

                buttonC3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));

            }

        }


        private void buttonLoadStatusC4()
        {
            SqlConnection con = Database_Connection.OpenCon();
            string query = @"select status from seat_status where trip_id=@tid and seat_no='c4'";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@tid", trip_id_number);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                statusC4 = Convert.ToString(reader[0]);
                // b = Int32.Parse(a);

            }
            if (statusC4 == "av")
            {
                buttonC4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));

            }
            else if (statusC4 == "booked")
            {

                buttonC4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(128)))), ((int)(((byte)(44)))));

            }
            else if (statusC4 == "sold")
            {

                buttonC4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));

            }

        }


        private void buttonLoadStatusD1()
        {
            SqlConnection con = Database_Connection.OpenCon();
            string query = @"select status from seat_status where trip_id=@tid and seat_no='D1'";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@tid", trip_id_number);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                statusD1 = Convert.ToString(reader[0]);
                // b = Int32.Parse(a);

            }
            if (statusD1 == "av")
            {
                buttonD1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));

            }
            else if (statusD1 == "booked")
            {

                buttonD1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(128)))), ((int)(((byte)(44)))));

            }
            else if (statusD1 == "sold")
            {

                buttonD1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));

            }

        }

        private void buttonLoadStatusD2()
        {
            SqlConnection con = Database_Connection.OpenCon();
            string query = @"select status from seat_status where trip_id=@tid and seat_no='D2'";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@tid", trip_id_number);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                statusD2 = Convert.ToString(reader[0]);
                // b = Int32.Parse(a);

            }
            if (statusD2 == "av")
            {
                buttonD2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));

            }
            else if (statusD2 == "booked")
            {

                buttonD2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(128)))), ((int)(((byte)(44)))));

            }
            else if (statusD2 == "sold")
            {

                buttonD2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));

            }

        }

        private void buttonLoadStatusD3()
        {
            SqlConnection con = Database_Connection.OpenCon();
            string query = @"select status from seat_status where trip_id=@tid and seat_no='D3'";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@tid", trip_id_number);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                statusD3 = Convert.ToString(reader[0]);
                // b = Int32.Parse(a);

            }
            if (statusD3 == "av")
            {
                buttonD3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));

            }
            else if (statusD3 == "booked")
            {

                buttonD3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(128)))), ((int)(((byte)(44)))));

            }
            else if (statusD3 == "sold")
            {

                buttonD3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));

            }

        }

        private void buttonLoadStatusD4()
        {
            SqlConnection con = Database_Connection.OpenCon();
            string query = @"select status from seat_status where trip_id=@tid and seat_no='D4'";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@tid", trip_id_number);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                statusD4 = Convert.ToString(reader[0]);
                // b = Int32.Parse(a);

            }
            if (statusD4 == "av")
            {
                buttonD4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));

            }
            else if (statusD4 == "booked")
            {

                buttonD4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(128)))), ((int)(((byte)(44)))));

            }
            else if (statusD4 == "sold")
            {

                buttonD4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));

            }

        }


        private void buttonLoadStatusE1()
        {
            SqlConnection con = Database_Connection.OpenCon();
            string query = @"select status from seat_status where trip_id=@tid and seat_no='e1'";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@tid", trip_id_number);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                statusE1 = Convert.ToString(reader[0]);
                // b = Int32.Parse(a);

            }
            if (statusE1 == "av")
            {
                buttonE1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));

            }
            else if (statusE1 == "booked")
            {

                buttonE1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(128)))), ((int)(((byte)(44)))));

            }
            else if (statusE1 == "sold")
            {

                buttonE1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));

            }

        }

        private void buttonLoadStatusE2()
        {
            SqlConnection con = Database_Connection.OpenCon();
            string query = @"select status from seat_status where trip_id=@tid and seat_no='e2'";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@tid", trip_id_number);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                statusE2 = Convert.ToString(reader[0]);
                // b = Int32.Parse(a);

            }
            if (statusE2 == "av")
            {
                buttonE2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));

            }
            else if (statusE2 == "booked")
            {

                buttonE2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(128)))), ((int)(((byte)(44)))));

            }
            else if (statusE2 == "sold")
            {

                buttonE2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));

            }

        }

        private void buttonLoadStatusE3()
        {
            SqlConnection con = Database_Connection.OpenCon();
            string query = @"select status from seat_status where trip_id=@tid and seat_no='e3'";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@tid", trip_id_number);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                statusE3 = Convert.ToString(reader[0]);
                // b = Int32.Parse(a);

            }
            if (statusE3 == "av")
            {
                buttonE3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));

            }
            else if (statusE3 == "booked")
            {

                buttonE3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(128)))), ((int)(((byte)(44)))));

            }
            else if (statusE3 == "sold")
            {

                buttonE3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));

            }

        }

        private void buttonLoadStatusE4()
        {
            SqlConnection con = Database_Connection.OpenCon();
            string query = @"select status from seat_status where trip_id=@tid and seat_no='e4'";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@tid", trip_id_number);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                statusE4 = Convert.ToString(reader[0]);
                // b = Int32.Parse(a);

            }
            if (statusE4 == "av")
            {
                buttonE4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));

            }
            else if (statusE4 == "booked")
            {

                buttonE4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(128)))), ((int)(((byte)(44)))));

            }
            else if (statusE4 == "sold")
            {

                buttonE4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));

            }

        }

        private void buttonLoadStatusF1()
        {
            SqlConnection con = Database_Connection.OpenCon();
            string query = @"select status from seat_status where trip_id=@tid and seat_no='f1'";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@tid", trip_id_number);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                statusF1 = Convert.ToString(reader[0]);
                // b = Int32.Parse(a);

            }
            if (statusF1 == "av")
            {
                buttonF1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));

            }
            else if (statusF1 == "booked")
            {

                buttonF1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(128)))), ((int)(((byte)(44)))));

            }
            else if (statusF1 == "sold")
            {

                buttonF1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));

            }

        }

        private void buttonLoadStatusF2()
        {
            SqlConnection con = Database_Connection.OpenCon();
            string query = @"select status from seat_status where trip_id=@tid and seat_no='f2'";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@tid", trip_id_number);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                statusF2 = Convert.ToString(reader[0]);
                // b = Int32.Parse(a);

            }
            if (statusF2 == "av")
            {
                buttonF2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));

            }
            else if (statusF2 == "booked")
            {

                buttonF2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(128)))), ((int)(((byte)(44)))));

            }
            else if (statusF2 == "sold")
            {

                buttonF2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));

            }

        }

        private void buttonLoadStatusF3()
        {
            SqlConnection con = Database_Connection.OpenCon();
            string query = @"select status from seat_status where trip_id=@tid and seat_no='f3'";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@tid", trip_id_number);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                statusF3 = Convert.ToString(reader[0]);
                // b = Int32.Parse(a);

            }
            if (statusF3 == "av")
            {
                buttonF3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));

            }
            else if (statusF3 == "booked")
            {

                buttonF3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(128)))), ((int)(((byte)(44)))));

            }
            else if (statusF3 == "sold")
            {

                buttonF3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));

            }

        }

        private void buttonLoadStatusF4()
        {
            SqlConnection con = Database_Connection.OpenCon();
            string query = @"select status from seat_status where trip_id=@tid and seat_no='f4'";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@tid", trip_id_number);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                statusF4 = Convert.ToString(reader[0]);
                // b = Int32.Parse(a);

            }
            if (statusF4 == "av")
            {
                buttonF4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));

            }
            else if (statusF4 == "booked")
            {

                buttonF4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(128)))), ((int)(((byte)(44)))));

            }
            else if (statusF4 == "sold")
            {

                buttonF4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));

            }

        }



        private void buttonC1_MouseClick(object sender, MouseEventArgs e)
        {

        }

       

        private void buttonA1_Click_1(object sender, EventArgs e)
        {

            if (statusA1 == "free" && buttonYellowA1 == 0)
            {
                seatList.Add("a1");
                buttonYellowA1 = 1;
                buttonA1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(78)))), ((int)(((byte)(162)))));
            }
            else if (statusA1 == "free" && buttonYellowA1 == 1)
            {
                seatList.Add("a1");
                buttonYellowA1 = 0;
                buttonA1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));


            }
        }

        private void buttonA2_Click_1(object sender, EventArgs e)
        {

            //MessageBox.Show("Button2 clicked");

            if (statusA2 == "free" && buttonYellowA2 == 0)
            {
                seatList.Add("a2");
                buttonYellowA2 = 1;
                buttonA2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(78)))), ((int)(((byte)(162)))));
            }
            else if (statusA2 == "free" && buttonYellowA2 == 1)
            {
                seatList.Remove("a2");
                buttonYellowA2 = 0;
                buttonA2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));


            }

        }

        private void buttonA3_Click(object sender, EventArgs e)
        {
            if (statusA3 == "free" && buttonYellowA3 == 0)
            {
                seatList.Add("a3");
                buttonYellowA3 = 1;
                buttonA2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(78)))), ((int)(((byte)(162)))));
            }
            else if (statusA3 == "free" && buttonYellowA3 == 1)
            {
                seatList.Remove("a3");
                buttonYellowA3 = 0;
                buttonA2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));


            }
        }

        private void buttonA4_Click(object sender, EventArgs e)
        {
            if (statusA4 == "free" && buttonYellowA4 == 0)
            {
                seatList.Add("a4");
                buttonYellowA4 = 1;
                buttonA2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(78)))), ((int)(((byte)(162)))));
            }
            else if (statusA4 == "free" && buttonYellowA4 == 1)
            {
                
                seatList.Remove("a4");
                buttonYellowA4 = 0;
                buttonA2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));


            }
        }


        private void buttonB1_Click(object sender, EventArgs e)
        {
            if (statusB1 == "free" && buttonYellowB1 == 0)
            {
                seatList.Add("b1");
                
                buttonYellowB1 = 1;
                buttonB1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(78)))), ((int)(((byte)(162)))));
            }
            else if (statusB1 == "free" && buttonYellowB1 == 1)
            {
                
                seatList.Remove("b1");
                buttonYellowB1 = 0;
                buttonB1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));


            }
        }

        private void buttonB2_Click(object sender, EventArgs e)
        {
            if (statusB2 == "free" && buttonYellowB2 == 0)
            {
                seatList.Add("b2");
                buttonYellowB2 = 1;
                buttonB2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(78)))), ((int)(((byte)(162)))));
            }
            else if (statusB2 == "free" && buttonYellowB2 == 1)
            {
                seatList.Remove("b2");
                buttonYellowB2 = 0;
                buttonB2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));


            }
        }

        private void buttonB3_Click(object sender, EventArgs e)
        {
            if (statusB3 == "free" && buttonYellowB3 == 0)
            {
                seatList.Add("b3");
                buttonYellowB3 = 1;
                buttonB3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(78)))), ((int)(((byte)(162)))));
            }
            else if (statusB3 == "free" && buttonYellowB3 == 1)
            {
                seatList.Remove("b3");
                buttonYellowB3 = 0;
                buttonB3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));


            }
        }

        private void buttonB4_Click(object sender, EventArgs e)
        {
            if (statusB4 == "free" && buttonYellowB4 == 0)
            {
                seatList.Add("b4");
                buttonYellowB4 = 1;
                buttonB4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(78)))), ((int)(((byte)(162)))));
            }
            else if (statusB4 == "free" && buttonYellowB4 == 1)
            {
                seatList.Remove("b4");
                buttonYellowB4 = 0;
                buttonB4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));


            }

        }




        private void buttonC1_Click(object sender, EventArgs e)
        {
            if (statusC1 == "free" && buttonYellowC1 == 0)
            {
                seatList.Add("c1");
                buttonYellowC1 = 1;
                buttonC1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(78)))), ((int)(((byte)(162)))));
            }
            else if (statusC1 == "free" && buttonYellowC1 == 1)
            {
                seatList.Remove("c1");
                buttonYellowC1 = 0;
                buttonC1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));


            }
        }

        private void buttonC2_Click(object sender, EventArgs e)
        {
            if (statusC2 == "free" && buttonYellowC2 == 0)
            {
                seatList.Add("c2");
                buttonYellowC2 = 1;
                buttonC2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(78)))), ((int)(((byte)(162)))));
            }
            else if (statusC2 == "free" && buttonYellowC2 == 1)
            {
                seatList.Remove("c2");
                buttonYellowC2 = 0;
                buttonC2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));


            }
        }

        private void buttonC3_Click(object sender, EventArgs e)
        {
            if (statusC3 == "free" && buttonYellowC3 == 0)
            {
                seatList.Add("c3");
                buttonYellowC3 = 1;
                buttonC3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(78)))), ((int)(((byte)(162)))));
            }
            else if (statusC3 == "free" && buttonYellowC3 == 1)
            {
                seatList.Remove("c3");
                buttonYellowC3 = 0;
                buttonC3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));


            }
        }

        private void buttonC4_Click(object sender, EventArgs e)
        {
            if (statusC4 == "free" && buttonYellowC4 == 0)
            {
                seatList.Add("c4");
                buttonYellowC4 = 1;
                buttonC4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(78)))), ((int)(((byte)(162)))));
            }
            else if (statusC4 == "free" && buttonYellowC4 == 1)
            {
                seatList.Remove("c4");
                buttonYellowC4 = 0;
                buttonC4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));


            }
        }


        private void buttonD1_Click(object sender, EventArgs e)
        {
            if (statusD1 == "free" && buttonYellowD1 == 0)
            {
                seatList.Add("d1");
                buttonYellowD1 = 1;
                buttonD1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(78)))), ((int)(((byte)(162)))));
            }
            else if (statusD1 == "free" && buttonYellowD1 == 1)
            {
                seatList.Remove("d1");
                buttonYellowD1 = 0;
                buttonD1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));


            }
        }

        private void buttonD2_Click(object sender, EventArgs e)
        {
            if (statusD2 == "free" && buttonYellowD2 == 0)
            {
                seatList.Add("d2");
                buttonYellowD2 = 1;
                buttonD2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(78)))), ((int)(((byte)(162)))));
            }
            else if (statusD2 == "free" && buttonYellowD2 == 1)
            {
                seatList.Remove("d2");
                buttonYellowD2 = 0;
                buttonD2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));


            }
        }

        private void buttond3_Click(object sender, EventArgs e)
        {
            if (statusD3 == "free" && buttonYellowD3 == 0)
            {
                seatList.Add("d3");
                buttonYellowD3 = 1;
                buttonD3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(78)))), ((int)(((byte)(162)))));
            }
            else if (statusD3 == "free" && buttonYellowD3 == 1)
            {
                seatList.Remove("d3");
                buttonYellowD3 = 0;
                buttonD3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));


            }
        }

        private void buttonD4_Click(object sender, EventArgs e)
        {
            if (statusD4 == "free" && buttonYellowD4 == 0)
            {
                seatList.Add("d4");
                buttonYellowD4 = 1;
                buttonD4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(78)))), ((int)(((byte)(162)))));
            }
            else if (statusD4 == "free" && buttonYellowD4 == 1)
            {
                seatList.Remove("d4");
                buttonYellowD4 = 0;
                buttonD4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));


            }
        }

        private void buttonE1_Click(object sender, EventArgs e)
        {
            if (statusE1 == "free" && buttonYellowE1 == 0)
            {
                seatList.Add("e1");
                buttonYellowE1 = 1;
                buttonE1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(78)))), ((int)(((byte)(162)))));
            }
            else if (statusE1 == "free" && buttonYellowE1 == 1)
            {
                seatList.Remove("e1");
                buttonYellowE1 = 0;
                buttonE1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));


            }
        }

        private void buttonE2_Click(object sender, EventArgs e)
        {
            if (statusE2 == "free" && buttonYellowE2 == 0)
            {
                seatList.Add("e2");
                buttonYellowE2 = 1;
                buttonE2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(78)))), ((int)(((byte)(162)))));
            }
            else if (statusE2 == "free" && buttonYellowE2 == 1)
            {
                seatList.Remove("e2");
                buttonYellowE2 = 0;
                buttonE2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));


            }
        }

        private void buttonE3_Click(object sender, EventArgs e)
        {
            if (statusE3 == "free" && buttonYellowE3 == 0)
            {
                seatList.Add("e3");
                buttonYellowE3 = 1;
                buttonE3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(78)))), ((int)(((byte)(162)))));
            }
            else if (statusE3 == "free" && buttonYellowE3 == 1)
            {
                seatList.Remove("e3");
                buttonYellowE3 = 0;
                buttonE3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));


            }
        }

        private void buttonE4_Click(object sender, EventArgs e)
        {
            if (statusE4 == "free" && buttonYellowE4 == 0)
            {
                seatList.Add("e4");
                buttonYellowE4 = 1;
                buttonE4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(78)))), ((int)(((byte)(162)))));
            }
            else if (statusE4 == "free" && buttonYellowE4 == 1)
            {
                seatList.Remove("e4");
                buttonYellowE4 = 0;
                buttonE4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));


            }
        }

        private void buttonF1_Click(object sender, EventArgs e)
        {
            if (statusF1 == "free" && buttonYellowF1 == 0)
            {
                seatList.Add("f1");
                buttonYellowF1 = 1;
                buttonF1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(78)))), ((int)(((byte)(162)))));
            }
            else if (statusF1 == "free" && buttonYellowF1 == 1)
            {
                seatList.Remove("f1");
                buttonYellowF1 = 0;
                buttonF1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));


            }
        }

        private void buttonF2_Click(object sender, EventArgs e)
        {
            if (statusF2 == "free" && buttonYellowF2 == 0)
            {
                seatList.Add("f2");
                buttonYellowF2 = 1;
                buttonF2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(78)))), ((int)(((byte)(162)))));
            }
            else if (statusF2 == "free" && buttonYellowF2 == 1)
            {
                seatList.Remove("f2");
                buttonYellowF2 = 0;
                buttonF2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));


            }
        }

        private void buttonF3_Click(object sender, EventArgs e)
        {
            if (statusF3 == "free" && buttonYellowF3 == 0)
            {
                seatList.Add("f3");
                buttonYellowF3 = 1;
                buttonF3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(78)))), ((int)(((byte)(162)))));
            }
            else if (statusF3 == "free" && buttonYellowF3 == 1)
            {
                seatList.Remove("f3");
                buttonYellowF3 = 0;
                buttonF3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));


            }
        }

        private void buttonF4_Click(object sender, EventArgs e)
        {
            if (statusF4 == "free" && buttonYellowF4 == 0)
            {
                seatList.Add("f4");
                buttonYellowF4 = 1;
                buttonF4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(78)))), ((int)(((byte)(162)))));
            }
            else if (statusF4 == "free" && buttonYellowF4 == 1)
            {
                seatList.Remove("f4");
                buttonYellowF4 = 0;
                buttonF4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));


            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            string s;
            int i = seatList.Count;

            UserControlBuyTicket b = new UserControlBuyTicket(userId , panelSignInForm , i , trip_id_number , seatList , date1);
            panelSignInForm.Controls.Clear();
            panelSignInForm.Controls.Add(b);
            
                


        }

        private void button25_Click(object sender, EventArgs e)
        {
            
        }
    }
}
