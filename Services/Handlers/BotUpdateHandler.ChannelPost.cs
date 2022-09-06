 
using Telegram.Bot;
using Telegram.Bot.Types;

namespace SurahSender.Services;

public partial class BotUpdateHandler
{

    private async Task HandlerChannelPostAsync(ITelegramBotClient botClient, Message? channelPost, CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(channelPost);

        var channelPostMessageId = channelPost.MessageId;

        _logger.LogInformation($"New Data successfully added to channel: {channelPostMessageId}, Name: {channelPost.Type}");

    }
}