using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bonus_windows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name, designation;
            float bonus = 0, totsal = 0;
            int basicsal;
            name = (textBox1.Text);
            designation = (textBox2.Text);
            basicsal = Convert.ToInt32(textBox3.Text);
            if (designation == "maneger")
            {
                bonus = 10000;
            }
            else if (designation == "clerk")
            {
                bonus = 5000;
            }
            else if (designation == "peun")
            {
                bonus = 2000;
            }
            else
            {
                throw new Exception("Invalid");
            }
            label4.Text = "bonus=" + bonus;
            totsal = basicsal + bonus;
            label5.Text = "totsal=" + totsal;
        }
    }
}


