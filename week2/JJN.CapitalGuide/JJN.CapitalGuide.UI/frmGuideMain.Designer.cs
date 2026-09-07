namespace JJN.CapitalGuide.UI
{
    partial class frmGuideMain
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
            lsxStates = new ListBox();
            lblOutput = new Label();
            btnExit = new Button();
            SuspendLayout();
            // 
            // lsxStates
            // 
            lsxStates.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lsxStates.FormattingEnabled = true;
            lsxStates.ItemHeight = 19;
            lsxStates.Location = new Point(11, 109);
            lsxStates.Name = "lsxStates";
            lsxStates.Size = new Size(150, 99);
            lsxStates.TabIndex = 1;
            lsxStates.SelectedIndexChanged += lsxStates_SelectedIndexChanged;
            // 
            // lblOutput
            // 
            lblOutput.BackColor = SystemColors.AppWorkspace;
            lblOutput.BorderStyle = BorderStyle.Fixed3D;
            lblOutput.Font = new Font("Archivo Narrow SemiBold", 22.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOutput.Location = new Point(194, 109);
            lblOutput.Name = "lblOutput";
            lblOutput.Size = new Size(464, 104);
            lblOutput.TabIndex = 0;
            lblOutput.Text = "Please choose a state.";
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Segoe UI Emoji", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.Location = new Point(548, 239);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(110, 85);
            btnExit.TabIndex = 2;
            btnExit.Text = "\U0001f6d1";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // frmGuideMain
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(681, 347);
            Controls.Add(btnExit);
            Controls.Add(lblOutput);
            Controls.Add(lsxStates);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "frmGuideMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Capital Guide";
            ResumeLayout(false);
        }

        #endregion

        private ListBox lsxStates;
        private Label lblOutput;
        private Button btnExit;
    }
}
