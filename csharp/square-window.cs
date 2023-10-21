namespace square1_windows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(textBox1.Text);
            int square = num * num;
            label2.Text = "square" + square;
        }
    }
}