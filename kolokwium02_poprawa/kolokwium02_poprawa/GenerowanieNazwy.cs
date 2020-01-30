namespace kolokwium02_poprawa
{
    using System;
    using System.IO;
    
    static class GenerowanieNazwy
    {
        public static string GetRandomString()
        {
            string path = Path.GetRandomFileName();
            path = path.Replace(".", "");
            return path;
        }
    }
}