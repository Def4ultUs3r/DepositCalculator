using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepositCalculator
{
    internal class CurrenciesData
    {
        private List<CurrencyRate> currRates = new List<CurrencyRate>();

        public List<CurrencyRate> CurrRates { get => currRates; set => currRates = value; }

        public CurrenciesData()
        {
            GetCurrenciesData();
        }
        private void GetCurrenciesData()
        {
            string date = DateTime.Now.ToString("yyyyMMdd");
            string URI = $"https://bank.gov.ua/NBUStatService/v1/statdirectory/exchange?date={date}&json";

            string webResponseString = Web.GetWebContent(URI);

            // Список объектов типа CurrencyRate
            if(webResponseString != null)   
            CurrRates = JsonConvert.DeserializeObject<List<CurrencyRate>>(webResponseString);
        }
    }
}
