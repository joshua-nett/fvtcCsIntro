namespace JN.MovieAdmission.UI
{
    public partial class frmWinMain : Form
    {
        public int minimumAge = 17;

        public frmWinMain()
        {
            InitializeComponent();
        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            int age;
            bool hasGuardian = chkParent.Checked;
            bool hasTicket = chkTicket.Checked;
            bool isBanned = chkBanned.Checked;

            if(!int.TryParse(txtAge.Text, out age))
            {
                txtAge.Focus();
                txtAge.SelectAll();
                lblResult.Text = "ERROR!";
                MessageBox.Show("Error! Invalid Age.\nPlease provide a valid whole number!");
                return;
            }

            if (!isBanned && hasTicket && (age >= minimumAge || hasGuardian))
            {
                lblResult.Text = "Approved!";
                return;
            }
            else
            {
                lblResult.Text = "Denied!";
            }
            if (isBanned)
            {
                lblResult.Text += "\nCustomer is banned!";
            }
            if (!hasTicket)
            {
                lblResult.Text += "\nNo ticket!";
            }
            if (age < minimumAge && !hasGuardian)
            {
                lblResult.Text += $"\nEither minimum age {minimumAge} or a Guardian are required.";
            }
            if(lblResult.Text == "Denied!")
            {
                lblResult.Text += "\nNo reason found please report this";
            }
        }
    }
}
