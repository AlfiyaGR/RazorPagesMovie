﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RazorPagesMovie.Data;

#nullable disable

namespace RazorPagesMovie.Migrations
{
    [DbContext(typeof(RazorPagesMovieContext))]
    [Migration("20230209112543_CreateFill")]
    partial class CreateFill
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("RazorPagesMovie.Models.Author", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nickname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Author", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Age = 22,
                            Email = "tt@mail.ru",
                            Nickname = "Poppy"
                        },
                        new
                        {
                            Id = 2,
                            Age = 32,
                            Email = "dthd@mail.ru",
                            Nickname = "Rob"
                        },
                        new
                        {
                            Id = 3,
                            Age = 23,
                            Email = "hgj465@mail.ru",
                            Nickname = "Al97"
                        });
                });

            modelBuilder.Entity("RazorPagesMovie.Models.Genre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Genre", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Actions"
                        });
                });

            modelBuilder.Entity("RazorPagesMovie.Models.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int?>("GenreId")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("GenreId");

                    b.ToTable("Movie", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Date = new DateTime(2001, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            GenreId = 1,
                            Price = 1.7m,
                            Title = "The Spirit"
                        },
                        new
                        {
                            Id = 2,
                            Date = new DateTime(2015, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            GenreId = 1,
                            Price = 2.4m,
                            Title = "Robot"
                        },
                        new
                        {
                            Id = 3,
                            Date = new DateTime(2000, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            GenreId = 1,
                            Price = 5.8m,
                            Title = "Katty in Hollywood"
                        });
                });

            modelBuilder.Entity("RazorPagesMovie.Models.MovieAuthor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AuthorId")
                        .HasColumnType("int");

                    b.Property<int>("MovieId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.HasIndex("MovieId");

                    b.ToTable("MovieAuthor", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AuthorId = 1,
                            MovieId = 2
                        },
                        new
                        {
                            Id = 2,
                            AuthorId = 2,
                            MovieId = 2
                        },
                        new
                        {
                            Id = 3,
                            AuthorId = 3,
                            MovieId = 2
                        },
                        new
                        {
                            Id = 4,
                            AuthorId = 1,
                            MovieId = 1
                        },
                        new
                        {
                            Id = 5,
                            AuthorId = 2,
                            MovieId = 1
                        },
                        new
                        {
                            Id = 6,
                            AuthorId = 3,
                            MovieId = 3
                        },
                        new
                        {
                            Id = 7,
                            AuthorId = 1,
                            MovieId = 3
                        });
                });

            modelBuilder.Entity("RazorPagesMovie.Models.Movie", b =>
                {
                    b.HasOne("RazorPagesMovie.Models.Genre", "Genre")
                        .WithMany()
                        .HasForeignKey("GenreId");

                    b.Navigation("Genre");
                });

            modelBuilder.Entity("RazorPagesMovie.Models.MovieAuthor", b =>
                {
                    b.HasOne("RazorPagesMovie.Models.Author", "Author")
                        .WithMany()
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RazorPagesMovie.Models.Movie", "Movie")
                        .WithMany("Authors")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");

                    b.Navigation("Movie");
                });

            modelBuilder.Entity("RazorPagesMovie.Models.Movie", b =>
                {
                    b.Navigation("Authors");
                });
#pragma warning restore 612, 618
        }
    }
}
