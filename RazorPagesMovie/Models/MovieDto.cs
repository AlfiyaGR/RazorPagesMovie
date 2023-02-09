using System.ComponentModel.DataAnnotations;

namespace RazorPagesMovie.Models
{
    public class MovieDto
    {
        //[Key]
        //public int Id { get; set; }

        public int movieId { get; set; }

        public string? Title { get; set; }

        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        public string? GenreName { get; set; }

        public decimal Price { get; set; }

        public ICollection<string>? AuthorNames { get; set; }

        public IList<string>? AuthorEmail { get; set; }
    }
    //todo: 2. Add lazy load. 3. Return type MovieDto (Id, Title, GenreName, Price, Date)
    // https://learn.microsoft.com/ru-ru/aspnet/core/tutorials/razor-pages/sql?view=aspnetcore-7.0&tabs=visual-studio - работа с базой данных
}
