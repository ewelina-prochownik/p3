using System;

namespace lab02
{
    class Program
    {
        static void Main(string[] args)
        {
            string nrZadania = "";
            Console.WriteLine("Podaj nr. zadania:");
            Console.WriteLine("1.Licznik sredniej odleglosci" +
                              "\n2.Licznik produktow\n");
            nrZadania = Console.ReadLine();

            switch (nrZadania)
            {
                case "1":
                    SredniaOdleglosc.Oblicz();
                    break;
                case "2":
                    LicznikProduktow.PoliczProdukty();
                    break;
                default:
                    Console.WriteLine("Zly nr zadania.");
                    break;
            }

            Console.ReadLine();
        }
    }
}