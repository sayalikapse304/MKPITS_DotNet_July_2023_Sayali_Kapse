using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dictionary_collection_window
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Dictionary<string,string>dic = new Dictionary<string,string>();
        private void button1_Click(object sender, EventArgs e)
        {
            dic.Add(textBox1.Text,textBox2.Text);
            textBox1.Clear();
            textBox2.Clear();
            textBox1.Focus();
            MessageBox.Show("added in dictionary");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            List<string> list = new List<string>();
            foreach (string key in dic.Keys)
            {
                sb.Append("keys in dictionary:" + key + "\n");
            }
            label3.Text = sb.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            List<string> keys = new List<string>(dic.Values);
            foreach (string key in dic.Keys)
            {
                sb.Append("values in dictionary:" + key + "\n");
            }
            label4.Text = sb.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            foreach(KeyValuePair<string,string>kvp in dic)
            {
                sb.Append("key"+kvp.Key+"value"+kvp.Value+"\n");
            }
            label4.Text = sb.ToString();
        }
    }
    
}
