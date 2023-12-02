using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vowel_or_nor_switch_window
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Character ch=new Character();
        private void button1_Click(object sender, EventArgs e)
        {
            char op = Convert.ToChar(textBox1.Text);
            ch.getdata(op);
            label2.Text = ch.res;

        }
    }
}
