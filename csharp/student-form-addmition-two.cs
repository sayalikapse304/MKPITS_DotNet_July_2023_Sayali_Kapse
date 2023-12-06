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
    public partial class addmission : Form
    {
        public addmission()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("name:" + textBox1.Text + "\n");
            sb.Append("email:" + textBox2.Text + "\n");
            sb.Append("mobail no:" + textBox3.Text + "\n");
            sb.Append("addmission date:" +dateTimePicker1.Text+"\n");
            sb.Append("cource:"+comboBox1.Text + "\n");
            label6.Text=sb.ToString();
        }
    }
}
