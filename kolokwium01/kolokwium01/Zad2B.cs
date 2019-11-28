using System;

namespace kolokwium01
{
    public class Zad2B
    {
        public void SprawdzTablice()
        {
            int[] tablica = {2, 8, 50, 3, 67, 8};

            for (int i = 0; i < tablica.Length; i++)
            {
                if (tablica[i] % (i + 1) == 0)
                {
                    Console.WriteLine("Liczba " + tablica[i] + " spełnia podany warunek");
                }
                else
                {
                    Console.WriteLine("Liczba " + tablica[i] + " nie spełnia podanego warunku");
                }
            }
        }
    }
}