using System;

namespace kolokwium02_poprawa
{
    public class Lampa
    {
        public void LampaEventHandler(object sender, EventArgs e)
        {
            Console.WriteLine("[lampa_on=1]");
        }
    }
}