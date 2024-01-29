using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace prime_num_or_not
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int num;
            int cnt;
            int rem = 0;
            
            num = Convert.ToInt32(TextBox1.Text);
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            for (cnt = 2; cnt < num; cnt++)
            {
                rem = num % cnt;
                if (rem == 0)
                {
                    sb.Append ("It is a not prime number");
                    break;
                    cnt = 1;
                }

            }
            if (num == cnt)
            {
                sb.Append("It is a prime number");
            }

            Label1.Text = sb.ToString();
        }
    }
}
        