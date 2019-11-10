using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP
{
    public interface IClient
    {
        int tableId { get; set; }
        List<string> actions { get; set; }

        void GetMenu(int waiterId);

        void CallWaiter(int waiterId);

        void PayOff(int waiterId);

        void GetReady();
    }
}
