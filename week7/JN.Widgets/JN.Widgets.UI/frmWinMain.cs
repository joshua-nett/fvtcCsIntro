namespace JN.Widgets.UI
{
    public partial class frmWinMain : Form
    {
        int gameCountdown = 100;
        int scaredyMoveCount = 0;
        bool scaredyCaught = false;
        public frmWinMain()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            int rngResult = Random.Shared.Next(1, 11);
            if (rngResult >= 8)
            {
                lblResult.Text = "You Win!!";
                lblResult.ForeColor = Color.Green;
            }
            else
            {
                lblResult.Text = "Try Again!";
                lblResult.ForeColor = Color.Red;
            }
            lblRoll.Text = $"{rngResult}";
        }

        private void btnScaredy_Click(object sender, EventArgs e)
        {
            scaredyCaught = true;
            /*int xMoveMax = 1 + (Size.Width - btnScaredy.Width);
            int yMoveMax = 1 + (Size.Height - btnScaredy.Height);
            btnScaredy.Left = Random.Shared.Next(xMoveMax);
            btnScaredy.Top = Random.Shared.Next(yMoveMax);*/
            BackColor = Color.GreenYellow;
            btnScaredy.Text = "WHAT!?!?! HOW DID YOU CATCH ME!!!";
        }

        private void tmrScaredyGame_Tick(object sender, EventArgs e)
        {
            /*gameCountdown--;
            lblScaredyTimer.Text = $"{gameCountdown}";*/
            DateTime timeNow = DateTime.Now;
            int yearOfCringle = timeNow.Year;
            if (timeNow.Month == 12 && timeNow.Day >= 25)
            {
                yearOfCringle++;
            }
            DateTime timeOfCringle = new DateTime(yearOfCringle, 12, 25);
            TimeSpan timeUntilCringle = timeOfCringle - timeNow;
            lblScaredyTimer.Text = $"{timeUntilCringle}";

            if (gameCountdown == 0)
            {
                tmrScaredyGame.Stop();
            }
        }

        private void btnScaredy_MouseEnter(object sender, EventArgs e)
        {
            if (scaredyCaught) return;
            int xMoveMax = ClientSize.Width - btnScaredy.Width;
            int yMoveMax = ClientSize.Height - btnScaredy.Height;
            btnScaredy.Left = Random.Shared.Next(xMoveMax+1);
            btnScaredy.Top = Random.Shared.Next(yMoveMax+1);

            scaredyMoveCount++;

            switch (scaredyMoveCount)
            {
                case > 10:
                    btnScaredy.Text = "Wow, you really suck huh? \n~\\_/( - _ -)\\_/~";
                    break;
                case > 6:
                    btnScaredy.Text = "I am SO good at this. 8)";
                    break;
                case > 3:
                    btnScaredy.Text = "Woah, you almost got me there! >:O";
                    break;
                default:
                    btnScaredy.Text = "Catch me, if you can! >:)";
                    break;
            }

        }
    }
}
