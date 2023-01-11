using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using fx_converter_backend.Engine;
using fx_converter_backend.Main;

namespace fx_converter_backend
{
    public static class FxConverter
    {
        [FunctionName("FxConverter")]
        public static async Task<object> Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", "post", Route = null)] HttpRequest req,
            ILogger log)
        {
            if(!Double.TryParse(req.Query["amount"], out double amount))
            {
                return new BadRequestObjectResult($"Unrecognised currency: {req.Query["inputCurrency"]}");
            }
            if (!Enum.TryParse(req.Query["inputCurrency"], out CurrencyEnum inputCurrency))
            {
                return new BadRequestObjectResult($"Unrecognised currency: {req.Query["inputCurrency"]}");
            }
            if (!Enum.TryParse(req.Query["outputCurrency"], out CurrencyEnum outputCurrency))
            {
                return new BadRequestObjectResult($"Unrecognised currency: {req.Query["outputCurrency"]}");
            }

            ConvertedObject converted = XRatesEngine.GetConvertedObject(inputCurrency, outputCurrency, amount);
            return converted;
        }
    }
}
