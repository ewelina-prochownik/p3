using System;

namespace kolokwium01_poprawa
{
    public class Zad1E
    {
        public static void PowierzchniaKuli(double promien)
        {
            double powierzchnia = 4.0 * 3.14 * promien * promien;
            Console.WriteLine($"Powierzchnia kuli wynosi {powierzchnia}");
        }

        public static void PojemnoscKuli(double promien)
        {
            double objetosc = (4.0 / 3) * 3.14 * promien * promien * promien;
            Console.WriteLine($"Pojemnosc kuli wynosi {objetosc}");
        }
    }
}