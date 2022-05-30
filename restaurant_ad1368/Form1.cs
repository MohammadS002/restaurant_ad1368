using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace restaurant_ad1368
{
    public partial class frmlogin : Form
    {

        public frmlogin()
        {

            InitializeComponent();


        }
        private void btnlogin_Click_1(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-ICV2K48;Initial Catalog=log;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("select * from tbl_login where username='" + txtuser.Text + "' and password='" + txtpass.Text + "'", conn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            string cmbItemValue = comboBox1.SelectedItem.ToString();
            if (dt.Rows.Count > 0)
{
                for (int i = 0; i < dt.Rows.Count; i++)
{

                    if (dt.Rows[i]["username"].ToString() == cmbItemValue) 
                    {

                        MessageBox.Show("you are login as " + dt.Rows[i][2]);
                        if (comboBox1.SelectedIndex == 0)
                        {
                            frmpos f = new frmpos();
                            f.Show();
                            this.Hide();
                        }
                        else
                        {
                           
                            Form3 ff = new Form3();
                            this.Hide();
                            ff.Show();
                        }
                    }

                }

            }
else
            {
                MessageBox.Show("error");
            }




        }
    }

}
