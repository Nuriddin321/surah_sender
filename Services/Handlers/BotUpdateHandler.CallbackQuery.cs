using Telegram.Bot;
using Telegram.Bot.Types;

namespace SurahSender.Services;

public partial class BotUpdateHandler
{
    private string _reciterName = "default";
    private string _sectionName = "default";
    private string _surahName = "default";
    private async Task HandleCallbackQueryAsync(ITelegramBotClient botClient,
                                          CallbackQuery query,
                                          CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(query);

        _logger.LogInformation("Received CallbackQuery from {from.FirstName} : {query.Data}", query.From?.FirstName, query.Data);

        var queryValue = query.Data;

        if (queryValue == "_audioQuran")
        {
            _sectionName = queryValue;
        }
        
        var reciter = query.Data switch
        {
            "_audioQuran" => await botClient.SendTextMessageAsync(
                query.Message.Chat.Id,
                text: "Qaysi qorining qiroatini tinglamoqchisiz?",
                replyMarkup: reciters,
                cancellationToken: cancellationToken),
            
            "_videoQuran" => await botClient.SendTextMessageAsync(
                query.Message.Chat.Id,
                text: "Qaysi qorining qiroatini tinglamoqchisiz?",
                replyMarkup: reciters,
                cancellationToken: cancellationToken),

            
        };

        _logger.LogInformation("_sectionName is {_sectionName}", _sectionName);
        _logger.LogInformation("reciter is {temp}", queryValue);

    }

}