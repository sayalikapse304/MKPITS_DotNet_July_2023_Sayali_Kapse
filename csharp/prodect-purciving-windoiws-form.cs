using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace product_purcuing_window
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            comboBox2.Text = " ";
            switch(comboBox1.Text)
            {
                case "Electronic device":
                    comboBox2.Items.Add("Tv");
                    comboBox2.Items.Add("Mobail");
                    comboBox2.Items.Add("Computer");
                    comboBox2.Items.Add("Freez");
                    break;

                case "stationary":
                    comboBox2.Items.Add("Foundation");
                    comboBox2.Items.Add("Blusher");
                    comboBox2.Items.Add("eyeshadow");
                    comboBox2.Items.Add("kajal");
                    break;

                case "house holder":
                    comboBox2.Items.Add("micro_oven");
                    comboBox2.Items.Add("decoration");
                    comboBox2.Items.Add("wallpaper");
                    break;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("name:" + textBox1.Text+"\n");
            sb.Append("Id:" + textBox2.Text+"\n");
            sb.Append("mobail no:" + maskedTextBox1.Text+"\n");
            int quantity = Convert.ToInt32(textBox3.Text);
            sb.Append("quantity:" + textBox3.Text + "\n");
            int rate= Convert.ToInt32(textBox4.Text);
            sb.Append("rate:" + textBox4.Text + "\n");
            int tot = quantity * rate;
            sb.Append("tot:" + tot);
            label8.Text = sb.ToString();
        }
    }
}
