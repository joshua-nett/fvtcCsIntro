namespace JN.Increment.UI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWinMain));
            btnMethod1 = new Button();
            btnMethod2 = new Button();
            btnMethod3 = new Button();
            lblResult = new Label();
            SuspendLayout();
            // 
            // btnMethod1
            // 
            btnMethod1.BackColor = SystemColors.ButtonFace;
            btnMethod1.FlatStyle = FlatStyle.Flat;
            btnMethod1.Font = new Font("Segoe UI Semibold", 16.3018875F, FontStyle.Bold);
            btnMethod1.Location = new Point(12, 12);
            btnMethod1.Name = "btnMethod1";
            btnMethod1.Size = new Size(166, 80);
            btnMethod1.TabIndex = 1;
            btnMethod1.Text = "Method &1";
            btnMethod1.UseVisualStyleBackColor = false;
            btnMethod1.Click += btnMethod1_Click;
            // 
            // btnMethod2
            // 
            btnMethod2.BackColor = SystemColors.ButtonFace;
            btnMethod2.FlatStyle = FlatStyle.Flat;
            btnMethod2.Font = new Font("Segoe UI Semibold", 16.3018875F, FontStyle.Bold);
            btnMethod2.Location = new Point(12, 98);
            btnMethod2.Name = "btnMethod2";
            btnMethod2.Size = new Size(166, 80);
            btnMethod2.TabIndex = 2;
            btnMethod2.Text = "Method &2";
            btnMethod2.UseVisualStyleBackColor = false;
            btnMethod2.Click += btnMethod2_Click;
            // 
            // btnMethod3
            // 
            btnMethod3.BackColor = SystemColors.ButtonFace;
            btnMethod3.FlatStyle = FlatStyle.Flat;
            btnMethod3.Font = new Font("Segoe UI Semibold", 16.3018875F, FontStyle.Bold);
            btnMethod3.Location = new Point(12, 184);
            btnMethod3.Name = "btnMethod3";
            btnMethod3.Size = new Size(166, 80);
            btnMethod3.TabIndex = 3;
            btnMethod3.Text = "Method &3";
            btnMethod3.UseVisualStyleBackColor = false;
            btnMethod3.Click += btnMethod3_Click;
            // 
            // lblResult
            // 
            lblResult.BackColor = SystemColors.Info;
            lblResult.BorderStyle = BorderStyle.Fixed3D;
            lblResult.FlatStyle = FlatStyle.Flat;
            lblResult.Font = new Font("Segoe UI Semibold", 19.6981125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResult.ForeColor = SystemColors.InfoText;
            lblResult.Location = new Point(12, 270);
            lblResult.Margin = new Padding(3);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(166, 80);
            lblResult.TabIndex = 0;
            lblResult.Text = "0";
            lblResult.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmWinMain
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(190, 362);
            Controls.Add(lblResult);
            Controls.Add(btnMethod3);
            Controls.Add(btnMethod2);
            Controls.Add(btnMethod1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmWinMain";
            Padding = new Padding(9);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Increment Methods";
            ResumeLayout(false);
        }

        #endregion

        private Button btnMethod1;
        private Button btnMethod2;
        private Button btnMethod3;
        private Label lblResult;
    }
}
