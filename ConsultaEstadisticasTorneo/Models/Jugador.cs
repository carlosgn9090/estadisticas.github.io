namespace ConsultaEstadisticasTorneo.Models
{
    public class Jugador
    {
        public int JugadorId { get; set; }
        public int EquipoId { get; set; }
        public string? Nombre { get; set; }
        public string? Identificacion { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public ICollection<Gol> Goles { get; set; } = new List<Gol>();
        public Equipo Equipo { get; set; } = null!;
        public ICollection<Amonestacion> Amonestaciones { get; set; } = new List<Amonestacion>();
    }
}
