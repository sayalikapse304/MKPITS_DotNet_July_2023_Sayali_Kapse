using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace stack_emp_window
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Employee emp;
        Stack st=new Stack();
        private void button1_Click(object sender, EventArgs e)
        {
            emp= new Employee(Convert.ToInt32(textBox1.Text), textBox2.Text, Convert.ToInt32(textBox3.Text), textBox4.Text);
            st.Push(emp);
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            st.Pop();
            StringBuilder sb = new StringBuilder();
            foreach (Employee emp in st)
            {
                sb.Append("empno: " + emp.empno+"\n");
                sb.Append("name: " + emp.name + "\n");
                sb.Append("salary: " + emp.salary + "\n");
                sb.Append("designation: " + emp.designation + "\n");

            }
            label5.Text= sb.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            foreach (Employee emp in st)
            {
                sb.Append("empno: " + emp.empno + "\n");
                sb.Append("name: " + emp.name + "\n");
                sb.Append("salary: " + emp.salary + "\n");
                sb.Append("designation: " + emp.designation + "\n");

            }
            label5.Text = sb.ToString();

        }
    }
}
