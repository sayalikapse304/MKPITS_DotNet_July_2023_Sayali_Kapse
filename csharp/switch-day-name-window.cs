using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace day_name_switch_window
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Day d=new Day();
        private void button1_Click(object sender, EventArgs e)
        {
            int dayno=Convert.ToInt32(textBox1.Text);
            d.getdata(dayno);
            label2.Text = "day name:"+d.res;
        }
    }
}
