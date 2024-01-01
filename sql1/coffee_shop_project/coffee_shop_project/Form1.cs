using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace coffee_shop_project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
      
        private void button1_Click(object sender, EventArgs e)
        {
            string name;
            int price = 0;
            int tot = 0;
            int qty = 0;

             if (txtmaggie.Checked)
            {
                name = "magii";
                qty = int.Parse(cntmaggie.Value.ToString());
                price = 80;
                tot = qty * price;
                dataGridView1.Rows.Add(name, price, qty, tot);
               
            }


            if (txtfries.Checked)
            {
                name = "fried rice";
                qty = int.Parse(cntfries.Text);
                price = 200;
                tot = qty * price;
                this.dataGridView1.Rows.Add(name, price, qty, tot);
            }

            if (txtmomos.Checked)
            {
                name = "Momos";
                qty = int.Parse(cntmomos.Text);
                price = 100;
                tot = qty * price;
                this.dataGridView1.Rows.Add(name, price, qty, tot);
            }

            if (txtcoldcoffee.Checked)
            {
                name = "Cold Coffee";
                qty = int.Parse(cntcoldcoffee.Value.ToString());
                price = 20;
                tot = qty * price;
                this.dataGridView1.Rows.Add(name, price, qty, tot);
            }


            if (txtcoffee.Checked)
            {
                name = "coffee";
                qty = int.Parse(cntcoffee.Text);
                price = 50;
                tot = qty * price;
                this.dataGridView1.Rows.Add(name, price, qty, tot);
            }

            if (txttea.Checked)
            {
                name = "Tea";
                qty = int.Parse(cnttea.Text);
                price = 100;
                tot = qty * price;
                this.dataGridView1.Rows.Add(name, price, qty, tot);
            }
            int sum = 0;

            for (int row = 0; row < dataGridView1.Rows.Count; row++)
            {
                sum = sum + Convert.ToInt32(dataGridView1.Rows[row].Cells[3].Value);
            }

            textBox1.Text = sum.ToString();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
