using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4C_
{
    internal class Engineer : Worker
    {
        public Engineer() : base("Інженер")
        {
        }

        public override void Print()
        {
            Console.WriteLine($"Посада: {position} - Виконує технічні завдання та розробляє інженерні рішення.");
        }
    }
}
