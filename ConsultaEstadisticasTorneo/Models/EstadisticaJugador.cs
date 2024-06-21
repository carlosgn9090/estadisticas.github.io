namespace ConsultaEstadisticasTorneo.Models
{
    public class EstadisticaJugador
    {
        public Jugador Jugador { get; set; } = null!;
        public Equipo Equipo { get; set; } = null!;
        public string Nombre { get; set; } = string.Empty;
        public int Goles { get; set; }
        public int Tarjetas { get; set; }
    }
}
