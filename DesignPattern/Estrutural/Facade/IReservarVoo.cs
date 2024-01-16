using System;

namespace DesignPattern.Facade
{
    public interface IReservarVoo
    {
        decimal Preco { get; set; }
        void SelecionarVoo();
        void ConfirmarVoo();
        public decimal CalcularTotal(); 

    }
}
