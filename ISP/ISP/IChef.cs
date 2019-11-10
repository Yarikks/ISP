using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP
{
    interface IChef
    {
        void GetOrder(string order);

        void Cook(string order);

        void CookedMeal();
    }
}
