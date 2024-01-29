using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace nested_loop11
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int row, col;
            int num = Convert.ToInt32(TextBox1.Text);
            System.Text.StringBuilder sb = new System.Text.StringBuilder();

            for (row = num; row >= 1; row--)
            {
                for (col = 1; col <= row; col++)
                {
                    sb.Append("\t"+col);
                    
                }
                sb.Append("<br>");
            }
            Label1.Text = sb.ToString();


        }
    }
}