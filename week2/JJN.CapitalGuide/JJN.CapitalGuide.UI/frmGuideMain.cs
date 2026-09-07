using System.Collections;

namespace JJN.CapitalGuide.UI
{

    public partial class frmGuideMain : Form
    {
        // Create a list of state capital key pairs
        Dictionary<String, String> stateCapitalPairs = new Dictionary<String, String>()
        {
            // ["choice"] = "display",
            ["Choose one"] = "", // Placeholder entry for listbox
            ["Wisconsin"] = "Madison",
            ["Michigan"] = "Lansing",
            ["Minnesota"] = "Saint Paul",
            ["Iowa"] = "Des Moines",
            ["Illinois"] = "Springfield"
        };

        public frmGuideMain()
        {
            InitializeComponent();
            // Loop through all states from the pair list
            // and add the statenames to the listbox in the UI
            foreach(String stateName in stateCapitalPairs.Keys)
            {
                lsxStates.Items.Add(stateName);
            }
            // Select the default (first) option in the list
            lsxStates.SetSelected(0, true);
        }

        // I didn't add a clear button since I added the "placeholder" selection.

        // When a (new) state is chosen
        private void lsxStates_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Based on the selected states name get the capital
            // Using the pair dict
            String capital = stateCapitalPairs[ lsxStates.Text ];
            // If the capital is an empty string it's the
            // placeholder/default option
            if(capital == "") {
                // Change the output label text
                lblOutput.Text = "Please choose a state.";
            }
            else
            {
                // If it's not the placeholder create the formatted
                // string and display to the output label
                lblOutput.Text = $"The Capital of {lsxStates.Text} is {capital}.";
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            // Close the application on exit button click
            Application.Exit();
        }
    }
}
