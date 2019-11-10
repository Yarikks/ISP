using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP
{
    class Program
    {
        static void Main(string[] args)
        {
            Client c1 = new Client(5);
            Waiter w1 = new Waiter(1);
            Chef ch1 = new Chef();

            w1.BringMenu(c1.tableId);
            c1.GetMenu(w1.waiterId);

            c1.GetReady();
            w1.GetOrder("Голубцы", c1.tableId);

            ch1.GetOrder("Голубцы");
            ch1.Cook("Голубцы");
            ch1.Cookedmeal();

            w1.BringOrder("Голубцы", c1.tableId);

            c1.CallWaiter(w1.waiterId);
            w1.GoForCall(c1.tableId);

            w1.AcceptPayment(c1.tableId);
            c1.PayOff(w1.waiterId);

            Console.ReadLine();
        }
    }
}
