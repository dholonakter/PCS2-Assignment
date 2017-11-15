namespace Assignment_1._3
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.tbA = new System.Windows.Forms.TextBox();
            this.tbB = new System.Windows.Forms.TextBox();
            this.tbIntDiv = new System.Windows.Forms.TextBox();
            this.tbRemainder = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.resultBtn = new System.Windows.Forms.Button();
            this.l = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // tbA
            // 
            this.tbA.Location = new System.Drawing.Point(54, 16);
            this.tbA.Name = "tbA";
            this.tbA.Size = new System.Drawing.Size(100, 20);
            this.tbA.TabIndex = 0;
            this.l.SetToolTip(this.tbA, "WholeNumber");
            // 
            // tbB
            // 
            this.tbB.Location = new System.Drawing.Point(261, 16);
            this.tbB.Name = "tbB";
            this.tbB.Size = new System.Drawing.Size(100, 20);
            this.tbB.TabIndex = 1;
            this.l.SetToolTip(this.tbB, "WholeNumber");
            // 
            // tbIntDiv
            // 
            this.tbIntDiv.Location = new System.Drawing.Point(54, 68);
            this.tbIntDiv.Name = "tbIntDiv";
            this.tbIntDiv.Size = new System.Drawing.Size(100, 20);
            this.tbIntDiv.TabIndex = 2;
            // 
            // tbRemainder
            // 
            this.tbRemainder.Location = new System.Drawing.Point(261, 71);
            this.tbRemainder.Name = "tbRemainder";
            this.tbRemainder.Size = new System.Drawing.Size(100, 20);
            this.tbRemainder.TabIndex = 3;

            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(209, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "B";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "A/B";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(209, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "A%B";
            // 
            // resultBtn
            // 
            this.resultBtn.Location = new System.Drawing.Point(144, 125);
            this.resultBtn.Name = "resultBtn";
            this.resultBtn.Size = new System.Drawing.Size(75, 23);
            this.resultBtn.TabIndex = 8;
            this.resultBtn.Text = "RESULT";
            this.resultBtn.UseVisualStyleBackColor = true;
            this.resultBtn.Click += new System.EventHandler(this.resultBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 261);
            this.Controls.Add(this.resultBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbRemainder);
            this.Controls.Add(this.tbIntDiv);
            this.Controls.Add(this.tbB);
            this.Controls.Add(this.tbA);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbA;
        private System.Windows.Forms.TextBox tbB;
        private System.Windows.Forms.TextBox tbIntDiv;
        private System.Windows.Forms.TextBox tbRemainder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button resultBtn;
        private System.Windows.Forms.ToolTip l;
    }
}

