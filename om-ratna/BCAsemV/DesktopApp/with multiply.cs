namespace DesktopApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var ans = int.Parse(textX.Text) + int.Parse(textY.Text);
            Result.Text = ans.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var ans =int.Parse(textY.Text) * int.Parse(textX.Text);
            Result.Text = ans.ToString();
        }
    }
}
