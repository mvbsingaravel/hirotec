namespace WinFormsApp1
{
    partial class MortgageForm
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
            mortgageDataGridView = new DataGridView();
            mortgageTypeComboBox = new ComboBox();
            loanAmountTextBox = new TextBox();
            interestRateTextBox = new TextBox();
            loanDurationTextBox = new TextBox();
            calculateButton = new Button();
            totalRepaymentLabel = new Label();
            interestPaidLabel = new Label();
            lbl_type = new Label();
            lbl_interestrate = new Label();
            lbl_loanamount = new Label();
            lbl_duration = new Label();
            ((System.ComponentModel.ISupportInitialize)mortgageDataGridView).BeginInit();
            SuspendLayout();
            // 
            // mortgageDataGridView
            // 
            mortgageDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            mortgageDataGridView.Location = new Point(14, 14);
            mortgageDataGridView.Margin = new Padding(4, 3, 4, 3);
            mortgageDataGridView.Name = "mortgageDataGridView";
            mortgageDataGridView.Size = new Size(905, 173);
            mortgageDataGridView.TabIndex = 0;
           
            // 
            // mortgageTypeComboBox
            // 
            mortgageTypeComboBox.FormattingEnabled = true;
            mortgageTypeComboBox.Location = new Point(116, 196);
            mortgageTypeComboBox.Margin = new Padding(4, 3, 4, 3);
            mortgageTypeComboBox.Name = "mortgageTypeComboBox";
            mortgageTypeComboBox.Size = new Size(140, 23);
            mortgageTypeComboBox.TabIndex = 1;
            // 
            // loanAmountTextBox
            // 
            loanAmountTextBox.Location = new Point(116, 225);
            loanAmountTextBox.Margin = new Padding(4, 3, 4, 3);
            loanAmountTextBox.Name = "loanAmountTextBox";
            loanAmountTextBox.Size = new Size(140, 23);
            loanAmountTextBox.TabIndex = 2;
            // 
            // interestRateTextBox
            // 
            interestRateTextBox.Location = new Point(116, 254);
            interestRateTextBox.Margin = new Padding(4, 3, 4, 3);
            interestRateTextBox.Name = "interestRateTextBox";
            interestRateTextBox.Size = new Size(140, 23);
            interestRateTextBox.TabIndex = 3;
            // 
            // loanDurationTextBox
            // 
            loanDurationTextBox.Location = new Point(116, 283);
            loanDurationTextBox.Margin = new Padding(4, 3, 4, 3);
            loanDurationTextBox.Name = "loanDurationTextBox";
            loanDurationTextBox.Size = new Size(140, 23);
            loanDurationTextBox.TabIndex = 4;
            // 
            // calculateButton
            // 
            calculateButton.Location = new Point(290, 285);
            calculateButton.Margin = new Padding(4, 3, 4, 3);
            calculateButton.Name = "calculateButton";
            calculateButton.Size = new Size(88, 27);
            calculateButton.TabIndex = 5;
            calculateButton.Text = "Calculate";
            calculateButton.UseVisualStyleBackColor = true;
            calculateButton.Click += calculateButton_Click;
            // 
            // totalRepaymentLabel
            // 
            totalRepaymentLabel.AutoSize = true;
            totalRepaymentLabel.Location = new Point(14, 348);
            totalRepaymentLabel.Margin = new Padding(4, 0, 4, 0);
            totalRepaymentLabel.Name = "totalRepaymentLabel";
            totalRepaymentLabel.Size = new Size(101, 15);
            totalRepaymentLabel.TabIndex = 6;
            totalRepaymentLabel.Text = "Total Repayment: ";
            // 
            // interestPaidLabel
            // 
            interestPaidLabel.AutoSize = true;
            interestPaidLabel.Location = new Point(16, 378);
            interestPaidLabel.Margin = new Padding(4, 0, 4, 0);
            interestPaidLabel.Name = "interestPaidLabel";
            interestPaidLabel.Size = new Size(78, 15);
            interestPaidLabel.TabIndex = 7;
            interestPaidLabel.Text = "Interest Paid: ";
            // 
            // lbl_type
            // 
            lbl_type.AutoSize = true;
            lbl_type.Location = new Point(14, 199);
            lbl_type.Name = "lbl_type";
            lbl_type.Size = new Size(31, 15);
            lbl_type.TabIndex = 8;
            lbl_type.Text = "Type";
            // 
            // lbl_interestrate
            // 
            lbl_interestrate.AutoSize = true;
            lbl_interestrate.Location = new Point(14, 267);
            lbl_interestrate.Name = "lbl_interestrate";
            lbl_interestrate.Size = new Size(26, 15);
            lbl_interestrate.TabIndex = 9;
            lbl_interestrate.Text = "ROI";
            // 
            // lbl_loanamount
            // 
            lbl_loanamount.AutoSize = true;
            lbl_loanamount.Location = new Point(14, 233);
            lbl_loanamount.Name = "lbl_loanamount";
            lbl_loanamount.Size = new Size(80, 15);
            lbl_loanamount.TabIndex = 9;
            lbl_loanamount.Text = "Loan Amount";
            // 
            // lbl_duration
            // 
            lbl_duration.AutoSize = true;
            lbl_duration.Location = new Point(14, 291);
            lbl_duration.Name = "lbl_duration";
            lbl_duration.Size = new Size(91, 15);
            lbl_duration.TabIndex = 10;
            lbl_duration.Text = "Duration (Years)";
            // 
            // MortgageForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 519);
            Controls.Add(lbl_duration);
            Controls.Add(lbl_loanamount);
            Controls.Add(lbl_interestrate);
            Controls.Add(lbl_type);
            Controls.Add(interestPaidLabel);
            Controls.Add(totalRepaymentLabel);
            Controls.Add(calculateButton);
            Controls.Add(loanDurationTextBox);
            Controls.Add(interestRateTextBox);
            Controls.Add(loanAmountTextBox);
            Controls.Add(mortgageTypeComboBox);
            Controls.Add(mortgageDataGridView);
            Margin = new Padding(4, 3, 4, 3);
            Name = "MortgageForm";
            Text = "Mortgage Calculator";
            Load += MortgageForm_Load;
            ((System.ComponentModel.ISupportInitialize)mortgageDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView mortgageDataGridView;
        private System.Windows.Forms.ComboBox mortgageTypeComboBox;
        private System.Windows.Forms.TextBox loanAmountTextBox;
        private System.Windows.Forms.TextBox interestRateTextBox;
        private System.Windows.Forms.TextBox loanDurationTextBox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label totalRepaymentLabel;
        private System.Windows.Forms.Label interestPaidLabel;
        private Label lbl_type;
        private Label lbl_interestrate;
        private Label lbl_loanamount;
        private Label lbl_duration;
    }
}