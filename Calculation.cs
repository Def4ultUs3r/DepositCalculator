using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepositCalculator
{

    public enum Currencies
    {
        UAH = 0,
        USD = 1,
        EUR = 2
    }

    internal class Calculation
    { 
        private decimal amountOfMoney;
        private decimal rate;
        private decimal monthCount;
        private bool isCapitalization;
        private int currency;
        private decimal result = 0;
        //курс НБУ на 02.06.2022
        private decimal valUAH = 1;
        private decimal valUSD = 29.2549m;
        private decimal valEUR = 31.3247m;


        public decimal AmountOfMoney  { get => amountOfMoney; set => amountOfMoney = value; }
        public decimal Rate { get => rate; set => rate = value; }
        public decimal MonthCount { get => monthCount; set => monthCount = value; }
        public bool IsCapitalization { get => isCapitalization; set => isCapitalization = value; }
        public int Currency { get => currency; set => currency = value; }
        public decimal ValUAH { get => valUAH; set => valUAH = value; }
        public decimal ValUSD { get => valUSD; set => valUSD = value; }
        public decimal ValEUR { get => valEUR; set => valEUR = value; }
        public decimal Result { get => result; set => result = value; }

        public Calculation()
        {
            amountOfMoney = 0;
            rate = 0;
            monthCount = 0;
            isCapitalization = false;
            currency = (int)Currencies.UAH;
        }

        public Calculation(decimal _amountOfMoney, decimal _rate, decimal _monthCount, bool _isCapitalization,
                                int _currency)
        {
            AmountOfMoney = _amountOfMoney;
            Rate = _rate/100.00m;
            MonthCount = _monthCount;
            IsCapitalization = _isCapitalization;
            Currency = _currency;            
        }

        public decimal ExpectedIncomeCalculation()
        {
            Result = 0;
           
            if(isCapitalization)
            {
                // количество периодов начисления процентов за полный год
                decimal interestPeriods = 12;
                decimal amountOfIncome = 1;
                decimal tempCalc = 1 + (Rate / interestPeriods);
                for(int i = 0; i < (int)MonthCount; i++)
                {
                    amountOfIncome = amountOfIncome * tempCalc;
                }
                
                Result = AmountOfMoney * amountOfIncome;
                    

            }
            else 
            {
                Result = AmountOfMoney + ((AmountOfMoney * Rate * MonthCount) / 12.00m);                
            }           

            return Result;
        }

        public decimal ResultInCurrency(decimal _result)
        {
            switch (Currency)
            {
                case ((int)Currencies.UAH):
                    _result *= ValUAH;
                    break;
                case ((int)Currencies.USD):
                    _result *= ValUSD;
                    break;
                case ((int)Currencies.EUR):
                    _result *= ValEUR;
                    break;
                default:
                    break;
            }
            return _result;
        }


    }
}
