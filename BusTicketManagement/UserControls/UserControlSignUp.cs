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
    public partial class UserControlSignUpForm : UserControl
    {

        private System.Windows.Forms.Panel panelSignInForm;
        public UserControlSignUpForm(System.Windows.Forms.Panel panelSignInForm)
        {
            this.panelSignInForm = panelSignInForm;
            InitializeComponent();

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            panelSignInForm.Controls.Clear();
            panelSignInForm.Controls.Add(new UserControlSignIn(panelSignInForm));

        }

        private void button1_Click(object sender, EventArgs e)
        {


            try {

                SqlConnection con = Database_Connection.OpenCon();
                string em = Convert.ToString(TextBoxEmail.Text);
                string query = @"INSERT INTO user_info(full_name, email, user_name , password , user_type ) VALUES(@nm , @em , @un , @pw , @type  )";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@un", TextBoxUserName.Text);
                cmd.Parameters.AddWithValue("@nm", TextBoxYourName.Text);
                cmd.Parameters.AddWithValue("@pw", TextBoxPassword.Text);
                cmd.Parameters.AddWithValue("@em", em);
                cmd.Parameters.AddWithValue("@type", "user");

                if (TextBoxPassword.Text.Equals(TextBoxPassword2.Text) && CheckBoxAgree.Checked && IsValidEmail(TextBoxEmail.Text))
                {

                    
                    cmd.ExecuteNonQuery();
                    //cmd.ExecuteScalar();
                    MessageBox.Show("Successful");

                }
                else {
                    MessageBox.Show("Password does not match\n check box does not checked \n Email not valid");
                }
                



            }
            catch (SqlException ex) {
                
                MessageBox.Show("User Name already Used");
                //MessageBox.Show(ex.ToString());

            }
            catch (Exception ex) {

                MessageBox.Show("User Name already Used");
               //MessageBox.Show(ex.ToString());

            }


           
                

           
            }



        bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }







        private void bunifuMaterialTextbox2_OnValueChanged(object sender, EventArgs e)
        {

        }
    }
}
