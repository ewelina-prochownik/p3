using System;

namespace lab02
{
    public static class LicznikProduktow
    {
        private static int iloscProduktow = 0;

        private static void UnikalnaNazwa(string nazwaProduktu)
        {
            iloscProduktow++;
            Console.WriteLine("Produkt [" + nazwaProduktu + "]" + iloscProduktow);
        }

        public static void PoliczProdukty()
        {
            Console.WriteLine("Zadanie 2: Licznik produktow");
            Console.WriteLine("Wpisz nazwe produktu (1,2,3), aby policzyc sume wszystkich produktow.");
            Console.WriteLine("Wpisz \"exit\" aby zakonczyc.");
            
            string escape = "exit";
            string odpowiedz = "";

            while (!odpowiedz.Equals(escape))
            {
                odpowiedz = Console.ReadLine();
                switch (odpowiedz)
                {
                    case "1":
                        UnikalnaNazwa("1");
                        break;
                    case "2":
                        UnikalnaNazwa("2");
                        break;
                    case "3":
                        UnikalnaNazwa("3");
                        break;
                }
            }
        }
    }
}