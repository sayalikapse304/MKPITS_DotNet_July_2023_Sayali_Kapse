using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tot_per_and_grade_window
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Subject sub=new Subject();
        private void button1_Click(object sender, EventArgs e)
        {
            int sub1=Convert.ToInt32(textBox1.Text);
            int sub2 = Convert.ToInt32(textBox2.Text);
            int sub3 = Convert.ToInt32(textBox3.Text);

            sub.getdata(sub1, sub2, sub3);

            label4.Text = "Total:" + sub.tot;
            label5.Text = "per:" + sub.per;
            label6.Text =  "grade:"+ sub.res;

        }
    }
}
