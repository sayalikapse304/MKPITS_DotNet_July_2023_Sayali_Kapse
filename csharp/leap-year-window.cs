using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace leap_year_or_not_window
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Year y=new Year();
        private void button1_Click(object sender, EventArgs e)
        {
            int year=Convert.ToInt32(textBox1.Text);
            y.getdata(year);
            label2.Text = y.res;
        }
    }
}
