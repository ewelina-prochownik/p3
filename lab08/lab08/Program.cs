using System;

namespace lab08
{
    class Program
    {
        static void Main(string[] args)
        {
            var printer = new Printer();
            printer.OutOfPaperEvent += OutOfPaperEventHandler;
            printer.OutOfInkEvent += OutOfInkEventHandler;
            printer.Print(10, 20, 5, 1, 0);
  
        }

        static void OutOfPaperEventHandler(object sender, EventArgs args)
        {
            Console.WriteLine("Please put more paper");
        }

        static void OutOfInkEventHandler(object sender, OutOfInkEventArgs args)
        {
            Console.WriteLine($"Please add more {args.Color} ink");
        }
    }
}