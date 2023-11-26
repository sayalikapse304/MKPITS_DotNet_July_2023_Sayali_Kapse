using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stack_program_pop_widow
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Stack s = new Stack();
        private void button1_Click(object sender, EventArgs e)
        {
            s.Push(textBox1.Text);
           textBox1.Clear();
            textBox1.Focus();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            s.Pop();
            StringBuilder sb = new StringBuilder();
            foreach (string c in s)
            {
                sb.Append(c+" ");
            }
            label2.Text = sb.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            StringBuilder sb1 = new StringBuilder();
            foreach (string s in s)
            {
                sb1.Append(s + "\n");
            }
            label2.Text = sb1.ToString();
        }
    }
    
}


            
        
