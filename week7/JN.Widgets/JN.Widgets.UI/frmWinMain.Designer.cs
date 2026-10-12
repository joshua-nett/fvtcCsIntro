namespace JN.Widgets.UI
{
    partial class frmWinMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            btnGenerate = new Button();
            lblRoll = new Label();
            lblResult = new Label();
            btnScaredy = new Button();
            tmrScaredyGame = new System.Windows.Forms.Timer(components);
            lblScaredyTimer = new Label();
            SuspendLayout();
            // 
            // btnGenerate
            // 
            btnGenerate.Location = new Point(38, 12);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(153, 65);
            btnGenerate.TabIndex = 0;
            btnGenerate.Text = "Generate";
            btnGenerate.UseVisualStyleBackColor = true;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // lblRoll
            // 
            lblRoll.BorderStyle = BorderStyle.FixedSingle;
            lblRoll.Location = new Point(27, 93);
            lblRoll.Name = "lblRoll";
            lblRoll.Size = new Size(164, 68);
            lblRoll.TabIndex = 1;
            lblRoll.Text = "0";
            lblRoll.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblResult
            // 
            lblResult.Location = new Point(23, 184);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(168, 101);
            lblResult.TabIndex = 2;
            lblResult.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnScaredy
            // 
            btnScaredy.BackColor = Color.Red;
            btnScaredy.FlatStyle = FlatStyle.Flat;
            btnScaredy.Font = new Font("Times New Roman", 12.2264156F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnScaredy.ForeColor = SystemColors.InactiveBorder;
            btnScaredy.Location = new Point(347, 49);
            btnScaredy.Name = "btnScaredy";
            btnScaredy.Size = new Size(147, 112);
            btnScaredy.TabIndex = 3;
            btnScaredy.Text = "Catch me, if you can! >:)";
            btnScaredy.UseVisualStyleBackColor = false;
            btnScaredy.Click += btnScaredy_Click;
            btnScaredy.MouseEnter += btnScaredy_MouseEnter;
            // 
            // tmrScaredyGame
            // 
            tmrScaredyGame.Enabled = true;
            tmrScaredyGame.Interval = 1000;
            tmrScaredyGame.Tick += tmrScaredyGame_Tick;
            // 
            // lblScaredyTimer
            // 
            lblScaredyTimer.BackColor = SystemColors.ControlLight;
            lblScaredyTimer.BorderStyle = BorderStyle.FixedSingle;
            lblScaredyTimer.Location = new Point(203, 342);
            lblScaredyTimer.Name = "lblScaredyTimer";
            lblScaredyTimer.Size = new Size(532, 68);
            lblScaredyTimer.TabIndex = 4;
            lblScaredyTimer.Text = "0";
            lblScaredyTimer.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmWinMain
            // 
            AutoScaleDimensions = new SizeF(17F, 33F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1166, 547);
            Controls.Add(btnScaredy);
            Controls.Add(lblScaredyTimer);
            Controls.Add(lblResult);
            Controls.Add(lblRoll);
            Controls.Add(btnGenerate);
            Font = new Font("Garamond", 19.6981125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(7, 6, 7, 6);
            Name = "frmWinMain";
            Text = "Widgets";
            ResumeLayout(false);
        }

        #endregion

        private Button btnGenerate;
        private Label lblRoll;
        private Label lblResult;
        private Button btnScaredy;
        private System.Windows.Forms.Timer tmrScaredyGame;
        private Label lblScaredyTimer;
    }
}
