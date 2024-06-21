namespace ConsultaEstadisticasTorneo.Models
{
    public class Clasificacion
    {
        public int Posicion { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public int PartidosJugados { get; set; }
        public int PartidosGanados { get; set; }
        public int PartidosEmpatados { get; set; }
        public int PartidosPerdidos { get; set; }
        public int GolesAFavor { get; set; }
        public int GolesEnContra { get; set; }
        public int DiferenciaGol { get; set; }
        public int Puntos => (PartidosGanados * 3) + (PartidosEmpatados * 1);
    }
}