using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PersonalTrainer.Models;

namespace PersonalTrainer.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<MyCustomUser> MyCustomUsers { get; set; }
        public DbSet<Trainer> Trainers { get; set; }
        public DbSet<Inquiry> Inquiries { get; set; }
    }
}