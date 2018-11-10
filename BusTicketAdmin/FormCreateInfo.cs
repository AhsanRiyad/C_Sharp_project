using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusTicketAdmin
{
    public partial class FormCreateInfo : Form
    {
        public FormCreateInfo()
        {
            InitializeComponent();
        }

        private void FormCreateInfo_Load(object sender, EventArgs e)
        {
            NewFolder1.UserControlCreate cr = new NewFolder1.UserControlCreate();
            panelCreateInfo.Controls.Clear();
            panelCreateInfo.Controls.Add(cr);
        }
    }
}
