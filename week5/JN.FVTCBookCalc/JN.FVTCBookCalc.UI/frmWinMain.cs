namespace JN.FVTCBookCalc.UI
{
    public partial class frmWinMain : Form
    {
        private const decimal discountMult = 0.25M;
        public frmWinMain()
        {
            InitializeComponent();
        }
        
        private void btnCalc_Click(object sender, EventArgs e)
        {
            decimal discount;
            // Try to parse input if not error
            if (decimal.TryParse(txtSalesIn.Text, out decimal salesIn))
            {
                // Calculate the discount amount and display it and display input minus discount then focus input
                discount = discountMult * salesIn;
                lblDiscountOut.Text = $"{discount:C}";
                lblFinalOut.Text = $"{(salesIn-discount):C}";
                txtSalesIn.Focus();
            }
            else
            {
                // Select all text in input and focus it, display error in outputs and message box
                txtSalesIn.Focus();
                txtSalesIn.SelectAll();
                lblDiscountOut.Text = "Error";
                lblFinalOut.Text = "Error";
                MessageBox.Show("Please enter a valid money amount");
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clear outputs on clear pressed and focus input
            lblDiscountOut.Text = "";
            lblFinalOut.Text = "";
            txtSalesIn.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Close app on exit pressed
            Close();
        }

        private void txtSalesIn_TextChanged(object sender, EventArgs e)
        {
            // Clear outputs when textbox changed
            lblDiscountOut.Text = "";
            lblFinalOut.Text = "";
        }
    }
}
