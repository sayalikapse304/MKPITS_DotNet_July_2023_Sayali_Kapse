using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace prime_num_or_not
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int num;
            int cnt = 2;
            int rem = 0;
            num = Convert.ToInt32(TextBox1.Text);
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            do
            {
                if (num % cnt == 0)
                {
                    sb.Append("number is not prime");
                    rem = 1;
                    break;
                }
                cnt++;
            }
            while (cnt < num);
            if(rem==0)
            {
                sb.Append("number is prime");
            }
            Label1.Text = sb.ToString();

        }
    }
}