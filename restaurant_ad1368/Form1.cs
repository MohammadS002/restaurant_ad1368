using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace restaurant_ad1368
{
    public partial class frmlogin : Form
    {
        private OleDbConnection conn = new OleDbConnection();



        public frmlogin()
        {
            InitializeComponent();

            conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C: \Users\ALI\OneDrive\Documents\Visual Studio 2022\login form.accdb
            Persist security Info=false;";
        }
        private void btnlogin_Click(object sender, EventArgs e)
        {
            conn.Open();
                OleDbCommand cmd = conn.CreateCommand();
            cmd.CommandText = "'select * from Account where username = '" + txtuser.Text + "'and password'" + txtpass.Text + "'";
            OleDbDataReader or = cmd.ExecuteReader();

            int count = 0;
            while(or.Read())
            {
                count = count + 1;
                
            }
            if(count == 1)
            {
                MessageBox.Show("login successfuly", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("incorrect username or password", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);          
            }
            conn.Close();
        }

    }
}
