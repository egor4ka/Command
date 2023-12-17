﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    internal class Remote
    {
        private Dictionary<int, (ICommand Remult, ICommand Undo)> _commands = new Dictionary<int, (ICommand Remult, ICommand Undo)>();
        private Stack<ICommand> _undo = new Stack<ICommand>();

        public void Add(int number, ICommand remult, ICommand undo)
        {
            _commands.Add(number, (remult, undo));
        }

        public void Execute(int number)
        {
            if (_commands.ContainsKey(number))
            {
                _commands[number].Remult.Execute();
                _undo.Push(_commands[number].Undo);
            }
            else
            {
                throw new ArgumentException("Кнопка не найдена", nameof(number));
            }
        }

        public void Undo()
        {
            if (_undo.Count > 0)
            {
                _undo.Pop().Execute();
            }
            else
            {
                Console.WriteLine("Нет выполненных команд для отмены");
            }
        }
    }
}
