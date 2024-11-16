using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4C_
{
    internal abstract class Worker
    {
        protected string position;

        protected Worker(string position) 
        {
            this.position = position;
        }

        public abstract void Print();
    }
}
