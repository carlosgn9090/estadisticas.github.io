namespace ConsultaEstadisticasTorneo.Models
{
    public class Gol
    {
        public int GolId { get; set; }
        public int PartidoId { get; set; }
        public int JugadorId { get; set; } // Can be null for own goals
        public int EquipoId { get; set; }
        public int Minuto { get; set; }
        public bool EsAutogol { get; set; }
        public Partido? Partido { get; set; }
        public Jugador? Jugador { get; set; }
    }
}
