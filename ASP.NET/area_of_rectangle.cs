using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Area_of_rectangle_11
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            float l = Convert.ToSingle(TextBox1.Text);
            float b = Convert.ToSingle(TextBox2.Text);
            float area = l * b;
            Label1.Text = "Area of Rectangle=" + area;
        }
    }
}