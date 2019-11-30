using System;

namespace kolokwium01_poprawa
{
    public class Zad3E
    {
        public static void ObliczanieSredniej(double[,] ocenyIWagi)
        {
            double ocena = 0;
            double sredniaWazona = 0;
            double koncowaSrednia = 0;
            double iloscOcen = 0;
            for (int i = 0; i < ocenyIWagi.GetLength(1); i++)
            {
                ocena = ocenyIWagi[0, i] * ocenyIWagi[1, i];
                sredniaWazona += ocena;
                iloscOcen += ocenyIWagi[1, i];
            }

            koncowaSrednia = sredniaWazona / iloscOcen;
            Console.WriteLine($"Srednia wazona tego ucznia to {koncowaSrednia}");
        }
    }
}