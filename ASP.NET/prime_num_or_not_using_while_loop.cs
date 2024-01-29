using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace prime_num_or_not
{
    public partial class WebForm3 : System.Web.UI.Page
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
            while(cnt<num)
            {
                if(num%cnt==0)
                {
                    rem = 1;
                    break;
                }
                cnt++;
            }
            if(rem==0)
            {
                sb.Append("no is prime");
            }
            else
            {
                sb.Append("no is not prime");
            }
            Label1.Text = sb.ToString();

        }
    }
}
       