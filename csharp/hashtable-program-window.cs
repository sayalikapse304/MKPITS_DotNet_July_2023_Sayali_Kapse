using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hashtable_program_window
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Hashtable ht = new Hashtable();
        private void button1_Click(object sender, EventArgs e)
        {
            ht.Add(textBox1.Text, textBox2.Text);
            textBox1.Clear();
            textBox2.Clear();
            textBox1.Focus();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            ICollection key = ht.Keys;
            foreach (string k in key)
            {
                sb.Append("album name " + k + "\n");
            }
            label3.Text = sb.ToString();

            StringBuilder sb1 = new StringBuilder();
            ICollection val = ht.Values;
            foreach (string s in val)
            {
                sb1.Append("siger name " + s + "\n");
            }
            label4.Text = sb1.ToString();
        }
    }
}

