using Telegram.Bot;
using Telegram.Bot.Types;
namespace SurahSender.Services;
public partial class BotUpdateHandler
{
    private string _reciterName = "default";
    private string _sectionName = "default";
    private int _surahNumber = 0;

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
            // change here / add book to database
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
            // change here / add book to database
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

    private async Task HandleAlphabetAsync(ITelegramBotClient botClient,
                                           CallbackQuery query,
                                           CancellationToken cancellationToken)
    {
        _sectionName = query.Data;
        _logger.LogInformation("_sectionName is {_sectionName}", _sectionName);
        //code here
        throw new NotImplementedException();
    }

    private async Task HandleProphetAsync(ITelegramBotClient botClient,
                                          CallbackQuery query,
                                          CancellationToken cancellationToken)
    {
        if (query.Data == "_prophet")
        {
            _sectionName = query.Data;
            _logger.LogInformation("_sectionName is {_sectionName}", _sectionName);

            await botClient.SendTextMessageAsync(
                query.Message.Chat.Id,
                text: "Bu bo'limda siz payg'ambarimiz Muhammad Mustafo Sallallohu alayhi vasallam " +
                "hayotlari haqida to'liq malumotga ega bo'lasiz \nin sha Alloh",
                cancellationToken: cancellationToken);

            await botClient.SendTextMessageAsync(
                query.Message.Chat.Id,
                text: aboutProphet1,
                replyMarkup: buttonsOfProphet1,
                cancellationToken: cancellationToken);

        }
        else if (query.Data == "_nextButtonOfProphet1")
        {
            await botClient.SendTextMessageAsync(
               query.Message.Chat.Id,
               text: aboutProphet2,
               replyMarkup: buttonsOfProphet2,
               cancellationToken: cancellationToken);
        }
        else if (query.Data == "_nextButtonOfProphet2")
        {
            await botClient.SendTextMessageAsync(
               query.Message.Chat.Id,
               text: aboutProphet3,
               replyMarkup: buttonsOfProphet3,
               cancellationToken: cancellationToken);
        }
        else if (query.Data == "_nextButtonOfProphet3")
        {
            await botClient.SendTextMessageAsync(
               query.Message.Chat.Id,
               text: aboutProphet4,
               replyMarkup: buttonsOfProphet4,
               cancellationToken: cancellationToken);
        }


    }

    private async Task HandleViewOfSurahsync(ITelegramBotClient botClient,
                                             CallbackQuery query,
                                             CancellationToken cancellationToken)
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

    private async Task HandleRecitersAsync(ITelegramBotClient botClient,
                                           CallbackQuery query,
                                           CancellationToken cancellationToken)
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

    private async Task HandleSurahNumberAsync(ITelegramBotClient botClient,
                                              CallbackQuery query,
                                              CancellationToken cancellationToken)
    {
        _logger.LogInformation("_sectionName is {_sectionName}", _sectionName);

        if (char.IsDigit(query.Data[0]))
        {
            _logger.LogInformation("SectionName is {sectionName}", _sectionName);
            _logger.LogInformation("_reciterName is {reciter}", _reciterName);

            _surahNumber = int.Parse(query.Data);
            _logger.LogInformation("_surahNumber is {surahNumber}", _surahNumber);

            if (_sectionName == "_audioQuran")
            {
                if (_reciterName == "_reciters1")
                {
                    int surahId = _surahNumber; // + id
                    await botClient.ForwardMessageAsync(
                       chatId: query.Message.Chat.Id,
                       fromChatId: -1001407276572,
                       surahId,
                       cancellationToken: cancellationToken);
                }
                else if (_reciterName == "_reciters2")
                {
                    //some code here
                    await botClient.SendTextMessageAsync(
                        query.Message.Chat.Id,
                        text: $"Bu Qorining qiroati botga tez orada qo'shiladi.\nYuzaga kelgan noqulaylik uchun uzr😐 ",
                        cancellationToken: cancellationToken);
                }
                else if (_reciterName == "_reciters3")
                {
                    //some code here
                    await botClient.SendTextMessageAsync(
                        query.Message.Chat.Id,
                        text: $"Bu Qorining qiroati botga tez orada qo'shiladi.\nYuzaga kelgan noqulaylik uchun uzr😐 ",
                        cancellationToken: cancellationToken);
                }
            }
            else if (_sectionName == "_videoQuran")
            {
                int surahId = _surahNumber; // + id

                await botClient.ForwardMessageAsync(
                   chatId: query.Message.Chat.Id,
                   fromChatId: -1001407276572,
                   surahId,
                   cancellationToken: cancellationToken);
            }
            else if (_sectionName == "_alphabet")
            {
                //some code here
                await botClient.SendTextMessageAsync(
                    query.Message.Chat.Id,
                    text: $"Bu bo'lim tez orada qo'shiladi.\nYuzaga kelgan noqulaylik uchun uzr😐 ",
                    cancellationToken: cancellationToken);
            }
        }
        else
        {
            _logger.LogInformation("buttonVlaue is {queryValue}", query.Data);
        }

    }
}