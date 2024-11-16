using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4C_
{
    internal class Manager : Worker
    {
        public Manager() : base("Менеджер")
        {
        }

        public override void Print()
        {
            Console.WriteLine($"Посада: {position} - Відповідає за організацію та координацію роботи команди.");
        }
    }
}
