namespace JJN.Week4.UI
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
            txb1st = new TextBox();
            btnCalc = new Button();
            txb2nd = new TextBox();
            lblOp = new Label();
            lblResult = new Label();
            btnIncr = new Button();
            btnReset = new Button();
            lblIncrCount = new Label();
            txbQty = new TextBox();
            lblTotalCost = new Label();
            btnCostCalc = new Button();
            SuspendLayout();
            // 
            // txb1st
            // 
            txb1st.Font = new Font("Verdana", 16.3018875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txb1st.Location = new Point(168, 12);
            txb1st.Name = "txb1st";
            txb1st.Size = new Size(464, 37);
            txb1st.TabIndex = 0;
            // 
            // btnCalc
            // 
            btnCalc.Location = new Point(168, 130);
            btnCalc.Name = "btnCalc";
            btnCalc.Size = new Size(230, 32);
            btnCalc.TabIndex = 1;
            btnCalc.Text = "Calculate";
            btnCalc.UseVisualStyleBackColor = true;
            btnCalc.Click += btnCalc_Click;
            // 
            // txb2nd
            // 
            txb2nd.Font = new Font("Verdana", 16.3018875F);
            txb2nd.Location = new Point(168, 87);
            txb2nd.Name = "txb2nd";
            txb2nd.Size = new Size(464, 37);
            txb2nd.TabIndex = 2;
            // 
            // lblOp
            // 
            lblOp.Font = new Font("Verdana", 16.3018875F);
            lblOp.Location = new Point(384, 52);
            lblOp.Name = "lblOp";
            lblOp.Size = new Size(32, 32);
            lblOp.TabIndex = 3;
            lblOp.Text = "+";
            // 
            // lblResult
            // 
            lblResult.BorderStyle = BorderStyle.Fixed3D;
            lblResult.Font = new Font("Verdana", 16.3018875F);
            lblResult.Location = new Point(402, 130);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(230, 32);
            lblResult.TabIndex = 4;
            lblResult.Text = "0";
            // 
            // btnIncr
            // 
            btnIncr.Location = new Point(562, 168);
            btnIncr.Name = "btnIncr";
            btnIncr.Size = new Size(32, 32);
            btnIncr.TabIndex = 5;
            btnIncr.Text = "➕";
            btnIncr.UseVisualStyleBackColor = true;
            btnIncr.Click += btnIncr_Click;
            // 
            // btnReset
            // 
            btnReset.ForeColor = Color.IndianRed;
            btnReset.Location = new Point(600, 168);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(32, 32);
            btnReset.TabIndex = 6;
            btnReset.Text = "❌";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // lblIncrCount
            // 
            lblIncrCount.BorderStyle = BorderStyle.Fixed3D;
            lblIncrCount.Font = new Font("Verdana", 16.3018875F);
            lblIncrCount.Location = new Point(168, 168);
            lblIncrCount.Name = "lblIncrCount";
            lblIncrCount.Size = new Size(388, 32);
            lblIncrCount.TabIndex = 7;
            lblIncrCount.Text = "Count: 0";
            // 
            // txbQty
            // 
            txbQty.Font = new Font("Verdana", 12.2264156F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txbQty.Location = new Point(166, 207);
            txbQty.Name = "txbQty";
            txbQty.Size = new Size(230, 29);
            txbQty.TabIndex = 9;
            // 
            // lblTotalCost
            // 
            lblTotalCost.BorderStyle = BorderStyle.Fixed3D;
            lblTotalCost.Font = new Font("Verdana", 16.3018875F);
            lblTotalCost.Location = new Point(168, 241);
            lblTotalCost.Name = "lblTotalCost";
            lblTotalCost.Size = new Size(464, 32);
            lblTotalCost.TabIndex = 10;
            // 
            // btnCostCalc
            // 
            btnCostCalc.Location = new Point(402, 206);
            btnCostCalc.Name = "btnCostCalc";
            btnCostCalc.Size = new Size(230, 32);
            btnCostCalc.TabIndex = 11;
            btnCostCalc.Text = "Calculate";
            btnCostCalc.UseVisualStyleBackColor = true;
            btnCostCalc.Click += btnCostCalc_Click;
            // 
            // frmWinMain
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCostCalc);
            Controls.Add(lblTotalCost);
            Controls.Add(txbQty);
            Controls.Add(lblIncrCount);
            Controls.Add(btnReset);
            Controls.Add(btnIncr);
            Controls.Add(lblResult);
            Controls.Add(lblOp);
            Controls.Add(txb2nd);
            Controls.Add(btnCalc);
            Controls.Add(txb1st);
            Name = "frmWinMain";
            Text = "Demo4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txb1st;
        private Button btnCalc;
        private TextBox txb2nd;
        private Label lblOp;
        private Label lblResult;
        private Button btnIncr;
        private Button btnReset;
        private Label lblIncrCount;
        private TextBox txbQty;
        private Label lblTotalCost;
        private Button btnCostCalc;
    }
}
