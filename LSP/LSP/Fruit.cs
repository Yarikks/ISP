using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP
{
    public abstract class Fruit
    {
        public virtual string GetColor()
        {
            return "Фрукт - ";
        }
    }
}
