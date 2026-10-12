namespace JN.TipCalc.UI
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
            lblInputBill = new Label();
            lblInputTip = new Label();
            lblTotal = new Label();
            lblTip = new Label();
            txtInputBill = new TextBox();
            txtInputTip = new TextBox();
            btnCalc = new Button();
            lblResTip = new Label();
            lblResTotal = new Label();
            btnClear = new Button();
            SuspendLayout();
            // 
            // lblInputBill
            // 
            lblInputBill.Font = new Font("Segoe UI", 18.3396225F);
            lblInputBill.Location = new Point(12, 12);
            lblInputBill.Margin = new Padding(3);
            lblInputBill.Name = "lblInputBill";
            lblInputBill.Size = new Size(160, 43);
            lblInputBill.TabIndex = 0;
            lblInputBill.Text = "Bill amount:";
            lblInputBill.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblInputTip
            // 
            lblInputTip.Font = new Font("Segoe UI", 18.3396225F);
            lblInputTip.Location = new Point(12, 61);
            lblInputTip.Margin = new Padding(3);
            lblInputTip.Name = "lblInputTip";
            lblInputTip.Size = new Size(160, 43);
            lblInputTip.TabIndex = 1;
            lblInputTip.Text = "Tip percent:";
            lblInputTip.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblTotal
            // 
            lblTotal.Font = new Font("Segoe UI", 18.3396225F);
            lblTotal.Location = new Point(12, 159);
            lblTotal.Margin = new Padding(3);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(160, 43);
            lblTotal.TabIndex = 2;
            lblTotal.Text = "Total:";
            lblTotal.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblTip
            // 
            lblTip.Font = new Font("Segoe UI", 18.3396225F);
            lblTip.Location = new Point(12, 110);
            lblTip.Margin = new Padding(3);
            lblTip.Name = "lblTip";
            lblTip.Size = new Size(160, 43);
            lblTip.TabIndex = 3;
            lblTip.Text = "Tip:";
            lblTip.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtInputBill
            // 
            txtInputBill.Font = new Font("Segoe UI", 18.3396225F);
            txtInputBill.Location = new Point(178, 12);
            txtInputBill.Name = "txtInputBill";
            txtInputBill.Size = new Size(160, 43);
            txtInputBill.TabIndex = 4;
            txtInputBill.TextAlign = HorizontalAlignment.Right;
            // 
            // txtInputTip
            // 
            txtInputTip.Font = new Font("Segoe UI", 18.3396225F);
            txtInputTip.Location = new Point(178, 61);
            txtInputTip.Name = "txtInputTip";
            txtInputTip.Size = new Size(160, 43);
            txtInputTip.TabIndex = 5;
            txtInputTip.TextAlign = HorizontalAlignment.Right;
            // 
            // btnCalc
            // 
            btnCalc.Font = new Font("Segoe UI", 18.3396225F);
            btnCalc.Location = new Point(12, 208);
            btnCalc.Name = "btnCalc";
            btnCalc.Size = new Size(160, 41);
            btnCalc.TabIndex = 6;
            btnCalc.Text = "Calculate";
            btnCalc.UseVisualStyleBackColor = true;
            btnCalc.Click += btnCalc_Click;
            // 
            // lblResTip
            // 
            lblResTip.BackColor = SystemColors.ControlLight;
            lblResTip.BorderStyle = BorderStyle.Fixed3D;
            lblResTip.Font = new Font("Segoe UI", 18.3396225F);
            lblResTip.Location = new Point(178, 110);
            lblResTip.Margin = new Padding(3);
            lblResTip.Name = "lblResTip";
            lblResTip.Size = new Size(160, 43);
            lblResTip.TabIndex = 8;
            lblResTip.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblResTotal
            // 
            lblResTotal.BackColor = SystemColors.ControlLight;
            lblResTotal.BorderStyle = BorderStyle.Fixed3D;
            lblResTotal.Font = new Font("Segoe UI", 18.3396225F);
            lblResTotal.Location = new Point(178, 159);
            lblResTotal.Margin = new Padding(3);
            lblResTotal.Name = "lblResTotal";
            lblResTotal.Size = new Size(160, 43);
            lblResTotal.TabIndex = 7;
            lblResTotal.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 18.3396225F);
            btnClear.Location = new Point(178, 208);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(160, 41);
            btnClear.TabIndex = 9;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // frmWinMain
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(348, 262);
            Controls.Add(btnClear);
            Controls.Add(lblResTip);
            Controls.Add(lblResTotal);
            Controls.Add(btnCalc);
            Controls.Add(txtInputTip);
            Controls.Add(txtInputBill);
            Controls.Add(lblTip);
            Controls.Add(lblTotal);
            Controls.Add(lblInputTip);
            Controls.Add(lblInputBill);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmWinMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tip Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblInputBill;
        private Label lblInputTip;
        private Label lblTotal;
        private Label lblTip;
        private TextBox txtInputBill;
        private TextBox txtInputTip;
        private Button btnCalc;
        private Label lblResTip;
        private Label lblResTotal;
        private Button btnClear;
    }
}
