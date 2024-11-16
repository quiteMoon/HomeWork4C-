using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4C_
{
    internal class Car : Device
    {
        public Car() : base("Автомобіль", "Транспортний засіб для пересування.") { }

        public override void Sound()
        {
            Console.WriteLine("Врум-врум");
        }
    }
}
