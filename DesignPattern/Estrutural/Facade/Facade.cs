
namespace DesignPattern.Facade
{
    #region --- Classes ---
    public class ReservarVoo : IReservarVoo
    {
        public decimal Preco { get; set; }

        public void SelecionarVoo()
        {
            Console.WriteLine("Seu voo foi selecionado.");
            ConfirmarVoo();
        }
        public void ConfirmarVoo()
        {
            Console.WriteLine("Seu voo foi reservado.");
        }
        public decimal CalcularTotal()
        {
            return Preco;
        }
    }

    public class ReservarHotel : IReservarHotel
    {
        public decimal Preco { get; set; }
        public void SelecionarQuarto()
        {
            Console.WriteLine("Seu quarto foi selecionado.");
            ConfirmarHotel();
        }
        public void SelecionarHotel()
        {
            Console.WriteLine("Seu hotel foi selecionado.");
            SelecionarQuarto();
        }
        public void ConfirmarHotel()
        {
            Console.WriteLine("Seu quarto foi reservado.");
        }

        public decimal CalcularTotal()
        {
            return Preco;
        }
    }

    public class ProcessadorPagamento : IProcessadorPagamento
    {
        public decimal valor {  get; set; }
        public void ProcessarPagamento(decimal valor)
        {
            Console.WriteLine("Pagamento processado.");
        }
    }
    #endregion

    #region --- Facade ---
    public class ReservasDeViagemFacade
    {
        private ReservarVoo _reservarVoo;
        private ReservarHotel _reservarHotel;
        private ProcessadorPagamento _processadorPagamento;

        public ReservasDeViagemFacade()
        {
            _reservarVoo = new ReservarVoo();
            _reservarHotel = new ReservarHotel();
            _processadorPagamento = new ProcessadorPagamento();
        }

        public void ReservarHotel()
        {
            _reservarHotel.SelecionarHotel();
        }
        public decimal CalcularTotalHotel()
        {
            return _reservarHotel.CalcularTotal();
        }

        public void ReservarVoo()
        {
            _reservarVoo.SelecionarVoo();
        }
        public decimal CalcularTotalVoo()
        {
            return _reservarVoo.CalcularTotal();
        }
        public void FinalizarCompra()
        {
            decimal totalHotel = CalcularTotalHotel();
            decimal totalVoo = CalcularTotalVoo();
            _processadorPagamento.ProcessarPagamento(totalHotel);
            _processadorPagamento.ProcessarPagamento(totalVoo);
        }

    }
    #endregion

}
