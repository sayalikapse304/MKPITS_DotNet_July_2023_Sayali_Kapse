using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tab_pages_windows_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder sb= new StringBuilder();
            sb.Append("Name:" + textBox1.Text+"\n");
            sb.Append("branch:" + textBox2.Text);
            label3.Text = sb.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Name:" + textBox3.Text + "\n");
            sb.Append("course:" + textBox4.Text);
            label6.Text = sb.ToString();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
    }
}
