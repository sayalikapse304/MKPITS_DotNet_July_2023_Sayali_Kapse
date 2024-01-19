using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace bonus_switch
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string name = TextBox1.Text;
            string designation = TextBox2.Text;
            int sal = Convert.ToInt32(TextBox3.Text);
            float hra=0;
            float da = 0;
            float totsal = 0;
            switch (designation)
            {
                case "Maneger":
                    hra = sal + 0.45f;
                    da = sal + 0.35f;
                    totsal = hra + da;
                    break;

                case "Peun":
                    hra = sal + 0.25f;
                    da = sal + 0.15f;
                    totsal = hra + da;
                    break;

                default:
                    Response.Write("Invalid designation");
                    break;
            }
            Label1.Text = hra.ToString();
            Label2.Text = da.ToString();
            Label3.Text = "Total sal=" + totsal;
        }
    }
}