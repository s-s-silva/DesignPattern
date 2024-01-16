using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Comportamental.Command
{
    public class Interruptor
    {
        public ICommand command;

        public void SetCommand(ICommand command)
        {
            this.command = command;
        }

        public void PressionarBotao()
        {
            command.Executa();
        }
    }
}
