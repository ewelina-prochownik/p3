using System;

namespace kolokwium01
{
    public class Zad3B
    {
        public void LiczbaPracownikow(int[][] dzialy)
        {
            int index = 1;
            foreach (var pracownicy in dzialy)
            {
                Console.WriteLine($"Dzial {index++}: {pracownicy.Length}");
            }
        }

        public void MaxLiczbaPracownikow(int[][] dzialy)
        {
            int maxIlosc = 0;
            int numerDzialu = 0;
            for (int i = 1; i < dzialy.Length; i++)
            {
                if (i == 1)
                {
                    maxIlosc = dzialy[i - 1].Length;
                }

                if (maxIlosc < dzialy[i].Length)
                {
                    maxIlosc = dzialy[i].Length;
                    numerDzialu = i;
                }
            }

            Console.WriteLine($"Dzial z najwieksza liczba pracownikow - {numerDzialu + 1}");
        }

        public void NajnowszyPracownik(int[][] dzialy)
        {
            int maxId = 0;
            int numerDzialu = 0;

            for (int i = 1; i < dzialy.Length; i++)
            {
                for (int j = 1; j < dzialy[i].Length; j++)
                {
                    if (i == 1 && j == 1)
                    {
                        maxId = dzialy[i - 1][j - 1];
                    }

                    if (maxId < dzialy[i][j])
                    {
                        maxId = dzialy[i][j];
                        numerDzialu = i;
                    }
                }
            }

            Console.WriteLine($"Najnowszy pracownik (id: {maxId}) znajduje sie w dziale {numerDzialu + 1}");
        }
    }
}