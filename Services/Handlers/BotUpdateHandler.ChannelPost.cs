 
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
        
        var channelPostMessageId = channelPost.MessageId;
        var name = channelPost.Caption;
        var size = 1;

        _logger.LogInformation("Id Of message {id}", channelPostMessageId);

        var result = await _quranService.AddDataAsync(new Entities.Quran()
        {
            IdOfMessage= channelPostMessageId,
            Name = name,
            Size = size
        });

        if (result.IsSuccess)
        {
            _logger.LogInformation($"New Data successfully added to database: {channelPostMessageId}, Name: {channelPost.Type}");
        }
        else
        {
            _logger.LogInformation($"Data not added: {channelPostMessageId}, Error: {result.ErrorMessage}");
        }
    }
}