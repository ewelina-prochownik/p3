using System;

namespace kolokwium01_poprawa
{
    class Program
    {
        static void Main(string[] args)
        {
//zad1
            Console.WriteLine("Podaj promien kuli");
            double promien = Convert.ToDouble(Console.ReadLine());
            
            Zad1E.PowierzchniaKuli(promien);
            Zad1E.PojemnoscKuli(promien);
         

//zad2
            double[] tablicaCen = {4.5, 5.7, 2.3, 9.0 };
            int[] tablicaIlosci = {5, 3, 7, 2 };
            
            var zad2E = new Zad2E();
            zad2E.KosztZamowienia(tablicaCen, tablicaIlosci);


//zad3
            double[,] ocenyIWagi =
            {
                {2.5, 5.0, 4.5, 2.0, 3.0},
                {3, 2, 1, 2, 1}
            };
            
            Zad3E.ObliczanieSredniej(ocenyIWagi);


        }
    }
}