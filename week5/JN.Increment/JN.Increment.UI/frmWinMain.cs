namespace JN.Increment.UI
{
    public partial class frmWinMain : Form
    {
        public frmWinMain()
        {
            InitializeComponent();
        }

        private int counter = 0;

        private void btnMethod1_Click(object sender, EventArgs e)
        {
            counter = counter + 1;
            lblResult.Text = $"{counter}";
        }

        private void btnMethod2_Click(object sender, EventArgs e)
        {
            counter += 1;
            lblResult.Text = $"{counter}";
        }

        private void btnMethod3_Click(object sender, EventArgs e)
        {
            counter++;
            lblResult.Text = $"{counter}";
        }
    }
}
