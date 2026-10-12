namespace JN.DemoSize.UI
{
    public partial class frmWinMain : Form
    {
        private const double dblMult = 5;

        public frmWinMain()
        {
            InitializeComponent();
        }

        private void Generate_Click(object sender, EventArgs e)
        {
            double dblNumIn;
            if(double.TryParse(txtNum.Text, out dblNumIn))
            {
                lblRes.Text = $"{dblNumIn * dblMult}";
            }
            else
            {
                txtNum.Focus();
                txtNum.SelectAll();
                lblRes.Text = "Err";
                MessageBox.Show($"Please enter a valid numeric value");
            }
            //if (dblNumIn > 40)
            //{
            //    lblRes.Text = "Wow, you are old.";
            //}
            //else
            //{
            //    lblRes.Text = "Stay young, my friend.";
            //}

            //try
            //{
            //    numIn = double.Parse(txtNum.Text);
            //}
            //catch (Exception err)
            //{
            //    txtNum.Focus();
            //    txtNum.SelectAll();
            //    lblRes.Text = "Err";
            //    MessageBox.Show($"Please enter a valid numeric value\n\n{err}");
            //    return;
            //}
            //lblRes.Text = $"{numIn*dblMult}";
        }
    }
}
