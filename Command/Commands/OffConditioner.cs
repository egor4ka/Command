using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Commands
{
    internal class OffConditioner : ICommand
    {
        private Conditioner _conditioner;

        public OffConditioner(Conditioner conditioner)
        {
            _conditioner = conditioner ?? throw new ArgumentNullException(nameof(conditioner));
        }

        public void Execute()
        {
            _conditioner.Off();
        }
    }
}
