namespace Delegate.Models
{
    public class PacoteTuristico
    {
        public int Id { get; set; }
        public string Titulo { get; set; } = "";
        public int CapacidadeMaxima { get; set; }
        public decimal Preco { get; set; } // diária
        public List<Models.Reserva> Reservas { get; set; } = new();
    }
}
