using Telegram.Bot;
using Telegram.Bot.Polling;

namespace SurahSender.Services;

public class BotBackgroundService : BackgroundService  // => bu class ExecuteAsync metodi orqali botni avtomatik ravishda ishga tushiradi
{
    private readonly ILogger<BotBackgroundService> _logger;
    private readonly TelegramBotClient _client;
    private readonly IUpdateHandler _handler;

    public BotBackgroundService(ILogger<BotBackgroundService> logger,
                                TelegramBotClient client,
                                IUpdateHandler handler) // => "BotBackgroundService" konstruktorida ILogger , TelegramBotClient va IUpdateHandler lar inject qilindi
    {
        _logger = logger;
        _client = client;
        _handler = handler;
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        var bot = await _client.GetMeAsync(stoppingToken);

        _logger.LogInformation("bot started succesfully : {bot.Username}", bot.Username);

        _client.StartReceiving( 
            _handler.HandleUpdateAsync,
            _handler.HandlePollingErrorAsync,
            new ReceiverOptions()
            {
                ThrowPendingUpdates = true // => bu code - bot run bolmagan paytda yozilgan bir nechta smslarni o'qimay tashlab yuboradi 
            },
            stoppingToken);  // => bu StartReceiving metodi ishga tushganda bot eshitishni boshlaydi yani userdan keldan xar qanday xabarni handle qiladi
    }
}