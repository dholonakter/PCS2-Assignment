namespace SimpleCalculator
{
    partial class SimpleCalculatorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbFirstNumber = new System.Windows.Forms.TextBox();
            this.tbSecondNumber = new System.Windows.Forms.TextBox();
            this.tbresult = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSubtract = new System.Windows.Forms.Button();
            this.btnDivision = new System.Windows.Forms.Button();
            this.btnMultpli = new System.Windows.Forms.Button();
            this.equal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbFirstNumber
            // 
            this.tbFirstNumber.Location = new System.Drawing.Point(2, 12);
            this.tbFirstNumber.Name = "tbFirstNumber";
            this.tbFirstNumber.Size = new System.Drawing.Size(243, 20);
            this.tbFirstNumber.TabIndex = 0;
            // 
            // tbSecondNumber
            // 
            this.tbSecondNumber.Location = new System.Drawing.Point(2, 90);
            this.tbSecondNumber.Name = "tbSecondNumber";
            this.tbSecondNumber.Size = new System.Drawing.Size(237, 20);
            this.tbSecondNumber.TabIndex = 1;
            // 
            // tbresult
            // 
            this.tbresult.Location = new System.Drawing.Point(2, 170);
            this.tbresult.Name = "tbresult";
            this.tbresult.ReadOnly = true;
            this.tbresult.Size = new System.Drawing.Size(243, 20);
            this.tbresult.TabIndex = 2;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(13, 55);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(32, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSubtract
            // 
            this.btnSubtract.Location = new System.Drawing.Point(62, 55);
            this.btnSubtract.Name = "btnSubtract";
            this.btnSubtract.Size = new System.Drawing.Size(32, 23);
            this.btnSubtract.TabIndex = 4;
            this.btnSubtract.Text = "-";
            this.btnSubtract.UseVisualStyleBackColor = true;
            this.btnSubtract.Click += new System.EventHandler(this.btnSubtract_Click);
            // 
            // btnDivision
            // 
            this.btnDivision.Location = new System.Drawing.Point(118, 55);
            this.btnDivision.Name = "btnDivision";
            this.btnDivision.Size = new System.Drawing.Size(32, 23);
            this.btnDivision.TabIndex = 5;
            this.btnDivision.Text = "/";
            this.btnDivision.UseVisualStyleBackColor = true;
            this.btnDivision.Click += new System.EventHandler(this.btnDivision_Click);
            // 
            // btnMultpli
            // 
            this.btnMultpli.Location = new System.Drawing.Point(177, 55);
            this.btnMultpli.Name = "btnMultpli";
            this.btnMultpli.Size = new System.Drawing.Size(32, 23);
            this.btnMultpli.TabIndex = 6;
            this.btnMultpli.Text = "*";
            this.btnMultpli.UseVisualStyleBackColor = true;
            this.btnMultpli.Click += new System.EventHandler(this.btnMultpli_Click);
            // 
            // equal
            // 
            this.equal.AutoSize = true;
            this.equal.Location = new System.Drawing.Point(96, 128);
            this.equal.Name = "equal";
            this.equal.Size = new System.Drawing.Size(13, 13);
            this.equal.TabIndex = 7;
            this.equal.Text = "=";
            // 
            // SimpleCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(251, 241);
            this.Controls.Add(this.equal);
            this.Controls.Add(this.btnMultpli);
            this.Controls.Add(this.btnDivision);
            this.Controls.Add(this.btnSubtract);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tbresult);
            this.Controls.Add(this.tbSecondNumber);
            this.Controls.Add(this.tbFirstNumber);
            this.Name = "SimpleCalculator";
            this.Text = "Simple Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbFirstNumber;
        private System.Windows.Forms.TextBox tbSecondNumber;
        private System.Windows.Forms.TextBox tbresult;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSubtract;
        private System.Windows.Forms.Button btnDivision;
        private System.Windows.Forms.Button btnMultpli;
        private System.Windows.Forms.Label equal;
    }
}

