using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace student22222
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student s = new Student();
            s.name = textBox1.Text;
            s.rollnum = Convert.ToInt32(textBox2.Text);
            s.marks[0] = Convert.ToInt32(textBox3.Text);
            s.marks[1] = Convert.ToInt32(textBox4.Text);
            s.marks[2] = Convert.ToInt32(textBox5.Text);



            StringBuilder sb = new StringBuilder();
            s.getdata(s.name, s.rollnum, s.marks);
            sb.Append("name:" + s.name);
            sb.Append("\nrollnum:" + s.rollnum);
            sb.Append("\ntotal:" + s.total);
            sb.Append("\navrage:" + s.avr);
            label6.Text = sb.ToString();

        }
    }
}
        
