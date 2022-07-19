using Microsoft.AspNetCore.Mvc;
using SurahSender.Entities;
using Telegram.Bot;
using Telegram.Bot.Types;

namespace SurahSender.Services;

public partial class BotUpdateHandler
{
    private async Task HandlerChannelPostAsync(ITelegramBotClient botClient, Message? channelPost, CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(channelPost);

        var id = channelPost.MessageId;
        _logger.LogInformation("Id Of message {id}", id);

    }
}