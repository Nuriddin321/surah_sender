// using Telegram.Bot;
// using Telegram.Bot.Types;

namespace SurahSender.Services;

public partial class BotUpdateHandler
{
    private async Task HandleCallbackQueryAsync(ITelegramBotClient botClient,
                                          CallbackQuery query,
                                          CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(query);

        var from = query.From;

        _logger.LogInformation("Received CallbackQuery from {from.FirstName} : {query.Data}", from?.FirstName, query.Data);

        await botClient.SendTextMessageAsync(
            message.Chat.Id,
            text: "Qur'on tingla botga xush kelibsiz ",
            cancellationToken: cancellationToken
        );
    }
}