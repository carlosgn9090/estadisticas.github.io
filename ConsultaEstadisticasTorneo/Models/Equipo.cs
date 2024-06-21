namespace ConsultaEstadisticasTorneo.Models
{
    public class Equipo
    {
        public int EquipoId { get; set; }
        public int TorneoId { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Logo { get; set; } = string.Empty;

        public Torneo Torneo { get; set; } = null!;
        public ICollection<Jugador> Jugadores { get; set; } = new List<Jugador>();
        public ICollection<Partido> PartidosLocal { get; set; } = new List<Partido>();
        public ICollection<Partido> PartidosVisitante { get; set; } = new List<Partido>();
    }
}
