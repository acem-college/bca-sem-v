namespace DesktopApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void add_Click(object sender, EventArgs e)
        {
            var ans = int.Parse(txtX.Text) + int.Parse(txtY.Text);
            Result.Text = ans.ToString();

        }

        private void multi_Click(object sender, EventArgs e)
        {
            Result.Text = $"{int.Parse(txtY.Text) * int.Parse(txtX.Text)}";

        }
    }
}
