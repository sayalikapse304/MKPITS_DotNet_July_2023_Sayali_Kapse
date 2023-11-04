using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace product_with_parameter_windows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Product p = new Product( Convert.ToInt32(textBox1.Text),textBox2.Text, Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox4.Text));
            StringBuilder sb = new StringBuilder();
            sb.Append("productid:" + p.productid+ "\n");
            sb.Append("name:" + p.productname + "\n");
            sb.Append("price:" + p.price + "\n");
            sb.Append("quantity:" + p.quantity+ "\n");
            label5.Text = sb.ToString();
        }
    }
}
        
