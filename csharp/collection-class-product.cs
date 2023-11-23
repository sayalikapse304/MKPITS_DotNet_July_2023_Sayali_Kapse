using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace collection_class_product
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Product p;
        ArrayList ar = new ArrayList();
        private void button2_Click(object sender, EventArgs e)
        {
            p = new Product(Convert.ToInt32(textBox1.Text), textBox2.Text, Convert.ToInt32(textBox3.Text));
            ar.Add(p);
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            
            textBox1.Focus();
            textBox2.Focus();
            textBox3.Focus();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder sb= new StringBuilder();
            foreach(Product p in ar)
            {
                sb.Append("product Id:"+p.Id+" "+"product name:"+p.Name+" "+"product rate"+p.Rate+"\n");
            }
            label4.Text= sb.ToString();
        }
    }
    
}
