namespace Assignmnet_1._4
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
            this.nrUpDownExchangeRate = new System.Windows.Forms.NumericUpDown();
            this.tbEuro = new System.Windows.Forms.TextBox();
            this.tbdollar = new System.Windows.Forms.TextBox();
            this.btnConvertDollarToEuro = new System.Windows.Forms.Button();
            this.btnConvertEuroToDollar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnMadeBy = new System.Windows.Forms.Button();
            this.btnHide = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nrUpDownExchangeRate)).BeginInit();
            this.SuspendLayout();
            // 
            // nrUpDownExchangeRate
            // 
            this.nrUpDownExchangeRate.DecimalPlaces = 2;
            this.nrUpDownExchangeRate.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.nrUpDownExchangeRate.Location = new System.Drawing.Point(363, 102);
            this.nrUpDownExchangeRate.Name = "nrUpDownExchangeRate";
            this.nrUpDownExchangeRate.Size = new System.Drawing.Size(120, 20);
            this.nrUpDownExchangeRate.TabIndex = 0;
            this.nrUpDownExchangeRate.Value = new decimal(new int[] {
            150,
            0,
            0,
            131072});
            // 
            // tbEuro
            // 
            this.tbEuro.Location = new System.Drawing.Point(45, 60);
            this.tbEuro.Name = "tbEuro";
            this.tbEuro.Size = new System.Drawing.Size(131, 20);
            this.tbEuro.TabIndex = 1;
            // 
            // tbdollar
            // 
            this.tbdollar.Location = new System.Drawing.Point(274, 57);
            this.tbdollar.Name = "tbdollar";
            this.tbdollar.Size = new System.Drawing.Size(140, 20);
            this.tbdollar.TabIndex = 2;
            // 
            // btnConvertDollarToEuro
            // 
            this.btnConvertDollarToEuro.Location = new System.Drawing.Point(182, 58);
            this.btnConvertDollarToEuro.Name = "btnConvertDollarToEuro";
            this.btnConvertDollarToEuro.Size = new System.Drawing.Size(38, 23);
            this.btnConvertDollarToEuro.TabIndex = 3;
            this.btnConvertDollarToEuro.Text = "<";
            this.toolTip1.SetToolTip(this.btnConvertDollarToEuro, "dollar to euro");
            this.btnConvertDollarToEuro.UseVisualStyleBackColor = true;
            this.btnConvertDollarToEuro.Click += new System.EventHandler(this.btnConvertDollarToEuro_Click);
            // 
            // btnConvertEuroToDollar
            // 
            this.btnConvertEuroToDollar.Location = new System.Drawing.Point(226, 57);
            this.btnConvertEuroToDollar.Name = "btnConvertEuroToDollar";
            this.btnConvertEuroToDollar.Size = new System.Drawing.Size(42, 23);
            this.btnConvertEuroToDollar.TabIndex = 4;
            this.btnConvertEuroToDollar.Text = ">";
            this.toolTip1.SetToolTip(this.btnConvertEuroToDollar, "Euro to dollar");
            this.btnConvertEuroToDollar.UseVisualStyleBackColor = true;
            this.btnConvertEuroToDollar.Click += new System.EventHandler(this.btnConvertEuroToDollar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(420, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "$";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(236, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Exchange rate 1 euro=$\r\n";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "€";
            // 
            // btnMadeBy
            // 
            this.btnMadeBy.Location = new System.Drawing.Point(45, 177);
            this.btnMadeBy.Name = "btnMadeBy";
            this.btnMadeBy.Size = new System.Drawing.Size(75, 23);
            this.btnMadeBy.TabIndex = 9;
            this.btnMadeBy.Text = "Made by";
            this.btnMadeBy.UseVisualStyleBackColor = true;
            this.btnMadeBy.Click += new System.EventHandler(this.btnMadeBy_Click);
            // 
            // btnHide
            // 
            this.btnHide.Location = new System.Drawing.Point(126, 177);
            this.btnHide.Name = "btnHide";
            this.btnHide.Size = new System.Drawing.Size(75, 23);
            this.btnHide.TabIndex = 11;
            this.btnHide.Text = "hide";
            this.btnHide.UseVisualStyleBackColor = true;
            this.btnHide.Click += new System.EventHandler(this.btnHide_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Dholon Barisali";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 228);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnHide);
            this.Controls.Add(this.btnMadeBy);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnConvertEuroToDollar);
            this.Controls.Add(this.btnConvertDollarToEuro);
            this.Controls.Add(this.tbdollar);
            this.Controls.Add(this.tbEuro);
            this.Controls.Add(this.nrUpDownExchangeRate);
            this.Name = "Form1";
            this.Text = "Euro Dollar Converter";
            ((System.ComponentModel.ISupportInitialize)(this.nrUpDownExchangeRate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nrUpDownExchangeRate;
        private System.Windows.Forms.TextBox tbEuro;
        private System.Windows.Forms.TextBox tbdollar;
        private System.Windows.Forms.Button btnConvertDollarToEuro;
        private System.Windows.Forms.Button btnConvertEuroToDollar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnMadeBy;
        private System.Windows.Forms.Button btnHide;
        private System.Windows.Forms.Label label5;
    }
}

