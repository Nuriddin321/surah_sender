using Microsoft.EntityFrameworkCore;
using SurahSender.Entities;

namespace SurahSender.Data;

public class AppDbContext : DbContext
{
    public DbSet<Quran>? Qurans { get; set; }
    
    public AppDbContext(DbContextOptions<AppDbContext> options): 
    base(options) {}

    
}