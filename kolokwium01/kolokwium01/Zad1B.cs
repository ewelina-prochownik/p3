using System;

namespace kolokwium01
{
    public class Zad1B
    {
        public static void Add()
        {
            float y = 0;
            Console.WriteLine("Podaj wartosc do przeskalowania");
            string liczba = Console.ReadLine();
            float x = Convert.ToSingle(liczba);

            if (x < 50 || x > 150)
            {
                Console.WriteLine("Wartość musi należeć do przedziału [50, 150]");
                return;
            }

            y = ((x - 50) / (150 - 50));
            Console.WriteLine(y);
        }
    }
}