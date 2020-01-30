namespace kolokwium02_poprawa
{
    public class Mieszkanie
    {
        public double Metraz;
        public string Nazwa;
        public double OdlegloscOdCentrum;

        public Mieszkanie()
        {
        }

        public Mieszkanie(double metraz, string nazwa, double odlegloscOdCentrum)
        {
            Metraz = metraz;
            Nazwa = nazwa;
            OdlegloscOdCentrum = odlegloscOdCentrum;
        }
    }
}