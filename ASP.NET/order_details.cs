using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Schema;

namespace Order_details
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int totalamt = 0;
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
                sb.Append("Order no:-"+TextBox1.Text+"<br>");
                sb.Append("Customer Name:-" + TextBox2.Text + "<br>");
                sb.Append("Date:-" + TextBox3.Text + "<br>");
                sb.Append("Product:-" + DropDownList1.Text + "<br>");

                int quantity = Convert.ToInt32(TextBox5.Text);
                int price = Convert.ToInt32(TextBox4.Text);
                totalamt = quantity * price;

                sb.Append("quantity:-" + TextBox5.Text + "<br>");
                sb.Append("Total amt:-" + totalamt);

                Label1.Text = sb.ToString();



        }


        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string p = DropDownList1.Text;

            double price = 0;
            switch (p)
            {
                case "Mobail":
                    price = 30000;
                    break;
                case "Laptop":
                    price = 40000;
                    break;
                case "TV":
                    price = 50000;
                    break;
            }
            TextBox4.Text = price.ToString();
        
            
            
        }
       
    }


}
    