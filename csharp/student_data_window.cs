using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace student_data1_window
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Student[] std = new Student[5];
        int cnt = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            std[0] = new Student();
            std[1] = new Student();
            std[2] = new Student();
            std[3] = new Student();
            std[4] = new Student();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (cnt < 5)
            {
                std[cnt].name = textBox1.Text;
                std[cnt].rno = Convert.ToInt32(textBox2.Text);
                std[cnt].fees = Convert.ToInt32(textBox3.Text);
                std[cnt].date = textBox4.Text;
                cnt++;
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox1.Focus();
                if (cnt == 5)
                {
                    button2.Enabled = false;
                    textBox1.Enabled = false;
                    textBox2.Enabled = false;
                    textBox3.Enabled = false;
                    textBox4.Enabled = false;
                    button1.Enabled = true;
                    MessageBox.Show("details of 10 student");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Student details are:" + "\n");
            for (int i = 0; i < 5; i++)
            {
                sb.Append("__________________________\n");
                sb.Append("student name:" + std[i].name + "\n");
                sb.Append("student rno:" + std[i].rno + "\n");
                sb.Append("student fees:" + std[i].fees + "\n");
                sb.Append("student date:" + std[i].date + "\n");
                sb.Append("__________________________\n");
            }
            label5.Text = sb.ToString();
            double high = std[0].fees;
            int foundat = 0;
            for (int i = 1; i < 5; i++)
            {
                if (high < std[i].fees)
                {
                    high = std[i].fees;
                    foundat = i;
                }
            }
            StringBuilder sb1 = new StringBuilder();
            sb1.Append("student with highest fees:\n");
            sb1.Append("student name:" + std[foundat].name + "\n");
            sb1.Append("student rno:" + std[foundat].rno + "\n");
            sb1.Append("student fees:" + std[foundat].fees + "\n");
            sb1.Append("student Date:" + std[foundat].date + "\n");
            label6.Text = sb1.ToString();
        }
    }
}
    
    
