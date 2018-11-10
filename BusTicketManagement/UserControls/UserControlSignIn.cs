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
    public partial class UserControlSignIn : UserControl
    {
        private System.Windows.Forms.Panel panelSignInForm;

        public UserControlSignIn(System.Windows.Forms.Panel panelSignInForm)
        {
            this.panelSignInForm = panelSignInForm;
            InitializeComponent();
            
        }

        private void UserControl2_Load(object sender, EventArgs e)
        {
            

        }

        private void button2_Click(object sender, EventArgs e)
        {

            //MessageBox.Show( DateTime.Now.ToString("MM-yyyy-dd"));

            try
            {




                SqlConnection con = Database_Connection.OpenCon();

                //string query = @"select email from user_info";
                string query = @"Select full_name , user_name , user_type from user_info where password=@pw and user_name=@un";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@un", TextBoxUserName.Text);
                cmd.Parameters.AddWithValue("@pw", TextBoxPassword.Text);
                cmd.ExecuteNonQuery();
                //MessageBox.Show(Convert.ToString(i));

                if (!TextBoxUserName.Text.Equals("UserName") && !TextBoxPassword.Text.Equals(null))
                {




                    SqlDataReader reader = cmd.ExecuteReader();
                    if (!reader.HasRows)
                    {
                        MessageBox.Show("User does not exist");

                    }


                    while (reader.Read())
                    {
                        //write the data on to the screen

                        //call the objects from their index
                        //    reader[0]));

                        string a = Convert.ToString(reader[0]);
                        string b = Convert.ToString(reader[1]);
                        string c = Convert.ToString(reader[2]);
                        //MessageBox.Show(a);

                        if (TextBoxUserName.Text.Equals(b) && c.Equals("user") )
                        {


                            panelSignInForm.Controls.Clear();
                            panelSignInForm.Controls.Add(new UserControlUser(TextBoxUserName.Text, a, panelSignInForm));
                            
                        }
                        if (TextBoxUserName.Text.Equals(b) && c.Equals("admin"))
                        {


                            //panelSignInForm.Controls.Clear();
                            //panelSignInForm.Controls.Add(new UserControlUser(TextBoxUserName.Text, a, panelSignInForm));
                            // panelSignInForm.Controls.Add(new BusTicketAdmin.UserControlAdminFront(TextBoxUserName.Text, a, panelSignInForm));

                            //panelSignInForm.Controls.Add(new BusTicketAdmin.UserControlAdminFront(TextBoxUserName.Text , a));


                            BusTicketAdmin.Form1 f = new BusTicketAdmin.Form1(a , TextBoxUserName.Text);
                            //f.Activate();
                            //this.Hide();
                            f.Show();

                            //BusTicketAdmin.FormManageTrip fm = new BusTicketAdmin.FormManageTrip(a, TextBoxUserName.Text);
                            //fm.Show();

                            


                        }


                    }


                }
                else
                {
                    MessageBox.Show("User Name and Password\n can not be null");


                }







            }
            catch (SqlException ex)
            {


            }
            catch (Exception ex)
            {





            }















            




        }

    public void panelSetUp(System.Windows.Forms.Panel panelSignInForm)
        {

            this.panelSignInForm = panelSignInForm;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelSignInForm.Controls.Clear();
            panelSignInForm.Controls.Add(new UserControlSignUpForm(panelSignInForm));
        }

        private void TextBoxUserName_OnValueChanged(object sender, EventArgs e)
        {

        }
    }
}
