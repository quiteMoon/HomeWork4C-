using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4C_
{
    internal class Security : Worker
    {
        public Security() : base("Охоронець")
        {
        }

        public override void Print()
        {
            Console.WriteLine($"Посада: {position} - Відповідає за забезпечення безпеки на робочому місці.");
        }
    }
}
