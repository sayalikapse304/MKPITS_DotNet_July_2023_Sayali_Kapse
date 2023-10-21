using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vowels_or_not_windows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            char ch;
            string res;
            ch = Convert.ToChar(textBox1.Text);
            if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
            {
                res = "It is vowels";
            }
            else
            {
                res = "It is not vowels";
            }
            label2.Text = "result=" + res;
            }
        }
    }

