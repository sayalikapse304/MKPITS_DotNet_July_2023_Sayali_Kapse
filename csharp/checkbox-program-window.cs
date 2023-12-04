using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chechebox_program_window
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            int bsal = Convert.ToInt32(textBox2.Text);

            float bonus = bsal * 0.40f;
            float totsal = bsal + bonus;
            if(checkBox1.Checked&&checkBox2.Checked)
            {
                label3.Text = "bonus " + bonus;
                label4.Text = "totsal " + totsal;
            }
        

            else if (checkBox1.Checked)
            {
                label3.Text = "bonus " + bonus;
            }
            else if (checkBox2.Checked)
            {
                label4.Text = "totsal " + totsal;



            }
        }
    }

                

    
}
