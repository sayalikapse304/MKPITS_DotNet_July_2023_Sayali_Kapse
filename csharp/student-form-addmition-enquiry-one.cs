using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace addmition_form_windows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (textBox1.Text == "sayali" && textBox2.Text == "1234")
            {
                panel1.Visible = false;
                enquiryToolStripMenuItem.Enabled = true;
                addmissionToolStripMenuItem.Enabled = true;
            }
            else
            {
                MessageBox.Show("enter Correct information");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {  
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void horizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void verticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void enquiryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            enquire en = new enquire();
            {
                en.MdiParent = this;
                en.Show();
            }


        }

        private void addmissionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addmission a = new addmission();
            a.MdiParent = this;
            a.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    
}

