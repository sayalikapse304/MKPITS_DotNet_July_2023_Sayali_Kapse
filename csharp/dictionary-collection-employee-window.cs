using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dictionary_collection_employee_window
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Dictionary<int,Employee>emp=new Dictionary<int,Employee>();
        private void button1_Click(object sender, EventArgs e)
        {
            Employee e1 = new Employee(Convert.ToInt32(textBox1.Text), textBox2.Text);
            Employee e2 = new Employee(Convert.ToInt32(textBox3.Text), textBox4.Text);
            emp.Add(e1.no, e1);
            emp.Add(e2.no, e2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            foreach (KeyValuePair<int, Employee> kv in emp)
            {
                sb.Append("emp no " + kv.Key + " emp name " + kv.Value.name + "\n");
            }
            label5.Text = sb.ToString();

        }
    }
}
