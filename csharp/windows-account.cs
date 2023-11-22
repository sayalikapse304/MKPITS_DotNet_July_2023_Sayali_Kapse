﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace windows_acc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Account act = null;
            int actno = Convert.ToInt32(textBox1.Text);
            int amt = Convert.ToInt32(textBox2.Text);
            string tt = textBox3.Text;

            if (tt == "saving")
            {
                act = new saving();
            }
            else if (tt == "current")
            {
                act = new current();
            }
            label4.Text = act.deposit(actno, amt);
            label5.Text = act.showbalance();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Account act = null;
            int actno = Convert.ToInt32(textBox1.Text);
            int amt = Convert.ToInt32(textBox2.Text);
            string tt = textBox3.Text;

            if (tt == "saving")
            {
                act = new saving();
            }
            else if (tt == "current")
            {
                act = new current();
            }
            label4.Text = act.withdrawl(actno, amt);
            label5.Text = act.showbalance();

        }
    }
}

        
