namespace DepositCalculator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            cbCurrency.SelectedIndex = 0;
            cbMethod.SelectedIndex = 0;
        }

        private void bCalc_Click(object sender, EventArgs e)
        {
            Calculation calc = new Calculation(nudSum.Value, nudRate.Value, nudPeriod.Value, 
                                                        cbMethod.SelectedIndex == 0 ? false : true, 
                                                                            cbCurrency.SelectedIndex);
            tbResult.Text = calc.ExpectedIncomeCalculation().ToString("F2") + " " + cbCurrency.SelectedItem.ToString();
            tbResInCurrency.Text = calc.ResultInCurrency(calc.Result).ToString("F2") + " UAH";
        }
    }
}