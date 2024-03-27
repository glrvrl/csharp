using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Data.SqlClient;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Net.Http.Headers;
using System.Linq.Expressions;


namespace AppPractices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TurnuvaUygulamasi();
            //SayiTekmiCiftmi();
            //HangisiBuyuk();
            //HesapMakinesi();
            //ToplamIndırımHesapla();
            //OtoparkUcretiHesapla();
            //Sayi3BasamakliVeFarklimi();
            //KendindenOncekiSayilarinToplami();
            //BasamakSayisiniBul(1);
            //GirilenSayilariDiziOlarakAlipCarpanUyg();
            //GirilenIkiSayiArasindakiSayilarinCarpimi();
            //IstenilenAdettekiSayininIslemiYapan();
            //GirilenSayiyaKadarOlanFiboSayilari();
            //BaziStringOrnekleri();
            //TarihSaatOrnekleri();
            //DiziOgrenciNotOrt();
            //DiziOgrenciler();
            //DiziOrnekler();
            //DiziCokBoyutluOrnek();
            //DiziBinarySearch();
            //DiziReverse();
            //CokBoyutluDiziler();
            //UcBoyutDizi();
            //DiziFibonacciBulma();

            //int RastgeleSayi = RastgeleIntSayiUretenFonk(1, 300);
            //Console.WriteLine("Sayı : {0}", RastgeleSayi);

            /*
            //method overload örneği
            //ayni isim farklı parametre tipleri ve farklı hesaplama şekliyle hesaplama yapmaya denilebilir
            int yas = 13;
            int DogumYili = YasHesapla(yas);
            Console.WriteLine("{0} yaşındaki birinin doğum Yılı : {1} 'dur... Bu yaşı bilien kişinin doğum yılını integer verip integer döndürür...", yas,DogumYili);

            DateTime DogumYili1 = new DateTime(2011, 1, 1);
            int yas1 = YasHesapla(DogumYili1);
            Console.WriteLine("{0} yaşındaki birinin doğum Yılı : {1} 'dur... Bu doğum tarihi bilien kişinin doğum yılını integer döndürür...", yas1, DogumYili1.Year);
            */

            /*
            //verilen int sayının faktoriyelini hesaplayan/ int döndüren fonksiyon
            Console.Write("Faktoriyeli hesaplanacak sayıyı giriniz: ");
            Console.WriteLine("Sonuc: {0}",FaktoriyelHesaplayanFunc(int.Parse(Console.ReadLine())));
            */

            /*
            //Kendisine gönderilen 2 boyutlu dizinin elemanlarını toplayıp, sonuc döndürmeden ekrana basan uygulama
            int[,] SayiDizisi = { { 1, 2 }, { 3, 6 }, { 8,-9} };
            DiziElemanlariniTopla(SayiDizisi);
            */

            /*
            //Kendisine gönderilen iki sayının/sayi dizisinin en büyük ortak bölenini bulup ekrana yazdıran metod
            int[] sayilar = { 60, 30, 90 };
            ObebBulanUygulama(sayilar);
            */

            //AtamaOperatorleri();

            //MathYuvarlamaIslemleri();

            //Girilen Yaş bilgisine göre oy kullanabilme durumunu verecek fonksiyon, 18 yaş kontrolü
            //OyKullanabilirmi();

            //girilen hak sayısına göre sayı tahmini yapan uygulama
            //SayiTahminUygulamasi();

            //turnuva uygulaması başka versiyon
            //TurnuvaApp1();

            /*
            //OOP inheritance(kalıtım) prensibinin anlatılması, Hayvan sınıfından türetilen kedi ve köpek sınıflarında kalıtım özelliklerinin ve türetilen yeni sınıflarda tanımlanan yeni özelliklerin kullanılması
            Kedi kedi = new Kedi();
            kedi.adi = "pisicik";
            kedi.Miyavliyor = true;
            kedi.sescikar();
            kedi.Miyavla();

            Kopek kopek = new Kopek();
            kopek.adi = "havhav";
            kopek.Havliyor = true;
            kopek.sescikar();
            kopek.Havla();
            */

            /*
            //enkapsülasyon örneği, enkapsülasyon sınıfın özellik, fonksiyon ve prosedürlerinin erişimini diğer sınıflardan engellemektir
            Ogrenci ogrenci = new Ogrenci();
            ogrenci.Ad = "Güler";
            ogrenci.Soyad = "Varol";
            ogrenci.BilgileriYazdir();
            ogrenci.Yasi = 18;
            ogrenci.Bolumu = "Endüstri Mühendisliği";
            ogrenci.OgrenciBilgileriYazdir();
            */

            /*
            //polimorfizm: farklı nesnelerin aynı işlevleri farklı şekillerde yapmasına imkan sağlayan bir OOP prensibidir
            ToplaOverloading islem = new ToplaOverloading();
            var intsonuc = islem.Topla(1,3);
            Console.WriteLine($"overlaoding integer olarak sonuç= {intsonuc}");

            var doublesonuc = islem.Topla(2.5, 9.6);
            Console.WriteLine($"overloading double sonuç = {doublesonuc}");
            */

            LibraryUser LibraryUsers = new LibraryUser();
            LibraryUsers.UserName = "Test";

            LibraryItem LibraryItems = new LibraryItem();

            Console.WriteLine("Çıkış için ENTER basınız");
            Console.ReadLine();
        }

        static void TurnuvaApp1()
        {
            ArrayList ulkeler = new ArrayList { "Türkiye", "Almanya", "Bulgaristan", "İngiltere" , "Fransa" , "Macaristan" , "ABD" , "İran" };
            ArrayList hakemler = new ArrayList { "Türkiye", "Almanya", "Bulgaristan", "İngiltere"  };

            try
            {
                Random rastgele = new Random();

                //Console.WriteLine(ulkeler.Count);

                rastgele.Next(ulkeler.Count - 1);

                for (int i = 0; i < ulkeler.Capacity/2; i++)
                {
                    int rastgele1 = rastgele.Next(ulkeler.Count - 1);
                    string takim1 = (string)ulkeler[rastgele1];
                    //Console.WriteLine(takim1);
                    ulkeler.RemoveAt(rastgele1);

                    int rastgele2 = rastgele.Next(ulkeler.Count - 1);
                    string takim2 = (string)ulkeler[rastgele2];
                    //Console.WriteLine(takim2);
                    ulkeler.RemoveAt(rastgele2);


                    string hakem = "";
                    int rastgele3 = 0;
                    do
                    {
                        rastgele3 = rastgele.Next(hakemler.Count - 1);
                        hakem = (string)hakemler[rastgele3];
                        //Console.WriteLine(takim1);
                        if ((!hakem.Equals(takim1) && !hakem.Equals(takim2))) hakemler.RemoveAt(rastgele3);
                    }
                    while (hakem.Equals(takim1) || hakem.Equals(takim2));



                    Console.WriteLine($"{i + 1}. eşleşme {takim1} x {takim2} - Hakem : {hakem}");

                    if (ulkeler.Count == 0) break;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e );
            }
            
        }

        static void SayiTahminUygulamasi()
        {
            Console.WriteLine("Sayı tahmin uygulaması: tanımlanan hak sayısınıda bulmaya çalışan uyg.  + : daha yüksek bir sayı , - daha küçük bir sayı olduğu ipucunu vermek için kullanabilirsiniz, 'tamam' sonuç doğru demektir.");
            Console.Write("Tahmin Hakkını Giriniz: ");
            int TahminHakki = int.Parse(Console.ReadLine());
            int TahminSayisi = 0;
            string sonuc = "";
            int sayi = -1;
            int[] TKucukler = {0};
            int[] TBuyukler = { 101 };
            TBuyukler[0] = 101;
            TKucukler[0] = 0;
            Random tahmin = new Random();
            sayi = (int) tahmin.Next(101);

            while (sonuc !="tamam" && TahminSayisi<TahminHakki)
            {
                switch (sonuc)
                {
                    case "+": TKucukler[0] = sayi; sayi = (int)tahmin.Next(sayi + 1, TBuyukler.Max()); break;
                    case "-": TBuyukler[0] = sayi; sayi = (int)tahmin.Next(TKucukler.Min() + 1, sayi); break;
                    default:
                        break;
                }

                Console.WriteLine("En Fazla : {0}", TBuyukler.Max());
                Console.WriteLine("En Az : {0}", TKucukler.Min());

                TahminSayisi++;
                Console.WriteLine("Tahminim : {0}", sayi);
                Console.Write(" ::: Lütfen beni +, -, tamam yazarak yönlendir : ");
                sonuc = Console.ReadLine();

            }

            if(sonuc=="tamam")
            {
                Console.WriteLine("Yaşasın aklından tuttuğun sayıyı {0} tahminde buldum: {1}",TahminSayisi, sayi);
            } else
            {
                Console.WriteLine("Maalesef tahmin hakkım doldu: {0} tahminde bulamadım", TahminSayisi);
            }

        }

        static void OyKullanabilirmi()
        {
            int yas = 0;

            while(yas<=0)
            {
                Console.Write("Oy kullanabilme kontrolü için Yaş Giriniz: ");
                yas = int.Parse(Console.ReadLine());

                Console.WriteLine("Sayı : {0}", Math.Sign(yas)==-1 ? "Negatif" : "Pozitif"); //sayının pozitif mi negatifmi kontrolü
                Console.WriteLine("Sayı : {0}", yas %2 == 0  ? "Çift" : "Tek"); //sayının pozitif mi negatifmi kontrolü
            }


            if(yas<0)
            {
                Console.WriteLine("Yaş bilgisi sıfırdan küçük olamaz");
            }
            else if (yas>=18)
            {
                Console.WriteLine("Oy kullanabilir");
            } else
            {
                Console.WriteLine("Oy kullanamaz");
            }

            
        }

        static void MathYuvarlamaIslemleri()
        {
            double sonuc;

            sonuc = Math.Sqrt(7);
            Console.WriteLine(sonuc);
            sonuc = Math.Ceiling(Math.Sqrt(7));
            Console.WriteLine("Aşağı değere ceiling ile yuvarla : {0}",sonuc);
            sonuc = Math.Floor(Math.Sqrt(7));
            Console.WriteLine("Yukarı değere floor ile yuvarla : {0}", sonuc);
            sonuc = Math.Round(Math.Sqrt(7));
            Console.WriteLine("Değere round ile yuvarla : {0}", sonuc);
            sonuc = Math.Round(Math.Sqrt(7),2);
            Console.WriteLine("Değere round ile 2 digit yuvarla : {0}", sonuc);
            sonuc = Math.Round(6.5);
            Console.WriteLine("round ile yuvarla : {0}", sonuc);

            Console.WriteLine(sonuc);
        }

        static void AtamaOperatorleri()
        {
            var a = 5;
            var b = 10;

            Console.WriteLine(a);

            a += b;
            Console.WriteLine(a);
            a -= b;
            Console.WriteLine(a);
            a *= b;
            Console.WriteLine(a);
            a /= b;
            Console.WriteLine(a);
            a %= b;
            Console.WriteLine(a);
        }

        static void ObebBulanUygulama(int[] sayilar)
        {
            int obeb = 0;

            for (int j = 0; j < sayilar.Length; j++)
            {
                Console.WriteLine("sayi[{0}] = {1}", j, sayilar[j]);
            }

                for (int i = 1; i < sayilar.Max(); i++)
            {
                int mod0olanlar = 0;
                for (int j = 0; j < sayilar.Length; j++)
                {
                    if (sayilar[j] % i == 0)
                    {
                        mod0olanlar++;
                        //Console.WriteLine("sayilar[j] % i = {0} % {1}", sayilar[j] , i);
                    }
                }

                if(mod0olanlar == sayilar.Length)
                {
                    obeb = i;
                }
            }

            if(obeb != 0)
            {
                Console.WriteLine("Bu sayıların OBEBi {0}", obeb);
            } 
            else
            {
                Console.WriteLine("Bu sayıların OBEBi yoktur");
            }
            
        }


        static void DiziElemanlariniTopla(int[,] dizi)
        {
            int sonuc = 0;

            for (int i = 0; i < dizi.GetLength(0); i++)
            {
                for (int x = 0; x < dizi.GetLength(1); x++)
                {
                    sonuc += dizi[i, x];
                }
            }

            Console.WriteLine("Dizi elemanları toplamı: {0}", sonuc);
        }


        static int FaktoriyelHesaplayanFunc(int sayi)
        {
            int sonuc = 1;
            for (int i = 1; i <= sayi; i++)
            {
                sonuc *= i;
            }
            return sonuc;
        }

        static int YasHesapla(DateTime dogumyili)
        {
            int sonuc = 0;
            sonuc = DateTime.Now.Year - dogumyili.Year;

            return sonuc;
        }

        static int YasHesapla(int Yil)
        {
            int sonuc = 0;
            sonuc = DateTime.Today.Year - Yil;

            return sonuc;
        }

        public static int RastgeleIntSayiUretenFonk(int StartRange, int EndRange)
        {
            Random UretilenSayi = new Random();
            

            return UretilenSayi.Next(StartRange, EndRange);  //System.Convert.ToInt32(UretilenSayi);
        }

        static void DiziFibonacciBulma()
        {
            Console.Write("Kaç elemanlı bir fibonacci dizisi oluşturmak istiyorsun? :");
            int DiziBuyuklugu = int.Parse(Console.ReadLine());
            int[] FiboDizisi = new int[DiziBuyuklugu];

            FiboDizisi[0] = 0;
            FiboDizisi[1] = 1;
            for (int i = 2; i < DiziBuyuklugu; i++)
            {
                FiboDizisi[i] = FiboDizisi[i-1] + FiboDizisi[i-2];
            }

            foreach (var item in FiboDizisi)
            {
                Console.WriteLine(item + " Altın Oran i/i-1 : {0} ",item);
            }
        }

        static void UcBoyutDizi()
        {
            string[,,] UcBoyutluString = { { { "Ahmet", "Mehmet", "Hasan" }, { "Hüseyin", "İsmail", "Gürbüz" }, { "Güler", "Kazım", "Ömer" } } };

            for (int i = 0; i < UcBoyutluString.GetLength(0); i++)
            {
                for (int x = 0; x < UcBoyutluString.GetLength(1); x++)
                {
                    for (int z = 0; z < UcBoyutluString.GetLength(2); z++)
                    {
                        Console.WriteLine("{0},{1},{2} : {3}", i, x, z, UcBoyutluString[i,x,z]);
                    }
                }
            }
        }

        static void CokBoyutluDiziler()
        {
            try {
                int[,] IkiBoyutluIntDizi = { { 1, 2 }, { 1, 6 }, {5,9} };
                int[,,] UcBoyutluIntDizi = { { { 1, 2, 6 }, { 1, 6, 5 } }, { { 5, 9, 7 }, { 5, 9, 7 } } };

                Console.WriteLine("İki boyutlu dizi satır sayısı: GetLength(0) : {0}", IkiBoyutluIntDizi.GetLength(0));
                Console.WriteLine("İki boyutlu dizi sütün sayısı: GetLength(1) : {0}", IkiBoyutluIntDizi.GetLength(1));


                Console.WriteLine("Üç boyutlu dizi satır sayısı: GetLength(0) : {0}", UcBoyutluIntDizi.GetLength(0));
                Console.WriteLine("Üç boyutlu dizi sütün sayısı: GetLength(1) : {0}", UcBoyutluIntDizi.GetLength(1));
                Console.WriteLine("Üç boyutlu dizi sütün sayısı: GetLength(2) : {0}", UcBoyutluIntDizi.GetLength(2));

                for (int i = 0; i < IkiBoyutluIntDizi.Length; i++)
                {

                }
            }
            catch(Exception e)
            {
                Console.WriteLine("Hata: {0}",e.Message);
            }
            finally
            {
                Console.WriteLine("Finally");
            }
        }

        static void DiziReverse()
        {
            string[] ReverseDizi = { "C#", "Cobol", "Pascal", "Java", "C++" ,"Rust", "Dart"};

            for (int i = 0; i < ReverseDizi.Length; i++)
            {
                Console.WriteLine(ReverseDizi[i]);
            }

            Array.Reverse(ReverseDizi);

            Console.WriteLine("Bu dizi ters sıraya çevrildi");
            for (int i = 0; i < ReverseDizi.Length; i++)
            {
                Console.WriteLine(ReverseDizi[i]);
            }

            Array.Reverse(ReverseDizi);
            Console.WriteLine("Bu halide for döngüsü ile çevrilmiştir.");

            for (int i = ReverseDizi.Length-1; i >=0 ; i--)
            {
                Console.WriteLine(ReverseDizi[i]);
            }
        }

        static void DiziBinarySearch()
        {
            //binary search ile dizide obje araması yapılabilir
            //öncesinde sort ile sıralama gerekir
            //ancak sadece tek boyutlu dizilerde Sort ile sıralama yapılabileceği için, çok boyutlu dizilerde BinarySearch ile arama yapılamaz
            string[] Dizi1 = { "Ahmet", "Hasan", "Hüseyin" };

            Array.Sort(Dizi1);

            Console.WriteLine(Dizi1[Array.BinarySearch(Dizi1, "Hasan")]);
        }

        static void DiziCokBoyutluOrnek()
        {
            
            string kurum = "GESTAŞ";
            string[] kurumDizi = {"GESTAŞ", "İL ÖZEL İDARE"};

            Console.WriteLine(kurum[2]);
            Console.WriteLine(kurumDizi[1]);
         
            
            //çok boyutlu diziler
            int[,] cokBoyutluDizi = new int[3, 5];

            cokBoyutluDizi[0, 1] = 12;

            cokBoyutluDizi[2, 3] = 34;

            for (int i = 0; i < cokBoyutluDizi.Length; i++)
            {
                Console.WriteLine("Veri {0}: {1}", i, cokBoyutluDizi[1,1]);
            }
            
            var tekBDizi1 = "a bu bir c$ alıştırma örneğidir.".Split(' ');
            Array.Sort(tekBDizi1);
            Console.WriteLine(tekBDizi1[1]);

            foreach (var item in tekBDizi1)
            {
                Console.WriteLine(item);
            }


            int[] intDizi = { 1, 3, 6, 7, 9 };

            Console.WriteLine("Min: {0}", intDizi.Min());
            Console.WriteLine("Max: {0}", intDizi.Max());
            Console.WriteLine("Sum: {0}", intDizi.Sum());


            foreach (var item in intDizi)
            {
                Console.WriteLine(item);
            }

        }

        static void DiziOrnekler()
        {
            char[] chrDizi = { 'C', 'F' };
            float[] floatDizi = { 0.5f, 1.7f };
            double[] doubleDizi = { 23.43, 325.76 };
            string[] strDizi = { "aleman 1", "zleman 2", "dest" };

            strDizi.SetValue("deneme", 2);

            Console.WriteLine(strDizi[2]);
            Console.WriteLine(Array.IndexOf(strDizi, "eleman 2"));

            Array.Sort(strDizi);
            Array.Reverse(strDizi);
            Console.WriteLine(Array.Exists(strDizi, element => element.Equals("deneme")));
            Console.WriteLine(Array.Find(strDizi, element => element.Equals("deneme")));
            Console.WriteLine(Array.FindAll(strDizi, element => element.Contains("e")).Length);
            Console.WriteLine(Array.FindIndex(strDizi, element => element.Contains("d")));
            Console.WriteLine(Array.FindLast(strDizi, element => element.Contains("d")));
            //Console.WriteLine(Array.Exists(strDizi, element => element.Equals("deneme")));
            //Console.WriteLine(strDizi[0]);

            //Array.ForEach(strDizi, element => Console.WriteLine(element));

            //Console.WriteLine(Array.TrueForAll(strDizi, item => item.Length>5));
            //Array.ForEach(strDizi, element => Console.WriteLine(element));
        }

        static void DiziOgrenciler()
        {
            string[] ogrenciler = new string[3];
            int[] notlar = new int[3];

            for (int i = 0; i < 3; i++)
            {
                Console.Write(" {0}. Öğrenci Adı :", i + 1);
                ogrenciler[i] = Console.ReadLine();

                Console.Write(" {0}. Öğrenci Notu :", i + 1);
                notlar[i] = System.Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Öğrenciler dizi sayısı: {0}", ogrenciler.Length);

            Console.WriteLine("İlk iki öğrencinin adları {0} ve {1}", ogrenciler[0], ogrenciler[1]);

            Console.WriteLine("Tüm öğrencilerin not ortlaaması: {0}", System.Convert.ToString(notlar.Average()));
        }

        static void DiziOgrenciNotOrt()
        {
            int[,] notlar = new int[3, 3];

            for (int y = 0; y < 3; y++)
            {
                for (int i = 0; i < 3; i++)
                {
                    Console.Write("{0}. öğrencinin {1}. notu gir: ", y + 1, i + 1);
                    notlar[y, i] = int.Parse(Console.ReadLine());
                }
            }

            for (int y = 0; y < 3; y++)
            {
                double toplamnot = 0;
                for (int i = 0; i < 3; i++)
                {
                    toplamnot += notlar[y, i];
                }

                Console.WriteLine("{0} nolu öğrenci ortalaması: {1}", y + 1, toplamnot / 3);
            }
        }

        static void TarihSaatOrnekleri()
        {
            var tarih = DateTime.Now;
            Console.WriteLine("Tarih Saat: {0}", tarih);

            DateTime yeniTarih = new DateTime(2024, 1, 3);
            Console.WriteLine("Oluşturulan tarih {0}", yeniTarih);

            var islem = tarih - yeniTarih;

            Console.WriteLine("İşlem: {0}", yeniTarih.AddDays(4));

        }

        static void BaziStringOrnekleri()
        {
            Console.WriteLine("İşlem yapılacak metni giriniz");
            string giris = Console.ReadLine();
            Console.WriteLine("Girilen karakter {0} uzunlunğundadır",giris.Length);
            Console.WriteLine("Hepsi küçük {0}", giris.ToLower());
            Console.WriteLine("Hepsi büyük {0}", giris.ToUpper());
            Console.WriteLine(". ile başlıyor  {0}", giris.StartsWith("."));
            Console.WriteLine("C# içeriyormu  {0}", giris.IndexOf("C#") >= 0 ? "Evet" : "Hayır");
            Console.WriteLine("C# konumu  {0}", giris.IndexOf("C#"));
        }

        static void GirilenSayiyaKadarOlanFiboSayilari()
        {
            Console.WriteLine("Hangi sayıya kadar olan fibonacci sayılarını bulmak istiyorsunuz?");

            int sayi = int.Parse(Console.ReadLine());

            int[] fiboSayilari = new int[sayi];

            int fiboIndex = 0;

            for (int i = 1; i < sayi; i++)
            {

                for (int j = i+1; j<sayi-1 && i!=j; j++)
                {
                    int hedefSayi = i + j;
                    if(hedefSayi>1 && hedefSayi<sayi)
                    {
                        //dif(fiboSayilari.)
                        fiboSayilari[fiboIndex] = i;
                        fiboSayilari[fiboIndex+1] = j;

                        fiboIndex += 2;
                    }

                    //fiboSayilari.;
                }

            }

            for (int i = 0; i < fiboSayilari.Length; i++)
            {
                Console.WriteLine("Fibo sayilari {0}", fiboSayilari[i]);
            }        

        }

        static void IstenilenAdettekiSayininIslemiYapan()
        {
            Console.WriteLine("Kaç adet sayı gireceksiniz ?");
            int adet = int.Parse(Console.ReadLine());

            Console.WriteLine("Hangi işlemin yapılamsı isteniyor +, -, *, / ?");
            string islem = Console.ReadLine();

            double sonuc = 0;
            for (int i = 1; i <= adet; i++)
            {
                Console.WriteLine("Sayı {0} :",i);
                int girilenSayi = int.Parse(Console.ReadLine());
                switch (islem)
                {
                    default: Console.WriteLine("Bilinmeye işlen : HATA, tekrar deneyin");
                        break;
                    case "+":
                        sonuc += girilenSayi;
                        break;

                    case "-":
                        sonuc -= girilenSayi;
                        break;

                    case "*": if (i == 1) sonuc = 1;
                        sonuc *= girilenSayi;
                        break;

                    case "/":
                        if (i == 1) sonuc = 1;
                        sonuc /= girilenSayi;
                        break;
                }
                Console.WriteLine("İşlem sonucu : {0}", sonuc);

            }

            Console.WriteLine("İşlem sonucu : {0}", sonuc);
        }

        static void GirilenIkiSayiArasindakiSayilarinCarpimi()
        {
            Console.WriteLine("İki Sayı arasında kalan sayıların çarıpımı bulunacak \n\r 1. Sayı: ");
            int sayi1 = int.Parse(Console.ReadLine());

            Console.WriteLine("2. Sayı: ");
            int sayi2 = int.Parse(Console.ReadLine());

            int sonuc = 1;
            for (int i = Math.Min(sayi1,sayi2)+1; i < Math.Max(sayi1,sayi2); i++) //girilen sayılar dahil değil
            {
                sonuc *= i;
            }

            Console.WriteLine("Girilen iki sayı arasındaki sayıların çarpımı {0}", sonuc);
        }

        static void GirilenSayilariDiziOlarakAlipCarpanUyg()
        {

            Console.WriteLine("Virgülle ayrılmış olarak sayı dizisi giriniz: Örnak : 1,2,34 gibi");
            string giris = Console.ReadLine().ToString();

            string[] sayilar = giris.Split(new char[] { ',' });

            int sonuc = 1;
            for (int i = 0; i < sayilar.Length; i++)
            {
                sonuc *= Convert.ToInt32(sayilar[i]);
            }

            Console.WriteLine("İşlem sonucu : {0}", sonuc);
        }

        static void BasamakSayisiniBul(int sayi)
        {

            sayi = int.Parse(Console.ReadLine());
            Console.WriteLine("Basamak sayisini bul : {0}", sayi);

            int kalan = sayi;
            int basamak = 0;

            if (sayi > 0) basamak = 1;

            while(kalan>10)
            {
                kalan = kalan / 10;
                basamak +=1;
            }

            Console.WriteLine("Basamak sayisi : {0}", basamak);
        }

        static void KendindenOncekiSayilarinToplami()
        {

            Console.WriteLine("Bir sayı giriniz:");
            int sayi = int.Parse(Console.ReadLine());

            int toplam = 0;

            for (int i = 1; i <= sayi; i++)
            {
                toplam += i;
            }

            Console.WriteLine("for: Kendinden öcneki sayılar(Kendisi dahil) ın toplamı : {0} ", toplam);

            toplam = 0;
            int j = 0;
            while (j<=sayi)
            {
                toplam += j;
                j++;
            }
            Console.WriteLine("while: Kendinden öcneki sayılar(Kendisi dahil) ın toplamı : {0} ", toplam);

            j = 0;
            toplam = 0;
            do
            {
                toplam += j;
                j++;
            } while (j-1<sayi);

            Console.WriteLine("do-while: Kendinden öcneki sayılar(Kendisi dahil) ın toplamı : {0} ", toplam);

        }

        static void Sayi3BasamakliVeFarklimi()
        {
            /*
             Klavyeden, 3 basamaklı ve rakamları birbirinden farklı bir sayı girilip girilmediğini kontrol
            edecek C# programını geliştiriniz.
            */

            Console.WriteLine("Bir sayı giriniz : ");
            int girilenSayi = int.Parse(Console.ReadLine());

            if(girilenSayi>=100 && girilenSayi<1000)
            {
                string sayiString = System.Convert.ToString(girilenSayi);

                if(sayiString[0] != sayiString[1] && sayiString[0] != sayiString[2] && sayiString[1] != sayiString[2])
                {
                    Console.WriteLine("Girilen sayının basamakları birbirine benzemiyor");
                } else
                {
                    Console.WriteLine("Girilen sayının basamakları birbirine ?? benziyor");
                }
                    

            } else
            {
                Console.WriteLine("Girilen sayı 3 basamaklı değil");
            }

        }

        static void OtoparkUcretiHesapla() 
        {
            /*
            Bir otoparkın ücret tarifesi şöyledir:
            0 – 3 saat: 7 TL
            3 – 7 saat: 7 TL + 3 saati aşan her saat için 2 TL
            7 – 12 saat: 7 TL + 3 saati aşan her saat için 1.75 TL/saat
            12 saat ve üzeri: 22 TL + 12 saati aşan her saat için 1 TL
            Buna göre girilen saate göre otoparka ödenecek ücreti hesaplayıp ekrana yazan programı
            oluşturunuz.
             */
            Console.WriteLine("Süreyi giriniz: ");
            int sure = System.Convert.ToInt32(Console.ReadLine());
            double ucret = 0;
            if(sure>0 && sure<99999999)
            {
                if (sure > 0 && sure <= 3)
                {
                    ucret = 7;
                }
                if(sure>3 && sure<=7)
                {
                    ucret = 7 + (sure-3) * 2;
                }

                if (sure > 7 && sure <= 12)
                {
                    ucret = 7 + (sure-3) * 1.75;
                }

                if (sure > 12)
                {
                    ucret = 22 + (sure-12) * 1.0;
                }

                Console.WriteLine("Toplam ücret {0}", ucret);
            } else
            {
                Console.WriteLine("Süre geçerli değil");
            }
            
        }
        static void ToplamIndırımHesapla()
        {
            /*
             Bir mağaza müşterilerine yaptıkları alışveriş tutarına göre indirim yapmaktadır.
            200 TL ye kadar olan alışverişler için %10
            200-400 TL arası olan alışverişler için %15
            400 TL den fazla olan alışverişler için %20 Buna göre bir kişinin ödeyeceği net miktarı
            hesaplayan C# programın kodunu yazınız.
             */
            Console.WriteLine("Toplam Alışveriş Tutarını Giriniz:");
            int toplamTutar = System.Convert.ToInt32(Console.ReadLine());
            int KalanTutar = 0;

            double toplamIndirim = 0.0;

            //200-300 tl ye kadarki kısım için %10
            //300-400 tla rası için %15
            //400tl üzeri için %20 indirim

            KalanTutar = toplamTutar;
            if (KalanTutar > 200)
            {
                for (int i = 0; i < 3; i++)
                {
                    if (KalanTutar < 300)
                    {
                        toplamIndirim += KalanTutar * 0.10;
                        KalanTutar -= 200;
                    }
                    if (KalanTutar > 300 && KalanTutar < 400)
                    {
                        toplamIndirim +=20; //20 tl
                        toplamIndirim +=(KalanTutar - 300) * 0.15;
                        KalanTutar -= 300;
                    }

                }
                Console.WriteLine("Tutar: {0}, Toplam İndirim: {1}, Ödenecek: {2}", toplamTutar, toplamIndirim, toplamTutar - toplamIndirim);
            }
            else
            {
                Console.WriteLine("Tutar 200Tl den küçük( {0} ) indirim uyuglanamaz", toplamTutar);

            }

        }

        static void HesapMakinesi()
        {

            Console.WriteLine("1. sayıyı giriniz");
            int sayi1 = System.Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("2. sayıyı giriniz");
            int sayi2 = System.Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("İşlem Seçiniz ( + - * /)");
            string islem = Console.ReadLine();

            switch (islem)
            {
                default:
                    Console.WriteLine("Hatalı işlem seçimi");
                    break;
                case "+":
                    Console.WriteLine("Toplamları: {0}", sayi1 + sayi2);
                    break;
                case "-":
                    Console.WriteLine("Farkları: {0}", Math.Abs(sayi1 - sayi2));
                    break;
                case "*":
                    Console.WriteLine("Çarpımları: {0}", sayi1 * sayi2);
                    break;
                case "/":
                    Console.WriteLine("Sayı1/Sayı2: {0}", sayi1 / sayi2);
                    break;
            }
        }

        static void HangisiBuyuk()
        {
            Console.WriteLine("1. Sayıyı giriniz: ");
            int sayi1 = System.Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("2. Sayıyı giriniz: ");
            int sayi2 = System.Convert.ToInt32(Console.ReadLine());

            if (sayi1 > sayi2) Console.WriteLine("Sayı 1, Sayı 2 Den büyüktür");
            if (sayi2 > sayi1) Console.WriteLine("Sayı 2, Sayı 1 Den büyüktür");
            if (sayi1 == sayi2) Console.WriteLine("Sayı 1 ve Sayı 2 birbirine eşittir");

        }

        static void SayiTekmiCiftmi()
        {

            Console.WriteLine("Kontrol Edilecek sayıyı giriniz");
            string sayiStr = Console.ReadLine();
            int sayi = System.Convert.ToInt32(sayiStr);

            int kalan = sayi % 2;

            switch(kalan)
            {
                case 1 : 
                    Console.WriteLine("Sayı tekdir"); 
                    break;
                case 0: 
                    Console.WriteLine("Sayı çiftdir");
                    break;
                default:
                    Console.WriteLine("Tekrar deneyiniz");
                    break;
            }

        }

        static void TurnuvaUygulamasi()
        {
            string[] ulkeList = { "Türkiye", "Almanya", "Yunanistan", "Rusya", "Bulgaristan", "İsrail", "Arnavutluk", "Moldova" };

            string[][] hakemList = {
                new string[] { "Türkiye", "Türk" },
                new string[]{ "Almanya","Alman" },
                new string[]{ "Bulgaristan","Bulgar" },
                new string[]{ "İsrail","İsrailli" }
            };

            string[][][] rastgeleKuraSonucu = { };

            for (var i = 0; i < ulkeList.Length; i++)
            {
                Console.WriteLine("Ülke " + (i + 1) + " : " + ulkeList[i]);
            }


            for (var i = 0; i < hakemList.Length; i++)
            {
                Console.WriteLine("Hakem " + (i + 1) + " Ülkesi : " + hakemList[i][0] + ", Adı: " + hakemList[i][1]);
            }

            Console.WriteLine("Rastgele takım eşleştir, hakemler kendi ülkelerinin maçlarını yönetemez");
            Console.ReadLine();

            int kuraSayisi = (ulkeList.Length / 2);

            for (var i = 1; i <= kuraSayisi; i++)
            {
                Random random = new Random();
                int indexRastgele = random.Next(0, ulkeList.Length - 1);
                while (ulkeList.Length < indexRastgele)
                {
                    indexRastgele = random.Next(0, ulkeList.Length - 1);
                }

                string takimRastgele1 = ulkeList[indexRastgele];
                //Console.WriteLine("Seçilen Takım 1: " + takimRastgele1);
                ulkeList = Array.FindAll(ulkeList, j => j != ulkeList[indexRastgele]); //listeden o ülkeyi kaldır
                indexRastgele = random.Next(0, ulkeList.Length - 1);

                while (ulkeList.Length < indexRastgele)
                {
                    indexRastgele = random.Next(0, ulkeList.Length - 1);
                }


                string takimRastgele2 = ulkeList[indexRastgele];
                //Console.WriteLine("Seçilen Takım 2: " + takimRastgele2);
                ulkeList = Array.FindAll(ulkeList, j => j != ulkeList[indexRastgele]);


                //Console.WriteLine(takimRastgele1 + " x " + takimRastgele2);

                /*
                                for(var p =0; p<hakemList.Length; p++)
                                {
                                    hakemList = Array.FindAll(hakemList, g => g[0] != takimRastgele1);
                                    hakemList = Array.FindAll(hakemList, g => g[0] != takimRastgele2);
                                }
                */
                indexRastgele = random.Next(0, hakemList.Length - 1);

                string hakemRastgele = hakemList[indexRastgele][0];

                while (hakemRastgele == takimRastgele1 || hakemRastgele == takimRastgele2)
                {
                    indexRastgele = random.Next(0, hakemList.Length - 1);
                    hakemRastgele = hakemList[indexRastgele][0];
                    //Console.WriteLine("indexRastgele " + indexRastgele + ", "+ hakemList[indexRastgele][0]);
                    Console.ReadLine(); //bitiş
                }

                hakemList = Array.FindAll(hakemList, f => f[0] != hakemRastgele);

                //Console.ReadLine(); //bitiş

                Console.WriteLine("Eşleşme " + i + " :" + takimRastgele1 + " x " + takimRastgele2 + ",  Hakem: " + hakemRastgele);
            }

            for (var i = 0; i < ulkeList.Length; i++)
            {
                Console.WriteLine("Kalan Ülke " + (i + 1) + " : " + ulkeList[i]);
            }

        }
    }

    class Hayvan
    {
        public int yasi { get; set; }
        public string adi { get; set; }

        public void sescikar()
        {
            Console.WriteLine($"{adi} isimli hayvan ses çıkarıyor...");
        }
    }

    class Kedi : Hayvan
    {
        public bool Miyavliyor { get; set; }
        public void Miyavla ()
        {
            Console.WriteLine("Kedi miyavlıyor, miyav miyav");
        }
    }

    class Kopek : Hayvan
    {
        public bool Havliyor { get; set;}
        public void Havla()
        {
            Console.WriteLine("Köpek havlıyor, hav hav");
        }
    }


    class Kisi
    {
        private string _ad;
        private string _soyad;
        public string Ad { get { return _ad; } set { _ad = value; } }
        public string Soyad { get { return _soyad; } set { _soyad = value; } }
        public void BilgileriYazdir()
        {
            Console.WriteLine($"Bu kişinin adı {_ad}, soyadı {_soyad} dır");
        }
    }


    class Ogrenci : Kisi
    {
        public int Yasi { get; set; }
        public string Bolumu { get; set; }

        public void OgrenciBilgileriYazdir()
        {
            Console.WriteLine($"Bu öğrencinin adı {this.Ad}, soyadı: {Soyad}, yaşı {Yasi}, bölümü {Bolumu} ...");
        }
    }

    interface IToplaOverloading
    {
        int Topla(int a, int b);
    }

    class ToplaOverloading : IToplaOverloading
    {
        public int Topla(int a, int b)
        {
            return a + b;
        }

        public double Topla(double a, double b)
        {
            return a + b;
        }
    }

    class ToplaOverRiding
    {
        public int Topla(int a, int b)
        {
            return a + b;
        }
    }

    class ToplaOR : ToplaOverRiding
    {
        public double Topla(double a, double b)
        {
            return a + b;
        }
    }

}


