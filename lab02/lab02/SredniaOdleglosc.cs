using System;

namespace lab02
{
    public static class SredniaOdleglosc
    {
        public static void Oblicz()
        {
            Console.WriteLine("Zadanie 1: Licznik sredniej odleglości");
            Console.WriteLine("Wpisuj po kolei liczby, aby policzyc srednia. Wpisz 0, aby zakonczyc.");
            
            int odleglosc = -1, licznik = 0, sumaOdleglosci = 0;
            float sredniaOdleglosc = 0;
            while (odleglosc != 0)
            {
                string odpowiedz = Console.ReadLine();
                odleglosc = Convert.ToInt32(odpowiedz);
                sumaOdleglosci += odleglosc;
                licznik++;
            }

            sredniaOdleglosc = (float) sumaOdleglosci / (licznik - 1);

            Console.WriteLine("wynik to: " + sredniaOdleglosc);
        } 
    }
}
