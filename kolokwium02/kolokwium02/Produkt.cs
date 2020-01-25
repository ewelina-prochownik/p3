namespace kolokwium02
{
    public class Produkt
    {
        public void Deconstruct(out string nazwa, out double cena, out string opis, out string dataWaznosci)
        {
            nazwa = Nazwa;
            cena = Cena;
            opis = Opis;
            dataWaznosci = DataWaznosci;
        }

        public void Deconstruct(out string nazwa, out double cena)
        {
            nazwa = Nazwa;
            cena = Cena;
        }

        public string Nazwa;
        public double Cena;
        public string Opis;
        public string DataWaznosci;
        public int Ilosc;
        
        
    }
}
