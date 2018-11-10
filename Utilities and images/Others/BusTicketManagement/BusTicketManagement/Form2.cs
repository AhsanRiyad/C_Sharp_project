using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusTicketManagement
{
    public partial class FormBusTicketBD : Form
    {
        public FormBusTicketBD()
        {
            InitializeComponent();

        }

        private void Form2_Load(object sender, EventArgs e)
        {

            UserControlSignIn s = new UserControlSignIn(panelSignInForm);
            //s.panelSetUp(panelSignInForm);           
            panelSignInForm.Controls.Add(s);
            



        }

        private void panelSignInForm_Paint(object sender, PaintEventArgs e)
        {

        }



        


    }
}
