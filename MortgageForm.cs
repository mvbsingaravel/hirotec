using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class MortgageForm : Form
    {
        private readonly MortgageDataContext _context;

        public MortgageForm()
        {
            InitializeComponent();
            _context = new MortgageDataContext();
        }

        private void MortgageForm_Load(object sender, EventArgs e)
        {
            var mortgages = _context.Mortgages.Where(m => m.IsActive).OrderBy(m => m.Type).ThenBy(m => m.InterestRate);
            mortgageDataGridView.DataSource = mortgages.ToList();

            var mortgageTypes = _context.Mortgages.Select(m => m.Type).Distinct().ToList();
            mortgageTypeComboBox.DataSource = mortgageTypes;
            mortgageTypeComboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            mortgageTypeComboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(mortgageTypeComboBox.Text))
                {
                    throw new Exception("Please select mortgage type!");
                }
                if (String.IsNullOrEmpty(loanAmountTextBox.Text))
                {
                    throw new Exception("Please provide loan amount!");
                }
                if (String.IsNullOrEmpty(interestRateTextBox.Text))
                {
                    throw new Exception("Please provide Rate of interest!");
                }
                if (String.IsNullOrEmpty(loanDurationTextBox.Text))
                {
                    throw new Exception("Please provide loan duration!");
                }
                var loanAmount = decimal.Parse(loanAmountTextBox.Text);
                var interestRate = decimal.Parse(interestRateTextBox.Text);
                var loanDuration = int.Parse(loanDurationTextBox.Text);

                var mortgageType = mortgageTypeComboBox.SelectedItem.ToString();
                var mortgage = _context.Mortgages.FirstOrDefault(m => m.Type == mortgageType);

                if (mortgage != null)
                {
                    var totalRepayment = CalculateTotalRepayment(loanAmount, interestRate, loanDuration, mortgage.InterestRate);
                    var interestPaid = CalculateInterestPaid(loanAmount, interestRate, loanDuration, mortgage.InterestRate);

                    totalRepaymentLabel.Text = $"Total Repayment: {totalRepayment:C}";
                    interestPaidLabel.Text = $"Interest Paid: {interestPaid:C}";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Morgage Calculator",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                
        }

        private decimal CalculateTotalRepayment(decimal loanAmount, decimal interestRate, int loanDuration, decimal mortgageInterestRate)
        {
            var monthlyInterestRate = (interestRate / 100) / 12;
            var numberOfPayments = loanDuration * 12;

            //var totalRepayment = (double)loanAmount * ((double)monthlyInterestRate * Math.Pow((double)(1 + (double)monthlyInterestRate), numberOfPayments)) / (Math.Pow((double)1 + (double)monthlyInterestRate, numberOfPayments) - 1);
            var totalRepayment = loanAmount + loanAmount * (interestRate / 100) * loanDuration;
            return (decimal)totalRepayment;
        }

        private decimal CalculateInterestPaid(decimal loanAmount, decimal interestRate, int loanDuration, decimal mortgageInterestRate)
        {
            //var monthlyInterestRate = (interestRate / 100) / 12;
            //var numberOfPayments = loanDuration * 12;

            //var totalRepayment = CalculateTotalRepayment(loanAmount, interestRate, loanDuration, mortgageInterestRate);
            //var principalPaid = loanAmount + (totalRepayment - loanAmount);

            var interestPaid = CalculateTotalRepayment(loanAmount, interestRate, loanDuration, mortgageInterestRate) - loanAmount;

            return interestPaid;
        }

       
    }
}
