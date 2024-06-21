using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ConsultaEstadisticasTorneo.Models;

namespace ConsultaEstadisticasTorneo.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Torneo> Torneos { get; set; }
        public DbSet<Equipo> Equipos { get; set; }
        public DbSet<Jugador> Jugadores { get; set; }
        public DbSet<Jornada> Jornadas { get; set; }
        public DbSet<Partido> Partidos { get; set; }
        public DbSet<Gol> Goles { get; set; }
        public DbSet<Amonestacion> Amonestaciones { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configuración de la relación Equipo - Partido (Local y Visitante)
            modelBuilder.Entity<Partido>()
                .HasOne(p => p.EquipoLocal)
                .WithMany(e => e.PartidosLocal)
                .HasForeignKey(p => p.EquipoLocalId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Partido>()
                .HasOne(p => p.EquipoVisitante)
                .WithMany(e => e.PartidosVisitante)
                .HasForeignKey(p => p.EquipoVisitanteId)
                .OnDelete(DeleteBehavior.Restrict);

            // Configuración de la relación Jornada - Partido
            modelBuilder.Entity<Partido>()
                .HasOne(p => p.Jornada)
                .WithMany(j => j.Partidos)
                .HasForeignKey(p => p.JornadaId)
                .OnDelete(DeleteBehavior.Cascade);

            // Configuración de la relación Torneo - Jornada
            modelBuilder.Entity<Jornada>()
                .HasOne(j => j.Torneo)
                .WithMany(t => t.Jornadas)
                .HasForeignKey(j => j.TorneoId)
                .OnDelete(DeleteBehavior.Cascade);

            // Configuración de la relación Torneo - Equipo
            modelBuilder.Entity<Torneo>()
                .HasMany(t => t.Equipos)
                .WithOne(e => e.Torneo)
                .HasForeignKey(e => e.TorneoId);

            // Configuración de la relación Equipo - Jugador
            modelBuilder.Entity<Equipo>()
                .HasMany(e => e.Jugadores)
                .WithOne(j => j.Equipo)
                .HasForeignKey(j => j.EquipoId);
        }
    }
}
