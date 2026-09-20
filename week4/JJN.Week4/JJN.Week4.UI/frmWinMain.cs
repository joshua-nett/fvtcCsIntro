namespace JJN.Week4.UI
{
    public partial class frmWinMain : Form
    {
        public frmWinMain()
        {
            InitializeComponent();
        }

        int intIncrCount = 0;

        private void btnCalc_Click(object sender, EventArgs e)
        {
            int intUsrNum0;
            int intUsrNum1;
            try
            {
                intUsrNum0 = int.Parse(txb1st.Text);
                intUsrNum1 = int.Parse(txb2nd.Text);
            }
            catch (Exception err)
            {
                lblResult.Text = "ERR";
                MessageBox.Show($"Please only input integers.\n\n{err}");
                return;
            }

            lblResult.Text = $"{intUsrNum0 + intUsrNum1}";
        }

        private void btnIncr_Click(object sender, EventArgs e)
        {
            lblIncrCount.Text = $"Count: {intIncrCount++}";
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            lblIncrCount.Text = $"Count: {intIncrCount = 0}";
        }

        private void btnCostCalc_Click(object sender, EventArgs e)
        {
            int intQty;
            try
            {
                intQty = int.Parse(txbQty.Text);
            }
            catch (Exception err)
            {
                lblTotalCost.Text = "ERR";
                MessageBox.Show($"Please only input integers.\n\n{err}");
                return;
            }
            lblTotalCost.Text = $"Total: {intQty*5}";
        }
    }
}
