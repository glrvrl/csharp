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
            //başlangıç 09:53
            /*
            List<string> takimlar = new List<string>() { "Almanya", "Türkiye", "Fransa", "Hollanda", "USA", "İngiltere" };
            List<string> hakemler = new List<string>() { "Almanya", "Türkiye", "Fransa", "Hollanda" };

            var takim1 = takimlar[new Random().Next(takimlar.Count)];
            var list = takimlar.Where(takim => takim!= takim1).Select(takim=>takim); //.Select( //SelectMany(takim => takim.Length>5);
            var takim2 = takimlar[new Random().Next(takimlar.Count)];

            Console.WriteLine($"takım 1 {takim1}");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            */

            //CollectionsWherePractice();

            //CollectionsWhereContains();

            //CollectionsDictionaryLinq();

            //ListIntOperations();

            //ListStringGroupBy();

            //ListObjOrderByOrderThen();

            //ListJoinedOtherListWithFormat();

            //TurnuvaAppV1();

            Console.ReadLine();
        }

        private static void ListJoinedOtherListWithFormat()
        {
            List<int> idler = new List<int> { 1, 2, 3, 4, 5, 6, 7 };
            List<string> isimler3 = new List<string> { "Ahmet", "Mehmet", "Hasan", "Hüseyin" };

            var joinedisimler = idler.Join(isimler3, id => idler.IndexOf(id), isim => isimler3.IndexOf(isim), (id, isim) => $"{id}: {isim}");
            foreach (var item in joinedisimler)
            {
                Console.WriteLine(item);
            }
        }

        private static void ListObjOrderByOrderThen()
        {
            List<Student> students = new List<Student>()
            {
                new Student{Age=15,Name="Güler Varol",Department="CS"},
                new Student{Age=17,Name="Mehmet Efe",Department="Proje İHO"},
                new Student{Age=14,Name="Ahmet Hüsrev", Department="Ömer Halisdemir İHO"},
                new Student{Age=12,Name="Abb", Department="Ömer Halisdemir İHO"},
                new Student{Age=11,Name="Ahmet Hüsrev", Department="Ömer Halisdemir İHO"},
                new Student{Age=11,Name="Ahmet Hüsrev", Department="Ömer Halisdemir İHO"},
                new Student{Age=12,Name="Aaa", Department="Ömer Halisdemir İHO"},
                new Student{Age=13,Name="Abc", Department="Ömer Halisdemir İHO"},

            };


            var students2 = students.OrderBy(n => n.Age).ThenBy(n => n.Name).ThenBy(n => n.Department);

            foreach (var item in students2)
            {
                Console.WriteLine($"Yaş: {item.Age}, İsim: {item.Name}, Bölüm: {item.Department}");
            }
        }

        private static void ListStringGroupBy()
        {
            List<string> isimler = new List<string>
            {
                "Güler",
                "Ahmet",
                "Hasan",
                "Hüseyin",
                "İsmail",
                "Osman",
                "Mehmet",
                "Murat"
            };


            var isimler2 = isimler.GroupBy(n => n[0]);
            foreach (var item in isimler2)
            {
                Console.WriteLine(item.Key + " ile başlayanlar aşağıda");
                foreach (var subitem in item)
                {
                    Console.WriteLine("-" + subitem);
                }
            }
        }

        private static void ListIntOperations()
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var result = numbers.Select(n => n = n * n);

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

            List<int> numbers2 = new List<int> { 1, 3, 5, 7, 9 };
            Console.WriteLine($"Bu sayıların toplamı :{numbers2.Sum()}, ortalaması : {numbers2.Average()}, en büyük: {numbers2.Max()}, en küçük: {numbers.Min()}, sayısı: {numbers2.Count()}");
        }

        private static void TurnuvaAppV1()
        {
            List<Takim> takimlar = new List<Takim>
            {
                new Takim("Beşikaş","Türkiye"),
                new Takim("Borusya","İtalya"),
                new Takim("Portakal","Bulgar"),
                new Takim("Mandalin","Rusya"),
                new Takim("Elma","Norweç"),
                new Takim("Kayısı","İngiltere"),
                new Takim("Beşikaş","Türkiye"),
                new Takim("Borusya","İtalya"),
                new Takim("Portakal","Bulgar"),
                new Takim("Mandalin","Rusya"),
                new Takim("Elma","Norweç"),
                new Takim("Kayısı","İngiltere"),
            };

            List<Hakem> hakemler = new List<Hakem>
            {
                new Hakem("Ahmet","Türkiye"),
                new Hakem("Hasan","İtalya"),
                new Hakem("Hüseyin","Bulgar"),
                new Hakem("Mahmud","İngiltere"),
                new Hakem("Celal","Rusya"),
                new Hakem("Ali","Norweç"),
                new Hakem("Osman","Türkiye"),
            };

            List<Karsilasma> karsilasmalar = new List<Karsilasma>();

            //int karsilasma = takimlar.Count / 2;
            Random rst = new Random();

            while (takimlar.Count > 0)
            {
                Takim takim1 = takimlar[rst.Next(takimlar.Count - 1)];
                takimlar.Remove(takim1);
                Takim takim2 = takimlar[rst.Next(takimlar.Count - 1)];
                takimlar.Remove(takim2);

                var hakem = hakemler.Where(n => n.Country != takim1.Country && n.Country != takim2.Country).First();
                karsilasmalar.Add(new Karsilasma(takim1, takim2, hakem));
                hakemler.Remove(hakem);
            }

            foreach (var item in karsilasmalar)
            {
                item.SonucUret();
            }
        }

        private static void CollectionsDictionaryLinq()
        {
            Dictionary<int, string> plakalar = new Dictionary<int, string>() { { 1, "Adana" }, { 17, "Çanakkale" }, { 34, "İstanbul" }, { 6, "Ankara" }, { 74, "Bartın" } };

            var result = plakalar.Where(n => n.Key > 10);
            foreach (var item in result)
            {
                Console.WriteLine($"{item.Key} = {item.Value}");
            }
        }

        private static void CollectionsWhereContains()
        {
            List<string> names = new List<string>() { "Güler", "Ahmet", "Hasan", "Hüseyin", "Üzeyir" };
            var result = names.Where(n => n.ToLower().Contains("ü"));
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }

        private static void CollectionsWherePractice()
        {
            int[] numbers = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            var evenNumbers = numbers.Where(n => n % 2 == 0);
            Console.WriteLine("2ye bölümü sıfır olanlar");
            foreach (var item in evenNumbers)
            {
                Console.WriteLine(item);
            }
        }
    }


    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    class Student : Person
    {
        public string Department { get; set; }
    }

    class Takim
    {
        public string Name { get; set; }
        public string Country { get; set; }

        public Takim(string name, string country)
        {
            Name = name;
            Country = country;
        }
    }

    class Hakem
    {
        public string Name { get; set; }
        public string Country { get; set; }

        public Hakem(string name, string country)
        {
            Country = country;
            Name = name;
        }
    }

    class Karsilasma
    {
        public Hakem Hakem { get; set; }
        public Takim Takim1 { get; set; }
        public Takim Takim2 { get; set; }
        public static Random rst = new Random();
        public Karsilasma(Takim takim1, Takim takim2, Hakem hakem)
        {
            Takim1 = takim1;
            Takim2 = takim2;
            Hakem = hakem;
        }
        public void SonucUret()
        {
           
            int sonuc2 = rst.Next(10);
            int sonuc1 = rst.Next(10);

            Console.WriteLine($"Hakem: {Hakem.Name}({Hakem.Country}) , Maç Sonucu: {Takim1.Name}({Takim1.Country}) {sonuc1} x {sonuc2} {Takim2.Name}({Takim2.Country})");
        }
    }
}
