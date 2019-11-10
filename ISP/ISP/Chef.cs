using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP
{
    class Chef
    {
        public void GetOrder(string order)
        {
            Console.WriteLine($"Повар принял заказ:{order}");
        }

        public void Cook(string order)
        {
            Console.WriteLine($"Повар начал готовить: {order}");
        }

        public void Cookedmeal()
        {
            Console.WriteLine($"Повар приготовил заказаное блюдо.");
        }
    }
}
