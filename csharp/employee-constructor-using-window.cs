using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace employee_constructor_using_window
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            employee e1= new employee(Convert.ToInt32(textBox1.Text),textBox2.Text, textBox3.Text, Convert.ToInt32(textBox4.Text));
            StringBuilder sb = new StringBuilder();
            sb.Append("empno:" +e1.empno + "\n");
            sb.Append("name:" + e1.name + "\n");
            sb.Append("designation:" + e1.designation + "\n");
            sb.Append("salary:" + e1.salary+ "\n");
            label5.Text = sb.ToString();
        }
    }
}
        
