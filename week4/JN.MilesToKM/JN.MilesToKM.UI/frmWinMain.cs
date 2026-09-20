namespace JN.MilesToKM.UI
{
    public partial class frmWinMain : Form
    {
        const double MILES_TO_KM = 1.61;

        public frmWinMain()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            // Variable for userinput
            double usrMilesIn;
            try
            {
                usrMilesIn = Double.Parse(tbxMiles.Text);
            }
            catch (Exception err)
            {
                lblResult.Text = "ERR!";
                MessageBox.Show($"Please provide a valid number.\n\n{err}");
                tbxMiles.Focus();
                tbxMiles.SelectAll();
                return;
            }
            lblResult.Text = $"{(usrMilesIn * MILES_TO_KM).ToString("N")}";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbxMiles.Text = "";
            lblResult.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
