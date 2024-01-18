using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace account_withdrawl_deposit
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int bal = 1000;
            
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.Append("account no:-" + TextBox1.Text+"<br>");
            
            int amt = Convert.ToInt32(TextBox2.Text);

            if(RadioButton1.Checked)
            {
                bal = bal + amt;
            }
            else if(RadioButton2.Checked)
            {
                bal = bal - amt;
            }
           
            Label1.Text = "bal:" + bal;
        }
    }
}