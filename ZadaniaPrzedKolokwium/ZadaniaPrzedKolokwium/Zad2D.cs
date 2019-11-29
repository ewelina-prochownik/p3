using System;

namespace ZadaniaPrzedKolokwium
{
    public class Zad2D
    {
        public static string Cezar(string wiadomosc, int przesuniecie)
        {
            string zwroconaWiadomosc = "";

            foreach (var litera in wiadomosc)
            {
                if (litera != ' ')
                {
                    var tmpInt = litera + przesuniecie;
                    var tmpChar = (char) tmpInt;
                    zwroconaWiadomosc += tmpChar;
                }
                else
                {
                    zwroconaWiadomosc += litera;
                }
            }
            
            return zwroconaWiadomosc;
        }
    }
}