using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dictionary_collection_attandace_window
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Dictionary<int,Attandance> a=new Dictionary<int,Attandance>();
        

        private void button1_Click(object sender, EventArgs e)
        {
           Attandance att = new Attandance(Convert.ToInt32(textBox1.Text), textBox2.Text, Convert.ToInt32(textBox3.Text), textBox4.Text);
            a.Add(Convert.ToInt32(textBox1.Text), att);
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
          
            textBox1.Focus();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int totalp = 0;
            int totala = 0;
            StringBuilder sb = new StringBuilder();
            foreach (KeyValuePair<int, Attandance> kvp in a)
            {
                if (kvp.Value.att == "a")
                {
                    totala++;
                }
                if(kvp.Value.att=="p")
                {
                    totalp++;
                }


                sb.Append("rollno:" + kvp.Key+"\n");
                sb.Append("name:" + kvp.Value.name+"\n");
                sb.Append("date:" + kvp.Value.date+"\n");
                sb.Append("attandace:" + kvp.Value.att+"\n");
                sb.Append("-----------------------------------\n");

                
            }
            sb.Append("student present:" + totalp + "\n");
            sb.Append("student absent:" + totala + "\n");

            label5.Text = sb.ToString();
            
        }
    }
    
}
