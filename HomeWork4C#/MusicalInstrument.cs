using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4C_
{
    internal class MusicalInstrument
    {
        protected string name;
        protected string description;
        protected string history;

        public MusicalInstrument(string name, string description, string history)
        {
            this.name = name;
            this.description = description;
            this.history = history;
        }

        public virtual void Show()
        {
            Console.WriteLine($"Назва музичного інструменту: {name}");
        }

        public virtual void Desc()
        {
            Console.WriteLine($"Опис: {description}");
        }

        public virtual void History()
        {
            Console.WriteLine($"Історія: {history}");
        }

        public virtual void Sound()
        {
            Console.WriteLine("Інструмент видає звук.");
        }
    }
}
