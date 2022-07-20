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

        var handler = query.Data switch
        {
            "_audioQuran" => HandleAudioQuranAsync(botClient, query, cancellationToken),
            "_videoQuran" => HandleVideoQuranAsync(botClient, query, cancellationToken),
            "_textQuran" => HandleTextQuranAsync(botClient, query, cancellationToken),
            "_alphabet" => HandleAlphabetAsync(botClient, query, cancellationToken),
            _ => Task.CompletedTask
        };

        _logger.LogInformation("_sectionName is {_sectionName}", _sectionName);
        _logger.LogInformation("reciter is {temp}", queryValue);
        
        await handler;
    }
 
    private async Task HandleAudioQuranAsync(ITelegramBotClient botClient,
                                       CallbackQuery query,
                                       CancellationToken cancellationToken)
    {
        await botClient.SendTextMessageAsync(
            query.Message.Chat.Id,
            text: "Qaysi qorining qiroatini tinglamoqchisiz?",
            replyMarkup: reciters,
            cancellationToken: cancellationToken);
    }

    private async Task HandleVideoQuranAsync(ITelegramBotClient botClient,
                                      CallbackQuery query,
                                      CancellationToken cancellationToken)
    {
        await botClient.SendTextMessageAsync(
            query.Message.Chat.Id,
            text: "Qaysi qorining qiroatini tinglamoqchisiz?",
            replyMarkup: reciters,
            cancellationToken: cancellationToken);
    }

    private async Task HandleTextQuranAsync(ITelegramBotClient botClient,
                                      CallbackQuery query,
                                      CancellationToken cancellationToken)
    {

        
        await botClient.SendDocumentAsync(
            query.Message.Chat.Id,
            document: "https://github.com/TelegramBots/book/raw/master/src/docs/photo-ara.jpg",
            caption: "<b>Ara bird</b>. <i>Source</i>: <a href=\"https://pixabay.com\">Pixabay</a>",
            cancellationToken: cancellationToken);

    }

    private async Task HandleAlphabetAsync(ITelegramBotClient botClient, CallbackQuery query, CancellationToken cancellationToken)
    {
        //code here
        throw new NotImplementedException();
    }

}