using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using static System.Net.Mime.MediaTypeNames;

namespace student_registraion_form
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            String str = "server=LAPTOP-LP6VHOMO\\SQLEXPRESS;integrated security=true;database=sample11";
            SqlConnection con = new SqlConnection(str);
            SqlCommand command;
            String qr;


            try
            {
                string imgname = null;
                if (FileUpload1.HasFile)
                {
                    imgname = FileUpload1.FileName;
                    FileUpload1.SaveAs(Server.MapPath(FileUpload1.FileName));
                }
                qr = "insert into stuinfo(roll_no,name,marks,stuimg) values('" + TextBox1.Text + "','" + TextBox2.Text + "' ,'" + TextBox3.Text + "','"+imgname+"')";
                command = new SqlCommand(qr, con);

                con.Open();

                command.ExecuteNonQuery();
                Label1.Text = "record saved successfully";
                TextBox1.Text = "";
                TextBox2.Text = "";
                TextBox3.Text = "";
                TextBox1.Focus();

            }
            catch (Exception ee)
            {
                Label1.Text = ee.ToString();
            }
            finally
            {

                con.Close();
            }

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            String str = "server=LAPTOP-LP6VHOMO\\SQLEXPRESS;integrated security=true;database=sample11";
            SqlConnection con = new SqlConnection(str);
            SqlCommand command;
            String qr;

            try
            {
                string imgname = null;
                if (FileUpload1.HasFile)
                {
                    imgname = FileUpload1.FileName;
                    FileUpload1.SaveAs(Server.MapPath(FileUpload1.FileName));
                }

                qr = "update  stuinfo set name='" + TextBox2.Text+ "',marks='" + TextBox3.Text + "',studimage='" + imgname+"' where roll_no='" + TextBox1.Text + "'";
                command = new SqlCommand(qr, con);

                con.Open();

                command.ExecuteNonQuery();
                Label1.Text = "record updated successfully";
                TextBox1.Text = "";
                TextBox2.Text = "";
                TextBox1.Focus();

            }
            catch (Exception ee)
            {
                Label1.Text = ee.ToString();
            }
            finally
            {

                con.Close();
            }



        }

        protected void Button4_Click(object sender, EventArgs e)
        {

            String str = "server=LAPTOP-LP6VHOMO\\SQLEXPRESS;integrated security=true;database=sample11";
            SqlConnection con = new SqlConnection(str);
            SqlCommand command;
            String qr;
            try
            {

                qr = "delete from  stuinfo where name='" + TextBox2.Text + "' or roll_no='" + TextBox1.Text + "'";
                command = new SqlCommand(qr, con);

                con.Open();

                command.ExecuteNonQuery();
                Label1.Text = "record deleted successfully";
                TextBox1.Text = "";
                TextBox2.Text = "";
                TextBox1.Focus();

            }
            catch (Exception ee)
            {
                Label1.Text = ee.ToString();
            }
            finally
            {

                con.Close();
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            String str = "server=LAPTOP-LP6VHOMO\\SQLEXPRESS;integrated security=true;database=sample11";
            SqlConnection con = new SqlConnection(str);
            SqlCommand command;
            String qr;
            try
            {

                qr = "select * from  stuinfo where  roll_no='" + TextBox1.Text + "'";
                command = new SqlCommand(qr, con);
                
                con.Open();
                
                SqlDataReader dr = command.ExecuteReader();
                int flag = 0;
                while (dr.Read())
                {
                    Label1.Text = "";
                    flag = 1;
                    TextBox2.Text = dr["name"].ToString();
                    TextBox3.Text = dr["marks"].ToString();
                    string img = dr["stuimg"].ToString();
                    Image1.ImageUrl = img;
                }
                dr.Close();
                if (flag == 0)
                {
                    Label1.Text = "no record found";
                }


            }
            catch (Exception ee)
            {
                Label1.Text = ee.ToString();
            }
            finally
            {
                

                con.Close();
            }
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            if (FileUpload1.HasFile)
            {
                FileUpload1.SaveAs(Server.MapPath(FileUpload1.FileName));
                Label1.Text = "file uploaded successfully";
            }
            else
            {
                Label1.Text = "please select a file first";
            }
        }
    }
}
    


    
