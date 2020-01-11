using System;

namespace lab09
{
    public class Reklama
    {
        public string Tekst;
        public PrzedzialWiekowy przedzialWiekowy;
        public Zainteresowania zainteresowania;

        public void Test()
        {
            Console.WriteLine(przedzialWiekowy);
            if (przedzialWiekowy.HasFlag(PrzedzialWiekowy.Dzieci))
            {
                Console.WriteLine("Reklama dla dzieci.");
            }
            
            if (przedzialWiekowy >= PrzedzialWiekowy.Dorosli)
            {
                Console.WriteLine("Reklama dla doroslych.");
            }

            if (przedzialWiekowy.CzyDlaNiepelnoletnich())
            {
                Console.WriteLine("Reklama takze dla niepelnoletnich");
            }

            for (int i = 0; i < 16; i++)
            {
                Console.WriteLine((PrzedzialWiekowy)i);
            }
            
        }
        public Reklama(string tekst, PrzedzialWiekowy przedzialWiekowy, Zainteresowania zainteresowania)
        {
            Tekst = tekst;
            this.przedzialWiekowy = przedzialWiekowy;
            this.zainteresowania = zainteresowania;
        }
    }
}