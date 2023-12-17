using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    internal class Door
    {
        public void Open()
        {
            Console.WriteLine("Дверь открыта");
        }

        public void Close()
        {
            Console.WriteLine("Дверь закрыта");
        }
    }
}
