namespace CashRegister
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.BurgerLabel = new System.Windows.Forms.Label();
            this.friesLabel = new System.Windows.Forms.Label();
            this.drinksLabel = new System.Windows.Forms.Label();
            this.burgerInput = new System.Windows.Forms.TextBox();
            this.friesInput = new System.Windows.Forms.TextBox();
            this.drinksInput = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.subTotalLabel = new System.Windows.Forms.Label();
            this.taxLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.subTotalOutput = new System.Windows.Forms.Label();
            this.TaxOutput = new System.Windows.Forms.Label();
            this.totalOutput = new System.Windows.Forms.Label();
            this.blackLineLable = new System.Windows.Forms.Label();
            this.tenderedLable = new System.Windows.Forms.Label();
            this.tenderedInput = new System.Windows.Forms.TextBox();
            this.calculateChangeButton = new System.Windows.Forms.Button();
            this.changeLabel = new System.Windows.Forms.Label();
            this.changeOutput = new System.Windows.Forms.Label();
            this.printReceiptButton = new System.Windows.Forms.Button();
            this.newordnerButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.BackColor = System.Drawing.Color.Red;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(-4, -2);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(901, 94);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "  McDonalds";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BurgerLabel
            // 
            this.BurgerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BurgerLabel.Location = new System.Drawing.Point(22, 138);
            this.BurgerLabel.Name = "BurgerLabel";
            this.BurgerLabel.Size = new System.Drawing.Size(219, 34);
            this.BurgerLabel.TabIndex = 1;
            this.BurgerLabel.Text = "Number of Burger";
            // 
            // friesLabel
            // 
            this.friesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.friesLabel.Location = new System.Drawing.Point(22, 208);
            this.friesLabel.Name = "friesLabel";
            this.friesLabel.Size = new System.Drawing.Size(218, 34);
            this.friesLabel.TabIndex = 2;
            this.friesLabel.Text = "Number of Fries";
            // 
            // drinksLabel
            // 
            this.drinksLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drinksLabel.Location = new System.Drawing.Point(22, 275);
            this.drinksLabel.Name = "drinksLabel";
            this.drinksLabel.Size = new System.Drawing.Size(231, 34);
            this.drinksLabel.TabIndex = 3;
            this.drinksLabel.Text = "Number of Drinks";
            // 
            // burgerInput
            // 
            this.burgerInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.burgerInput.Location = new System.Drawing.Point(274, 138);
            this.burgerInput.Name = "burgerInput";
            this.burgerInput.Size = new System.Drawing.Size(85, 30);
            this.burgerInput.TabIndex = 1;
            // 
            // friesInput
            // 
            this.friesInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.friesInput.Location = new System.Drawing.Point(274, 208);
            this.friesInput.Name = "friesInput";
            this.friesInput.Size = new System.Drawing.Size(85, 30);
            this.friesInput.TabIndex = 5;
            // 
            // drinksInput
            // 
            this.drinksInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drinksInput.Location = new System.Drawing.Point(274, 275);
            this.drinksInput.Name = "drinksInput";
            this.drinksInput.Size = new System.Drawing.Size(85, 30);
            this.drinksInput.TabIndex = 6;
            // 
            // calculateButton
            // 
            this.calculateButton.BackColor = System.Drawing.Color.Silver;
            this.calculateButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.calculateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calculateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateButton.Location = new System.Drawing.Point(79, 338);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(252, 60);
            this.calculateButton.TabIndex = 8;
            this.calculateButton.Text = "Calculate Totals";
            this.calculateButton.UseVisualStyleBackColor = false;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // subTotalLabel
            // 
            this.subTotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subTotalLabel.Location = new System.Drawing.Point(23, 424);
            this.subTotalLabel.Name = "subTotalLabel";
            this.subTotalLabel.Size = new System.Drawing.Size(142, 34);
            this.subTotalLabel.TabIndex = 9;
            this.subTotalLabel.Text = "Sub Total";
            // 
            // taxLabel
            // 
            this.taxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxLabel.Location = new System.Drawing.Point(23, 475);
            this.taxLabel.Name = "taxLabel";
            this.taxLabel.Size = new System.Drawing.Size(140, 34);
            this.taxLabel.TabIndex = 10;
            this.taxLabel.Text = "Tax";
            // 
            // totalLabel
            // 
            this.totalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.Location = new System.Drawing.Point(23, 523);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(122, 34);
            this.totalLabel.TabIndex = 11;
            this.totalLabel.Text = "Total";
            // 
            // subTotalOutput
            // 
            this.subTotalOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subTotalOutput.Location = new System.Drawing.Point(235, 424);
            this.subTotalOutput.Name = "subTotalOutput";
            this.subTotalOutput.Size = new System.Drawing.Size(126, 34);
            this.subTotalOutput.TabIndex = 12;
            // 
            // TaxOutput
            // 
            this.TaxOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaxOutput.Location = new System.Drawing.Point(235, 475);
            this.TaxOutput.Name = "TaxOutput";
            this.TaxOutput.Size = new System.Drawing.Size(125, 34);
            this.TaxOutput.TabIndex = 13;
            // 
            // totalOutput
            // 
            this.totalOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalOutput.Location = new System.Drawing.Point(235, 523);
            this.totalOutput.Name = "totalOutput";
            this.totalOutput.Size = new System.Drawing.Size(126, 34);
            this.totalOutput.TabIndex = 14;
            // 
            // blackLineLable
            // 
            this.blackLineLable.BackColor = System.Drawing.Color.Black;
            this.blackLineLable.Location = new System.Drawing.Point(23, 581);
            this.blackLineLable.Name = "blackLineLable";
            this.blackLineLable.Size = new System.Drawing.Size(372, 16);
            this.blackLineLable.TabIndex = 15;
            // 
            // tenderedLable
            // 
            this.tenderedLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenderedLable.Location = new System.Drawing.Point(22, 622);
            this.tenderedLable.Name = "tenderedLable";
            this.tenderedLable.Size = new System.Drawing.Size(136, 34);
            this.tenderedLable.TabIndex = 16;
            this.tenderedLable.Text = "Tendered";
            // 
            // tenderedInput
            // 
            this.tenderedInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenderedInput.Location = new System.Drawing.Point(274, 622);
            this.tenderedInput.Name = "tenderedInput";
            this.tenderedInput.Size = new System.Drawing.Size(87, 30);
            this.tenderedInput.TabIndex = 17;
            // 
            // calculateChangeButton
            // 
            this.calculateChangeButton.BackColor = System.Drawing.Color.Silver;
            this.calculateChangeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.calculateChangeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calculateChangeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateChangeButton.Location = new System.Drawing.Point(79, 681);
            this.calculateChangeButton.Name = "calculateChangeButton";
            this.calculateChangeButton.Size = new System.Drawing.Size(252, 60);
            this.calculateChangeButton.TabIndex = 18;
            this.calculateChangeButton.Text = "Calculate Change";
            this.calculateChangeButton.UseVisualStyleBackColor = false;
            this.calculateChangeButton.Click += new System.EventHandler(this.calculateChangeButton_Click);
            // 
            // changeLabel
            // 
            this.changeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeLabel.Location = new System.Drawing.Point(23, 761);
            this.changeLabel.Name = "changeLabel";
            this.changeLabel.Size = new System.Drawing.Size(138, 34);
            this.changeLabel.TabIndex = 19;
            this.changeLabel.Text = "Change";
            // 
            // changeOutput
            // 
            this.changeOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeOutput.Location = new System.Drawing.Point(269, 759);
            this.changeOutput.Name = "changeOutput";
            this.changeOutput.Size = new System.Drawing.Size(111, 36);
            this.changeOutput.TabIndex = 20;
            // 
            // printReceiptButton
            // 
            this.printReceiptButton.BackColor = System.Drawing.Color.Silver;
            this.printReceiptButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.printReceiptButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.printReceiptButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printReceiptButton.Location = new System.Drawing.Point(79, 806);
            this.printReceiptButton.Name = "printReceiptButton";
            this.printReceiptButton.Size = new System.Drawing.Size(252, 62);
            this.printReceiptButton.TabIndex = 21;
            this.printReceiptButton.Text = "Print Receipts";
            this.printReceiptButton.UseVisualStyleBackColor = false;
            this.printReceiptButton.Click += new System.EventHandler(this.printReceiptButton_Click);
            // 
            // newordnerButton
            // 
            this.newordnerButton.BackColor = System.Drawing.Color.Silver;
            this.newordnerButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.newordnerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newordnerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newordnerButton.Location = new System.Drawing.Point(493, 806);
            this.newordnerButton.Name = "newordnerButton";
            this.newordnerButton.Size = new System.Drawing.Size(252, 62);
            this.newordnerButton.TabIndex = 22;
            this.newordnerButton.Text = "New Order";
            this.newordnerButton.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(878, 894);
            this.Controls.Add(this.newordnerButton);
            this.Controls.Add(this.printReceiptButton);
            this.Controls.Add(this.changeOutput);
            this.Controls.Add(this.changeLabel);
            this.Controls.Add(this.calculateChangeButton);
            this.Controls.Add(this.tenderedInput);
            this.Controls.Add(this.tenderedLable);
            this.Controls.Add(this.blackLineLable);
            this.Controls.Add(this.totalOutput);
            this.Controls.Add(this.TaxOutput);
            this.Controls.Add(this.subTotalOutput);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.taxLabel);
            this.Controls.Add(this.subTotalLabel);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.drinksInput);
            this.Controls.Add(this.friesInput);
            this.Controls.Add(this.burgerInput);
            this.Controls.Add(this.drinksLabel);
            this.Controls.Add(this.friesLabel);
            this.Controls.Add(this.BurgerLabel);
            this.Controls.Add(this.titleLabel);
            this.Name = "Form1";
            this.Text = "Cash Register";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label BurgerLabel;
        private System.Windows.Forms.Label friesLabel;
        private System.Windows.Forms.Label drinksLabel;
        private System.Windows.Forms.TextBox burgerInput;
        private System.Windows.Forms.TextBox friesInput;
        private System.Windows.Forms.TextBox drinksInput;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label subTotalLabel;
        private System.Windows.Forms.Label taxLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label subTotalOutput;
        private System.Windows.Forms.Label TaxOutput;
        private System.Windows.Forms.Label totalOutput;
        private System.Windows.Forms.Label blackLineLable;
        private System.Windows.Forms.Label tenderedLable;
        private System.Windows.Forms.TextBox tenderedInput;
        private System.Windows.Forms.Button calculateChangeButton;
        private System.Windows.Forms.Label changeLabel;
        private System.Windows.Forms.Label changeOutput;
        private System.Windows.Forms.Button printReceiptButton;
        private System.Windows.Forms.Button newordnerButton;
    }
}

