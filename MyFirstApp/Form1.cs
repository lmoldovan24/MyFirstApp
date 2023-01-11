namespace MyFirstApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Felicitari";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Bravo";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Ssxsxs";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Luci";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label2.Text = textBox1.Text; 
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            label2.Text = "";
        }
    }
}