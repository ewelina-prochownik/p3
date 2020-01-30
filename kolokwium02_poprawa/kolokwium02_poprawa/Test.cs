namespace kolokwium02_poprawa
{
    public class Test
    {
        public void Deconstruct(out int id, out string nazwa, out string opis, out bool powodzenie, out string tester)
        {
            id = Id;
            nazwa = Nazwa;
            opis = Opis;
            powodzenie = Powodzenie;
            tester = Tester;
        }

        public void Deconstruct(out int id, out bool powodzenie)
        {
            id = Id;
            powodzenie = Powodzenie;
        }

        private int Id;
        private string Nazwa;
        private string Opis;
        private bool Powodzenie;
        private string Tester;
    }
}