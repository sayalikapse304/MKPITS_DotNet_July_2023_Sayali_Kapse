﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Addition
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int n1 = Convert.ToInt32(TextBox2.Text);
            int n2 = Convert.ToInt32(TextBox3.Text);
            int res = n1 + n2;
            Label1.Text = "Addition of Two No:" + res;

        }
    }
}