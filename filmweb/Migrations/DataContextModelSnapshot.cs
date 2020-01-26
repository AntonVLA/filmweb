﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using filmweb.Data;

namespace filmweb.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("filmweb.Models.Actor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Actors");

                    b.HasData(
                        new
                        {
                            Id = 3,
                            Name = "Леонардо Дикаприо"
                        },
                        new
                        {
                            Id = 1,
                            Name = "Джони Деп"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Том Круз"
                        });
                });

            modelBuilder.Entity("filmweb.Models.Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("FilmId")
                        .HasColumnType("int");

                    b.Property<string>("Text")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("FilmId");

                    b.HasIndex("UserId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("filmweb.Models.FavoriteFilms", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("FilmId")
                        .HasColumnType("int");

                    b.HasKey("UserId", "FilmId");

                    b.HasIndex("FilmId");

                    b.ToTable("FavoriteFilms");
                });

            modelBuilder.Entity("filmweb.Models.Film", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Films");

                    b.HasData(
                        new
                        {
                            Id = 3,
                            Name = "Тёмный рыцарь"
                        },
                        new
                        {
                            Id = 1,
                            Name = "Однажды в Голивуде"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Космическая одисея"
                        });
                });

            modelBuilder.Entity("filmweb.Models.FilmActor", b =>
                {
                    b.Property<int>("ActorId")
                        .HasColumnType("int");

                    b.Property<int>("FilmId")
                        .HasColumnType("int");

                    b.HasKey("ActorId", "FilmId");

                    b.HasIndex("FilmId");

                    b.ToTable("FilmActor");

                    b.HasData(
                        new
                        {
                            ActorId = 3,
                            FilmId = 3
                        },
                        new
                        {
                            ActorId = 2,
                            FilmId = 1
                        },
                        new
                        {
                            ActorId = 1,
                            FilmId = 2
                        });
                });

            modelBuilder.Entity("filmweb.Models.FilmGenre", b =>
                {
                    b.Property<int>("GenreId")
                        .HasColumnType("int");

                    b.Property<int>("FilmId")
                        .HasColumnType("int");

                    b.HasKey("GenreId", "FilmId");

                    b.HasIndex("FilmId");

                    b.ToTable("FilmGenre");

                    b.HasData(
                        new
                        {
                            GenreId = 1,
                            FilmId = 3
                        },
                        new
                        {
                            GenreId = 2,
                            FilmId = 1
                        },
                        new
                        {
                            GenreId = 3,
                            FilmId = 2
                        });
                });

            modelBuilder.Entity("filmweb.Models.FilmProducer", b =>
                {
                    b.Property<int>("ProducerId")
                        .HasColumnType("int");

                    b.Property<int>("FilmId")
                        .HasColumnType("int");

                    b.HasKey("ProducerId", "FilmId");

                    b.HasIndex("FilmId");

                    b.ToTable("FilmProducer");

                    b.HasData(
                        new
                        {
                            ProducerId = 3,
                            FilmId = 3
                        },
                        new
                        {
                            ProducerId = 1,
                            FilmId = 1
                        },
                        new
                        {
                            ProducerId = 2,
                            FilmId = 2
                        });
                });

            modelBuilder.Entity("filmweb.Models.Genre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Genres");

                    b.HasData(
                        new
                        {
                            Id = 3,
                            Name = "Боевик"
                        },
                        new
                        {
                            Id = 1,
                            Name = "Фентези"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Детектив"
                        });
                });

            modelBuilder.Entity("filmweb.Models.Producer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Producers");

                    b.HasData(
                        new
                        {
                            Id = 3,
                            Name = "Кристофер Нолан"
                        },
                        new
                        {
                            Id = 1,
                            Name = "Квентин Тарантино"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Стэнли Кубрик"
                        });
                });

            modelBuilder.Entity("filmweb.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Login")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("filmweb.Models.Comment", b =>
                {
                    b.HasOne("filmweb.Models.Film", "Film")
                        .WithMany()
                        .HasForeignKey("FilmId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("filmweb.Models.User", "User")
                        .WithMany("Comments")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("filmweb.Models.FavoriteFilms", b =>
                {
                    b.HasOne("filmweb.Models.Film", "Film")
                        .WithMany("UserFav")
                        .HasForeignKey("FilmId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("filmweb.Models.User", "User")
                        .WithMany("FavoriteFilms")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("filmweb.Models.FilmActor", b =>
                {
                    b.HasOne("filmweb.Models.Actor", "Actor")
                        .WithMany("Films")
                        .HasForeignKey("ActorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("filmweb.Models.Film", "Film")
                        .WithMany("Actors")
                        .HasForeignKey("FilmId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("filmweb.Models.FilmGenre", b =>
                {
                    b.HasOne("filmweb.Models.Film", "Film")
                        .WithMany("Genres")
                        .HasForeignKey("FilmId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("filmweb.Models.Genre", "Genre")
                        .WithMany("Films")
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("filmweb.Models.FilmProducer", b =>
                {
                    b.HasOne("filmweb.Models.Film", "Film")
                        .WithMany("Producers")
                        .HasForeignKey("FilmId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("filmweb.Models.Producer", "Producer")
                        .WithMany("Films")
                        .HasForeignKey("ProducerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
