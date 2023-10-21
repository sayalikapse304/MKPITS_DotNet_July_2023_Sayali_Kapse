using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace greater_num_windows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1, num2,num3;
            string res=null;
            num1 = Convert.ToInt32(textBox1.Text);
            num2 = Convert.ToInt32(textBox2.Text);
            num3 = Convert.ToInt32(textBox3.Text);

            if (num1 > num2 && num1>num3)
            {
                res = "num1 is greater";
            }
           
            else if(num2>num3)
            { 
                res = "num2 is grater";
            }
            else
            {
                res = "num3 is greater";
            }
            label4.Text = "result=" + res;
        }
    }
}
