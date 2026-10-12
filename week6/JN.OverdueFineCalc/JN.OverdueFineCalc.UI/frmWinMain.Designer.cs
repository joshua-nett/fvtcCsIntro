using JN.ControlsLibrary.Controls;

namespace JN.OverdueFineCalc.UI
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
            btnCalc = new Button();
            btnExit = new Button();
            btnClear = new Button();
            lblHeader = new Label();
            pnlFakeBorder = new Panel();
            lblExplanation = new Label();
            lblItemCaption = new Label();
            lblDayCaption = new Label();
            btnCopy = new Button();
            lblResultDeco = new EnhancedLabel();
            lblResult = new EnhancedLabel();
            lblCurrencySymbol = new EnhancedLabel();
            txtItemNum = new TextBox();
            txtDayNum = new TextBox();
            lblResultCaption = new Label();
            pnlFakeBorder.SuspendLayout();
            SuspendLayout();
            // 
            // btnCalc
            // 
            btnCalc.BackColor = Color.FromArgb(55, 53, 51);
            btnCalc.FlatAppearance.BorderSize = 0;
            btnCalc.FlatAppearance.MouseDownBackColor = Color.FromArgb(50, 48, 47);
            btnCalc.FlatAppearance.MouseOverBackColor = Color.FromArgb(65, 65, 65);
            btnCalc.FlatStyle = FlatStyle.Flat;
            btnCalc.Font = new Font("UbuntuSans NF Medium", 14.26415F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalc.ForeColor = Color.FromArgb(241, 192, 80);
            btnCalc.Location = new Point(12, 292);
            btnCalc.Name = "btnCalc";
            btnCalc.Padding = new Padding(4, 0, 0, 0);
            btnCalc.Size = new Size(157, 42);
            btnCalc.TabIndex = 3;
            btnCalc.Text = " &Calculate";
            btnCalc.TextAlign = ContentAlignment.MiddleLeft;
            btnCalc.UseCompatibleTextRendering = true;
            btnCalc.UseVisualStyleBackColor = false;
            btnCalc.Click += btnCalc_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.FromArgb(55, 53, 51);
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatAppearance.MouseDownBackColor = Color.FromArgb(50, 48, 47);
            btnExit.FlatAppearance.MouseOverBackColor = Color.FromArgb(65, 65, 65);
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("UbuntuSans NF Medium", 14.26415F, FontStyle.Bold);
            btnExit.ForeColor = Color.FromArgb(241, 192, 80);
            btnExit.Location = new Point(175, 340);
            btnExit.Name = "btnExit";
            btnExit.Padding = new Padding(4, 0, 0, 0);
            btnExit.Size = new Size(157, 42);
            btnExit.TabIndex = 6;
            btnExit.Text = "󰈆 E&xit";
            btnExit.TextAlign = ContentAlignment.MiddleLeft;
            btnExit.UseCompatibleTextRendering = true;
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(55, 53, 51);
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.FlatAppearance.MouseDownBackColor = Color.FromArgb(50, 48, 47);
            btnClear.FlatAppearance.MouseOverBackColor = Color.FromArgb(65, 65, 65);
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("UbuntuSans NF Medium", 14.26415F, FontStyle.Bold);
            btnClear.ForeColor = Color.FromArgb(241, 192, 80);
            btnClear.Location = new Point(12, 340);
            btnClear.Name = "btnClear";
            btnClear.Padding = new Padding(4, 0, 0, 0);
            btnClear.Size = new Size(157, 42);
            btnClear.TabIndex = 5;
            btnClear.Text = "󰇾 Clea&r";
            btnClear.TextAlign = ContentAlignment.MiddleLeft;
            btnClear.UseCompatibleTextRendering = true;
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // lblHeader
            // 
            lblHeader.BackColor = Color.FromArgb(72, 72, 72);
            lblHeader.Dock = DockStyle.Top;
            lblHeader.Font = new Font("UbuntuSans NF Medium", 14.26415F, FontStyle.Bold);
            lblHeader.ForeColor = Color.White;
            lblHeader.Location = new Point(0, 0);
            lblHeader.Margin = new Padding(3);
            lblHeader.Name = "lblHeader";
            lblHeader.Padding = new Padding(2, 0, 0, 6);
            lblHeader.Size = new Size(388, 40);
            lblHeader.TabIndex = 0;
            lblHeader.Text = " Library Fine Calculator";
            lblHeader.TextAlign = ContentAlignment.BottomLeft;
            // 
            // pnlFakeBorder
            // 
            pnlFakeBorder.BackColor = Color.FromArgb(32, 32, 32);
            pnlFakeBorder.BackgroundImageLayout = ImageLayout.None;
            pnlFakeBorder.Controls.Add(lblHeader);
            pnlFakeBorder.Dock = DockStyle.Top;
            pnlFakeBorder.Location = new Point(0, 0);
            pnlFakeBorder.Name = "pnlFakeBorder";
            pnlFakeBorder.Size = new Size(388, 42);
            pnlFakeBorder.TabIndex = 0;
            // 
            // lblExplanation
            // 
            lblExplanation.Font = new Font("UbuntuSans NF", 8.150944F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblExplanation.ForeColor = Color.FromArgb(144, 132, 118);
            lblExplanation.Location = new Point(3, 48);
            lblExplanation.Margin = new Padding(3);
            lblExplanation.Name = "lblExplanation";
            lblExplanation.Size = new Size(314, 17);
            lblExplanation.TabIndex = 0;
            lblExplanation.Text = " Overdue items are assessed at 5¢ per item per day";
            // 
            // lblItemCaption
            // 
            lblItemCaption.Location = new Point(12, 91);
            lblItemCaption.Name = "lblItemCaption";
            lblItemCaption.Size = new Size(125, 17);
            lblItemCaption.TabIndex = 0;
            lblItemCaption.Text = "Item count";
            // 
            // lblDayCaption
            // 
            lblDayCaption.Location = new Point(12, 155);
            lblDayCaption.Name = "lblDayCaption";
            lblDayCaption.Size = new Size(157, 19);
            lblDayCaption.TabIndex = 0;
            lblDayCaption.Text = "Days overdue";
            // 
            // btnCopy
            // 
            btnCopy.BackColor = Color.FromArgb(55, 53, 51);
            btnCopy.FlatAppearance.BorderSize = 0;
            btnCopy.FlatAppearance.MouseDownBackColor = Color.FromArgb(50, 48, 47);
            btnCopy.FlatAppearance.MouseOverBackColor = Color.FromArgb(65, 65, 65);
            btnCopy.FlatStyle = FlatStyle.Flat;
            btnCopy.Font = new Font("UbuntuSans NF Medium", 14.26415F, FontStyle.Bold);
            btnCopy.ForeColor = Color.FromArgb(241, 192, 80);
            btnCopy.Location = new Point(175, 292);
            btnCopy.Name = "btnCopy";
            btnCopy.Padding = new Padding(4, 0, 0, 0);
            btnCopy.Size = new Size(157, 42);
            btnCopy.TabIndex = 4;
            btnCopy.Text = "󰆏 Cop&y";
            btnCopy.TextAlign = ContentAlignment.MiddleLeft;
            btnCopy.UseCompatibleTextRendering = true;
            btnCopy.UseVisualStyleBackColor = false;
            btnCopy.Click += btnCopy_Click;
            // 
            // lblResultDeco
            // 
            lblResultDeco.BackColor = Color.FromArgb(23, 23, 23);
            lblResultDeco.Border3D.Colors.Bottom = Color.FromArgb(40, 40, 40);
            lblResultDeco.Border3D.Colors.InnerRim = Color.Black;
            lblResultDeco.Border3D.Colors.OuterRim = Color.FromArgb(62, 62, 62);
            lblResultDeco.Border3D.Colors.Top = Color.FromArgb(32, 32, 32);
            lblResultDeco.Border3D.Enabled = true;
            lblResultDeco.Border3D.RimRatio = 2;
            lblResultDeco.Border3D.Width = 3;
            lblResultDeco.Font = new Font("DSEG7 Modern", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResultDeco.ForeColor = Color.FromArgb(49, 48, 47);
            lblResultDeco.Location = new Point(12, 244);
            lblResultDeco.Margin = new Padding(3);
            lblResultDeco.Name = "lblResultDeco";
            lblResultDeco.Padding = new Padding(4, 0, 4, 0);
            lblResultDeco.Size = new Size(320, 42);
            lblResultDeco.TabIndex = 0;
            lblResultDeco.Text = "8888888888888.88";
            lblResultDeco.TextAlign = ContentAlignment.MiddleRight;
            lblResultDeco.TransparentBackground = false;
            // 
            // lblResult
            // 
            lblResult.BackColor = Color.Transparent;
            lblResult.Border3D.Colors.Bottom = Color.Gray;
            lblResult.Border3D.Colors.InnerRim = Color.Black;
            lblResult.Border3D.Colors.OuterRim = Color.Silver;
            lblResult.Border3D.Colors.Top = Color.DarkGray;
            lblResult.Border3D.Enabled = false;
            lblResult.Border3D.RimRatio = 2;
            lblResult.Border3D.Width = 2;
            lblResult.Font = new Font("DSEG7 Classic", 18.33962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResult.Location = new Point(12, 244);
            lblResult.Margin = new Padding(3);
            lblResult.Name = "lblResult";
            lblResult.Padding = new Padding(4, 0, 4, 0);
            lblResult.Size = new Size(320, 42);
            lblResult.TabIndex = 0;
            lblResult.Text = "0.00";
            lblResult.TextAlign = ContentAlignment.MiddleRight;
            lblResult.TransparentBackground = true;
            // 
            // lblCurrencySymbol
            // 
            lblCurrencySymbol.Border3D.Colors.Bottom = Color.FromArgb(40, 40, 40);
            lblCurrencySymbol.Border3D.Colors.InnerRim = Color.Black;
            lblCurrencySymbol.Border3D.Colors.OuterRim = Color.FromArgb(62, 62, 62);
            lblCurrencySymbol.Border3D.Colors.Top = Color.FromArgb(32, 32, 32);
            lblCurrencySymbol.Border3D.Enabled = false;
            lblCurrencySymbol.Border3D.RimRatio = 2;
            lblCurrencySymbol.Border3D.Width = 3;
            lblCurrencySymbol.Font = new Font("Stencil", 23.7735844F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCurrencySymbol.ForeColor = Color.FromArgb(144, 132, 118);
            lblCurrencySymbol.Location = new Point(335, 244);
            lblCurrencySymbol.Margin = new Padding(0);
            lblCurrencySymbol.Name = "lblCurrencySymbol";
            lblCurrencySymbol.Size = new Size(34, 42);
            lblCurrencySymbol.TabIndex = 0;
            lblCurrencySymbol.Text = "$";
            lblCurrencySymbol.TextAlign = ContentAlignment.MiddleLeft;
            lblCurrencySymbol.TransparentBackground = false;
            // 
            // txtItemNum
            // 
            txtItemNum.Location = new Point(12, 110);
            txtItemNum.Name = "txtItemNum";
            txtItemNum.Size = new Size(203, 23);
            txtItemNum.TabIndex = 1;
            txtItemNum.TextAlign = HorizontalAlignment.Right;
            // 
            // txtDayNum
            // 
            txtDayNum.Location = new Point(12, 177);
            txtDayNum.Name = "txtDayNum";
            txtDayNum.Size = new Size(209, 23);
            txtDayNum.TabIndex = 2;
            txtDayNum.TextAlign = HorizontalAlignment.Right;
            // 
            // lblResultCaption
            // 
            lblResultCaption.Location = new Point(12, 222);
            lblResultCaption.Name = "lblResultCaption";
            lblResultCaption.Size = new Size(157, 19);
            lblResultCaption.TabIndex = 0;
            lblResultCaption.Text = "Fine amount";
            // 
            // frmWinMain
            // 
            AcceptButton = btnCalc;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 40, 40);
            CancelButton = btnExit;
            ClientSize = new Size(388, 397);
            Controls.Add(pnlFakeBorder);
            Controls.Add(lblExplanation);
            Controls.Add(lblItemCaption);
            Controls.Add(txtItemNum);
            Controls.Add(lblDayCaption);
            Controls.Add(txtDayNum);
            Controls.Add(lblResultCaption);
            Controls.Add(lblResult);
            Controls.Add(lblResultDeco);
            Controls.Add(lblCurrencySymbol);
            Controls.Add(btnCalc);
            Controls.Add(btnCopy);
            Controls.Add(btnClear);
            Controls.Add(btnExit);
            DoubleBuffered = true;
            ForeColor = Color.FromArgb(234, 212, 175);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmWinMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Library Fine Calculator";
            pnlFakeBorder.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCalc;
        private Button btnExit;
        private Button btnClear;
        private Label lblHeader;
        private Panel pnlFakeBorder;
        private Label lblExplanation;
        private Label lblItemCaption;
        private Label lblDayCaption;
        private EnhancedLabel lblResultDeco;
        private Button btnCopy;
        private EnhancedLabel lblResult;
        private EnhancedLabel lblCurrencySymbol;
        private TextBox txtItemNum;
        private TextBox txtDayNum;
        private Label lblResultCaption;
    }
}
