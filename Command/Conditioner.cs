using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    internal class Conditioner
    {
        public void On()
        {
            Console.WriteLine("Кондиционер включен");
        }

        public void Off()
        {
            Console.WriteLine("Кондиционер выключен");
        }
    }
}
