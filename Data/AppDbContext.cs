using Microsoft.EntityFrameworkCore;
using SurahSender.Entities;

namespace SurahSender.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options): 
    base(options) {}

    public DbSet<Quran>? Qurans { get; set; }
}