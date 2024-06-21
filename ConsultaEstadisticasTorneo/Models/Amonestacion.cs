namespace ConsultaEstadisticasTorneo.Models
{
    public class Amonestacion
    {
        public int AmonestacionId { get; set; }
        public int PartidoId { get; set; }
        public int JugadorId { get; set; }
        public string? Tipo { get; set; } // Amarilla, Roja
        public int Minuto { get; set; }
    }
}
