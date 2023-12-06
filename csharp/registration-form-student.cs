using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace registration_form_student_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            string name = textBox1.Text;
            int age = Convert.ToInt32(numericUpDown1.Text);

            if (textBox1.Text == ""&& numericUpDown1.Value==0)
            {
                MessageBox.Show("enter name");
            }
            else if(textBox1.Text =="")
            {
                MessageBox.Show("enter name");
            }
             if(numericUpDown1.Value == 0)
            {
                MessageBox.Show("enter age");
            }
            if (numericUpDown1.Value <= 18)
            {
                MessageBox.Show("age should be greater than 18");
            }
            else
            {

            

            sb.Append("name:" + name + "\n");
            sb.Append("age:" + age + "\n");
        }
            label4.Text = sb.ToString();
        }
    

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            numericUpDown1.Value=0;
        }
    }
}
