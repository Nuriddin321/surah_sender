 
using Telegram.Bot;
using Telegram.Bot.Types;

namespace SurahSender.Services;

public partial class BotUpdateHandler
{
    private QuranService _quranService;

    private async Task HandlerChannelPostAsync(ITelegramBotClient botClient, Message? channelPost, CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(channelPost);

        using var scope = _scopeFactory.CreateScope();
        
        _quranService = scope.ServiceProvider.GetRequiredService<QuranService>();
        
        var idOfMessage = channelPost.MessageId;
        var name = channelPost.Caption;
        var size = 1;

        _logger.LogInformation("Id Of message {id}", idOfMessage);

        var result = await _quranService.AddDataAsync(new Entities.Quran()
        {
            IdOfMessage = idOfMessage,
            Name = name,
            Size = size
        });

        if (result.IsSuccess)
        {
            _logger.LogInformation($"New Quran Video successfully added: {idOfMessage}, Name: {name}");
            _logger.LogInformation($"canal id: {channelPost.Chat.Id}, Name: {name}");

        }
        else
        {
            _logger.LogInformation($"Quran video not added: {idOfMessage}, Error: {result.ErrorMessage}");
        }
    }
}