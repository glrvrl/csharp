using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// diziden kelime seçerek verilan hak kadar tahminde kelime buldurmya çalışan uygulama
namespace KelimeTahminUyg
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> kelimeler = new List<string> { "araba","elma","ağaç"};

            Random random = new Random();
            string secilenkelime = kelimeler[random.Next(kelimeler.Count - 1)].ToLower();
            List<char> skarray = new List<char>();
            Console.WriteLine($"{secilenkelime} seçildi");

            Console.Write("Tahmin hak sayısı giriniz: ");
            int hak = Convert.ToInt32(Console.ReadLine());
            int sayac = 0;
            string maskelimetin = "";

            foreach (var harf in secilenkelime)
            {
                skarray.Add(harf);
                maskelimetin += "_";
            }

            Console.WriteLine(maskelimetin);
            
            while (sayac<hak)
            {
                Console.Write("Tahmininizi giriniz: ");
                string tahminharf = Console.ReadLine().ToLower();

                StringBuilder sb = new StringBuilder(tahminharf);
                Console.WriteLine(sb[1]);

                if(tahminharf != null)
                {
                    int konum = secilenkelime.IndexOf(tahminharf);
                    if (konum>=0)
                    {
                        Console.WriteLine($"Tebrikler tahmin: {tahminharf} kelimede bulunuyor");

                        for (int i = 0; i < secilenkelime.Length; i++)
                        {
                            if(secilenkelime[i].Equals(tahminharf))
                            {
                                //skarray[i] = tahminharf.ToCharArray();
                            }
                            
                        }

                    } else
                    {
                        Console.WriteLine($"Maalesef tahmin: {tahminharf} kelimede bulunmuyor !!!");
                    }
                    
                    sayac++;

                    Console.WriteLine($"Kalan hakkınız {hak-sayac}");
                }

                
            }


            Console.ReadLine();
        }
    }
}
