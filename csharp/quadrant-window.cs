using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quaderant_windows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x, y;
            string res;
            x = Convert.ToInt32(textBox1.Text);
            y = Convert.ToInt32(textBox2.Text);
            if (x > 0 && y > 0)
            {
                res = "point lies in 1st quadrant";
            }
            else if(x>0 && y<0)
            {
                res= "point lies in 2nd quadrant";
            }
            else if (x < 0 && y < 0)
            {
                res = "point lies in 3rd quadrant";
            }
            else 
            {
                res = "point lies in 4th quadrant";
            }
            label3.Text = "result=" + res;
        }
    }
}
