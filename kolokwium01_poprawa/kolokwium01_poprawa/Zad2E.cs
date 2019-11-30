using System;

namespace kolokwium01_poprawa
{
    public class Zad2E
    {
        public void KosztZamowienia(double[] tablicaCen, int[] tablicaIlosci)
        {
            double calkowityKoszt = 0;
            double cena = 0;
            for (int i = 0; i < tablicaIlosci.Length; i++)
            {
                cena = tablicaCen[i] * tablicaIlosci[i];
                calkowityKoszt += cena;
            }

            Console.WriteLine($"Calkowity koszt zamowienia to {calkowityKoszt} zl.");
        }
    }
}