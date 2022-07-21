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

        var key = query.Data;

        _logger.LogInformation("Received CallbackQuery from {from.FirstName} : {query.Data}", query.From?.FirstName, query.Data);

        var queryValue = query.Data;

        _logger.LogInformation("button is {queryValue}", queryValue);

        var handler = query.Data switch
        {
            "_audioQuran" => HandleAudioQuranAsync(botClient, query, cancellationToken),
            "_videoQuran" => HandleVideoQuranAsync(botClient, query, cancellationToken),
            "_textQuran" or "_arabBook" or "_uzBook" => HandleTextQuranAsync(botClient, query, cancellationToken),
            "_alphabet" => HandleAlphabetAsync(botClient, query, cancellationToken),
 
            "_next1" or "_next2" => HandleViewOfSurahsync(botClient, query, cancellationToken),
            "_reciters1" or "_reciters2" or "_reciters3" => HandleRecitersAsync(botClient, query, cancellationToken),
            _ => HandleSurahNumberAsync(botClient, query, cancellationToken)
        };
 
        // _logger.LogInformation("_sectionName is {_sectionName}", _sectionName);
        // _logger.LogInformation("reciter is {temp}", queryValue);

    }
 

}