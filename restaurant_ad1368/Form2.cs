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
    public partial class frmpos : Form
    {
        public frmpos()
        {
            InitializeComponent();
        }

        private void frenchcb_CheckedChanged(object sender, EventArgs e)
        {
            if(frenchcb.Checked == true)
            {
                frenchtb.Enabled = true;
            }
            if(frenchcb.Checked == false)
            {
                frenchtb.Enabled = false;
                frenchtb.Text = "0";
            }
        }

        private void burgercb_CheckedChanged(object sender, EventArgs e)
        {
            if (burgercb.Checked == true)
            {
                burgertb.Enabled = true;
            }
            if (burgercb.Checked == false)
            {
                burgertb.Enabled = false;
                burgertb.Text = "0";
            }

        }

        private void hotcb_CheckedChanged(object sender, EventArgs e)
        {
            if (hotcb.Checked == true)
            {
                hottb.Enabled = true;
            }
            if (hotcb.Checked == false)
            {
                hottb.Enabled = false;
                hottb.Text = "0";
            }
        }

        private void shacb_CheckedChanged(object sender, EventArgs e)
        {
            if (shacb.Checked == true)
            {
                shatb.Enabled = true;
            }
            if (shacb.Checked == false)
            {
                shatb.Enabled = false;
                shatb.Text = "0";
            }
        }

        private void cocacb_CheckedChanged(object sender, EventArgs e)
        {
            if (cocacb.Checked == true)
            {
                cocatb.Enabled = true;
            }
            if (cocacb.Checked == false)
            {
                cocatb.Enabled = false;
                cocatb.Text = "0";
            }
        }

        private void watercb_CheckedChanged(object sender, EventArgs e)
        {
            if (watercb.Checked == true)
            {
                watertb.Enabled = true;
            }
            if (watercb.Checked == false)
            {
                watertb.Enabled = false;
                watertb.Text = "0";
            }
        }

        private void oracb_CheckedChanged(object sender, EventArgs e)
        {
            if (oracb.Checked == true)
            {
                oratb.Enabled = true;
            }
            if (oracb.Checked == false)
            {
                oratb.Enabled = false;
                oratb.Text = "0";
            }
        }

        private void pancb_CheckedChanged(object sender, EventArgs e)
        {
            if (pancb.Checked == true)
            {
                pantb.Enabled = true;
            }
            if (pancb.Checked == false)
            {
                pantb.Enabled = false;
                pantb.Text = "0";
            }
        }
        string name;
        int price;
        int tot;
        private void button2_Click(object sender, EventArgs e)
        {
            if (frenchcb.Checked)
            {
                name = "French fries";
                int qty = int.Parse(frenchtb.Text);
                price = 2;
                tot = qty * price;
                this.dataGridView1.Rows.Add(name, price, qty, tot);

            }
            if (burgercb.Checked)
            {
                name = "burger";
                int qty = int.Parse(burgertb.Text);
                price = 5;
                tot = qty * price;
                this.dataGridView1.Rows.Add(name, price, qty, tot);
            }
            if (cocacb.Checked)
            {
                name = "cocacola";
                int qty = int.Parse(cocatb.Text);
                price = 1;
                tot = qty * price;
                this.dataGridView1.Rows.Add(name, price, qty, tot);
            }
            if (watercb.Checked)
            {
                name = "water";
                int qty = int.Parse(watertb.Text);
                price = 1;
                tot = qty * price;
                this.dataGridView1.Rows.Add(name, price, qty, tot);
            }



            if (hotcb.Checked)
            {
                name = "hot dog";
                int qty = int.Parse(hottb.Text);
                price = 3;
                tot = qty * price;
                this.dataGridView1.Rows.Add(name, price, qty, tot);
            }


            if (oracb.Checked)
            {
                name = "Orange Juice";
                int qty = int.Parse(oratb.Text);
                price = 2;
                tot = qty * price;
                this.dataGridView1.Rows.Add(name, price, qty, tot);
            }


            if (shacb.Checked)
            {
                name = "shawerma";
                int qty = int.Parse(shatb.Text);
                price = 3;
                tot = qty * price;
                this.dataGridView1.Rows.Add(name, price, qty, tot);
            }

            if (pancb.Checked)
            {
                name = "pancakes";
                int qty = int.Parse(pantb.Text);
                price = 4;
                tot = qty * price;
                this.dataGridView1.Rows.Add(name, price, qty, tot);
            }



            int sum = 0;

            for (int row = 0; row < dataGridView1.Rows.Count; row++)
            {
                sum = sum + Convert.ToInt32(dataGridView1.Rows[row].Cells[3].Value);
            }

            lbltotal.Text = sum.ToString();
        }
    }

         
        
    }

