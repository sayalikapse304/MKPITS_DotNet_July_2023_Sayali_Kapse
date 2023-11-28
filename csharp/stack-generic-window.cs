using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stack_generic_cwindow
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Stack<string> msg = new Stack<string>();

        private void button1_Click(object sender, EventArgs e)
        {



            msg.Push(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            foreach (string s in msg)
            {
                sb.Append("msg:" + s + "\n");
            }
            label2.Text = sb.ToString();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            msg.Pop();

            StringBuilder sb = new StringBuilder();
            foreach (string s in msg)
            {
                sb.Append("msg:" + s + "\n");
            }
            label2.Text = sb.ToString();
        }
    }
}


