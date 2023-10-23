using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace triangle_valid_or_not_windows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int angle1, angle2, angle3,sum;
            string res;
            angle1 = Convert.ToInt32(textBox1.Text);
            angle2 = Convert.ToInt32(textBox2.Text);
            angle3 = Convert.ToInt32(textBox3.Text);
            sum = angle1 + angle2 + angle3;
            label4.Text = "sum=" + sum;
            if (sum == 180)
            {
                res = "Triangle is valid";
            }
            else
            {
                res = "triangle is invalid";
            }
            label5.Text = "result=" + res;
                }
            }
        }
      
