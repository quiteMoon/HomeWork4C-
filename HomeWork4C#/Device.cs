using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4C_
{
    internal class Device
    {
        protected string name;
        protected string description;

        public Device(string name, string description)
        {
            this.name = name;
            this.description = description;
        }

        public virtual void Show()
        {
            Console.WriteLine($"Назва пристрою: {name}");
        }

        public virtual void Desc()
        {
            Console.WriteLine($"Опис: {description}");
        }

        public virtual void Sound()
        {
            Console.WriteLine("Пристрій видає звук.");
        }
    }
}
