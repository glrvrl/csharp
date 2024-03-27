using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringPractices
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "turkiye.gov.tr Türkiyenin Portalı i";
            //StringUzunlukBulma(str);
            //StringKarakterAyirma(str);
            //StringTerstenAyir(str);
            //StringKelimeSay1(str);
            //StringKelimeSay2(str);
            //StringKarsilastirma1();
            //StringKopyalama(str);
            //StringSesliHarfSay(str);
            //StringEncokKarakterSay(str);
            //StringSiralanmisAyrilmisChr(str);
            //StringGirilenMetinleriSiralama();
            //StringIstenenIndexAlma(str);
            //StringKarakterleriBuyukKucukTersleyen(str);

            Console.ReadLine();
        }

        private static void StringKarakterleriBuyukKucukTersleyen(string str)
        {
            Console.WriteLine($"Giriş metni : {str}");

            string sonuc = "";
            foreach (var item in str)
            {
                if (item.ToString().ToUpperInvariant() != item.ToString().ToLowerInvariant())
                {
                    if (item.ToString() == item.ToString().ToLowerInvariant()) sonuc += item.ToString().ToUpperInvariant();
                    if (item.ToString() == item.ToString().ToUpperInvariant()) sonuc += item.ToString().ToLowerInvariant();
                }
                else sonuc += item.ToString();
            }

            Console.WriteLine($"Sonuç : {sonuc}");
        }

        private static void StringIstenenIndexAlma(string str)
        {
            Console.WriteLine($"{str} den başlangıç veriniz... \n Başlangıç :");
            int basIndex = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{str} den uzunluk veriniz... \n Uzunluk :");
            int uzunluk = Convert.ToInt32(Console.ReadLine());

            string sonuc = "";

            if (uzunluk < str.Length && basIndex < str.Length - 1 && basIndex >= 0 && uzunluk > 0)
            {
                for (int i = basIndex; i <= basIndex + uzunluk; i++)
                {
                    sonuc += str[i];
                }
                Console.WriteLine($"Sonuç metin: {sonuc}");
            }
            else
            {
                Console.WriteLine("girişlerde hata var");
            }
        }

        private static void StringGirilenMetinleriSiralama()
        {
            Console.Write("Girilecek metin sayısı : ");
            int girisSayisi = Convert.ToInt32(Console.ReadLine());
            List<string> girisler = new List<string>();

            for (int i = 0; i < girisSayisi; i++)
            {
                Console.Write($"Giriş {i + 1} :");
                girisler.Add(Console.ReadLine());
            }
            Console.WriteLine("Giriş bitti. \n Sonuç :");
            girisler.Sort();

            foreach (var item in girisler)
            {
                Console.WriteLine(item);
            }
        }

        private static void StringSiralanmisAyrilmisChr(string str)
        {
            Console.WriteLine($"Sıralanıp listenecek string: {str.ToLower()}");
            List<char> karakterler = new List<char>();
            foreach (var chr in str.ToLower())
            {
                karakterler.Add(chr);
            }

            karakterler.Sort();

            Console.WriteLine("alfabetik sıralanmış string: ");
            foreach (var item in karakterler)
            {
                if (item != ' ') Console.Write(item + " ");

            }
        }

        private static void StringEncokKarakterSay(string str)
        {
            Console.WriteLine($"{str} içinde en çok olan karakter bulunuyor");

            int index = 0;
            int index2 = 0;
            int encok1 = 0;
            int encok2 = 0;
            char encokchr = 'a';
            while (index < str.Length)
            {
                encok1 = 0;
                index2 = 0;
                while (index2 < str.Length)
                {
                    if (str[index] == str[index2])
                    {
                        encok1++;
                        encokchr = str[index];
                    }

                    index2++;
                }

                encok2 = encok1 > encok2 ? encok1 : encok2;
                index++;
            }

            Console.WriteLine($"{str} içinde en çok olan karakter {encok2} adet {encokchr}");
        }

        private static void StringSesliHarfSay(string str)
        {
            //char[] sesliharfler = new char[8] { 'a','e','ı','i','o','ö','u','ü'};
            string sesliharfler = "aeıioöuü";
            int sayac = 0;
            foreach (var item in str)
            {
                if (sesliharfler.IndexOf(item) >= 0) sayac++;
            }

            Console.WriteLine($"{str} \n İçinde Toplam sesli harf {sayac} adet");
        }

        private static void StringKopyalama(string str)
        {
            Console.WriteLine("Kopyalanıyor");
            string str2 = (string)str.Clone(); //CopyTo(0,'', str.Length - 1, 0);
            Console.WriteLine($"{str} kopyalandı str2'ye:  {str2}");
        }

        private static void StringKarsilastirma1()
        {
            Console.Write("karşılaştıracak 1. string: ");
            string str1 = Console.ReadLine();
            Console.Write("karşılaştıracak 2. string: ");
            string str2 = Console.ReadLine();

            bool esitlik = true;

            if (str1.Length == str2.Length) Console.WriteLine("İki metin uzunluğu aynı");
            for (int i = 0; i < str1.Length; i++)
            {
                if (str1[i] != str2[i]) { esitlik = false; }
            }
            if (esitlik)
            {
                Console.WriteLine("iki metin birbirine eşit");
            }
            else
            {
                Console.WriteLine("İki metin birbirine eşit değil");
            }
        }

        private static void StringKelimeSay2(string str)
        {
            int i = str.Length;
            int kelimesayisi = 1;
            while (i > 0)
            {
                if (str[i - 1].Equals(' ') || str[i - 1].Equals('\n') || str[i - 1].Equals('\t')) kelimesayisi += 1;

                i--;
            }

            Console.WriteLine($"{str} deki Kelime Sayisi {kelimesayisi}");
        }

        private static void StringKelimeSay1(string str)
        {
            string[] kelime = str.Split(' ');
            Console.WriteLine($"{str} de {kelime.Length} kadar kelime vardır");
        }

        private static void StringTerstenAyir(string str)
        {
            char[] reversestr = str.ToArray();

            //reversestr.Reverse();
            foreach (var ch in reversestr.Reverse())
            {
                Console.Write(ch + " ");
            }
            Console.WriteLine();
        }

        private static void StringKarakterAyirma(string str)
        {

            foreach (var txt in str)
            {
                Console.Write(txt + " ");
            }
            Console.WriteLine();
        }

        private static void StringUzunlukBulma(string str)
        {
            //string lengthstr = "bu bir deneme stringidir, uzunluğunu farklı yoldan bulacağım";
            int i = 0;
            for (i = 0; i < str.Length; i++)
            {

            }

            Console.WriteLine($"{str} >> uzunluğu {i} karakterdir");
        }
    }
}
