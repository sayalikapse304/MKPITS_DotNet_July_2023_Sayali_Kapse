using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fendal_project_product
{
    public partial class Form1 : Form
    {

        public enum Nationality { Indian, NRI }
        Nationality nat;
        string strcon = "server=LAPTOP-LP6VHOMO\\SQLEXPRESS;integrated security=true;database=fendal_project;";
        SqlConnection con;
        SqlDataAdapter da;
        DataSet ds;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("enter only numbers");
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Text = DateTime.Now.ToShortDateString();
            getCategory();
            getProduct();
            getPrice();
            nat = Nationality.Indian;

        }
        public void getCategory()
        {
            con = new SqlConnection(strcon);
            da = new SqlDataAdapter("select * from TableProductCategory1", con);
            ds = new DataSet();
            da.Fill(ds, "tpc");
            comboBox1.DataSource = ds.Tables["tpc"];
            comboBox1.DisplayMember = "product_type_name";
            comboBox1.ValueMember = "product_category_Id";

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox11.Text = "0";
            getProduct();
            if (comboBox1.Text != "System.Data.DataRowView")
            {
                string catname = comboBox1.Text;

                con = new SqlConnection(strcon);
                da = new SqlDataAdapter("select * from TableProductGstDetails12 where Gst_Detail_Name=@gdn", con);
                da.SelectCommand.Parameters.AddWithValue("@gdn", catname);
                ds = new DataSet();
                da.Fill(ds, "tgst");
                foreach (DataRow dr in ds.Tables["tgst"].Rows)
                {
                    textBox3.Text = dr["CGST"].ToString();
                    textBox4.Text = dr["SGST"].ToString();
                    textBox5.Text = dr["IGST"].ToString();
                }
            }
        }



        public void getProduct()
        {
            if (comboBox1.SelectedValue.ToString() != "System.Data.DataRowView")
            {
                con = new SqlConnection(strcon);
                da = new SqlDataAdapter("select * from TableProduct2 where product_category_Id=@pci", con);
                da.SelectCommand.Parameters.AddWithValue("@pci", comboBox1.SelectedValue);
                ds = new DataSet();
                da.Fill(ds, "tp");
                comboBox2.DataSource = ds.Tables["tp"];
                comboBox2.DisplayMember = "product_name";
                comboBox2.ValueMember = "product_Id";
            }

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox10.Text = "0";
            textBox11.Text = "0";
            getPrice();
        }
        public void getPrice()
        {
            try
            {
                if (comboBox2.SelectedValue.ToString() != "System.Data.DataRowView")
                {
                    con = new SqlConnection(strcon);
                    da = new SqlDataAdapter("select * from TableProduct2 where product_Id = @pid", con);
                    da.SelectCommand.Parameters.AddWithValue("@pid", comboBox2.SelectedValue);
                    ds = new DataSet();
                    da.Fill(ds, "tp1");
                    foreach (DataRow dr in ds.Tables["tp1"].Rows)
                    {
                        textBox9.Text = dr["product_price"].ToString();
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                nat = Nationality.Indian;
                textBox6.Text = "0";
                textBox7.Text = "0";
                textBox8.Text = "0";
                textBox10.Text = "0";
                textBox11.Text = "0";
                textBox12.Text = "0";
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                nat = Nationality.NRI;
                textBox6.Text = "0";
                textBox7.Text = "0";
                textBox8.Text = "0";
                textBox10.Text = "0";
                textBox11.Text = "0";
                textBox12.Text = "0";
            }
        }
        

        double tcgst = 0;
        double tsgst = 0;
        double tigst = 0;
        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            if (textBox10.Text != "")
            {
                double price = Convert.ToDouble(textBox9.Text);
                double quantity = Convert.ToDouble(textBox10.Text);
                double totalamount = price * quantity;
                textBox11.Text = totalamount.ToString();

                double pcgst = Convert.ToDouble(textBox3.Text);
                tcgst = totalamount * (pcgst / 100);
                textBox6.Text = tcgst.ToString();

                double psgst = Convert.ToDouble(textBox4.Text);
                tcgst = totalamount * (psgst / 100);
                textBox7.Text = tcgst.ToString();

                double pigst = Convert.ToDouble(textBox5.Text);
                tcgst = totalamount * (pigst / 100);
                textBox8.Text = tcgst.ToString();

                if (nat.ToString() == "Indian")
                {
                    double netamount = Convert.ToDouble(textBox11.Text) + Convert.ToDouble(textBox6.Text) + Convert.ToDouble(textBox7.Text);
                    textBox12.Text = netamount.ToString();
                }
                else if (nat.ToString() == "NRI")
                {
                    double netamount = Convert.ToDouble(textBox11.Text) + Convert.ToDouble(textBox8.Text);
                    textBox12.Text = netamount.ToString();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime SelectedDate = dateTimePicker1.Value;
            if (SelectedDate.Date < DateTime.Today)
            {
                MessageBox.Show("");
            }

            else
            {
                SqlConnection conn = new SqlConnection(strcon);
                conn.Open();
                try
                {
                    string s1 = "insert into Tableinvoicedetail values(@customer_name,@customer_contact,@productTypeID,@product_Id,@Residential_Type_Id,@Invoice_Date,@quantity, @price ,@CGST,@SGST,@IGST,@CGST_value,@SGST_value,@IGST_value,@total_amount)";
                    SqlCommand cmd = new SqlCommand(s1, conn);
                    
                    cmd.Parameters.AddWithValue("customer_name", textBox1.Text);
                    cmd.Parameters.AddWithValue("customer_contact", textBox2.Text);
                    cmd.Parameters.AddWithValue("productTypeID", comboBox1.SelectedValue);
                    cmd.Parameters.AddWithValue("product_Id", comboBox2.SelectedValue);
                    cmd.Parameters.AddWithValue("Residential_Type_Id",1001);
                    cmd.Parameters.AddWithValue("Invoice_Date", dateTimePicker1.Value);
                    cmd.Parameters.AddWithValue("quantity", textBox10.Text);
                    cmd.Parameters.AddWithValue("price", textBox9.Text);
                    cmd.Parameters.AddWithValue("CGST", textBox3.Text);
                    cmd.Parameters.AddWithValue("SGST", textBox4.Text);
                    cmd.Parameters.AddWithValue("IGST", textBox5.Text);
                    cmd.Parameters.AddWithValue("CGST_value", textBox6.Text);
                    cmd.Parameters.AddWithValue("SGST_value", textBox7.Text);
                    cmd.Parameters.AddWithValue("IGST_value", textBox8.Text);
                    cmd.Parameters.AddWithValue("total_amount", textBox11.Text);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Record inserted in TableInvoiceDetails");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }

       
        public void Clear()
        {
            dateTimePicker1.Value = DateTime.Today;
            comboBox1.Text = "Select";
            comboBox2.Text = "Select";
            textBox3.Text = "0";
            textBox4.Text = "0";
            textBox5.Text = "0";
            textBox6.Text = "0";
            textBox7.Text = "0";
            textBox8.Text = "0";
            textBox9.Text = "0";
            textBox10.Text = "0";
            textBox11.Text = "0";
            textBox12.Text = "0";
            textBox1.Clear();
            textBox2.Clear();
        }

        
        
private void button2_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
    
}

    

        
    




