using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using BizLayer;
using Entities;
using Newtonsoft.Json;

namespace ManuelTestProjekt
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassEntities CEntities = new ClassEntities();
            using (var webClient = new System.Net.WebClient())
            {
                string rawJSON = new WebClient().DownloadString("https://openexchangerates.org/api/latest.json?app_id=4e1ebea12d2e4f5eb2849d83044a2d76&base=USD");
                CEntities = JsonConvert.DeserializeObject<ClassEntities>(rawJSON);
                Console.WriteLine(CEntities.Rate);
            }
            ClassBiz CBiz = new ClassBiz();
            string sample = CBiz.GetUsdPriceFromApi();
            Console.WriteLine(sample);
            Console.ReadLine();
        }
    }
}
