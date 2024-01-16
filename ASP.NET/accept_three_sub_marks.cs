using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace accept_three_sub_marks
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            float per = 0;
            float sub1 = Convert.ToSingle(TextBox1.Text);
            float sub2 = Convert.ToSingle(TextBox2.Text);
            float sub3 = Convert.ToSingle(TextBox3.Text);
           
            float tot = sub1 + sub2 + sub3;
            Label1.Text = "Total:-" + tot;
            per = tot / 300 * 100;
           
            Label2.Text = "per:-" + per;
            string res;
            if (per >= 75)
            {
                res = "A";
            }
            else if (per <=75 && per >= 55)
            {
                res = "B";
            }
            else if (per <=55 && per >= 35)
            {
                res = "C";
            }
            else
            {
                res = "Fail";
            }
           
            Label3.Text = "Gread:-" + res;
        }
    }
}