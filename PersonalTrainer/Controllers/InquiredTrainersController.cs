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
        /// <summary>
        /// Index page shows the list of inquired trainers by the user logged in
        /// </summary>
        /// <param name="id">id of the user that is logged in</param>
        /// <param name="page">page number that user is on</param>
        /// <returns></returns>
        public async Task<IActionResult> Index(string? id, int? page)
        {
            const int NumTrainersToDisplayPerPage = 10;
            const int PageOffset = 1; // Need a page offset to use current page and figure out, num games to skip
            int currentPage = page ?? 1;

            int totalNumOfInquiries = await _context.Inquiries.Where(i => i.Id == id).CountAsync();
            double maxNumPages = Math.Ceiling((double)totalNumOfInquiries / NumTrainersToDisplayPerPage);
            int lastPage = Convert.ToInt32(maxNumPages); // Rounding pages up, to next whole page number

            List<Inquiry> inquiries = await _context.Inquiries.Where(i => i.Id == id)
                                    .Skip(NumTrainersToDisplayPerPage * (currentPage - PageOffset))
                                    .Take(NumTrainersToDisplayPerPage).ToListAsync();

            List<MyCustomUser> allUsers = await _context.MyCustomUsers.ToListAsync();

            List<Trainer> trainers = await _context.Trainers.ToListAsync();

            ClientInquiryListViewModel clientInquiryListViewModel = new(trainers, allUsers, inquiries, lastPage, currentPage);

            return View(clientInquiryListViewModel);
        }
    }
}
