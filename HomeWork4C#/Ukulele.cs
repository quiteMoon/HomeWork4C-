using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4C_
{
    internal class Ukulele : MusicalInstrument
    {
        public Ukulele() : base("Укулеле", "Невеликий струнний інструмент родом з Гаваїв.", "Укулеле з'явилося в 19 столітті і швидко стало популярним у світі.")
        {
        }

        public override void Sound()
        {
            Console.WriteLine("Укулеле видає звук: 'Трі-лінг'.");
        }
    }
}
