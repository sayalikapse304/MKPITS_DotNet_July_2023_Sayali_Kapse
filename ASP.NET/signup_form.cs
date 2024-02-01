using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace signup_from
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String str = "data source=.\\SQLEXPRESS;integrated security=true;database=sample11";
            SqlConnection con = new SqlConnection(str);

            String qr;
            try
            {
                string imgname = null;
                if(FileUpload1.HasFile)
                {
                    imgname = FileUpload1.FileName;
                    FileUpload1.SaveAs(Server.MapPath(FileUpload1.FileName));
                }

                string g = null;
                string h = null;

                qr = "insert into signup11(name,email,gender,hobby,city,user_img) values(@name,@email,@gender,@hobby,@city,@user_img)";
                SqlCommand cmd = new SqlCommand(qr, con);
                con.Open();
                cmd.Parameters.AddWithValue("@name", TextBox1.Text);
                cmd.Parameters.AddWithValue("@email", TextBox2.Text);
                cmd.Parameters.AddWithValue("@city", DropDownList1.Text);
                cmd.Parameters.AddWithValue("@user_img", imgname);


                if (RadioButton1.Checked)
                    g = "Male";

                else if (RadioButton2.Checked)
                    g = "Female";
                cmd.Parameters.AddWithValue("@gender", g);

                if (CheckBox1.Checked)
                    h = h + "" + CheckBox1.Text;
                if (CheckBox2.Checked)
                    h = h + "" + CheckBox2.Text;
                if (CheckBox3.Checked)
                    h = h + "" + CheckBox3.Text;
                cmd.Parameters.AddWithValue("@hobby", h);

                cmd.ExecuteNonQuery();
                Label1.Text = "record saved successfully";
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

        protected void Button2_Click(object sender, EventArgs e)
        {
            String str = "data source=.\\SQLEXPRESS;integrated security=true;database=sample11";
            SqlConnection con = new SqlConnection(str);

            String qr;
            string imgname = null;
            if (FileUpload1.HasFile)
            {
                imgname = FileUpload1.FileName;
                FileUpload1.SaveAs(Server.MapPath(FileUpload1.FileName));
            }
            string g = null;
            string h = null;

            try
            {
                qr = "update signup11 set email=@email,gender=@gender,hobby=@hobby,city=@city,user_img=@user_img where name=@name";
                SqlCommand cmd = new SqlCommand(qr, con);
                con.Open();
                cmd.Parameters.AddWithValue("@name", TextBox1.Text);
                cmd.Parameters.AddWithValue("@email", TextBox2.Text);
                cmd.Parameters.AddWithValue("@city", DropDownList1.Text);
                cmd.Parameters.AddWithValue("@user_img", imgname);


                if (RadioButton1.Checked)
                    g = "Male";

                else if (RadioButton2.Checked)
                    g = "Female";
                cmd.Parameters.AddWithValue("@gender", g);

                if (CheckBox1.Checked)
                    h = h + "" + CheckBox1.Text;
                if (CheckBox2.Checked)
                    h = h + "" + CheckBox2.Text;
                if (CheckBox3.Checked)
                    h = h + "" + CheckBox3.Text;
                cmd.Parameters.AddWithValue("@hobby", h);

                cmd.ExecuteNonQuery();
                Label1.Text = "record update successfully";
                TextBox1.Text = "";
                TextBox2.Text = "";
                TextBox1.Focus();

            }
            catch (Exception ee)
            {
                Label1.Text = ee.Message;
            }
            finally
            {

                con.Close();
            }

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            String str = "data source=.\\SQLEXPRESS;integrated security=true;database=sample11";
            SqlConnection con = new SqlConnection(str);

            String qr;
            

            try
            {
                qr = "delete from signup11 where name=@name";
                SqlCommand cmd = new SqlCommand(qr, con);
                con.Open();
                cmd.Parameters.AddWithValue("@name", TextBox1.Text);

                cmd.ExecuteNonQuery();
                Label1.Text = "record delete successfully";
                TextBox1.Text = "";
                TextBox2.Text = "";
                TextBox1.Focus();

            }
            catch (Exception ee)
            {
                Label1.Text = ee.Message;
            }
            finally
            {

                con.Close();
            }

        }

        protected void Button4_Click(object sender, EventArgs e)
        {

            String str = "data source=.\\SQLEXPRESS;integrated security=true;database=sample11";
            SqlConnection con = new SqlConnection(str);

            String qr;


            try
            {
                qr = "select * from signup11 where name=@name";
                SqlCommand cmd = new SqlCommand(qr, con);
                con.Open();
                cmd.Parameters.AddWithValue("@name", TextBox1.Text);

                SqlDataReader dr= cmd.ExecuteReader();
                int flag = 0;
                while (dr.Read())
                {



                    Label1.Text = "";
                    flag = 1;
                    TextBox2.Text = dr["email"].ToString();
                    string img = dr["user_img"].ToString();
                    Image1.ImageUrl = img;
                    TextBox1.Focus();
                }

            }
            catch (Exception ee)
            {
                Label1.Text = ee.Message;
            }
            finally
            {

                con.Close();
            }

        }

    }
}

    

            