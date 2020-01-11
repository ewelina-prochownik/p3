using System;

namespace lab09
{
    [Flags]
    public enum PrzedzialWiekowy
    {
        Brak = 0,
        Dzieci = 1,
        Dorosli = 2,
        Mlodziez = 4,
        Starsi = 8
    }

    [Flags]
    public enum Zainteresowania
    {
        Elektronika,
        Motoryzacja,
        Gaming,
        Ekonomia
    }
}