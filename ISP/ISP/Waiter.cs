using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP
{
    class Waiter:IWaiter
    {
        public int waiterId { get; set; }

        public Waiter(int waiterN)
        {

            waiterId = waiterN;
        }


        public void BringMenu(int tableId)
        {
            Console.WriteLine($"Официант принес меню за {tableId} столик.\n");
        }

        public void GetOrder(string order, int tableId)
        {
            Console.WriteLine($"{waiterId} официант принимает заказ: {order}\n С {tableId} столика и несет его к повару.");
        }

        public void BringOrder(string order, int tableId)
        {
            Console.WriteLine($"{waiterId} официант забирает готовый заказ: {order}\nУ повара и несет его за {tableId} столик.");
        }

        public void GoForCall(int tableId)
        {
            Console.WriteLine($"{waiterId} официант бежит к {tableId} столику, чтобы выполнить просьбу.");
        }

        public void AcceptPayment(int tableId)
        {
            Console.WriteLine($"{waiterId} официант рассчитивает {tableId} столик.");
        }
    }
}
