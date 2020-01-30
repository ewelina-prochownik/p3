using System;
using System.Drawing;
using System.Linq;

namespace kolokwium02_poprawa
{
    class Program
    {
        static void Main(string[] args)
        {
//            zad1E
            Random random = new Random();
//            Mieszkanie mieszkanie = new Mieszkanie();
//           Mieszkanie mieszkanie = Enumerable.Range(1, 50).Select(m => new
//            {
//                mieszkanie.Metraz,
//                mieszkanie.Nazwa,
//                mieszkanie.OdlegloscOdCentrum
//            }).ToList();
                
//                .Select( m => 
//            new {
//                m.Metraz = random.Next(15, 200);
//                mieszkanie.Nazwa = GenerowanieNazwy.GetRandomString();
//                mieszkanie.OdlegloscOdCentrum = random.Next(1, 50);
//            })

//            zad2E - Test.cs

//            zad3E
            Point punkt = new Point();
            punkt.X = 16;
            punkt.Y = -5;

            Console.WriteLine(punkt.NazwaCwiartki());

//            zad4E
            
//            zad5E
            Syrena syrena1 = new Syrena();
            Syrena syrena2 = new Syrena();
            Syrena syrena3 = new Syrena();

            Lampa lampa1 = new Lampa();
            Lampa lampa2 = new Lampa();
            Lampa lampa3 = new Lampa();

            Drzwi drzwi1 = new Drzwi();
            Drzwi drzwi2 = new Drzwi();
            Drzwi drzwi3 = new Drzwi();

            Ochrona.Alarm += syrena1.SyrenaEventHandler;
            Ochrona.Alarm += syrena2.SyrenaEventHandler;
            Ochrona.Alarm += syrena3.SyrenaEventHandler;
            Ochrona.Alarm += lampa1.LampaEventHandler;
            Ochrona.Alarm += lampa2.LampaEventHandler;
            Ochrona.Alarm += lampa3.LampaEventHandler;
            Ochrona.Alarm += drzwi1.DrzwiEventHandler;

            Console.WriteLine("Podaj kod do uruchomienia pełnej ochrony.");
            Console.WriteLine();
            string kod = Console.ReadLine();

        }
    }
}