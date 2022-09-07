using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PersonalTrainer.Data;
using PersonalTrainer.Data.API;
using PersonalTrainer.Models;
using System.Diagnostics;

namespace PersonalTrainer.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }
        /// <summary>
        /// Pass Home view model to the index page to be used.
        /// </summary>
        /// <returns></returns>
        public async Task<IActionResult> Index()
        {
            List<MyCustomUser> customUsers = await _context.MyCustomUsers.ToListAsync();
            HomeViewModel homeViewModel = new(customUsers);
            return View(homeViewModel);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}