using Microsoft.EntityFrameworkCore;
using SurahSender.Data;
using SurahSender.Entities;

namespace SurahSender.Services;

public class QuranService
{
    private readonly AppDbContext _context;

    public QuranService(AppDbContext context)
    {
        _context = context;
    }
    public async Task<Quran?> GetQuranAsync(long? Id)
    {
        ArgumentNullException.ThrowIfNull(Id);

        var quran = await _context.Qurans.FindAsync(Id);

        return quran;
    }
    public async Task<(bool IsSuccess, string? ErrorMessage)> AddDataAsync(Quran quran)
    {
        if (await Exists(quran.IdOfMessage))
            return (false, "Quran exists");
        try
        {
            var result = await _context.Qurans.AddAsync(quran);
            await _context.SaveChangesAsync();
            return (true, null);
        }
        catch (Exception e)
        {
            return (false, e.Message);
        }
    }
    public async Task<bool> Exists(long idOfMessage)
        => await _context.Qurans.AnyAsync(u => u.IdOfMessage == idOfMessage);
}