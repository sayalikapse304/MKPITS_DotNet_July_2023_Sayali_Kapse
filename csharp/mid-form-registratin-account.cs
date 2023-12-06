using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mid_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void registerFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registerform r = new Registerform();
            r.MdiParent = this;
            r.Show();
        }

        private void accountFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            accountform a = new accountform();
            a.MdiParent = this;
            a.Show();
        }

        private void rRegisterFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void registerformToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Registerform r = new Registerform();
            r.MdiParent = this;
            r.Show();
        }

        private void accountformToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            accountform a = new accountform();
            a.MdiParent = this;
            a.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Registerform r = new Registerform();
            r.MdiParent = this;
            r.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            accountform a = new accountform();
            a.MdiParent = this;
            a.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = DateTime.Now.ToString();
        }
    }
    
}
    


