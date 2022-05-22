using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace restaurant_ad1368
{
    public partial class frmlogin : Form
    {
        public frmlogin()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if(txtuser.Text == "mohammad" && txtpass.Text == "1234")
            {
                new frmpos().Show();
                this.Hide();
                MessageBox.Show("welcome " + (txtuser.Text));
            }
            else
            {
                MessageBox.Show("the user name or password is incorrect");
            }
        }
    }
}
