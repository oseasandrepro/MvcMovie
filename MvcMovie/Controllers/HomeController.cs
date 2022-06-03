using Microsoft.AspNetCore.Mvc;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace MvcMovie.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Index(string searchString)
        {
            var movies = from m in _context.Movie select m;

            if( !String.IsNullOrEmpty(searchString) )
            {
                movies = movies.Where( s => s.Title!.Contains(searchString) );
            }

            return View(await movies.ToListAsync());
        }
    }
}
