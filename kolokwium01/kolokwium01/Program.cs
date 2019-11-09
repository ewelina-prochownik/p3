using System;

namespace kolokwium01
{

    class Program
    {
        static void Main(string[] args)
        {
            //zad1b
            float y = 0;
            Console.WriteLine("Podaj wartosc do przeskalowania");
            string liczba = Console.ReadLine();
            float x = Convert.ToSingle(liczba);

            y = ((x - 50) / (150 - 50));
            Console.WriteLine(y);

        }
    }
};
