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
        public DbSet<User> Users { get; set; }
        public DbSet<Comment> Comments { get; set; }

        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {
            
        }


        public DataContext()
        {
            //Database.EnsureDeleted();
            //Database.EnsureCreated();
            //Database.Migrate();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region manyToMany
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
            #endregion

            #region initdata

            modelBuilder.Entity<Genre>().HasData(
                new Genre[]
                {
                    new Genre {Id = 3, Name = "Боевик"},
                    new Genre {Id = 1, Name = "Фентези"},
                    new Genre {Id = 2, Name = "Детектив"}
                });

            modelBuilder.Entity<Actor>().HasData(
                new Actor[]
                {
                    new Actor {Id = 3, Name = "Леонардо Дикаприо"},
                    new Actor {Id = 1, Name = "Джони Деп"},
                    new Actor {Id = 2, Name = "Том Круз"}
                });

            modelBuilder.Entity<Producer>().HasData(
                new Producer[]
                {
                    new Producer {Id = 3, Name = "Кристофер Нолан"},
                    new Producer {Id = 1, Name = "Квентин Тарантино"},
                    new Producer {Id = 2, Name = "Стэнли Кубрик"}
                });

            modelBuilder.Entity<Film>().HasData(
                new Film[]
                {
                    new Film {Id = 3, Name = "Тёмный рыцарь"},
                    new Film {Id = 1, Name = "Однажды в Голивуде"},
                    new Film {Id = 2, Name = "Космическая одисея"}
                });

            modelBuilder.Entity<User>().HasData(
                new User[]
                {
                    new User {Id = 3, Login = "test"}
                });

            modelBuilder.Entity<Comment>().HasData(
                new Comment[]
                {
                    new Comment {Id = 3, FilmId=3, UserId=3, Text = "классный фильм!"},
                });

            modelBuilder.Entity<FilmActor>().HasData(
                new FilmActor[]
                {
                    new FilmActor {FilmId = 3, ActorId = 3},
                    new FilmActor {FilmId = 1, ActorId = 2},
                    new FilmActor {FilmId = 2, ActorId = 1}
                });

            modelBuilder.Entity<FilmGenre>().HasData(
                new FilmGenre[]
                {
                    new FilmGenre {FilmId = 3, GenreId = 1},
                    new FilmGenre {FilmId = 1, GenreId = 2},
                    new FilmGenre {FilmId = 2, GenreId = 3}
                });

            modelBuilder.Entity<FilmProducer>().HasData(
                new FilmProducer[]
                {
                    new FilmProducer {FilmId = 3, ProducerId = 3},
                    new FilmProducer {FilmId = 1, ProducerId = 1},
                    new FilmProducer {FilmId = 2, ProducerId = 2}
                });


            #endregion
        }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer(@"Server=localhost,1433;Database=filmwebdb;User Id=sa;Password=reallyStrongPwd123; Integrated Security=False");
            optionsBuilder.UseSqlServer(@"Data Source=.\;Database=filmvebdb;Integrated Security=True;");
        }
    }
}
