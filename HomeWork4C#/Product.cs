using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4C_
{
    internal class Product : Money
    {
        private string productName;

        public Product(string name, int whole, int cents) : base(whole, cents)
        {
            productName = name;
        }   
        
        public void DecreasePrice(int whole, int cents)
        {
            int totalCents = (wholePart * 100 + centsPart) - (whole * 100 + cents);
            if (totalCents < 0)
            {
                totalCents = 0;
            }

            wholePart = totalCents / 100;
            centsPart = totalCents % 100;
            Normalize();
        }
        public void DisplayProduct()
        {
            Console.Write($"{productName}: ");
            base.Display();
        }
    }
}
