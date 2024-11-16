using System;
using System.Text;

namespace HomeWork4C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            //Завдання 1
            /*Money money = new Money(10, 150);
            money.Display();

            Product product = new Product("Шоколад", 5, 99);
            product.DisplayProduct();
            product.DecreasePrice(1, 50); 
            product.DisplayProduct();*/

            //Завдання 2
            /*Device[] devices = new Device[]
            {
                new Kettle(),
                new Microwave(),
                new Car(),
                new Steamboat()
            };

            foreach (var device in devices)
            {
                device.Show();
                device.Desc();
                device.Sound();
                Console.WriteLine();
            }*/

            //Завдання 3
            /*MusicalInstrument[] instruments = new MusicalInstrument[]
            {
                new Violin(),
                new Trombone(),
                new Ukulele(),
                new Cello()
            };

            foreach (var instrument in instruments)
            {
                instrument.Show();
                instrument.Desc();
                instrument.History();
                instrument.Sound();
                Console.WriteLine();
            }*/

            //Завдання 4
            /*Worker[] workers = new Worker[]
            {
                new President(),
                new Security(),
                new Manager(),
                new Engineer()
            };

            foreach (var worker in workers)
            {
                worker.Print();
                Console.WriteLine();
            }*/
        }
    }
}
