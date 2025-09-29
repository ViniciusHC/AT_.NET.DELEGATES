using Delegate.Delegates;
using Delegate.Models;

namespace Delegate.Services
{
    public class ReservaService
    {
        public bool TentarAdicionarReserva(PacoteTuristico pacote, Reserva nova)
        {
            var futuras = pacote.Reservas.Count + 1;

            if (futuras > pacote.CapacidadeMaxima)
            {
                Reserva.RaiseCapacityReached(pacote);
                LogDelegate.Log($"Tentativa excedeu capacidade do pacote '{pacote.Titulo}'.");
                return false;
            }

            pacote.Reservas.Add(nova);
            LogDelegate.Log("Reserva adicionada no pacote "+pacote.Titulo+". Total: "+pacote.Reservas.Count+".");
            return true;
        }
    }
}
