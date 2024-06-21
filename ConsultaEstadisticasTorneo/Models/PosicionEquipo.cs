namespace ConsultaEstadisticasTorneo.Models
{
    public class PosicionEquipo
    {
        public int Pos { get; set; }
        public Equipo Equipo { get; set; } = null!;
        public int EquipoId { get; set; }
        public int PJ { get; set; }
        public int PG { get; set; }
        public int PE { get; set; }
        public int PP { get; set; }
        public int GF { get; set; }
        public int GC { get; set; }
        public int Dif { get; set; }
        public int PTS { get; set; }
    }
}
