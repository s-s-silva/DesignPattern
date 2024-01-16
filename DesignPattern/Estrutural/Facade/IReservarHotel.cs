using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DesignPattern.Facade
{
    public interface IReservarHotel
    {
        decimal Preco {  get; set; }
        public void SelecionarQuarto();
        public void SelecionarHotel();
        public void ConfirmarHotel();

        public decimal CalcularTotal();
    }
}
