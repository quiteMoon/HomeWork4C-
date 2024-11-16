using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4C_
{
    internal class Kettle : Device
    {
        public Kettle() : base("Чайник", "Пристрій для нагрівання води.") { }

        public override void Sound()
        {
            Console.WriteLine("Чайник свистить.");
        }
    }
}
