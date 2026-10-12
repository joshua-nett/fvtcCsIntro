namespace JN.DemoSize.UI
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
            txtNum = new TextBox();
            Generate = new Button();
            lblRes = new Label();
            lblDescAgeIn = new Label();
            lblDescAgeOut = new Label();
            SuspendLayout();
            // 
            // txtNum
            // 
            txtNum.Font = new Font("Segoe UI Semibold", 16.3018875F, FontStyle.Bold);
            txtNum.Location = new Point(100, 12);
            txtNum.Name = "txtNum";
            txtNum.Size = new Size(310, 39);
            txtNum.TabIndex = 0;
            // 
            // Generate
            // 
            Generate.Font = new Font("Segoe UI Semibold", 16.3018875F, FontStyle.Bold);
            Generate.Location = new Point(140, 104);
            Generate.Name = "Generate";
            Generate.Size = new Size(142, 39);
            Generate.TabIndex = 1;
            Generate.Text = "Generate";
            Generate.UseVisualStyleBackColor = true;
            Generate.Click += Generate_Click;
            // 
            // lblRes
            // 
            lblRes.BorderStyle = BorderStyle.Fixed3D;
            lblRes.Font = new Font("Segoe UI Semibold", 16.3018875F, FontStyle.Bold);
            lblRes.Location = new Point(100, 59);
            lblRes.Margin = new Padding(3);
            lblRes.Name = "lblRes";
            lblRes.Size = new Size(310, 39);
            lblRes.TabIndex = 2;
            lblRes.TextAlign = ContentAlignment.BottomLeft;
            // 
            // lblDescAgeIn
            // 
            lblDescAgeIn.BorderStyle = BorderStyle.Fixed3D;
            lblDescAgeIn.Font = new Font("Segoe UI Semibold", 14.2641506F, FontStyle.Bold);
            lblDescAgeIn.Location = new Point(12, 12);
            lblDescAgeIn.Margin = new Padding(3);
            lblDescAgeIn.Name = "lblDescAgeIn";
            lblDescAgeIn.Size = new Size(82, 39);
            lblDescAgeIn.TabIndex = 3;
            lblDescAgeIn.Text = "Age:";
            lblDescAgeIn.TextAlign = ContentAlignment.BottomRight;
            // 
            // lblDescAgeOut
            // 
            lblDescAgeOut.BorderStyle = BorderStyle.Fixed3D;
            lblDescAgeOut.Font = new Font("Segoe UI Semibold", 14.2641506F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDescAgeOut.Location = new Point(12, 59);
            lblDescAgeOut.Margin = new Padding(3);
            lblDescAgeOut.Name = "lblDescAgeOut";
            lblDescAgeOut.Size = new Size(82, 39);
            lblDescAgeOut.TabIndex = 4;
            lblDescAgeOut.Text = "Age*5";
            lblDescAgeOut.TextAlign = ContentAlignment.BottomRight;
            // 
            // frmWinMain
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(422, 155);
            Controls.Add(lblDescAgeOut);
            Controls.Add(lblDescAgeIn);
            Controls.Add(lblRes);
            Controls.Add(Generate);
            Controls.Add(txtNum);
            Name = "frmWinMain";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNum;
        private Button Generate;
        private Label lblRes;
        private Label lblDescAgeIn;
        private Label lblDescAgeOut;
    }
}
