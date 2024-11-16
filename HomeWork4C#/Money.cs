using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4C_
{
    internal class Money
    {
        protected int wholePart;
        protected int centsPart; 

        public Money(int whole, int cents)
        {
            wholePart = whole;
            centsPart = cents;
            Normalize(); 
        }

        public void SetValues(int whole, int cents)
        {
            wholePart = whole;
            centsPart = cents;
            Normalize();
        }

        public void Display()
        {
            Console.WriteLine($"{wholePart} {GetCurrencyName()} і {centsPart} {GetCentName()}");
        }

        protected void Normalize()
        {
            if (centsPart >= 100)
            {
                wholePart += centsPart / 100;
                centsPart = centsPart % 100;
            }
        }

        private string GetCurrencyName() => "доларів";
        private string GetCentName() => "центів";
    }
}
