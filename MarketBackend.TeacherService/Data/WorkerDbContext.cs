using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using MarketBackend.WorkerService.Models;

namespace MarketBackend.WorkerService.Data
{
    public class WorkerDbContext : DbContext
    {
        public WorkerDbContext(DbContextOptions<WorkerDbContext> options) : base(options) { }

        public DbSet<Worker> Workers { get; set; }
        public DbSet<Lesson> Lessons { get; set; }
        public DbSet<Student> Students { get; set; }
    }
}
