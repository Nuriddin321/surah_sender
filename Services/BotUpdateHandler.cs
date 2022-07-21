
using SurahSender.Data;
using Telegram.Bot;
using Telegram.Bot.Polling;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;

namespace SurahSender.Services;

public partial class BotUpdateHandler : IUpdateHandler
{
    private readonly ILogger<BotUpdateHandler> _logger;
    private readonly IServiceScopeFactory _scopeFactory;
    private readonly AppDbContext _context;

    public BotUpdateHandler(
        ILogger<BotUpdateHandler> logger, 
        IServiceScopeFactory scopeFactory,
        AppDbContext context)
    {
        _logger = logger;
        _scopeFactory = scopeFactory;
        _context =context;
    }
    public Task HandlePollingErrorAsync(ITelegramBotClient botClient,
                                        Exception exception,
                                        CancellationToken cancellationToken)
    {
        _logger.LogInformation("Error ocured with Telegram bot : {e.Message}", exception);

        return Task.CompletedTask;
    }

    public async Task HandleUpdateAsync(ITelegramBotClient botClient,
                                        Update update,
                                        CancellationToken cancellationToken)
    {   _logger.LogInformation("Update type {update.Type} received ", update.Type);

        var handler = update.Type switch
        {
            UpdateType.Message => HandleMessageAsync(botClient, update.Message, cancellationToken),  
            UpdateType.CallbackQuery => HandleCallbackQueryAsync(botClient, update.CallbackQuery, cancellationToken),
            UpdateType.ChannelPost => HandlerChannelPostAsync(botClient, update.ChannelPost, cancellationToken),
            _ => HandleUnknownUpdate(botClient, update, cancellationToken)
        };

        try
        {
            await handler;
        }
        catch (Exception e)
        {
            await HandlePollingErrorAsync(botClient, e, cancellationToken);
        }
    }

    private Task HandleUnknownUpdate(ITelegramBotClient botClient,
                                     Update update,
                                     CancellationToken cancellationToken)
    {
        _logger.LogInformation("Update type {update.Type} received ", update.Type);

        return Task.CompletedTask;
    }
}

