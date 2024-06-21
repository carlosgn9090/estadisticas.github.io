namespace ConsultaEstadisticasTorneo.Models
{
    public class Partido
    {
        public int PartidoId { get; set; }
        public int JornadaId { get; set; }
        public int EquipoLocalId { get; set; }
        public int EquipoVisitanteId { get; set; }
        public DateTime FechaHora { get; set; }
        public int GolesLocal { get; set; }
        public int GolesVisitante { get; set; }
        public string Notas { get; set; } = string.Empty;

        public Jornada Jornada { get; set; } = null!;
        public Equipo EquipoLocal { get; set; } = null!;
        public Equipo EquipoVisitante { get; set; } = null!;
        public ICollection<Gol> Goles { get; set; } = new List<Gol>();
        public ICollection<Amonestacion> Amonestaciones { get; set; } = new List<Amonestacion>();
    }
}
