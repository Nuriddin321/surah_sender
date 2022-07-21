using Microsoft.EntityFrameworkCore;
using SurahSender.Entities;

namespace SurahSender.Data;

public class AppDbContext : DbContext
{
    private readonly string _connectionString;

    public DbSet<Quran>? Qurans { get; set; }
    public AppDbContext(string conn)
    {
        _connectionString = conn;

    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite(_connectionString);
    }
    public AppDbContext(DbContextOptions<AppDbContext> options) :
    base(options)
    { }


}