using System.Windows.Forms.VisualStyles;

namespace JJN.FvtcNameSwitcher.UI
{
    public partial class frmWinMain : Form
    {
        /*
         * I use variables for a lot of values instead of only having them
         * inline in the Design this makes the code more reusable and expandable
         * for example if you wanted to create translations/a locale
         * this makes it easier
         */

        // Tracks the current state making dynamic strings easier
        UInt16 intState = 0;
        
        // The base string to add the suffix to on the button
        string strBaseBtn = "Switch to ";
        string strTitleSuffix = " Name Changer";
        /*
         * Switch arrays are specified as
         * "suffix", "output", "bg hex (optional)", "fg hex (optional)"
         * The 1st switch array (strSwitchArray[0]) is the default and
         * should usually be clear
         * The window title will also be changed to the suffix
        */
        string[][] strSwitchArray = [[
            "Clear",
            "",
            "f0f0f0"
        ],[
            "FVTC",
            "Fox Valley Technical College",
            "800d22"
        ],
            [
            "C#",
            "C# is Fun!",
            "8080ff"
        ]];
        /*
         * Get the next valid state reseting
         * to the start when the state would
         * surpass the array length
         * I know I don't check for overflows
         * And I don't care
        */
        private UInt16 intNextState() {
            if (intState+1 >= strSwitchArray.Length) {
                return 0;
            }
            return (UInt16)(intState + 1);
        }
        // Updates the ui based on the state
        private void updState()
        {
            // Update button text to the base text plus the states text
            btnSwitchLbl.Text = $"{strBaseBtn}{strSwitchArray[intNextState()][0]}";
            // Update the text of the title to be the states text with the suffix text
            Text = $"{strSwitchArray[intState][0]}{strTitleSuffix}";
            // Shows the user this states response
            lblResponse.Text = strSwitchArray[intState][1];
            // Set the background color to the states hexcode
            BackColor = ColorTranslator.FromHtml($"#{strSwitchArray[intState][2]}");
        }
        public frmWinMain()
        {
            InitializeComponent();
            // Ensure window is in correct state
            updState();
        }
        // Sets state to the following one and updates the ui
        private void btnSwitchLbl_Click(object sender, EventArgs e)
        {
            intState = intNextState();
            updState();
        }
        // Set state to "0" which is the default (meant to be clear)
        // then updates the ui
        private void btnClearLbl_Click(object sender, EventArgs e)
        {
            intState = 0;
            updState();
        }
        // Exit app when button is pressed
        private void btnExitApp_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
