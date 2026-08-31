namespace JJN.Demo.UI
{
    public partial class frmWinMain : Form
    {
        // Intending to add more just comitting for now
        long epochMS = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();

        Random randValGen = new Random();
        public frmWinMain()
        {
            InitializeComponent();
        }
        // Set label text to a pet sound depending on
        // the button clicked.
        private void btnDog_Click(object sender, EventArgs e)
        {
            lblPetNoise.Text = "woof";
        }

        private void btnCat_Click(object sender, EventArgs e)
        {
            lblPetNoise.Text = "mewo";
        }

        private void btnPlant_Click(object sender, EventArgs e)
        {
            lblPetNoise.Text = "...";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblPetNoise.Text = "";
        }
    }
}
