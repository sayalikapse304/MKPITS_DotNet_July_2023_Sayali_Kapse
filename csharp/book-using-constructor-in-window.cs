using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace book_using_constructor_in_windows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Book b = new Book(Convert.ToInt32(textBox1.Text), textBox2.Text, textBox3.Text, Convert.ToInt32(textBox4.Text));
            StringBuilder sb = new StringBuilder();
            sb.Append("bookid:" + b.bookid+"\n");
            sb.Append("title:" + b.title + "\n");
            sb.Append("auther:" + b.auther + "\n");
            sb.Append("price:" + b.price + "\n");
            label5.Text = sb.ToString();
        }
    }
}
                

    
