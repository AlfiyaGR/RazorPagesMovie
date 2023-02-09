using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovie.Data;
using RazorPagesMovie.Models;

namespace RazorPagesMovie.Controllers
{
    public class MovieController : Controller
    {
        private readonly RazorPagesMovieContext _context;

        public MovieController(RazorPagesMovieContext context)
        {
            _context = context;
        }

        // GET: Movie
        public async Task<IActionResult> Index()
        {
            var movies = await _context.Movie.ToListAsync();

            List<MovieDto> result = new List<MovieDto>();
            foreach (var movie in movies)
            {
                result.Add(new MovieDto
                { 
                    movieId = movie.Id,
                    Date = movie.Date,
                    GenreName = movie.Genre?.Name,
                    Price = movie.Price,
                    Title = movie.Title,
                });
            }

            return Json(result);
        }

        //        // GET: MovieDtoes/Details/5
        //        public async Task<IActionResult> Details(int? id)
        //        {
        //            if (id == null || _context.MovieDto == null)
        //            {
        //                return NotFound();
        //            }

        //            var movieDto = await _context.MovieDto
        //                .FirstOrDefaultAsync(m => m.Id == id);
        //            if (movieDto == null)
        //            {
        //                return NotFound();
        //            }

        //            return View(movieDto);
        //        }

        //        // GET: MovieDtoes/Create
        //        public IActionResult Create()
        //        {
        //            return View();
        //        }

        //        // POST: MovieDtoes/Create
        //        // To protect from overposting attacks, enable the specific properties you want to bind to.
        //        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //        [HttpPost]
        //        [ValidateAntiForgeryToken]
        //        public async Task<IActionResult> Create([Bind("Id,movieId,Title,Date,GenreName,Price")] MovieDto movieDto)
        //        {
        //            if (ModelState.IsValid)
        //            {
        //                _context.Add(movieDto);
        //                await _context.SaveChangesAsync();
        //                return RedirectToAction(nameof(Index));
        //            }
        //            return View(movieDto);
        //        }

        //        // GET: MovieDtoes/Edit/5
        //        public async Task<IActionResult> Edit(int? id)
        //        {
        //            if (id == null || _context.MovieDto == null)
        //            {
        //                return NotFound();
        //            }

        //            var movieDto = await _context.MovieDto.FindAsync(id);
        //            if (movieDto == null)
        //            {
        //                return NotFound();
        //            }
        //            return View(movieDto);
        //        }

        //        // POST: MovieDtoes/Edit/5
        //        // To protect from overposting attacks, enable the specific properties you want to bind to.
        //        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //        [HttpPost]
        //        [ValidateAntiForgeryToken]
        //        public async Task<IActionResult> Edit(int id, [Bind("Id,movieId,Title,Date,GenreName,Price")] MovieDto movieDto)
        //        {
        //            if (id != movieDto.Id)
        //            {
        //                return NotFound();
        //            }

        //            if (ModelState.IsValid)
        //            {
        //                try
        //                {
        //                    _context.Update(movieDto);
        //                    await _context.SaveChangesAsync();
        //                }
        //                catch (DbUpdateConcurrencyException)
        //                {
        //                    if (!MovieDtoExists(movieDto.Id))
        //                    {
        //                        return NotFound();
        //                    }
        //                    else
        //                    {
        //                        throw;
        //                    }
        //                }
        //                return RedirectToAction(nameof(Index));
        //            }
        //            return View(movieDto);
        //        }

        //        // GET: MovieDtoes/Delete/5
        //        public async Task<IActionResult> Delete(int? id)
        //        {
        //            if (id == null || _context.MovieDto == null)
        //            {
        //                return NotFound();
        //            }

        //            var movieDto = await _context.MovieDto
        //                .FirstOrDefaultAsync(m => m.Id == id);
        //            if (movieDto == null)
        //            {
        //                return NotFound();
        //            }

        //            return View(movieDto);
        //        }

        //        // POST: MovieDtoes/Delete/5
        //        [HttpPost, ActionName("Delete")]
        //        [ValidateAntiForgeryToken]
        //        public async Task<IActionResult> DeleteConfirmed(int id)
        //        {
        //            if (_context.MovieDto == null)
        //            {
        //                return Problem("Entity set 'RazorPagesMovieContext.MovieDto'  is null.");
        //            }
        //            var movieDto = await _context.MovieDto.FindAsync(id);
        //            if (movieDto != null)
        //            {
        //                _context.MovieDto.Remove(movieDto);
        //            }

        //            await _context.SaveChangesAsync();
        //            return RedirectToAction(nameof(Index));
        //        }

        //        private bool MovieDtoExists(int id)
        //        {
        //          return _context.MovieDto.Any(e => e.Id == id);
        //        }
    }
}
