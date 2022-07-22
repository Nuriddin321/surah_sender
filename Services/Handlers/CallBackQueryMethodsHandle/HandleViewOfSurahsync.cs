using Telegram.Bot;
using Telegram.Bot.Types;
namespace SurahSender.Services;
public partial class BotUpdateHandler
{
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
}