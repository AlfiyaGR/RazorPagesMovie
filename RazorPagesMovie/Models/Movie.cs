using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Infrastructure.Internal;
using System.ComponentModel.DataAnnotations;
using static NuGet.Packaging.PackagingConstants;

namespace RazorPagesMovie.Models
{
    public class Movie
    {
        public int Id { get; set; }

        public int? GenreId { get; set; }

       //public virtual Genre? Genre { get; set; }

        public virtual ICollection<MovieAuthor>? Authors { get; set; }

        public string? Title { get; set; }

        public decimal Price { get; set; }

        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        private Genre? _genre;

        //private ICollection<MovieAuthor>? _author;

        private ILazyLoader? LazyLoader { get; set; }

        public Movie() { }

        private Movie(ILazyLoader lazyLoader)
        {
            LazyLoader = lazyLoader;
        }

        public Genre? Genre
        {
            get => LazyLoader.Load(this, ref _genre);
            set => _genre = value;
        }
        /*
        public ICollection<MovieAuthor>? Authors
        {
            get => LazyLoader.Load(this, ref _author);
            set => _author = value;
        }*/
    }
}
