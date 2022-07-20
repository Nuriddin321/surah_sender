using SurahSender.Data;

namespace SurahSender.Services;

public class QuranSelect
{
    private ILogger<QuranSelect> _logger;
    private AppDbContext _context;

    public QuranSelect(
        ILogger<QuranSelect> logger,
        AppDbContext context)
    {
        _logger = logger;
        _context = context;
        
    }
    

}