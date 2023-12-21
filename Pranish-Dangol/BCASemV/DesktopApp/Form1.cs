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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            int label3Value = int.Parse(txtX.Text) + int.Parse(txtY.Text)";
            lblResult.Text = label3Value.ToString(); ;

        }
    }
}
