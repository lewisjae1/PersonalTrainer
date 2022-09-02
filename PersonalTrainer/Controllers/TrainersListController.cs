using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PersonalTrainer.Data;
using PersonalTrainer.Models;

namespace PersonalTrainer.Controllers
{
    public class TrainersListController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TrainersListController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: TrainersList
        public async Task<IActionResult> Index(int? id)
        {
            const int NumTrainersToDisplayPerPage = 10;
            const int PageOffset = 1; // Need a page offset to use current page and figure out, num games to skip
            int currentPage = id ?? 1;

            int totalNumOfTrainers = await _context.Trainers.Where(t => t.Listed == true).CountAsync();
            double maxNumPages = Math.Ceiling((double)totalNumOfTrainers / NumTrainersToDisplayPerPage);
            int lastPage = Convert.ToInt32(maxNumPages); // Rounding pages up, to next whole page number

            // Get all games from the DB
            List<Trainer> trainers = await _context.Trainers.Where(t => t.Listed == true)
                                    .Skip(NumTrainersToDisplayPerPage * (currentPage - PageOffset))
                                    .Take(NumTrainersToDisplayPerPage).ToListAsync();

            List<MyCustomUser> allUsers = await _context.MyCustomUsers.ToListAsync();

            TrainerListViewModel TrainerListModel = new(trainers, allUsers, lastPage, currentPage);
            return View(TrainerListModel);
        }

        // GET: TrainersList/Details/5
        public async Task<IActionResult> Details(string? id)
        {
            if (id == null || _context.Trainers == null)
            {
                return NotFound();
            }

            var trainer = await _context.MyCustomUsers
                .FirstOrDefaultAsync(m => m.Id == id);
            if (trainer == null)
            {
                return NotFound();
            }

            return View(trainer);
        }

        // GET: TrainersList/Create
        public async Task<IActionResult> Inquiry(string? id)
        {
            Trainer trainer = await _context.Trainers
                             .FirstOrDefaultAsync(m => m.Id == id);

            Inquiry newInquiry = new();

            newInquiry.TrainerId = trainer.TrainerId;

            return View(newInquiry);
        }

        // POST: TrainersList/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Inquiry(Inquiry newInquiry)
        {
            List<Inquiry> inquiries = await _context.Inquiries.ToListAsync();

            for (int i = 0; i < inquiries.Count(); i++)
            {
                if (inquiries[i].Id == newInquiry.Id && inquiries[i].TrainerId == newInquiry.TrainerId)
                {
                    ViewData["Message"] = "Inquiry has already been sent!";
                }
            }

            if (ViewData["Message"] != "Inquiry has already been sent!")
            {
                newInquiry.Status = "Pending";

                await _context.Inquiries.AddAsync(newInquiry);
                await _context.SaveChangesAsync();

                ViewData["Message"] = "Successfully submitted!";

            }

            return View();
        }
    }
}
