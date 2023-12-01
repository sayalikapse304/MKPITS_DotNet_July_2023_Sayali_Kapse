using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace employee_designation_salary_window
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Employee emp=new Employee();
        private void button1_Click(object sender, EventArgs e)
        {
            string n = textBox1.Text;
            int bsal = Convert.ToInt32(textBox2.Text);
            string deg = textBox3.Text;
            emp.sal(n, bsal, deg);
            label4.Text= "hra:"+emp.hra;
            label5.Text ="bonus:"+emp.bonus;
            label6.Text = "totalsal:" + emp.totalsal;





        }
    }
}
