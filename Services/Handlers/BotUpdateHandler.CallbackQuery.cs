using Telegram.Bot;
using Telegram.Bot.Types;

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

        var temp = query.Data;
        var reciter = query.Data switch
        {
            "_audioQuran" => await botClient.SendTextMessageAsync(
                query.Message.Chat.Id,
                text: "Qaysi qorining qiroatini tinglamoqchisiz?",
                replyMarkup: reciters,
                cancellationToken: cancellationToken),

            _ => await botClient.SendTextMessageAsync(
                query.Message.Chat.Id,
                text: $"default",
                cancellationToken: cancellationToken),
        };
        _logger.LogInformation("reciter is {temp}", temp);
 
    }

}