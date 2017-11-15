namespace Assignment_1._8
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
            this.tbxOrderNumber = new System.Windows.Forms.TextBox();
            this.tbxCustomerName = new System.Windows.Forms.TextBox();
            this.tbxShipppingAddress = new System.Windows.Forms.TextBox();
            this.tbxQuantityOfDice = new System.Windows.Forms.TextBox();
            this.chbxRed = new System.Windows.Forms.CheckBox();
            this.checkBoxGreen = new System.Windows.Forms.CheckBox();
            this.checkBoxBlue = new System.Windows.Forms.CheckBox();
            this.checkBoxYellow = new System.Windows.Forms.CheckBox();
            this.btnResetFields = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblShipping = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbxOrderNumber
            // 
            this.tbxOrderNumber.Location = new System.Drawing.Point(104, 22);
            this.tbxOrderNumber.Name = "tbxOrderNumber";
            this.tbxOrderNumber.Size = new System.Drawing.Size(209, 20);
            this.tbxOrderNumber.TabIndex = 0;
            // 
            // tbxCustomerName
            // 
            this.tbxCustomerName.Location = new System.Drawing.Point(104, 62);
            this.tbxCustomerName.Name = "tbxCustomerName";
            this.tbxCustomerName.Size = new System.Drawing.Size(209, 20);
            this.tbxCustomerName.TabIndex = 1;
            // 
            // tbxShipppingAddress
            // 
            this.tbxShipppingAddress.Location = new System.Drawing.Point(104, 100);
            this.tbxShipppingAddress.Name = "tbxShipppingAddress";
            this.tbxShipppingAddress.Size = new System.Drawing.Size(209, 20);
            this.tbxShipppingAddress.TabIndex = 2;
            // 
            // tbxQuantityOfDice
            // 
            this.tbxQuantityOfDice.Location = new System.Drawing.Point(104, 145);
            this.tbxQuantityOfDice.Name = "tbxQuantityOfDice";
            this.tbxQuantityOfDice.ReadOnly = true;
            this.tbxQuantityOfDice.Size = new System.Drawing.Size(209, 20);
            this.tbxQuantityOfDice.TabIndex = 4;
            this.tbxQuantityOfDice.DoubleClick += new System.EventHandler(this.tbxQuantityOfDice_DoubleClick);
            // 
            // chbxRed
            // 
            this.chbxRed.AutoSize = true;
            this.chbxRed.Location = new System.Drawing.Point(496, 12);
            this.chbxRed.Name = "chbxRed";
            this.chbxRed.Size = new System.Drawing.Size(46, 17);
            this.chbxRed.TabIndex = 5;
            this.chbxRed.Text = "Red";
            this.chbxRed.UseVisualStyleBackColor = true;
            this.chbxRed.Click += new System.EventHandler(this.chbxRed_Click);
            // 
            // checkBoxGreen
            // 
            this.checkBoxGreen.AutoSize = true;
            this.checkBoxGreen.Location = new System.Drawing.Point(496, 55);
            this.checkBoxGreen.Name = "checkBoxGreen";
            this.checkBoxGreen.Size = new System.Drawing.Size(55, 17);
            this.checkBoxGreen.TabIndex = 6;
            this.checkBoxGreen.Text = "Green";
            this.checkBoxGreen.UseVisualStyleBackColor = true;
            // 
            // checkBoxBlue
            // 
            this.checkBoxBlue.AutoSize = true;
            this.checkBoxBlue.Location = new System.Drawing.Point(496, 132);
            this.checkBoxBlue.Name = "checkBoxBlue";
            this.checkBoxBlue.Size = new System.Drawing.Size(47, 17);
            this.checkBoxBlue.TabIndex = 7;
            this.checkBoxBlue.Text = "Blue";
            this.checkBoxBlue.UseVisualStyleBackColor = true;
            // 
            // checkBoxYellow
            // 
            this.checkBoxYellow.AutoSize = true;
            this.checkBoxYellow.Location = new System.Drawing.Point(496, 93);
            this.checkBoxYellow.Name = "checkBoxYellow";
            this.checkBoxYellow.Size = new System.Drawing.Size(55, 17);
            this.checkBoxYellow.TabIndex = 9;
            this.checkBoxYellow.Text = "yellow";
            this.checkBoxYellow.UseVisualStyleBackColor = true;
            // 
            // btnResetFields
            // 
            this.btnResetFields.Location = new System.Drawing.Point(238, 249);
            this.btnResetFields.Name = "btnResetFields";
            this.btnResetFields.Size = new System.Drawing.Size(75, 23);
            this.btnResetFields.TabIndex = 16;
            this.btnResetFields.Text = "Reset";
            this.btnResetFields.UseVisualStyleBackColor = true;
            this.btnResetFields.Click += new System.EventHandler(this.btnResetFields_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Order Number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Customer Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Shipping Address :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Quantity";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(53, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "TotalCost";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(53, 254);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Tax";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(39, 280);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Shipping fee";
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.AutoSize = true;
            this.lblTotalCost.Location = new System.Drawing.Point(130, 228);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(43, 13);
            this.lblTotalCost.TabIndex = 22;
            this.lblTotalCost.Text = "............";
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Location = new System.Drawing.Point(130, 254);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(43, 13);
            this.lblTax.TabIndex = 23;
            this.lblTax.Text = "............";
            // 
            // lblShipping
            // 
            this.lblShipping.AutoSize = true;
            this.lblShipping.Location = new System.Drawing.Point(130, 280);
            this.lblShipping.Name = "lblShipping";
            this.lblShipping.Size = new System.Drawing.Size(43, 13);
            this.lblShipping.TabIndex = 23;
            this.lblShipping.Text = "............";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 377);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblShipping);
            this.Controls.Add(this.lblTax);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblTotalCost);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnResetFields);
            this.Controls.Add(this.checkBoxYellow);
            this.Controls.Add(this.checkBoxBlue);
            this.Controls.Add(this.checkBoxGreen);
            this.Controls.Add(this.chbxRed);
            this.Controls.Add(this.tbxQuantityOfDice);
            this.Controls.Add(this.tbxShipppingAddress);
            this.Controls.Add(this.tbxCustomerName);
            this.Controls.Add(this.tbxOrderNumber);
            this.Name = "Form1";
            this.Text = "ed";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxOrderNumber;
        private System.Windows.Forms.TextBox tbxCustomerName;
        private System.Windows.Forms.TextBox tbxShipppingAddress;
        private System.Windows.Forms.TextBox tbxQuantityOfDice;
        private System.Windows.Forms.CheckBox chbxRed;
        private System.Windows.Forms.CheckBox checkBoxGreen;
        private System.Windows.Forms.CheckBox checkBoxBlue;
        private System.Windows.Forms.CheckBox checkBoxYellow;
        private System.Windows.Forms.Button btnResetFields;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblTotalCost;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label lblShipping;
    }
}

