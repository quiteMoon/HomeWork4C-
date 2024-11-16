using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4C_
{
    internal class Trombone : MusicalInstrument
    {
        public Trombone() : base("Тромбон", "Духовий інструмент з глибоким звучанням.", "Тромбон був створений у 15 столітті і часто використовується в оркестрах.")
        {
        }

        public override void Sound()
        {
            Console.WriteLine("Тромбон видає звук: 'Туууууу'.");
        }
    }
}
