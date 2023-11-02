using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bank_customer_windows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bank b = new Bank();
            b.name = textBox1.Text;
            b.acc_num = Convert.ToInt32(textBox2.Text);
            b.bal = Convert.ToInt32(textBox3.Text);

            StringBuilder sb = new StringBuilder();
            b.getdata(b.name, b.acc_num, b.bal);
            sb.Append("deposit:" + b.deposit +"\n");
            sb.Append("Withdrawl:" + b.withdrawal);
            label4.Text = sb.ToString();




        }
    }
}
