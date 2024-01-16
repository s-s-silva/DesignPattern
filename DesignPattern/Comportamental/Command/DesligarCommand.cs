using DesignPattern.Facade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Comportamental.Command
{
    public class DesligarCommand : ICommand
    {
        private Luz luz;

        public DesligarCommand(Luz luz)
        {
            this.luz = luz;
        }
        public void Executa()
        {
            luz.Desligar();
        }
    }
}
