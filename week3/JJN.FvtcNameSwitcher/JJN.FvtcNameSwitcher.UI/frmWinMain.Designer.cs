namespace JJN.FvtcNameSwitcher.UI
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
            btnSwitchLbl = new Button();
            btnExitApp = new Button();
            lblHeading = new Label();
            btnClearLbl = new Button();
            lblResponse = new Label();
            SuspendLayout();
            // 
            // btnSwitchLbl
            // 
            btnSwitchLbl.Font = new Font("Segoe UI", 12.2264156F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSwitchLbl.ForeColor = SystemColors.ControlText;
            btnSwitchLbl.Location = new Point(10, 164);
            btnSwitchLbl.Name = "btnSwitchLbl";
            btnSwitchLbl.Size = new Size(181, 56);
            btnSwitchLbl.TabIndex = 2;
            btnSwitchLbl.Text = "Switch to FVTC";
            btnSwitchLbl.UseVisualStyleBackColor = true;
            btnSwitchLbl.Click += btnSwitchLbl_Click;
            // 
            // btnExitApp
            // 
            btnExitApp.Font = new Font("Segoe UI", 12.2264156F, FontStyle.Bold);
            btnExitApp.Location = new Point(299, 164);
            btnExitApp.Name = "btnExitApp";
            btnExitApp.Size = new Size(122, 56);
            btnExitApp.TabIndex = 3;
            btnExitApp.Text = "Exit";
            btnExitApp.UseVisualStyleBackColor = true;
            btnExitApp.Click += btnExitApp_Click;
            // 
            // lblHeading
            // 
            lblHeading.BackColor = Color.FromArgb(166, 166, 255);
            lblHeading.Dock = DockStyle.Top;
            lblHeading.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHeading.Location = new Point(0, 0);
            lblHeading.Name = "lblHeading";
            lblHeading.Size = new Size(433, 78);
            lblHeading.TabIndex = 0;
            lblHeading.Text = "Name Switcher!";
            // 
            // btnClearLbl
            // 
            btnClearLbl.BackColor = Color.RosyBrown;
            btnClearLbl.Font = new Font("Segoe UI", 12.2264156F, FontStyle.Bold);
            btnClearLbl.ForeColor = SystemColors.ControlText;
            btnClearLbl.Location = new Point(369, 91);
            btnClearLbl.Name = "btnClearLbl";
            btnClearLbl.Size = new Size(53, 57);
            btnClearLbl.TabIndex = 1;
            btnClearLbl.Text = "X";
            btnClearLbl.UseVisualStyleBackColor = false;
            btnClearLbl.Click += btnClearLbl_Click;
            // 
            // lblResponse
            // 
            lblResponse.BackColor = Color.FromArgb(213, 228, 242);
            lblResponse.BorderStyle = BorderStyle.Fixed3D;
            lblResponse.Font = new Font("Segoe UI", 14.2641506F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResponse.Location = new Point(10, 91);
            lblResponse.Name = "lblResponse";
            lblResponse.Padding = new Padding(7, 0, 0, 0);
            lblResponse.Size = new Size(381, 57);
            lblResponse.TabIndex = 0;
            lblResponse.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // frmWinMain
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(433, 231);
            Controls.Add(lblHeading);
            Controls.Add(btnClearLbl);
            Controls.Add(lblResponse);
            Controls.Add(btnExitApp);
            Controls.Add(btnSwitchLbl);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "frmWinMain";
            Text = " ";
            ResumeLayout(false);
        }

        #endregion

        private Button btnSwitchLbl;
        private Button btnExitApp;
        private Label lblHeading;
        private Button btnClearLbl;
        private Label lblResponse;
    }
}
