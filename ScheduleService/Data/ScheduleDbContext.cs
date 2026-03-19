using Microsoft.EntityFrameworkCore;
using MarketBackend.ScheduleService.Models;

namespace MarketBackend.ScheduleService.Data
{
    public class ScheduleDbContext : DbContext
    {
        public ScheduleDbContext(DbContextOptions<ScheduleDbContext> options) : base(options) { }

        public DbSet<Schedule> Schedules { get; set; }
    }
}
