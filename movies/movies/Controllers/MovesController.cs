using Moves_List.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

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

    }
}
