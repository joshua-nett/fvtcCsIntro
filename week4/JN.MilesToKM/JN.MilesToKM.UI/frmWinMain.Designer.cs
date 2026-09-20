namespace JN.MilesToKM.UI
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
            tbxMiles = new TextBox();
            lblMiles = new Label();
            lblKilometers = new Label();
            lblResult = new Label();
            btnConvert = new Button();
            lblHeading = new Label();
            btnExit = new Button();
            btnClear = new Button();
            SuspendLayout();
            // 
            // tbxMiles
            // 
            tbxMiles.BackColor = SystemColors.Control;
            tbxMiles.Font = new Font("Archivo Narrow", 12.2264137F, FontStyle.Bold);
            tbxMiles.ForeColor = SystemColors.ControlText;
            tbxMiles.Location = new Point(12, 66);
            tbxMiles.MinimumSize = new Size(0, 36);
            tbxMiles.Name = "tbxMiles";
            tbxMiles.Size = new Size(192, 36);
            tbxMiles.TabIndex = 1;
            tbxMiles.TextAlign = HorizontalAlignment.Right;
            // 
            // lblMiles
            // 
            lblMiles.BackColor = Color.Transparent;
            lblMiles.Font = new Font("Archivo Narrow", 12.2264137F, FontStyle.Bold);
            lblMiles.ForeColor = Color.Black;
            lblMiles.Location = new Point(210, 62);
            lblMiles.Margin = new Padding(3);
            lblMiles.Name = "lblMiles";
            lblMiles.Size = new Size(98, 36);
            lblMiles.TabIndex = 0;
            lblMiles.Text = "Mile(s)";
            lblMiles.TextAlign = ContentAlignment.BottomLeft;
            // 
            // lblKilometers
            // 
            lblKilometers.BackColor = Color.Transparent;
            lblKilometers.Font = new Font("Archivo Narrow", 12.2264137F, FontStyle.Bold);
            lblKilometers.ForeColor = Color.Black;
            lblKilometers.Location = new Point(210, 104);
            lblKilometers.Margin = new Padding(3);
            lblKilometers.Name = "lblKilometers";
            lblKilometers.Size = new Size(98, 36);
            lblKilometers.TabIndex = 0;
            lblKilometers.Text = "Kilometer(s)";
            lblKilometers.TextAlign = ContentAlignment.BottomLeft;
            // 
            // lblResult
            // 
            lblResult.BackColor = SystemColors.ControlDark;
            lblResult.BorderStyle = BorderStyle.Fixed3D;
            lblResult.FlatStyle = FlatStyle.Flat;
            lblResult.Font = new Font("Archivo Narrow", 12.2264137F, FontStyle.Bold);
            lblResult.ForeColor = SystemColors.ControlText;
            lblResult.Location = new Point(12, 104);
            lblResult.Margin = new Padding(3);
            lblResult.Name = "lblResult";
            lblResult.Padding = new Padding(0, 0, 3, 0);
            lblResult.Size = new Size(192, 36);
            lblResult.TabIndex = 0;
            lblResult.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnConvert
            // 
            btnConvert.BackColor = Color.SteelBlue;
            btnConvert.FlatStyle = FlatStyle.Flat;
            btnConvert.Font = new Font("Segoe UI Semibold", 10.18868F, FontStyle.Bold);
            btnConvert.ForeColor = Color.Black;
            btnConvert.Location = new Point(12, 146);
            btnConvert.Name = "btnConvert";
            btnConvert.Size = new Size(145, 36);
            btnConvert.TabIndex = 2;
            btnConvert.Text = "&Convert";
            btnConvert.UseVisualStyleBackColor = false;
            btnConvert.Click += btnConvert_Click;
            // 
            // lblHeading
            // 
            lblHeading.BackColor = Color.Transparent;
            lblHeading.Font = new Font("Saira SemiCondensed SemiBold", 19.6981125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHeading.ForeColor = Color.Black;
            lblHeading.Location = new Point(12, 12);
            lblHeading.Margin = new Padding(3);
            lblHeading.Name = "lblHeading";
            lblHeading.Size = new Size(296, 44);
            lblHeading.TabIndex = 0;
            lblHeading.Text = "M2KM Converter";
            lblHeading.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.SteelBlue;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Segoe UI Semibold", 10.18868F, FontStyle.Bold);
            btnExit.ForeColor = Color.Black;
            btnExit.Location = new Point(12, 188);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(296, 36);
            btnExit.TabIndex = 4;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.SteelBlue;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI Semibold", 10.18868F, FontStyle.Bold);
            btnClear.ForeColor = Color.Black;
            btnClear.Location = new Point(163, 146);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(145, 36);
            btnClear.TabIndex = 3;
            btnClear.Text = "Clea&r";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // frmWinMain
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSlateGray;
            ClientSize = new Size(320, 234);
            Controls.Add(lblHeading);
            Controls.Add(tbxMiles);
            Controls.Add(lblMiles);
            Controls.Add(lblResult);
            Controls.Add(lblKilometers);
            Controls.Add(btnConvert);
            Controls.Add(btnClear);
            Controls.Add(btnExit);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            HelpButton = true;
            MaximizeBox = false;
            Name = "frmWinMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "M2KM Converter";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbxMiles;
        private Label lblMiles;
        private Label lblKilometers;
        private Label lblResult;
        private Button btnConvert;
        private Label lblHeading;
        private Button btnExit;
        private Button btnClear;
    }
}
