using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Comportamental.Command
{
    public class LigarCommand : ICommand
    {
        private Luz luz;

        public LigarCommand(Luz luz)
        {
            this.luz = luz;
        }
        public void Executa()
        {
            luz.Ligar();
        }
    }
}
