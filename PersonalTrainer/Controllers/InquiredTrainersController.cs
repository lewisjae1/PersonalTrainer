using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PersonalTrainer.Data;
using PersonalTrainer.Models;

namespace PersonalTrainer.Controllers
{
    public class InquiredTrainersController : Controller
    {
        private readonly ApplicationDbContext _context;

        public InquiredTrainersController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index(string? id, int? page)
        {
            const int NumGamesToDisplayPerPage = 3;
            const int PageOffset = 1; // Need a page offset to use current page and figure out, num games to skip
            int currentPage = page ?? 1;

            int totalNumOfProducts = await _context.Trainers.CountAsync();
            double maxNumPages = Math.Ceiling((double)totalNumOfProducts / NumGamesToDisplayPerPage);
            int lastPage = Convert.ToInt32(maxNumPages); // Rounding pages up, to next whole page number

            List<Inquiry> inquiries = await _context.Inquiries
                                    .Skip(NumGamesToDisplayPerPage * (currentPage - PageOffset))
                                    .Take(NumGamesToDisplayPerPage).Where(i => i.Id == id).ToListAsync();

            List<MyCustomUser> allUsers = await _context.MyCustomUsers.ToListAsync();

            List<Trainer> trainers = await _context.Trainers.ToListAsync();

            ClientInquiryListViewModel clientInquiryListViewModel = new(trainers, allUsers, inquiries, lastPage, currentPage);

            return View(clientInquiryListViewModel);
        }
    }
}
