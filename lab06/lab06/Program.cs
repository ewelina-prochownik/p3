using System;
using System.Collections.Generic;
using System.Linq;
using RandomDataGenerator.Randomizers;
using RandomDataGenerator.FieldOptions;

namespace lab06
{
    class Osoba
    {
        public int id;
        public string imie;
        public string nazwisko;

        public Osoba(int id, string imie, string nazwisko)
        {
            this.id = id;
            this.imie = imie;
            this.nazwisko = nazwisko;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
//            List<int> lista = Enumerable.Range(100, 150).ToList();
//            List<int> podzielnePrzez3 =
//                lista.Where(x => x % 3 == 0).ToList();
//
//            int elementyNaStronie = 25;
//            int nrStrony = 2;
//            List<int> strona =
//                lista.Skip(elementyNaStronie * (nrStrony - 1))
//                    .Take(elementyNaStronie).ToList();
//
//            double srednia = lista.Average();
//
////            Console.WriteLine(srednia);
////
////            foreach (var item in strona)
////            {
////                Console.WriteLine(item);
////            }
//
//            List<Osoba> osoby =
//                Enumerable.Range(1, 50)
//                    .Select(x => new Osoba()
//                    {
//                        id = x,
//                        imie = x.ToString(),
//                        nazwisko = "aaa"
//                    }).ToList();
//
//            osoby[30].nazwisko = "bbb";
//            
////            foreach (var item in osoby)
////            {
////                Console.WriteLine($"{item.id}: {item.imie} {item.nazwisko}");
////            }
//
//            IEnumerable<int> ids = osoby.Select(x => x.id);
//
////            foreach (var item in ids)
////            {
////                Console.WriteLine(item);
////            }
//
//                osoby.Select(x => x.nazwisko)
//                    .Distinct().ToList().ForEach(x => Console.WriteLine(x));
//
//                int pierwszy = lista.FirstOrDefault(x => x%300 == 0);
//                Console.WriteLine(pierwszy);

            var intGenerator = RandomizerFactory.GetRandomizer(new FieldOptionsInteger());
            var nameGenerator = RandomizerFactory.GetRandomizer(new FieldOptionsFirstName());
            var lastNameGenerator = RandomizerFactory.GetRandomizer(new FieldOptionsLastName());


            Osoba random = new Osoba(
                intGenerator.Generate().Value,
                nameGenerator.Generate(),
                lastNameGenerator.Generate()
            );


                Console.WriteLine($"{random.id}: {random.imie} {random.nazwisko}");
        }
    }
}