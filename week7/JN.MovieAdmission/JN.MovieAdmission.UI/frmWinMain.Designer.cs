namespace JN.MovieAdmission.UI
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
            lblHeader = new Label();
            lblAge = new Label();
            txtAge = new TextBox();
            chkParent = new CheckBox();
            chkTicket = new CheckBox();
            chkBanned = new CheckBox();
            btnVerify = new Button();
            lblResult = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblHeader
            // 
            lblHeader.BackColor = Color.DarkRed;
            lblHeader.Dock = DockStyle.Top;
            lblHeader.Font = new Font("Elephant", 35.9999962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHeader.ForeColor = Color.Beige;
            lblHeader.Location = new Point(0, 0);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(800, 77);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "Movie Theater Admission";
            lblHeader.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblAge
            // 
            lblAge.Font = new Font("Stardos Stencil", 12.2264156F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAge.Location = new Point(51, 231);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(59, 34);
            lblAge.TabIndex = 1;
            lblAge.Text = "Age";
            lblAge.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtAge
            // 
            txtAge.BackColor = Color.Navy;
            txtAge.BorderStyle = BorderStyle.FixedSingle;
            txtAge.Font = new Font("MS UI Gothic", 18.3396225F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtAge.ForeColor = Color.Yellow;
            txtAge.Location = new Point(116, 231);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(113, 34);
            txtAge.TabIndex = 2;
            // 
            // chkParent
            // 
            chkParent.Font = new Font("Stardos Stencil", 12.2264156F, FontStyle.Bold);
            chkParent.Location = new Point(51, 99);
            chkParent.Name = "chkParent";
            chkParent.Size = new Size(178, 38);
            chkParent.TabIndex = 3;
            chkParent.Text = "Guardian present";
            chkParent.UseVisualStyleBackColor = true;
            // 
            // chkTicket
            // 
            chkTicket.Font = new Font("Stardos Stencil", 12.2264156F, FontStyle.Bold);
            chkTicket.Location = new Point(51, 143);
            chkTicket.Name = "chkTicket";
            chkTicket.Size = new Size(178, 38);
            chkTicket.TabIndex = 4;
            chkTicket.Text = "Has ticket";
            chkTicket.UseVisualStyleBackColor = true;
            // 
            // chkBanned
            // 
            chkBanned.Font = new Font("Stardos Stencil", 12.2264156F, FontStyle.Bold);
            chkBanned.Location = new Point(51, 187);
            chkBanned.Name = "chkBanned";
            chkBanned.Size = new Size(178, 38);
            chkBanned.TabIndex = 5;
            chkBanned.Text = "Is banned";
            chkBanned.UseVisualStyleBackColor = true;
            // 
            // btnVerify
            // 
            btnVerify.BackColor = Color.Navy;
            btnVerify.FlatStyle = FlatStyle.Flat;
            btnVerify.Font = new Font("Stardos Stencil", 12.2264156F, FontStyle.Bold);
            btnVerify.Location = new Point(51, 271);
            btnVerify.Name = "btnVerify";
            btnVerify.Size = new Size(382, 170);
            btnVerify.TabIndex = 6;
            btnVerify.Text = "Verify";
            btnVerify.UseVisualStyleBackColor = false;
            btnVerify.Click += btnVerify_Click;
            // 
            // lblResult
            // 
            lblResult.BorderStyle = BorderStyle.Fixed3D;
            lblResult.Font = new Font("MS UI Gothic", 12.2264156F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResult.Location = new Point(439, 99);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(349, 342);
            lblResult.TabIndex = 7;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(283, 134);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(110, 55);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // frmWinMain
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(lblResult);
            Controls.Add(btnVerify);
            Controls.Add(chkBanned);
            Controls.Add(chkTicket);
            Controls.Add(chkParent);
            Controls.Add(txtAge);
            Controls.Add(lblAge);
            Controls.Add(lblHeader);
            ForeColor = Color.Yellow;
            Name = "frmWinMain";
            Text = "Movie Admission Software ™️";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHeader;
        private Label lblAge;
        private TextBox txtAge;
        private CheckBox chkParent;
        private CheckBox chkTicket;
        private CheckBox chkBanned;
        private Button btnVerify;
        private Label lblResult;
        private PictureBox pictureBox1;
    }
}
