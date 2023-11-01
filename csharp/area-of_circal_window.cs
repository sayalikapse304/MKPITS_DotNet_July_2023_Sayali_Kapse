using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace area_of_circal_windows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Circal c = new Circal();
            c.radius = Convert.ToInt32(textBox1.Text);
           
            c.getdata(c.radius);
            
            label2.Text = c.area.ToString();
            label3.Text = c.circ.ToString();



        }
    }
}
