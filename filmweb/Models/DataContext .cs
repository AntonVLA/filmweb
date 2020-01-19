using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace filmweb.Models
{
    public class DataContext : DbContext
    {
        public DbSet<Film> Films { get; set; }
        public DbSet<Actor> Actors { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Producer> Producers { get; set; }

        public DataContext()
        {
            //Database.EnsureDeleted();
            //Database.EnsureCreated();
            //Database.Migrate();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Связь многие к многим FILM-ACTOR
            modelBuilder.Entity<FilmActor>()
                .HasKey(t => new { t.ActorId, t.FilmId });
            modelBuilder.Entity<FilmActor>()
                .HasOne(sc => sc.Actor)
                .WithMany(s => s.Films)
                .HasForeignKey(sc => sc.ActorId);
            modelBuilder.Entity<FilmActor>()
                .HasOne(sc => sc.Film)
                .WithMany(c => c.Actors)
                .HasForeignKey(sc => sc.FilmId);

            // Связь многие ко многим FILM-GENRES
            modelBuilder.Entity<FilmGenre>()
                .HasKey(t => new { t.GenreId, t.FilmId });
            modelBuilder.Entity<FilmGenre>()
                .HasOne(sc => sc.Genre)
                .WithMany(s => s.Films)
                .HasForeignKey(sc => sc.GenreId);
            modelBuilder.Entity<FilmGenre>()
                .HasOne(sc => sc.Film)
                .WithMany(c => c.Genres)
                .HasForeignKey(sc => sc.FilmId);

            // Связь многие ко многим FILM-PRODUCERS
            modelBuilder.Entity<FilmProducer>()
                .HasKey(t => new { t.ProducerId, t.FilmId });
            modelBuilder.Entity<FilmProducer>()
                .HasOne(sc => sc.Producer)
                .WithMany(s => s.Films)
                .HasForeignKey(sc => sc.ProducerId);
            modelBuilder.Entity<FilmProducer>()
                .HasOne(sc => sc.Film)
                .WithMany(c => c.Producers)
                .HasForeignKey(sc => sc.FilmId);

            // Связь многие ко многим FavoriteFilms
            modelBuilder.Entity<FavoriteFilms>()
                .HasKey(t => new { t.UserId, t.FilmId });
            modelBuilder.Entity<FavoriteFilms>()
                .HasOne(sc => sc.Film)
                .WithMany(c => c.UserFav)
                .HasForeignKey(sc => sc.FilmId);
            modelBuilder.Entity<FavoriteFilms>()
                .HasOne(sc => sc.User)
                .WithMany(c => c.FavoriteFilms)
                .HasForeignKey(sc => sc.UserId);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=localhost,1433;Database=filmwebdb;User Id=sa;Password=reallyStrongPwd123; Integrated Security=False");
        }
    }
}
