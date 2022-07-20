using Telegram.Bot;
using Telegram.Bot.Types;
using SurahSender.Services.MarcupHelper;
using SurahSender.Data;
namespace SurahSender.Services;
public partial class BotUpdateHandler
{
    private string _reciterName = "default";
    private string _sectionName = "default";
    private int _surahNumber = 0;


    // private QuranService _scopSelect;
    // private int surah;
    private async Task HandleCallbackQueryAsync(ITelegramBotClient botClient,
                                          CallbackQuery query,
                                          CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(query);

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
            _ => HandleSurahAsync(botClient, query, cancellationToken)
        };


    }

    private async Task HandleViewOfSurahsync(ITelegramBotClient botClient, CallbackQuery query, CancellationToken cancellationToken)
    {
        if (query.Data == "_next1")
        {
            var root = Directory.GetCurrentDirectory();
            var filePath = Path.Combine(root, "img41-80.png");

            var bytes = await System.IO.File.ReadAllBytesAsync(filePath, cancellationToken);

            using var stream = new MemoryStream(bytes);
            await botClient.SendPhotoAsync(
                query.Message.Chat.Id,
                photo: stream,
                replyMarkup: buttonsOfSurah2,
                cancellationToken: cancellationToken);
        }
        else if (query.Data == "_next2")
        {
            var root = Directory.GetCurrentDirectory();
            var filePath = Path.Combine(root, "img81-114.png");

            var bytes = await System.IO.File.ReadAllBytesAsync(filePath, cancellationToken);

            using var stream = new MemoryStream(bytes);
            await botClient.SendPhotoAsync(
                query.Message.Chat.Id,
                photo: stream,
                replyMarkup: buttonsOfSurah3,
                cancellationToken: cancellationToken);
        }

    }

    private async Task HandleRecitersAsync(ITelegramBotClient botClient, CallbackQuery query, CancellationToken cancellationToken)
    {
        _reciterName = query.Data;
        _logger.LogInformation("buttonVlaue is {queryValue}", query.Data);

        var root = Directory.GetCurrentDirectory();
        var filePath = Path.Combine(root, "img1-40.png");

        var bytes = await System.IO.File.ReadAllBytesAsync(filePath, cancellationToken);

        using var stream = new MemoryStream(bytes);
        await botClient.SendPhotoAsync(
            query.Message.Chat.Id,
            photo: stream,
            replyMarkup: buttonsOfSurah1,
            cancellationToken: cancellationToken);

        await botClient.SendTextMessageAsync(
            query.Message.Chat.Id,
            text: "",
            replyMarkup: buttonsOfSurah1,
            cancellationToken: cancellationToken);
    }

    private async Task HandleSurahAsync(ITelegramBotClient botClient, CallbackQuery query, CancellationToken cancellationToken)
    {
        _logger.LogInformation("_sectionName is {_sectionName}", _sectionName);
        _logger.LogInformation("buttonVlaue is {queryValue}", query.Data);
        _surahNumber = int.Parse(query.Data);
        _logger.LogInformation("_surahNumber is {surahNumber}", _surahNumber);

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
        _sectionName = query.Data;
        _logger.LogInformation("_sectionName is {_sectionName}", _sectionName);

        var root = Directory.GetCurrentDirectory();
        var filePath = Path.Combine(root, "img1-40.png");

        var bytes = await System.IO.File.ReadAllBytesAsync(filePath, cancellationToken);

        using var stream = new MemoryStream(bytes);

        await botClient.SendPhotoAsync(
            query.Message.Chat.Id,
            photo: stream,
            replyMarkup: buttonsOfSurah1,
            cancellationToken: cancellationToken);

        await botClient.SendTextMessageAsync(
            query.Message.Chat.Id,
            text: "",
            replyMarkup: buttonsOfSurah1,
            cancellationToken: cancellationToken);
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