namespace JN.TipCalc.UI
{
    public partial class frmWinMain : Form
    {
        public frmWinMain()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            double bill, tipPercent, tipResult;
            try
            {
                bill = double.Parse(txtInputBill.Text);
                tipPercent = double.Parse(txtInputTip.Text);
            }
            catch (Exception err)
            {
                MessageBox.Show($"Error, Please enter valid numeric values.\n\n{err}");
                return;
            }
            tipResult = bill * (tipPercent / 100.0);
            lblResTip.Text = $"{tipResult:C}";
            lblResTotal.Text = $"{(tipResult + bill):C}";

            // total tipResult+bill


        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblResTip.Text = "";
            lblResTotal.Text = "";
        }
    }
}
