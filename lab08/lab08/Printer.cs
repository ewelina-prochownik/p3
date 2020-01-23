using System;

namespace lab08
{
    class Printer
    {
        private int _paperCount;
        private int _printedPages;
        private int _cyanInk;
        private int _magentaInk;
        private int _yellowInk;
        private int _blackInk;
        public event EventHandler OutOfPaperEvent;
        public event EventHandler<OutOfInkEventArgs> OutOfInkEvent;
  
        public Printer()
        {
            _paperCount = 300;
            _cyanInk = 100;
            _magentaInk = 100;
            _yellowInk = 100;
            _blackInk = 100;

            OutOfPaperEvent += OutOfPaperEventHandler;
            OutOfInkEvent += OutOfInkEventHandler;
        }
        public void Print(int pages, int cyan, int magneta, int yellow, int black)
        {
            Console.WriteLine("Printing...");

            for(int i = 1; i <= pages; i++)
            {
                if(_paperCount <= 0)
                {
                    OutOfPaperEvent?.Invoke(this, EventArgs.Empty);
                    return;
                }

                if(_cyanInk <= 0)
                {
                    OutOfInkEvent?.Invoke(this, new OutOfInkEventArgs("Cyan"));
                    break;
                }

                if(_magentaInk <= 0)
                {
                    OutOfInkEvent?.Invoke(this, new OutOfInkEventArgs("Magenta"));
                    break;
                }

                if (_yellowInk <= 0)
                {
                    OutOfInkEvent?.Invoke(this, new OutOfInkEventArgs("Yellow"));
                    break;
                }

                if (_blackInk <= 0)
                {
                    OutOfInkEvent?.Invoke(this, new OutOfInkEventArgs("Black"));
                    break;
                }

                _paperCount--;
                _printedPages++;
                _cyanInk -= cyan;
                _magentaInk -= magneta;
                _yellowInk -= yellow;
                _blackInk -= black;

            }

            Console.WriteLine($"Number of printed pages: {_printedPages}");
        }

        private void OutOfPaperEventHandler(object sender, EventArgs args)
        {
            Console.WriteLine(
                $"{DateTime.Now.ToShortDateString()} " + 
                $"{ DateTime.Now.ToShortTimeString()} | [PrinterLog]: Out of paper");
        }

        private void OutOfInkEventHandler(object sender, OutOfInkEventArgs args)
        {
            
            Console.WriteLine(
                $"{DateTime.Now.ToShortDateString()} " +
                $"{ DateTime.Now.ToShortTimeString()} | [PrinterLog]: Out of {args.Color} ink");
        }
    }
}
