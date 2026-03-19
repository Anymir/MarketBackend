using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using MarketBackend.AuthService.Models;

namespace MarketBackend.AuthService.Data
{
    public class AuthDbContext : DbContext
    {
        public AuthDbContext(DbContextOptions<AuthDbContext> options) : base(options) { }
        public DbSet<User> Users { get; set; }
    }
}
