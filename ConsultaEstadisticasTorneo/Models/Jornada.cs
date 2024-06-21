namespace ConsultaEstadisticasTorneo.Models
{
    public class Jornada
    {
        public int JornadaId { get; set; }
        public int TorneoId { get; set; }
        public string Nombre { get; set; } = string.Empty;

        public Torneo Torneo { get; set; } = null!;
        public ICollection<Partido> Partidos { get; set; } = new List<Partido>();
    }
}
