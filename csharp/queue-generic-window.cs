using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace queus_windowssssssssssssssssssssssssssssssss
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Queue<string> msg = new Queue<string>();
        private void button1_Click(object sender, EventArgs e)
        {


            msg.Enqueue(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            StringBuilder sb = new StringBuilder();
            foreach (string s in msg)
            {
                sb.Append("msg:"+s+"\n");
            }
            label2.Text= sb.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            msg.Dequeue();
            
            StringBuilder sb = new StringBuilder();
            foreach (string s in msg)
            {
                sb.Append("msg:" + s + "\n");
            }
            label2.Text = sb.ToString();
        }

        
    }
    
}
