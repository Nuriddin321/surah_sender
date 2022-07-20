using Telegram.Bot;
using Telegram.Bot.Types;
using SurahSender.Services.MarcupHelper;
using SurahSender.Data;
namespace SurahSender.Services;
public partial class BotUpdateHandler
{
    private string _reciterName = "default";
    private string _sectionName = "default";
    private string _surahName = "default";
    private QuranService _scopSelect;
    private int surah;
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
            "001" => HandleFotihaAsync(botClient, query, cancellationToken),
            // _ =>  some code here
        };

        _logger.LogInformation("_sectionName is {_sectionName}", _sectionName);
        _logger.LogInformation("reciter is {temp}", queryValue);

    }

    private async Task HandleFotihaAsync(ITelegramBotClient botClient, CallbackQuery query, CancellationToken cancellationToken)
    {

        await botClient.SendTextMessageAsync(
            query.Message.Chat.Id,
            text: "Fotiha",
            cancellationToken: cancellationToken);

        await botClient.ForwardMessageAsync(
            chatId: query.Message.Chat.Id,
            fromChatId: -1001679802094,
            96,
            cancellationToken: cancellationToken);

    }

    private Task HandleAlphabetAsync(ITelegramBotClient botClient, CallbackQuery query, CancellationToken cancellationToken)
    {
        //code here
        throw new NotImplementedException();
    }



    private Task HandleTextQuranAsync(ITelegramBotClient botClient, CallbackQuery query, CancellationToken cancellationToken)
    {
        //code here
        throw new NotImplementedException();
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
         replyMarkup: MarcupHelpers.GetKeyboardMarkup(
            new Dictionary<string, string>
            {
                {"Fotiha", "001"},
                {"Nas", "002"},
                {"Ift", "003"},
                {"Fotiha1", "004"},
                {"Fotiha2", "005"},

            }
         ),
         cancellationToken: cancellationToken);
    }


}