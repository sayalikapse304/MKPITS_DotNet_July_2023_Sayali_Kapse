using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace nested_loop11
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            int row, col;
            int num = Convert.ToInt32(TextBox1.Text);

            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            for (row = 1; row <= num; row++)
            {
                for (col = 1; col <= num; col++)
                {
                    sb.Append(row);
                }

                sb.Append("<br>");
            }
            Label1.Text = sb.ToString();
        }
        
    }
}
