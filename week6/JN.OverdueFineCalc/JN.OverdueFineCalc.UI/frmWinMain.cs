
using System.Media;
using System.Runtime.InteropServices;

namespace JN.OverdueFineCalc.UI
{
    public partial class frmWinMain : Form
    {
        // TODO: Replace top header with enhanced label (Add support to enhanced label for per-side borders)
        // TODO: Constant writable sound stream implementation (probably make in controls library actually)
        // FIXIT: LSS means "Legacy Sound System" means there's audio playback that'll need replacing (see line above)
        // FIXIT: Limit character length of output to max characters of output box.

        string defaultOutput = "0.00";


        public frmWinMain()
        {
            InitializeComponent();
            lblResult.Text = defaultOutput;
        }
        // Alias for double tryparse but it throws away the number ouput using "out _"
        private bool isValidDouble(string testString) => double.TryParse(testString, out _);

        // Formats int to be a string with a fixed point where 1 = 1 cent aka. 1=0.01
        // Yes I do know that if I used a decimal I could have just done tostring C2
        private string toMoneyString(int money, bool addPrefix = false, string moneyPrefix = "$")
        {
            /* If not adding a prefix then clear it, the prefix is used
             * to add the negative sign if the number is negative so
             * clearing it is needed. Also this variable assignment
             * style works as follows.
             * variable = checkCondition ? isTrue : isFalse;
             */
            moneyPrefix = addPrefix ? moneyPrefix : "";
            // If input is less than zero (a negative number) then
            // prepend a minus to the prefix and inverse the input
            if (money < 0)
            {
                moneyPrefix = $"-{moneyPrefix}";
                money = -money;
            }
            // Convert the input to a string
            string strResult = money.ToString();
            // Based on the length of the resulting string apply different formatting
            switch (strResult.Length)
            {
                case 1:
                    // If the length is one prefix with 0.0 (ex. # -> 0.0#)
                    strResult = $"0.0{strResult}";
                    break;
                case 2:
                    // If the length is two prefix with 0. (ex. ## -> 0.##)
                    strResult = $"0.{strResult}";
                    break;
                default:
                    // If string length doesn't match previous it is 3 or higher so
                    // Add a decimal point two from the end (ex. (...)### -> (...)#.##)
                    strResult = strResult.Insert(strResult.Length - 2, ".");
                    break;
            }
            // Return the resulting string with the prefix added
            return $"{moneyPrefix}{strResult}";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtItemNum.Text = "";
            txtDayNum.Text = "";
            lblResult.Text = defaultOutput;
            txtItemNum.Focus();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            // Create variables for inputs
            int itemNum;
            int dayNum;

            // Parse each input and check if either failed
            if (!int.TryParse(txtItemNum.Text, out itemNum) || !int.TryParse(txtDayNum.Text, out dayNum))
            {
                // Play Exclamation system sound
                SystemSounds.Exclamation.Play(); // FIXIT: LSS
                // If either input failed check if they both succeed as doubles. Using "&&" so that if one of the
                // inputs is wrong in a different way it will not trigger the decimal specific error message
                // If decimals are the issue show that specific error.
                if (isValidDouble(txtItemNum.Text) && isValidDouble(txtDayNum.Text))
                {
                    MessageBox.Show("An input contains decimals, only whole numbers are supported.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                // If all other cases fail show generic error.
                MessageBox.Show("Input invalid."); // TODO: Add more checks before falling back to generic error, TODO: highlight specific box/make error checking per-box.
                return;
            }

            /* Calculate the fine amount, decimal is usually used for currency
             * but I wanted to use an int as the decimal point never moves.
             * As such this is the total cost in cents.
             */
            int totalCents = dayNum * 5 * itemNum; // For each day add 5 cents then multiply by the amount of items.
            lblResult.Text = toMoneyString(totalCents);
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            // Play windows ding then prompt for confirmation
            SystemSounds.Beep.Play(); // FIXIT: LSS
            DialogResult confirmCopy = MessageBox.Show(
                "Copy to clipboard?", // Body
                "Confirm action", // Title
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question // I know the docs say don't use this icon it's "confusing for users." I'm using it anyway, it's not confusing.
            );
            // If anything besides Yes is pressed then cancel. This also should catch if the window is closed without
            // a response being selected. If Yes is pressed copy the text from the result label to the clipboard.
            if (confirmCopy != DialogResult.Yes) return;
            Clipboard.SetText(lblResult.Text);
        }
    }
}
