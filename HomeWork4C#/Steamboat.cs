using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4C_
{
    internal class Steamboat : Device
    {
        public Steamboat() : base("Пароплав", "Судно для водних перевезень.") { }

        public override void Sound()
        {
            Console.WriteLine("Пароплав сигналить: 'Гудок пароплава!'");
        }
    }
}
