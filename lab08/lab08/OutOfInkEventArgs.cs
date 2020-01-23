using System;

namespace lab08
{
    public class OutOfInkEventArgs : EventArgs
    {
        public string Color { get; }

        public OutOfInkEventArgs(string color)
        {
            Color = color;
        }
    }
}