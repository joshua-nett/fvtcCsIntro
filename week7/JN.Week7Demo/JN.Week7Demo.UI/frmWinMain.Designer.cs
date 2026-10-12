
namespace JN.Week7Demo.UI
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
            btnGo = new Button();
            SuspendLayout();
            // 
            // btnGo
            // 
            btnGo.Location = new Point(288, 155);
            btnGo.Name = "btnGo";
            btnGo.Size = new Size(83, 25);
            btnGo.TabIndex = 0;
            btnGo.Text = "GO";
            btnGo.UseVisualStyleBackColor = true;
            btnGo.Click += this.btnGo_Click;
            // 
            // frmWinMain
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnGo);
            Name = "frmWinMain";
            Text = "Week7 Demo";
            ResumeLayout(false);
        }

        #endregion

        private Button btnGo;
    }
}
