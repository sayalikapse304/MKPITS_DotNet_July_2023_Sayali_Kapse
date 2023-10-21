using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace even_odd_windows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num;
            string res;
            num = Convert.ToInt32(textBox1.Text);
            if (num % 2 == 0)
            {
                res = "number is even";
            }
            else
            {
                res = "number is odd";
            }
            label2.Text = "result=" + res;
            }

        }
    }

