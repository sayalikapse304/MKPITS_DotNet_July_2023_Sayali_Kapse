using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace login_form_with_menustrip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string constr = "server=LAPTOP-LP6VHOMO\\SQLEXPRESS; integrated security = true; database = sample11";


        private void button1_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(constr);
            string qr = "select count(*) from Login22 where username=@username and password=@password";
            try
            {
                SqlCommand cmd = new SqlCommand(qr, con);
                cmd.Parameters.AddWithValue("@username", textBox1.Text);
                cmd.Parameters.AddWithValue("@password", textBox2.Text);
                con.Open();
                int cnt=Convert.ToInt32(cmd.ExecuteScalar());
                if(cnt>0)
                {
                    MessageBox.Show("Login Successfull");
                    panel1.Visible = false;
                    menuStrip1.Visible = true;
                }
                else
                {
                    MessageBox.Show("Invalid Credentails! try Again");
                }
                
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }
            
        }
    }
}




           
     