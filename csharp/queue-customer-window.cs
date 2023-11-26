using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
namespace queuq_customer_window
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Customer c;
        Queue q=new Queue();
        private void button1_Click(object sender, EventArgs e)
        {
            c = new Customer(Convert.ToInt32(textBox1.Text), textBox2.Text, Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox4.Text));
            q.Enqueue(c);
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox1.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Customer r = (Customer)q.Dequeue();
            StringBuilder sb = new StringBuilder();
            foreach (Customer c in q)
            {
                sb.Append("custid: " + c.custid + "\n");
                sb.Append("name: " + c.name + "\n");
                sb.Append("moba: " + c.moba + "\n");
                sb.Append("email: " + c.email + "\n");

            }
            label5.Text = sb.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            foreach (Customer c in q)
            {
                sb.Append("custid: " + c.custid + "\n");
                sb.Append("name: " + c.name + "\n");
                sb.Append("moba: " + c.moba + "\n");
                sb.Append("email: " + c.email + "\n");

            }
            label5.Text = sb.ToString();
        }
    }
    
}

