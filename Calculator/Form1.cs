namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }


        int a;
        int b;

        private void btn_adunare_Click(object sender, EventArgs e)
        {
            a =  Convert.ToInt32(txtBox_a.Text);
            b =  Convert.ToInt32(txtBox_b.Text);

            lbl_rezultat.Text = Convert.ToString(a + b);
        }

        private void btn_scadere_Click(object sender, EventArgs e)
        {
            a = Convert.ToInt32(txtBox_a.Text);
            b = Convert.ToInt32(txtBox_b.Text);

            lbl_rezultat.Text = Convert.ToString(a - b);
        }

        private void btn_inmultire_Click(object sender, EventArgs e)
        {
            a = Convert.ToInt32(txtBox_a.Text);
            b = Convert.ToInt32(txtBox_b.Text);

            lbl_rezultat.Text = Convert.ToString(a * b);
        }

        private void btn_impartire_Click(object sender, EventArgs e)
        {
            a = Convert.ToInt32(txtBox_a.Text);
            b = Convert.ToInt32(txtBox_b.Text);

            lbl_rezultat.Text = Convert.ToString(a / b);
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            Convert.ToString(txtBox_a.Text = "");
            Convert.ToString(txtBox_b.Text = "");
            Convert.ToString(lbl_rezultat.Text = "");
        }
    }
}