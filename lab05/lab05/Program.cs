using System;
using System.Linq;
using System.Collections.Generic;
namespace lab05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            List<DateTime> lista = new List<DateTime>();
            DateTime wynik = lista.Where(
                x => x.Year > 2000 &&
                     x.Month == 11 &&
                     x.AddDays(1).DayOfWeek == DayOfWeek.Monday)
                .FirstOrDefault();

        }
    }
}