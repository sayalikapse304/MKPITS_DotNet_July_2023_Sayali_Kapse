using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace leap_year_windows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int year;
            string result;
            year = Convert.ToInt32(textBox1.Text);
            if (year % 4 == 0)
            {
                result = "leap year";
            }
            else
            {
                result = "not leap year";
            }
            label2.Text = "result=" + result;
            }
        }
    }

