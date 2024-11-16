using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4C_
{
    internal class Cello : MusicalInstrument
    {
        public Cello() : base("Віолончель", "Струнний музичний інструмент з насиченим тоном.", "Віолончель розвинулася в 17 столітті в Італії і є важливою частиною оркестру.")
        {
        }

        public override void Sound()
        {
            Console.WriteLine("Віолончель видає звук: 'Вум-вум'.");
        }
    }
}
