using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Facade
{
    public interface IProcessadorPagamento
    {
        public decimal valor {  get; set; }
        public void ProcessarPagamento(decimal valor);
    }
}
