using Moves_List.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using movies.ViewModels;
using System.Collections.Generic;
using System.IO;
using System;

namespace Moves_List.Controllers
{
    public class MovesController : Controller
    {
        private readonly AppDbContext _context;

        public MovesController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var Movies = await _context.Moves.ToListAsync();
            return View(Movies);
        }
        public async Task<IActionResult> Create()
        {
            var model = new Movies_VM
            {
                Genres = await _context.Genres.OrderBy(a => a.Name).ToListAsync()
            };

            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Movies_VM model)
        {
            if (!ModelState.IsValid)
            {
                model.Genres = await _context.Genres.OrderBy(a => a.Name).ToListAsync();
                return View(model);
            }
            var files = Request.Form.Files;
            if (!files.Any())
            {
                model.Genres = await _context.Genres.OrderBy(a => a.Name).ToListAsync();
                ModelState.AddModelError("Poster", "Pleas Select Poster..!");
                return View(model);
            }
            var poster = files.FirstOrDefault();
            var EX = new List<string> { ".jpg", ".png" };
            if (!EX.Contains(Path.GetExtension(poster.FileName).ToLower()))
            {
                model.Genres = await _context.Genres.OrderBy(a => a.Name).ToListAsync();
                ModelState.AddModelError("Poster", "jpg or png only ..!");
                return View(model);
            }
            if (poster.Length < 1048576)
            {
                model.Genres = await _context.Genres.OrderBy(a => a.Name).ToListAsync();
                ModelState.AddModelError("Poster", "1MB only ..!");
                return View(model);
            }
            using var stream = new MemoryStream();
            await poster.CopyToAsync(stream);
            var move = new Move
            {
                Title = model.Title,
                GenreId = model.GenreId,
                Rate = model.Rate,
                Year = model.Year,
                StoryLine = model.StoryLine,
                Poster = stream.ToArray()
            };
            _context.Add(move);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));


        }

    }
}
