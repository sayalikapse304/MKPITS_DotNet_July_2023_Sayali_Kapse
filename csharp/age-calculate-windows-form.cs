using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace age_calculate_window
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string age = dateTimePicker1.Text;
                MessageBox.Show("dob" + age);

            int yr = dateTimePicker1.Value.Year;
            MessageBox.Show("dob year" + yr);

            int cyr=DateTime.Now.Year;
            MessageBox.Show("current Year" + cyr);

            int diff = cyr - Convert.ToInt32(yr);
            MessageBox.Show("your age is" + diff);
        }
    }
}
