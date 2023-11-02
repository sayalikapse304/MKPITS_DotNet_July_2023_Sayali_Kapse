using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace auther_publicationyear_title_windws
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Book[] b = new Book[3];
            int cnt = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            b[0] = new Book();
            b[1] = new Book();
            b[2] = new Book();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (cnt < 3)
            {
                b[cnt].Title = textBox1.Text;
                b[cnt].auther = textBox2.Text;
                b[cnt].publicationYear = Convert.ToInt32(textBox3.Text);
                cnt++;
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox1.Focus();
                if (cnt == 3)
                {
                    button2.Enabled = false;
                    textBox1.Enabled = false;
                    textBox2.Enabled = false;
                    textBox3.Enabled = false;
                    button1.Enabled = true;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < 3; i++)
            { 
            sb.Append("____________________________\n");
            sb.Append("title:" + b[i].Title + "\n");
            sb.Append("auther:" + b[i].auther + "\n");
            sb.Append("publishYear:" + b[i].publicationYear + "\n");
            sb.Append("____________________________\n");
            }
            label4.Text = sb.ToString();

        }
        }
    }
    
