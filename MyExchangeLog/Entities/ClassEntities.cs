using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Entities
{
    public class ClassEntities
    {
        private string _timestamp;
        private string _license;
        private string _disclaimer;
        private string _base;
        private string _rate;

        public ClassEntities()
        {
        }

        public string TimeStamp
        {
            get { return _timestamp; }
            set { _timestamp = value; }
        }

        public string License
        {
            get { return _license; }
            set { _license = value; }
        }

        public string Disclaimer
        {
            get { return _disclaimer; }
            set { _disclaimer = value; }
        }

        public string Base
        {
            get { return _base; }
            set { _base = value; }
        }

        public string Rate
        {
            get { return _rate; }
            set
            {
                _rate = value; //ny metode der kalder class der kan holde landekode og rate + list af class }
            }
        }

        private List<ClassRates> _ratesList;

        public List<ClassRates> ratesList
        {
            get { return _ratesList; }
            set { _ratesList = value; }
        }

        private void FillListWithRates()
        {
            string[] ValueArray = Rate.Split(',');
            foreach (string rate in ValueArray)
            {
                string[] ValueArraySplitTwice = rate.Split(':');
                foreach (string item in ValueArraySplitTwice)
                {
                    ClassRates CRates = new ClassRates();
                }
            }
        }
    }
}
