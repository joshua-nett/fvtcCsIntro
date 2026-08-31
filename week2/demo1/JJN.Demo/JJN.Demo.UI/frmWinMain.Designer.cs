namespace JJN.Demo.UI
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
            btnCat = new Button();
            gupPet = new GroupBox();
            btnClear = new Button();
            btnDog = new Button();
            btnPlant = new Button();
            lblPetNoise = new Label();
            pnlBtnDivider = new Panel();
            gupPet.SuspendLayout();
            SuspendLayout();
            // 
            // btnCat
            // 
            btnCat.Font = new Font("MS Mincho", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCat.Location = new Point(6, 102);
            btnCat.Name = "btnCat";
            btnCat.Size = new Size(220, 70);
            btnCat.TabIndex = 2;
            btnCat.Text = "Cat";
            btnCat.UseVisualStyleBackColor = true;
            btnCat.Click += btnCat_Click;
            // 
            // gupPet
            // 
            gupPet.BackColor = Color.Transparent;
            gupPet.Controls.Add(btnDog);
            gupPet.Controls.Add(btnCat);
            gupPet.Controls.Add(btnPlant);
            gupPet.Controls.Add(btnClear);
            gupPet.Font = new Font("Papyrus", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gupPet.Location = new Point(12, 12);
            gupPet.Name = "gupPet";
            gupPet.Size = new Size(233, 339);
            gupPet.TabIndex = 0;
            gupPet.TabStop = false;
            gupPet.Text = "AWESOME PETS!";
            // 
            // btnClear
            // 
            btnClear.Font = new Font("MS Mincho", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(6, 261);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(220, 69);
            btnClear.TabIndex = 4;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnDog
            // 
            btnDog.Font = new Font("MS Mincho", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDog.Location = new Point(6, 26);
            btnDog.Name = "btnDog";
            btnDog.Size = new Size(220, 70);
            btnDog.TabIndex = 1;
            btnDog.Text = "Dog";
            btnDog.UseVisualStyleBackColor = true;
            btnDog.Click += btnDog_Click;
            // 
            // btnPlant
            // 
            btnPlant.Font = new Font("Comic Sans MS", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPlant.Location = new Point(6, 178);
            btnPlant.Name = "btnPlant";
            btnPlant.Size = new Size(220, 70);
            btnPlant.TabIndex = 3;
            btnPlant.Text = "Plant";
            btnPlant.UseVisualStyleBackColor = true;
            btnPlant.Click += btnPlant_Click;
            // 
            // lblPetNoise
            // 
            lblPetNoise.BackColor = Color.White;
            lblPetNoise.Font = new Font("Vladimir Script", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPetNoise.ForeColor = SystemColors.ControlText;
            lblPetNoise.Location = new Point(290, 38);
            lblPetNoise.Name = "lblPetNoise";
            lblPetNoise.Size = new Size(212, 80);
            lblPetNoise.TabIndex = 0;
            lblPetNoise.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlBtnDivider
            // 
            pnlBtnDivider.BackColor = Color.WhiteSmoke;
            pnlBtnDivider.Location = new Point(12, 266);
            pnlBtnDivider.Name = "pnlBtnDivider";
            pnlBtnDivider.Size = new Size(233, 1);
            pnlBtnDivider.TabIndex = 0;
            // 
            // frmWinMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(764, 363);
            Controls.Add(pnlBtnDivider);
            Controls.Add(lblPetNoise);
            Controls.Add(gupPet);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "frmWinMain";
            Text = "Demo";
            gupPet.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnCat;
        private GroupBox gupPet;
        private Button btnDog;
        private Button btnPlant;
        private Label lblPetNoise;
        private Button btnClear;
        private Panel pnlBtnDivider;
    }
}
