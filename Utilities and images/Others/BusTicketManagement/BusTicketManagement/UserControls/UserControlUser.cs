using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusTicketManagement
{
    public partial class UserControlUser : UserControl
    {
        System.Windows.Forms.Panel panelSignInForm;
        string userId;
        string userFullName;
        public UserControlUser(string userId, string userFullName, System.Windows.Forms.Panel panelSignInForm)
        {
            InitializeComponent();
            LabelWelcomeName.Text = userFullName;
            this.userId = userId;
            this.panelSignInForm = panelSignInForm;
            this.userFullName = userFullName;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void LabelWelcomeName_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void ButtonRecovery_Click(object sender, EventArgs e)
        {

        }

        private void ButtonSignUp_Click(object sender, EventArgs e)
        {
            panelSignInForm.Controls.Clear();
            panelSignInForm.Controls.Add(new UserControlSignIn(panelSignInForm));
        }

        private void ButtonSearch_Click(object sender, EventArgs e)
        {
           
            string From1 = dropDownFrom.selectedValue;
            string To1 = dropDownTo.selectedValue;
            DateTime Date1 = DatepickerDate.Value.Date;
            string s= Date1.ToString("yyyy-MM-dd");
            string dates = Date1.ToString("dd-MMMM-yyyy");
            //MessageBox.Show(s);

            





            if (!From1.Equals("Home") && !To1.Equals("Destination"))
            {

                if (Date1 < DateTime.Now)
                {
                    MessageBox.Show("You have selected a past date");

                }
                else {

                    panelSignInForm.Controls.Clear();
                    panelSignInForm.Controls.Add(new UserControlShowBusesGridView(dates, s, To1, From1, panelSignInForm , userId ,Date1 , userFullName));

                }




               

            }
            else
            {

                MessageBox.Show("You must select Items");


            }




        }

        private void UserControlUser_Load(object sender, EventArgs e)
        {
            
        }

        private void DatepickerDate_onValueChanged(object sender, EventArgs e)
        {
            
        }
    }
}
