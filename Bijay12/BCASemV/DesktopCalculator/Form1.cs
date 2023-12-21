namespace DesktopCalculator
{
    public partial class Form1 : Form
    {
        private object int32;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*(label3.Text) =int.TryParse(String txt1.Text)  +int.TryParse( String txt2.Text);*/
            /* int (label3.Text) = int.Parse( txt1.Text) + int.Parse( txt2.Text);
              label3.Text = label3Value.ToString();*/
            int label3Value = int.Parse(txt1.Text) + int.Parse(txt2.Text);
            label3.Text = label3Value.ToString();
        }

        private void txt1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
