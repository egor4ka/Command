﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Commands
{
    internal class CloseDoor : ICommand
    {
        private Door _door;

        public CloseDoor(Door door)
        {
            _door = door ?? throw new ArgumentNullException(nameof(door));
        }

        public void Execute()
        {
            _door.Close();
        }
    }
}
