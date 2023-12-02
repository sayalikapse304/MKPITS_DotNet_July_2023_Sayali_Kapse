using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace operator_accept_using_switch_window
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Operation ope=new Operation();
        private void button1_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(textBox1.Text);
            int num2 = Convert.ToInt32(textBox2.Text);
            char op = Convert.ToChar(textBox3.Text);

            ope.getdata(op,num1,num2);
            label4.Text = "res:"+ope.res;

        }
    }
}
