using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4C_
{
    internal class Violin : MusicalInstrument
    {
        public Violin() : base("Скрипка", "Струнний музичний інструмент з високим тоном.", "Скрипка походить з Італії 16 століття.")
        {
        }

        public override void Sound()
        {
            Console.WriteLine("Скрипка видає звук: 'Віііііі'.");
        }
    }
}
