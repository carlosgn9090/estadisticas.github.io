namespace ConsultaEstadisticasTorneo.Models
{
    public class Torneo
    {
        public int TorneoId { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Logo { get; set; } = string.Empty;
        public ICollection<Equipo>? Equipos { get; set; }
        public ICollection<Jornada> Jornadas { get; set; } = new List<Jornada>();
    }
}