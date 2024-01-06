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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace employee_info_disconnected_enviornment
{
    public partial class Form1 : Form
    {
        string ConnectionString = "Server= LAPTOP-LP6VHOMO\\SQLEXPRESS; Integrated Security = true; database = Employe";
        SqlDataAdapter Sqlda;
        DataSet dataSet = new DataSet();
        SqlCommandBuilder cb;
        public Form1()
        {

            InitializeComponent();
            Sqlda = new SqlDataAdapter("select * from employee89", ConnectionString);
            cb = new SqlCommandBuilder(Sqlda);
            dataSet = new DataSet();
            Sqlda.Fill(dataSet, "Emp1");
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataRow dr = dataSet.Tables["Emp1"].NewRow();

            dr[0] = Convert.ToInt32(textBox1.Text);
            dr[1] = textBox2.Text;
            dr[2] = textBox3.Text;
            dr[3] = Convert.ToInt32(textBox4.Text);
            dr[4] = textBox5.Text;
            dr[5] = Convert.ToDecimal(textBox6.Text);

            dataSet.Tables["Emp1"].Rows.Add(dr);
            Sqlda.Update(dataSet.Tables["Emp1"]);
            MessageBox.Show("Data successfully inserted......");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dataSet.Tables["Emp1"];
        }



        private void button2_Click(object sender, EventArgs e)
        {
            foreach (DataRow dr in dataSet.Tables["Emp1"].Rows)
            {
                if (dr[0].ToString() == textBox1.Text)
                {
                    try
                    {


                        dr[0] = Convert.ToInt32(textBox1.Text);
                        dr[1] = textBox2.Text;
                        dr[2] = textBox3.Text;
                        dr[3] = Convert.ToInt32(textBox4.Text);
                        dr[4] = textBox5.Text;
                        dr[5] = Convert.ToDecimal(textBox6.Text);

                        Sqlda.Update(dataSet.Tables["Emp1"]);
                        MessageBox.Show("Data Successfully Updated..");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    break;

                }
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int intCounter = 0;
            DataRow drTarget;
            foreach (DataRow dr in dataSet.Tables["Emp1"].Rows)
            {
                if (dr[0].ToString() == textBox1.Text)
                {
                    try
                    {
                        //dataSet.Tables["Emp"].Rows.Remove(dr);
                        //dr.Delete();
                        //Sqlda.Update(dataSet.Tables["Emp"]);
                        dr.Delete();
                        // No need to call Rows.Remove(dr) if you are using dr.Delete()

                        Sqlda.Update(dataSet.Tables["Emp1"]);
                        dataSet.Tables["Emp1"].AcceptChanges();
                        MessageBox.Show("Data Successfully Deleted..");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    break;
                }
            }
        }
                


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1[0, e.RowIndex].Value.ToString();
            textBox2.Text = dataGridView1[1, e.RowIndex].Value.ToString();
            textBox3.Text = dataGridView1[2, e.RowIndex].Value.ToString();
            textBox4.Text = dataGridView1[3, e.RowIndex].Value.ToString();
            textBox5.Text = dataGridView1[4, e.RowIndex].Value.ToString();
            textBox6.Text = dataGridView1[5, e.RowIndex].Value.ToString();

        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBox1.Text = dataGridView1[0, e.RowIndex].Value.ToString();
            textBox2.Text = dataGridView1[1, e.RowIndex].Value.ToString();
            textBox3.Text = dataGridView1[2, e.RowIndex].Value.ToString();
            textBox4.Text = dataGridView1[3, e.RowIndex].Value.ToString();
            textBox5.Text = dataGridView1[4, e.RowIndex].Value.ToString();
            textBox6.Text = dataGridView1[5, e.RowIndex].Value.ToString();


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1[0, e.RowIndex].Value.ToString();
            textBox2.Text = dataGridView1[1, e.RowIndex].Value.ToString();
            textBox3.Text = dataGridView1[2, e.RowIndex].Value.ToString();
            textBox4.Text = dataGridView1[3, e.RowIndex].Value.ToString();
            textBox5.Text = dataGridView1[4, e.RowIndex].Value.ToString();
            textBox6.Text = dataGridView1[5, e.RowIndex].Value.ToString();
        }
    }
}
    


