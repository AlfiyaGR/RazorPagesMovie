using Microsoft.EntityFrameworkCore;
using RazorPagesMovie.Data;
using System.Diagnostics;

namespace RazorPagesMovie.Models
{
    public class SeedData
    {
        public static void Initialize(RazorPagesMovieContext context)
        {
            if (context.Movie.Any())
            {
                return;
            }           
        }
    }
}
