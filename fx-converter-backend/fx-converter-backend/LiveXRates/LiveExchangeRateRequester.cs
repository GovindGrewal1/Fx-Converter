using fx_converter_backend.NewFolder;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fx_converter_backend.LiveXRates
{
    public class LiveExchangeRateRequester
    {
        public LiveExchangeRateRequester()
        {
            var client = new RestClient("https://api.apilayer.com/fixer/latest?symbols=GBP%2CEUR%2cJPY&base=EUR");

            var request = new RestRequest();
            request.AddHeader("apikey", "8gbyeifJxOG3cB94TEPjZ70aL6zeY17S");

            var response = client.Execute(request);
            Console.WriteLine(response.Content);
            int banana = 0;

            XRatesResponse desresponse = JsonConvert.DeserializeObject<XRatesResponse>(response.Content);
        }
    }
}
