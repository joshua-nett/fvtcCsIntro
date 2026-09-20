namespace JN.MilesToKM.UI
{
    public partial class frmWinMain : Form
    {
        // Define miles to kilometers conversion rate
        const double M2KM_RATE= 1.61;

        public frmWinMain()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            // Variable for userinput
            double usrMilesIn;
            // Attempt to parse user input as double
            try
            {
                usrMilesIn = Double.Parse(tbxMiles.Text);
            }
            catch (Exception err)
            {
                // If unable to parse input show messagebox with error
                lblResult.Text = "ERR!";
                MessageBox.Show($"Please provide a valid number.\n\n{err}");
                tbxMiles.Focus();
                tbxMiles.SelectAll();
                return;
            }
            /* If parse successful multiply input by conversion rate, use N
             * to limit to 2 decimal places (using interpolation but left
             * other way commented so you can see I know how using ToString */
            lblResult.Text = $"{(usrMilesIn * M2KM_RATE):N}"; //$"{(usrMilesIn * M2KM_RATE).ToString("N")}";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clear the input and output on clear button click
            tbxMiles.Text = "";
            lblResult.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Close program on exit button click
            Close();
        }
    }
}
