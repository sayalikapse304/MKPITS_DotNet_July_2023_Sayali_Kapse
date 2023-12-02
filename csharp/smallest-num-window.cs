using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace smallest_num_window
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Number n = new Number();
        private void button1_Click(object sender, EventArgs e)
        {
            int num1=Convert.ToInt32(textBox1.Text);
            int num2 = Convert.ToInt32(textBox2.Text);
            n.getdata(num1, num2);
            label3.Text = "smallest number: " + n.res;

        }
    }
}
