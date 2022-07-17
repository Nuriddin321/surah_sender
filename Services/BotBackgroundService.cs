using Telegram.Bot;

namespace surahSender.Services;

public class BotBackgroundService : BackgroundService
{
    private readonly ILogger<BotBackgroundService> _logger;
    private readonly TelegramBotClient _client;

    public BotBackgroundService(ILogger<BotBackgroundService> logger, TelegramBotClient client)
    {
        _logger = logger;
        _client = client;
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        var bot = await _client.GetMeAsync(stoppingToken);

        _logger.LogInformation("bot started succesfully : {bot.Username}", bot.Username);
    }
}