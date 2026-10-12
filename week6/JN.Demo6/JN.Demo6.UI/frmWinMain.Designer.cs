namespace JN.Demo6.UI
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
            btnEnter = new Button();
            btnExit = new Button();
            txtScore = new TextBox();
            lblRes = new Label();
            SuspendLayout();
            // 
            // btnEnter
            // 
            btnEnter.Location = new Point(174, 103);
            btnEnter.Name = "btnEnter";
            btnEnter.Size = new Size(138, 25);
            btnEnter.TabIndex = 0;
            btnEnter.Text = "Convert Grade Letter";
            btnEnter.UseVisualStyleBackColor = true;
            btnEnter.Click += btnEnter_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(351, 121);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(83, 25);
            btnExit.TabIndex = 1;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // txtScore
            // 
            txtScore.Location = new Point(376, 66);
            txtScore.Name = "txtScore";
            txtScore.Size = new Size(110, 25);
            txtScore.TabIndex = 2;
            // 
            // lblRes
            // 
            lblRes.BackColor = SystemColors.InactiveBorder;
            lblRes.BorderStyle = BorderStyle.Fixed3D;
            lblRes.Location = new Point(229, 177);
            lblRes.Name = "lblRes";
            lblRes.Size = new Size(132, 60);
            lblRes.TabIndex = 3;
            lblRes.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmWinMain
            // 
            AcceptButton = btnEnter;
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new Size(800, 458);
            Controls.Add(lblRes);
            Controls.Add(txtScore);
            Controls.Add(btnExit);
            Controls.Add(btnEnter);
            Name = "frmWinMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEnter;
        private Button btnExit;
        private TextBox txtScore;
        private Label lblRes;
    }
}
