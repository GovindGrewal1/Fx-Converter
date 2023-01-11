using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fx_converter_backend.NewFolder
{
    public class XRatesResponse
    {
        public string success { get; set; }
        public string timestamp { get; set; }
        public string date { get; set; }
        public Rates rates { get; set; }
    }
    public class Rates
    {
        public string GBP { get; set; }
        public string EUR { get; set; }
        public string JPY { get; set; }
    }
}
