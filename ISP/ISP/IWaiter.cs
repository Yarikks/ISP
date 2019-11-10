using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP
{
    interface IWaiter
    {
        int waiterId { get; set; }

        void BringMenu(int tableId);

        void GetOrder(string order, int tableId);

        void BringOrder(string order, int tableId);

        void GoForCall(int tableId);

        void AcceptPayment(int tableId);
    }
}
