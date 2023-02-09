namespace RazorPagesMovie.Models
{
    public class MovieAuthor
    {
        public int Id { get; set; }

        public int AuthorId { get; set; }

        public virtual Author? Author { get; set; }

        public int MovieId { get; set; }

        public virtual Movie? Movie { get; set; }
    }
}
