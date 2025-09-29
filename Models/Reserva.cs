namespace Delegate.Models
{
    public class Reserva
    {
        public int Id { get; set; }
        public int ClienteId { get; set; }
        public int PacoteTuristicoId { get; set; }
      
        public static event Action<PacoteTuristico>? CapacidadeMaxima;

        public static void RaiseCapacityReached(PacoteTuristico pacote)
            => CapacidadeMaxima?.Invoke(pacote);
    }
}
