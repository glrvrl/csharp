using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnuvaAppV1
{
    class Program
    {
        static void Main(string[] args)
        {
            //başlangıç 16:35

            Dictionary<string, string> takimlar = new Dictionary<string, string>(); // { "Türkiye"="Türkiye"};
            takimlar.Add("Türkiye", "Türkiye");
            takimlar.Add("Almanya", "Almanya");
            takimlar.Add("Fransa", "Fransa");
            takimlar.Add("Bulgaristan", "Bulgaristan");

            Dictionary<string, string> hakemler = new Dictionary<string, string>();
            hakemler.Add("Türkiye", "Türk");
            hakemler.Add("Almanya", "Alman");
            hakemler.Add("Fransa", "Fransız");
            hakemler.Add("Bulgaristan", "Bulgar");

            List<string> eslesme = new List<string>();

            Random rnd = new Random();
            int rastgele = rnd.Next(takimlar.Count);

            for (int i = 0; i < takimlar.Count/2; i++)
            {
                for (int i = 0; i < hakemler.Count; i++)
                {

                }
            }


        }
    }

    class Takim
    {
        public string Name { get; set; }
        public string Country { get; set; }
    }

    class Hakem
    {
        public string Name { get; set; }
        public string Country { get; set; }
    }   
}
