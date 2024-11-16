using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4C_
{
    internal class Microwave : Device
    {
        public Microwave() : base("Мікрохвильовка", "Пристрій для розігріву їжі.") { }

        public override void Sound()
        {
            Console.WriteLine("Мікрохвильовка дзвенить, коли завершено розігрів.");
        }
    }
}
