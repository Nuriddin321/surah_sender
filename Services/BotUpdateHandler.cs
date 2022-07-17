using Telegram.Bot;
using Telegram.Bot.Polling;
using Telegram.Bot.Types;

namespace surah_sender.Services;
public class BotUpdateHandler : IUpdateHandler
{
    private readonly ILogger<BotUpdateHandler> _logger;
    public BotUpdateHandler(ILogger<BotUpdateHandler> logger)
    {
        _logger = logger; 
    }
    public Task HandlePollingErrorAsync(ITelegramBotClient botClient, Exception exception, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
    public Task HandleUpdateAsync(ITelegramBotClient botClient, Exception exception, CancellationToken cancellationToken)
    {
        throw new NotImplementedException(); 
    }

    public Task HandleUpdateAsync(ITelegramBotClient botClient, Update update, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}