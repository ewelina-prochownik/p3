using System;

namespace kolokwium01
{

    class Program
    {
        static void Main(string[] args)
        {
            Zad1B.Add();
            
            var zad2B = new Zad2B();
            zad2B.SprawdzTablice();

            int[][] dzialy =
            {
                new[] {3, 7, 12, 4},
                new[] {9, 1, 34, 17, 6, 2},
                new[] {5, 150},
                new[] {8, 19, 43}
            };

            var zad3B = new Zad3B();
            zad3B.LiczbaPracownikow(dzialy);
            zad3B.MaxLiczbaPracownikow(dzialy);
            zad3B.NajnowszyPracownik(dzialy);
        }
    }
};
