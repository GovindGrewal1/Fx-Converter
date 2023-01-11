using fx_converter_backend.Engine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fx_converter_backend.Main
{
    public static class XRatesEngine
    {
        public static ConvertedObject GetConvertedObject(CurrencyEnum currencyFrom, CurrencyEnum currencyTo, double amount)
        {
            double conversion = DummyXRates.XRates[currencyTo] / DummyXRates.XRates[currencyFrom];
            return new ConvertedObject(conversion* amount, currencyTo);
        }
    }
    public class ConvertedObject
    {
        public ConvertedObject(double amount, CurrencyEnum currency)
        {
            Amount = amount;
            Currency= currency;
        }
        public double Amount;
        public CurrencyEnum Currency;
    }
}
