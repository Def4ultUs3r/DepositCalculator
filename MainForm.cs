namespace DepositCalculator
{
    public partial class MainForm : Form
    {
        CurrenciesData currData = new CurrenciesData();
        public MainForm()
        {
            InitializeComponent();           
            
            if(currData.CurrRates != null && currData.CurrRates?.Count > 0)
            {
                cbCurrency.Items.Clear();
                foreach(var curr  in currData.CurrRates)
                {
                    cbCurrency.Items.Add(curr.cc);
                }
                
            }

            cbCurrency.SelectedIndex = 0;
            cbMethod.SelectedIndex = 0;
        }

        private void bCalc_Click(object sender, EventArgs e)
        {
            Calculation calc = new Calculation(nudSum.Value, nudRate.Value, nudPeriod.Value, 
                                                        cbMethod.SelectedIndex == 0 ? false : true, 
                                                                            cbCurrency.SelectedIndex);
            tbResult.Text = calc.ExpectedIncomeCalculation().ToString("F2") + " " + cbCurrency.SelectedItem.ToString();
            if (currData.CurrRates != null && currData.CurrRates?.Count > 0)
                tbResInCurrency.Text = calc.ResultInCurrency(calc.Result,
                    Convert.ToDecimal(currData.CurrRates.FirstOrDefault(x => x.cc == cbCurrency.SelectedItem.ToString())?.rate)).ToString("F2") + " UAH";
            else   
                tbResInCurrency.Text = calc.ResultInDefaultCurrency(calc.Result).ToString("F2") + " UAH";
        }
    }
}