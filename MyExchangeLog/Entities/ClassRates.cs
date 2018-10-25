using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class ClassRates
    {
        private string _countryCode;

        public string countryCode
        {
            get { return _countryCode; }
            set { _countryCode = value; }
        }
        private string _rateValue;

        public string rateValue
        {
            get { return _rateValue; }
            set { _rateValue = value; }
        }

    }
}
