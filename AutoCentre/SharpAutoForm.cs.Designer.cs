namespace AutoCentre
{
    partial class autoCentreForm
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
            this.calculateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.accessoriesGroupBox = new System.Windows.Forms.GroupBox();
            this.stereoSystemCheckBox = new System.Windows.Forms.CheckBox();
            this.leatherInteriorCheckBox = new System.Windows.Forms.CheckBox();
            this.computerNavigationCheckBox = new System.Windows.Forms.CheckBox();
            this.exteriorFinishGroupBox = new System.Windows.Forms.GroupBox();
            this.customizedDetailingRadioButton = new System.Windows.Forms.RadioButton();
            this.peralizedRadioButton = new System.Windows.Forms.RadioButton();
            this.standardRadioButton = new System.Windows.Forms.RadioButton();
            this.BasePriceLabel = new System.Windows.Forms.Label();
            this.AdditionalOptionsLabel = new System.Windows.Forms.Label();
            this.subtotalLabel = new System.Windows.Forms.Label();
            this.salesTaxLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.tradeInAllowanceLabel = new System.Windows.Forms.Label();
            this.amountDueLabel = new System.Windows.Forms.Label();
            this.carSalesPriceTextBox = new System.Windows.Forms.TextBox();
            this.accessoriesFinishTextBox = new System.Windows.Forms.TextBox();
            this.subtotalTextBox = new System.Windows.Forms.TextBox();
            this.salesTaxTextBox = new System.Windows.Forms.TextBox();
            this.totalTextBox = new System.Windows.Forms.TextBox();
            this.tradeInAllowanceTextBox = new System.Windows.Forms.TextBox();
            this.amountDueTextBox = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.accessoriesGroupBox.SuspendLayout();
            this.exteriorFinishGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(19, 328);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 6;
            this.calculateButton.Text = "&Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(133, 328);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 7;
            this.clearButton.Text = "C&lear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitButton.Location = new System.Drawing.Point(242, 328);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 8;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // accessoriesGroupBox
            // 
            this.accessoriesGroupBox.Controls.Add(this.stereoSystemCheckBox);
            this.accessoriesGroupBox.Controls.Add(this.leatherInteriorCheckBox);
            this.accessoriesGroupBox.Controls.Add(this.computerNavigationCheckBox);
            this.accessoriesGroupBox.Location = new System.Drawing.Point(253, 28);
            this.accessoriesGroupBox.Name = "accessoriesGroupBox";
            this.accessoriesGroupBox.Size = new System.Drawing.Size(136, 128);
            this.accessoriesGroupBox.TabIndex = 4;
            this.accessoriesGroupBox.TabStop = false;
            this.accessoriesGroupBox.Text = "Accessories";
            // 
            // stereoSystemCheckBox
            // 
            this.stereoSystemCheckBox.AutoSize = true;
            this.stereoSystemCheckBox.Location = new System.Drawing.Point(6, 28);
            this.stereoSystemCheckBox.Name = "stereoSystemCheckBox";
            this.stereoSystemCheckBox.Size = new System.Drawing.Size(94, 17);
            this.stereoSystemCheckBox.TabIndex = 0;
            this.stereoSystemCheckBox.Text = "&Stereo System";
            this.toolTip1.SetToolTip(this.stereoSystemCheckBox, "Click to add Stereo System option to your car");
            this.stereoSystemCheckBox.UseVisualStyleBackColor = true;
            // 
            // leatherInteriorCheckBox
            // 
            this.leatherInteriorCheckBox.AutoSize = true;
            this.leatherInteriorCheckBox.Location = new System.Drawing.Point(6, 66);
            this.leatherInteriorCheckBox.Name = "leatherInteriorCheckBox";
            this.leatherInteriorCheckBox.Size = new System.Drawing.Size(97, 17);
            this.leatherInteriorCheckBox.TabIndex = 1;
            this.leatherInteriorCheckBox.Text = "Leather &Interior";
            this.toolTip1.SetToolTip(this.leatherInteriorCheckBox, "Click to add Leather Interior option to your car");
            this.leatherInteriorCheckBox.UseVisualStyleBackColor = true;
            // 
            // computerNavigationCheckBox
            // 
            this.computerNavigationCheckBox.AutoSize = true;
            this.computerNavigationCheckBox.Location = new System.Drawing.Point(6, 104);
            this.computerNavigationCheckBox.Name = "computerNavigationCheckBox";
            this.computerNavigationCheckBox.Size = new System.Drawing.Size(125, 17);
            this.computerNavigationCheckBox.TabIndex = 2;
            this.computerNavigationCheckBox.Text = "Computer &Navigation";
            this.toolTip1.SetToolTip(this.computerNavigationCheckBox, "Click to add Computer Navigation option to your car");
            this.computerNavigationCheckBox.UseVisualStyleBackColor = true;
            // 
            // exteriorFinishGroupBox
            // 
            this.exteriorFinishGroupBox.Controls.Add(this.customizedDetailingRadioButton);
            this.exteriorFinishGroupBox.Controls.Add(this.peralizedRadioButton);
            this.exteriorFinishGroupBox.Controls.Add(this.standardRadioButton);
            this.exteriorFinishGroupBox.Location = new System.Drawing.Point(253, 182);
            this.exteriorFinishGroupBox.Name = "exteriorFinishGroupBox";
            this.exteriorFinishGroupBox.Size = new System.Drawing.Size(136, 140);
            this.exteriorFinishGroupBox.TabIndex = 5;
            this.exteriorFinishGroupBox.TabStop = false;
            this.exteriorFinishGroupBox.Text = "Exterior Finish";
            // 
            // customizedDetailingRadioButton
            // 
            this.customizedDetailingRadioButton.AutoSize = true;
            this.customizedDetailingRadioButton.Checked = true;
            this.customizedDetailingRadioButton.Location = new System.Drawing.Point(6, 117);
            this.customizedDetailingRadioButton.Name = "customizedDetailingRadioButton";
            this.customizedDetailingRadioButton.Size = new System.Drawing.Size(123, 17);
            this.customizedDetailingRadioButton.TabIndex = 2;
            this.customizedDetailingRadioButton.TabStop = true;
            this.customizedDetailingRadioButton.Text = "Customized &Detailing";
            this.toolTip1.SetToolTip(this.customizedDetailingRadioButton, "Click to add Customized Detailing Exterior Finish to your car");
            this.customizedDetailingRadioButton.UseVisualStyleBackColor = true;
            this.customizedDetailingRadioButton.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // peralizedRadioButton
            // 
            this.peralizedRadioButton.AutoSize = true;
            this.peralizedRadioButton.Location = new System.Drawing.Point(6, 74);
            this.peralizedRadioButton.Name = "peralizedRadioButton";
            this.peralizedRadioButton.Size = new System.Drawing.Size(68, 17);
            this.peralizedRadioButton.TabIndex = 1;
            this.peralizedRadioButton.Text = "&Pearlized";
            this.toolTip1.SetToolTip(this.peralizedRadioButton, "Click to add Pearlized Exterior Finish to your car");
            this.peralizedRadioButton.UseVisualStyleBackColor = true;
            this.peralizedRadioButton.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // standardRadioButton
            // 
            this.standardRadioButton.AutoSize = true;
            this.standardRadioButton.Location = new System.Drawing.Point(6, 31);
            this.standardRadioButton.Name = "standardRadioButton";
            this.standardRadioButton.Size = new System.Drawing.Size(68, 17);
            this.standardRadioButton.TabIndex = 0;
            this.standardRadioButton.Text = "S&tandard";
            this.toolTip1.SetToolTip(this.standardRadioButton, "Click to add Standard Exterior Finish to your car");
            this.standardRadioButton.UseVisualStyleBackColor = true;
            this.standardRadioButton.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // BasePriceLabel
            // 
            this.BasePriceLabel.AutoSize = true;
            this.BasePriceLabel.Location = new System.Drawing.Point(30, 43);
            this.BasePriceLabel.Name = "BasePriceLabel";
            this.BasePriceLabel.Size = new System.Drawing.Size(55, 13);
            this.BasePriceLabel.TabIndex = 0;
            this.BasePriceLabel.Text = "BasePrice";
            this.BasePriceLabel.Click += new System.EventHandler(this.carSalesPriceLabel_Click);
            // 
            // AdditionalOptionsLabel
            // 
            this.AdditionalOptionsLabel.AutoSize = true;
            this.AdditionalOptionsLabel.Location = new System.Drawing.Point(10, 75);
            this.AdditionalOptionsLabel.Name = "AdditionalOptionsLabel";
            this.AdditionalOptionsLabel.Size = new System.Drawing.Size(92, 13);
            this.AdditionalOptionsLabel.TabIndex = 9;
            this.AdditionalOptionsLabel.Text = "Additional Options";
            this.AdditionalOptionsLabel.Click += new System.EventHandler(this.accessoriesFinishLabel_Click);
            // 
            // subtotalLabel
            // 
            this.subtotalLabel.AutoSize = true;
            this.subtotalLabel.Location = new System.Drawing.Point(39, 119);
            this.subtotalLabel.Name = "subtotalLabel";
            this.subtotalLabel.Size = new System.Drawing.Size(46, 13);
            this.subtotalLabel.TabIndex = 11;
            this.subtotalLabel.Text = "Subtotal";
            this.subtotalLabel.Click += new System.EventHandler(this.subtotalLabel_Click);
            // 
            // salesTaxLabel
            // 
            this.salesTaxLabel.AutoSize = true;
            this.salesTaxLabel.Location = new System.Drawing.Point(20, 157);
            this.salesTaxLabel.Name = "salesTaxLabel";
            this.salesTaxLabel.Size = new System.Drawing.Size(86, 13);
            this.salesTaxLabel.TabIndex = 13;
            this.salesTaxLabel.Text = "Sales Tax (15%):";
            this.salesTaxLabel.Click += new System.EventHandler(this.salesTaxLabel_Click);
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Location = new System.Drawing.Point(46, 198);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(31, 13);
            this.totalLabel.TabIndex = 15;
            this.totalLabel.Text = "Total";
            this.totalLabel.Click += new System.EventHandler(this.totalLabel_Click);
            // 
            // tradeInAllowanceLabel
            // 
            this.tradeInAllowanceLabel.AutoSize = true;
            this.tradeInAllowanceLabel.Location = new System.Drawing.Point(12, 242);
            this.tradeInAllowanceLabel.Name = "tradeInAllowanceLabel";
            this.tradeInAllowanceLabel.Size = new System.Drawing.Size(99, 13);
            this.tradeInAllowanceLabel.TabIndex = 2;
            this.tradeInAllowanceLabel.Text = "T&rade-In Allowance";
            this.tradeInAllowanceLabel.Click += new System.EventHandler(this.tradeInAllowanceLabel_Click);
            // 
            // amountDueLabel
            // 
            this.amountDueLabel.AutoSize = true;
            this.amountDueLabel.Location = new System.Drawing.Point(29, 283);
            this.amountDueLabel.Name = "amountDueLabel";
            this.amountDueLabel.Size = new System.Drawing.Size(66, 13);
            this.amountDueLabel.TabIndex = 17;
            this.amountDueLabel.Text = "Amount Due";
            this.amountDueLabel.Click += new System.EventHandler(this.amountDueLabel_Click);
            // 
            // carSalesPriceTextBox
            // 
            this.carSalesPriceTextBox.Location = new System.Drawing.Point(119, 40);
            this.carSalesPriceTextBox.Name = "carSalesPriceTextBox";
            this.carSalesPriceTextBox.Size = new System.Drawing.Size(103, 20);
            this.carSalesPriceTextBox.TabIndex = 1;
            this.toolTip1.SetToolTip(this.carSalesPriceTextBox, "How much the car is selling for");
            // 
            // accessoriesFinishTextBox
            // 
            this.accessoriesFinishTextBox.Location = new System.Drawing.Point(119, 75);
            this.accessoriesFinishTextBox.Name = "accessoriesFinishTextBox";
            this.accessoriesFinishTextBox.ReadOnly = true;
            this.accessoriesFinishTextBox.Size = new System.Drawing.Size(103, 20);
            this.accessoriesFinishTextBox.TabIndex = 10;
            this.accessoriesFinishTextBox.TabStop = false;
            // 
            // subtotalTextBox
            // 
            this.subtotalTextBox.Location = new System.Drawing.Point(119, 116);
            this.subtotalTextBox.Name = "subtotalTextBox";
            this.subtotalTextBox.ReadOnly = true;
            this.subtotalTextBox.Size = new System.Drawing.Size(103, 20);
            this.subtotalTextBox.TabIndex = 12;
            this.subtotalTextBox.TabStop = false;
            // 
            // salesTaxTextBox
            // 
            this.salesTaxTextBox.Location = new System.Drawing.Point(119, 157);
            this.salesTaxTextBox.Name = "salesTaxTextBox";
            this.salesTaxTextBox.ReadOnly = true;
            this.salesTaxTextBox.Size = new System.Drawing.Size(103, 20);
            this.salesTaxTextBox.TabIndex = 14;
            this.salesTaxTextBox.TabStop = false;
            // 
            // totalTextBox
            // 
            this.totalTextBox.Location = new System.Drawing.Point(119, 198);
            this.totalTextBox.Name = "totalTextBox";
            this.totalTextBox.ReadOnly = true;
            this.totalTextBox.Size = new System.Drawing.Size(103, 20);
            this.totalTextBox.TabIndex = 16;
            this.totalTextBox.TabStop = false;
            // 
            // tradeInAllowanceTextBox
            // 
            this.tradeInAllowanceTextBox.Location = new System.Drawing.Point(119, 239);
            this.tradeInAllowanceTextBox.Name = "tradeInAllowanceTextBox";
            this.tradeInAllowanceTextBox.Size = new System.Drawing.Size(103, 20);
            this.tradeInAllowanceTextBox.TabIndex = 3;
            this.toolTip1.SetToolTip(this.tradeInAllowanceTextBox, "How much the car you are trading in is worth");
            // 
            // amountDueTextBox
            // 
            this.amountDueTextBox.Location = new System.Drawing.Point(119, 280);
            this.amountDueTextBox.Name = "amountDueTextBox";
            this.amountDueTextBox.ReadOnly = true;
            this.amountDueTextBox.Size = new System.Drawing.Size(103, 20);
            this.amountDueTextBox.TabIndex = 18;
            this.amountDueTextBox.TabStop = false;
            // 
            // autoCentreForm
            // 
            this.AcceptButton = this.calculateButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitButton;
            this.ClientSize = new System.Drawing.Size(389, 353);
            this.Controls.Add(this.amountDueTextBox);
            this.Controls.Add(this.tradeInAllowanceTextBox);
            this.Controls.Add(this.totalTextBox);
            this.Controls.Add(this.salesTaxTextBox);
            this.Controls.Add(this.subtotalTextBox);
            this.Controls.Add(this.accessoriesFinishTextBox);
            this.Controls.Add(this.carSalesPriceTextBox);
            this.Controls.Add(this.amountDueLabel);
            this.Controls.Add(this.tradeInAllowanceLabel);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.salesTaxLabel);
            this.Controls.Add(this.subtotalLabel);
            this.Controls.Add(this.AdditionalOptionsLabel);
            this.Controls.Add(this.BasePriceLabel);
            this.Controls.Add(this.exteriorFinishGroupBox);
            this.Controls.Add(this.accessoriesGroupBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calculateButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "autoCentreForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Auto Centre";
            this.Load += new System.EventHandler(this.autoCentreForm_Load);
            this.accessoriesGroupBox.ResumeLayout(false);
            this.accessoriesGroupBox.PerformLayout();
            this.exteriorFinishGroupBox.ResumeLayout(false);
            this.exteriorFinishGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.GroupBox accessoriesGroupBox;
        private System.Windows.Forms.CheckBox stereoSystemCheckBox;
        private System.Windows.Forms.CheckBox leatherInteriorCheckBox;
        private System.Windows.Forms.CheckBox computerNavigationCheckBox;
        private System.Windows.Forms.GroupBox exteriorFinishGroupBox;
        private System.Windows.Forms.RadioButton customizedDetailingRadioButton;
        private System.Windows.Forms.RadioButton peralizedRadioButton;
        private System.Windows.Forms.RadioButton standardRadioButton;
        private System.Windows.Forms.Label BasePriceLabel;
        private System.Windows.Forms.Label AdditionalOptionsLabel;
        private System.Windows.Forms.Label subtotalLabel;
        private System.Windows.Forms.Label salesTaxLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label tradeInAllowanceLabel;
        private System.Windows.Forms.Label amountDueLabel;
        private System.Windows.Forms.TextBox carSalesPriceTextBox;
        private System.Windows.Forms.TextBox accessoriesFinishTextBox;
        private System.Windows.Forms.TextBox subtotalTextBox;
        private System.Windows.Forms.TextBox salesTaxTextBox;
        private System.Windows.Forms.TextBox totalTextBox;
        private System.Windows.Forms.TextBox tradeInAllowanceTextBox;
        private System.Windows.Forms.TextBox amountDueTextBox;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

