﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shortedList_program_window
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SortedList sl=new SortedList();
        private void button1_Click(object sender, EventArgs e)
        {

            sl.Add(textBox1.Text, textBox2.Text);
            textBox1.Clear();
            textBox2.Clear();
            textBox1.Focus();
        }

            private void button2_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            ICollection key = sl.Keys;
            foreach (string str in key)
            {
                sb.Append("album name " + str + "\n");
            }
            label3.Text = sb.ToString();
        
        StringBuilder sb1 = new StringBuilder();
            ICollection val = sl.Values;
            foreach (string k in val)
            {
                sb1.Append("singer name  " + k + "\n");
            }
            label4.Text = sb1.ToString();
        }
    }
}
