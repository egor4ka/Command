﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    internal class Light
    {
        public void On()
        {
            Console.WriteLine("Свет включен");
        }

        public void Off()
        {
            Console.WriteLine("Свет выключен");
        }
    }
}
