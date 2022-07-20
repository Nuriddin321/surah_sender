using Telegram.Bot;
using Telegram.Bot.Types;
using SurahSender.Services.MarcupHelper;


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
            "Fotiha" => HandleFotihaAsync(botClient, query, cancellationToken, key),
            // _ =>  some code here
        };

        _logger.LogInformation("_sectionName is {_sectionName}", _sectionName);
        _logger.LogInformation("reciter is {temp}", queryValue);

    }

    private async Task HandleFotihaAsync(ITelegramBotClient botClient, CallbackQuery query, CancellationToken cancellationToken, string key)
    {  
        var item = _context.Qurans.First(q => q.Name == key);
        var idOfMessage = item.IdOfMessage;

        await botClient.SendTextMessageAsync(
            query.Message.Chat.Id,
            text: "Fotiha",
            cancellationToken: cancellationToken);

        await botClient.ForwardMessageAsync(
            chatId: query.Message.Chat.Id,
            fromChatId: -1001679802094,
            (int)item.IdOfMessage,
            cancellationToken: cancellationToken);

    }

    private async Task HandleAudioQuranAsync(ITelegramBotClient botClient,
                                       CallbackQuery query,
                                       CancellationToken cancellationToken)
    {
        _sectionName = query.Data;
        _logger.LogInformation("_sectionName is {_sectionName}", _sectionName);
        await botClient.SendTextMessageAsync(
            query.Message.Chat.Id,
            text: "Qaysi 👳🏻‍♂️ qorining qiroatini tinglamoqchisiz?",
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
                {"Fotiha", "Fotiha"},
                {"Nas", "002"},
                {"Ift", "003"},
                {"Fotiha1", "004"},
                {"Fotiha2", "005"},

            }
         ),
         cancellationToken: cancellationToken);
        _sectionName = query.Data;
        _logger.LogInformation("_sectionName is {_sectionName}", _sectionName);
        
        // await botClient.ForwardMessageAsync(
        //     chatId: message.Chat.Id,
        //     fromChatId: -1001679802094,
        //     37,
        //     cancellationToken: cancellationToken);
    }

    private async Task HandleTextQuranAsync(ITelegramBotClient botClient,
                                      CallbackQuery query,
                                      CancellationToken cancellationToken)
    {

        if (query.Data == "_textQuran")
        {
            await botClient.SendTextMessageAsync(
                query.Message.Chat.Id,
                text: "Qaysi tilda o'qimoqchisiz?",
                replyMarkup: books,
                cancellationToken: cancellationToken);
        }
        else if (query.Data == "_uzBook")
        {
            var root = Directory.GetCurrentDirectory();
            var filePath = Path.Combine(root, "quroni-karim-alouddin-mansur.pdf");

            var bytes = await System.IO.File.ReadAllBytesAsync(filePath, cancellationToken);

            using var stream = new MemoryStream(bytes);

            await botClient.SendDocumentAsync(
                query.Message.Chat.Id,
                document: stream,
                caption: "📖 Qur'oni Karim. Alouddin Mansur Tarjimasi ",
                cancellationToken: cancellationToken);
        }
        else if (query.Data == "_arabBook")
        {
            var root = Directory.GetCurrentDirectory();
            var filePath = Path.Combine(root, "Quran.pdf");

            var bytes = await System.IO.File.ReadAllBytesAsync(filePath, cancellationToken);

            using var stream = new MemoryStream(bytes);

            await botClient.SendDocumentAsync(
                query.Message.Chat.Id,
                document: stream,
                caption: "📖 Qur'oni Karim",
                cancellationToken: cancellationToken);
        }

    }

    private async Task HandleAlphabetAsync(ITelegramBotClient botClient, CallbackQuery query, CancellationToken cancellationToken)
    {
        _sectionName = query.Data;
        _logger.LogInformation("_sectionName is {_sectionName}", _sectionName);
        //code here
        throw new NotImplementedException();
    }

}