using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace addmition_form_windows
{
    public partial class enquire : Form
    {
        public enquire()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("name:" + textBox1.Text+"\n");
            sb.Append("email:" + textBox2.Text + "\n");
            sb.Append("mobail no:" + maskedTextBox1.Text + "\n");
            sb.Append("education:" + textBox4.Text + "\n");
           sb.Append("dob:" +dateTimePicker1.Text+"\n");

            string gender = null;
            if (radioButton1.Checked)
            {
                gender = radioButton1.Text;
            }
            else if (radioButton2.Checked)
            {
                gender = radioButton2.Text;
            }
            sb.Append("gender:" + gender + "\n");
            sb.Append("cources:");
            if (checkBox1.Checked)
            {
                sb.Append(checkBox1.Text + "\n");
            }
            if (checkBox2.Checked)
            {
                sb.Append(checkBox2.Text + "\n");
            }
            if (checkBox3.Checked)
            {
                sb.Append(checkBox3.Text + "\n");
            }
            if (checkBox4.Checked)
            {
                sb.Append(checkBox4.Text + "\n");
            }
            label8.Text = sb.ToString();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
        
