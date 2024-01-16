using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Comportamental.Command
{
    public class Luz
    {
        private bool on = false;

        public void Ligar()
        {
            on = true;
            Console.WriteLine($"Ligada!");
        }
        public void Desligar()
        {
            on = false;
            Console.WriteLine($"Desligada!");
        }
    }
}
