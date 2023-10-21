using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace positive_numbers_or_not_windows
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
            string result;
            num = Convert.ToInt32(textBox1.Text);
            if (num > 0)
            {
                result = "number are positive";
            }
            else
            {
                result = "number are negative";
            }
            label2.Text = "result=" + result;
            }
        }
    }

