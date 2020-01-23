﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Dziedziczenie
{
    public abstract class Silnik
    {
        public int Moc { get; private set; }
        public double Spalanie { get; private set; }
        public string Dzwiek { get; private set; }

        public void Dzialaj()
        {
            Console.Write(Dzwiek + " ");
        }


        protected Silnik(int moc, double spalanie, string dzwiek)
        {
            Moc = moc;
            Spalanie = spalanie;
            Dzwiek = dzwiek;
        }
    }
}
