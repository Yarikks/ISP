using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP
{
    class Client:IClient
    {
        public int tableId { get; set; }

        public List<string> actions { get; set; }
        
        public Client(int table)
        {
            tableId = table;
            actions = new List<string>();
            actions.Add("попросить воды");
            actions.Add("заказать блюдо");
            actions.Add("угостить девушку за соседним столиком");
            actions.Add("рассчитаться");
        }

        public void GetMenu(int waiterId)
        {
            Console.WriteLine($"Клиент получил меню от {waiterId} официанта.");
            Console.WriteLine("..............");
        }

        public void GetReady()
        {
            Console.WriteLine($"Клиент готов заказать.");
        }

        public void CallWaiter(int waiterId)
        {
            Random rnd = new Random();

            Console.WriteLine($"Клиент позвал {waiterId} официанта , чтобы {actions[rnd.Next(0,3)]}. ");
        }

        public void PayOff(int waiterId)
        {
            Console.WriteLine("Клиент платить за блюда, благодарит и уходит.");
        }
    }
}
