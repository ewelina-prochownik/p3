using System;
using System.Linq;

namespace lab09
{
    public static class ExtensionMethod
    {
        public static (int wynik, int reszta) DzielenieZReszta(this int liczba, int dzielnik)
        {
            return (liczba / dzielnik, liczba % dzielnik);
        }

        public static int LiczenieLiter(this string tekst, char litera)
        {
            return tekst.Where(x => x.Equals(litera)).Count();
        }

        public static int LiczenieLiter(this string tekst, string litera)
        {
            if (litera.Length > 1)
            {
                throw new ArgumentException();
            }

            return LiczenieLiter(tekst, litera[0]);
            return tekst.LiczenieLiter(litera[0]);
        }

        public static int LiczenieLiter(this string tekst, char litera, bool caseInvariant = true)
        {
            if (caseInvariant)
            {
                tekst = tekst.ToLower();
                litera = char.ToLower(litera);
            }
            return tekst.LiczenieLiter(litera);

        }
        
        public static bool CzyDlaNiepelnoletnich(this PrzedzialWiekowy przedzial)
        {
            if (przedzial == PrzedzialWiekowy.Dzieci || przedzial == PrzedzialWiekowy.Mlodziez)
            {
                return true;
            }

            return false;
        }
    }
}