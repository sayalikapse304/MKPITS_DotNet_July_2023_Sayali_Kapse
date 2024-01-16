using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace area_of_circal_and_circ
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            float r = Convert.ToSingle(TextBox1.Text);
            float circal =  3.14f * r*r;
            float circ = 2 * 3.14f * r;
            Label1.Text = "area=" + circal + "<br>" + circ;
        }
    }
}