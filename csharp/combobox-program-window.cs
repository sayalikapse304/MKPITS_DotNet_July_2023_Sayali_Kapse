using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace combobox_program_window
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string empname = textBox2.Text;
            int bsal = Convert.ToInt32(textBox1.Text);
            string designation = comboBox1.Text;
            float bonus = 0.0f;
            float totalsal = 0.0f;
            if (checkBox1.Checked && checkBox2.Checked)
            {
                label4.Text = "bonus " + bonus;
                label5.Text = "total sal" + totalsal;
            }
            switch (designation)
            {
                case "manager":
                    bonus = bsal * 0.55f;
                    break;
                case "clerk":
                    bonus = bsal * 0.45f;
                    break;
                case "peon":
                    bonus = bsal * 0.35f;
                    break;

            }
            totalsal = bsal + bonus;
            if (checkBox1.Checked)
            {
                label4.Text = "bonus " + bonus;
            }
            else if (checkBox2.Checked)
            {
                label5.Text = "total sal" + totalsal;
            }


        }
    }
}
  
