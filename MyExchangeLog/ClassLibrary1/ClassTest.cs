using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace ClassLibrary1
{
    public class ClassTest
    {
        private DateTime _timestamp;
        private string _license;
        private string _disclaimer;
        private string _base;

        
        public void GetValutaDataAsObject()
        {
            using (var webClient = new System.Net.WebClient())
            {
                var json = new WebClient().DownloadString("https://openexchangerates.org/api/");
            }
        }
        public DateTime TimeStamp
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
        private string _rate;

        public string Rate
        {
            get { return _rate; }
            set { _rate = value; }
        }
    }
}
