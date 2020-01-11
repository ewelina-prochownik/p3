using System;

namespace lab09
{
    class Program
    {
        static void Main(string[] args)
        {
//            //Extension
//            
//            int liczba = Convert.ToInt32(Console.ReadLine());
//            int wynik, resztaZDzielenia;
//            (wynik, resztaZDzielenia) = liczba.DzielenieZReszta(3);
//            Console.WriteLine($"{liczba}/3={wynik}r{resztaZDzielenia}");
//
//
//            string tekst = "Ala ma kota";
//            Console.WriteLine(tekst.LiczenieLiter('a'));

                Reklama reklama = new Reklama(
                    "Kup teraz!",
                    PrzedzialWiekowy.Dorosli | PrzedzialWiekowy.Mlodziez,
                    Zainteresowania.Elektronika
                    );
                reklama.Test();
                
                Reklama reklama2 = new Reklama(
                    "Kup teraz!",
                    PrzedzialWiekowy.Dorosli | PrzedzialWiekowy.Starsi,
                    Zainteresowania.Elektronika
                );
                reklama2.Test();


        }
    }
}