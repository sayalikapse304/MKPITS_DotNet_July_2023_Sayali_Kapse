using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace both_num_equals_or_not_windows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1, num2;
            string result = null;
            num1 = Convert.ToInt32(textBox1.Text);
            num2 = Convert.ToInt32(textBox2.Text);
            if(num1==num2)
            {
                result = "Both Numbers are equal";
            }
            else
            {
                result = "Both numbers are not equal";
            }
            label3.Text = "Result: " + result;
        }

    }
}


       
