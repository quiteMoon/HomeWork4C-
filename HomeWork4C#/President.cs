using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4C_
{
    internal class President : Worker
    {
        public President() : base("Президент")
        {
        }

        public override void Print()
        {
            Console.WriteLine($"Посада: {position} - Відповідає за загальне управління компанією та прийняття стратегічних рішень.");
        }
    }
}
