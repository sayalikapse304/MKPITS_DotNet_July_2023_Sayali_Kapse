using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace minor_young_old_window
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Age a=new Age();
        private void button1_Click(object sender, EventArgs e)
        {
            int age=Convert.ToInt32(textBox1.Text);
            a.getdata(age);
            label2.Text = "age: " + a.res;

        }
    }
}
