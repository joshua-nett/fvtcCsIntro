namespace JN.Demo6.UI
{
    public partial class frmWinMain : Form
    {
        public frmWinMain()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Closes the app
            Close();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            // Define variables
            string errorMessage = "";
            int score;

            if (!int.TryParse(txtScore.Text, out score))
            {
                // If the input fails to parse set error message
                errorMessage = "Enter a valid number (1 through 100)";
                if (double.TryParse(txtScore.Text, out _))
                {
                    // If the input succeeds as a double set more specific error message
                    errorMessage = "Only whole numbers are supported.";
                }
            }else if (score > 100 || score < 1)
            {
                // If input parsed but is out of range set error message
                errorMessage = "Number must be 1-100";
            }
            if(!string.IsNullOrEmpty(errorMessage))
            {
                // If the error message is not empty show the message, highlight the text, set response to error
                txtScore.Focus();
                txtScore.SelectAll();
                lblRes.Text = "Error";
                MessageBox.Show(errorMessage);
                // Return so it doesn't proceed to processing logic
                return;
            }
            // Switch result based on conditions relative to an input
            switch (score)
            {
                // Example of a case is, this case can be replaced with if(score>=90)
                case >= 90:
                    lblRes.Text = "A";
                    // "break" exits the switch if you do not have a break it will continue executing rest of the switch
                    // Basically adding the "else" otherwise it's like a "if if" sorta thing
                    break;
                case >= 80:
                    lblRes.Text = "B";
                    break;
                case >= 70:
                    lblRes.Text = "C";
                    break;
                case >= 60:
                    lblRes.Text = "D";
                    break;
                default:
                    // Default adds a fallback for if all other cases fail
                    lblRes.Text = "F";
                    break;
            }

        }
    }
}
