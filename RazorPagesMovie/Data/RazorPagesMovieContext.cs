using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovie.Models;

namespace RazorPagesMovie.Data
{
    public class RazorPagesMovieContext : DbContext
    {
        public RazorPagesMovieContext(DbContextOptions<RazorPagesMovieContext> options)
            : base(options)
        {
        }

        public DbSet<Movie> Movie { get; set; } = default!;
        public DbSet<Genre> Genre { get; set; } = default!;
        public DbSet<Author> Author { get; set; } = default!;
        public DbSet<MovieAuthor> MovieAuthor { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>().ToTable("Movie");
            modelBuilder.Entity<Genre>().ToTable("Genre");
            modelBuilder.Entity<Author>().ToTable("Author");
            modelBuilder.Entity<MovieAuthor>().ToTable("MovieAuthor");

            modelBuilder.Entity<Genre>().HasData(new Genre { Id = 1, Name = "Actions" });
            
            //TODO: Add authors
            modelBuilder.Entity<Author>().HasData(new Author { Id = 1, Nickname = "Poppy", Age = 22, Email = "tt@mail.ru" },
                 new Author { Id = 2, Nickname = "Rob", Age = 32, Email = "dthd@mail.ru" },
                 new Author { Id = 3, Nickname = "Al97", Age = 23, Email = "hgj465@mail.ru" });

            modelBuilder.Entity<Movie>().HasData(new Movie { Id = 1, GenreId = 1, Title = "The Spirit", Date = DateTime.Parse("2001-1-23"), Price = 1.7M },
                new Movie { Id = 2, GenreId = 1, Title = "Robot", Date = DateTime.Parse("2015-5-29"), Price = 2.4M },
                new Movie { Id = 3, GenreId = 1, Title = "Katty in Hollywood", Date = DateTime.Parse("2000-2-2"), Price = 5.8M });

            //TODO: Add movie author
            modelBuilder.Entity<MovieAuthor>().HasData(new MovieAuthor { Id = 1, AuthorId = 1, MovieId = 2 },
                new MovieAuthor { Id = 2, AuthorId = 2, MovieId = 2 }, new MovieAuthor { Id = 3, AuthorId = 3, MovieId = 2},
                new MovieAuthor { Id = 4, AuthorId = 1, MovieId = 1 }, new MovieAuthor { Id = 5, AuthorId = 2, MovieId = 1 },
                new MovieAuthor { Id = 6, AuthorId = 3, MovieId = 3 }, new MovieAuthor { Id = 7, AuthorId = 1, MovieId = 3 });
        }
        
    }
}
