using Microsoft.EntityFrameworkCore;
using TE_CODEFIRST.Models;
//using NToastNotify;

namespace TE_CODEFIRST.Data
{
    public class TraineeDbContext: DbContext
    {
        public TraineeDbContext(DbContextOptions<TraineeDbContext> options) : base(options)
        {

        }

        public DbSet<Trainee> Trainees { get; set; }

    }
}