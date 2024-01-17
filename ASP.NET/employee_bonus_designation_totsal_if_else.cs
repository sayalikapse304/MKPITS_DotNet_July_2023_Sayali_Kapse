using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace bonus
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
            int salary = Convert.ToInt32(TextBox3.Text);
            float hra = 0;
            float da = 0;
            float totsal = 0;
            if (designation == "Maneger")
            {
                hra = salary + 0.45f;
                da = salary + 0.35f;
                totsal = hra + da + salary;
            }
            else if(designation=="peun")
            {
                hra = salary + 0.25f;
                da = salary + 0.15f;
                totsal = hra + da + salary;
            }
            Label1.Text = "Total salary=" + totsal;
            
        }
        
    }
}