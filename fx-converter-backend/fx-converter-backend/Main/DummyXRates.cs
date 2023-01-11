using fx_converter_backend.Engine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fx_converter_backend.Main
{
    public static class DummyXRates
    {
        public static readonly Dictionary<CurrencyEnum, double> XRates = new Dictionary<CurrencyEnum, double>()
        {
            { CurrencyEnum.GBP, 0.719154 },
            { CurrencyEnum.EUR, 0.806942 },
            { CurrencyEnum.CHF, 0.933058 },
            { CurrencyEnum.CAD, 1.260046 },
            { CurrencyEnum.USD, 1 },
        };
    }
}
