
using DesignPattern.Comportamental.Command;
using DesignPattern.Facade;

#region --- Command ---

Console.WriteLine("\n --- Command --- \n");
Luz luz = new Luz();
Interruptor interruptor = new Interruptor();

ICommand ligarCommand = new LigarCommand(luz);
ICommand desligarCommand = new DesligarCommand(luz);

interruptor.SetCommand(ligarCommand);
interruptor.PressionarBotao();

interruptor.SetCommand(desligarCommand);
interruptor.PressionarBotao();

#endregion

#region --- Facade ---
Console.WriteLine("\n --- Facade --- \n");
ReservasDeViagemFacade reserva = new ReservasDeViagemFacade();
reserva.ReservarHotel();
reserva.ReservarVoo();
reserva.FinalizarCompra();

#endregion