using System.Drawing;

namespace kolokwium02_poprawa
{
    public static class ExtensionMethod
    {
        public static string NazwaCwiartki(this Point punkt)
        {
            if (punkt.X > 0 && punkt.Y > 0)
            {
                return "Cwiartka 1";
            } else if (punkt.X < 0 && punkt.Y > 0)
            {
                return "Cwiartka 2";
            } else if (punkt.X < 0 && punkt.Y < 0)
            {
                return "Cwiartka 3";
            } else if (punkt.X > 0 && punkt.Y < 0)
            {
                return "Cwiartka 4";
            }
            else
            {
                return "Podano bledne wartosci";
            }
        }
    }
}