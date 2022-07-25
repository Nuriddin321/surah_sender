
using Telegram.Bot;
using Telegram.Bot.Types;
 
namespace SurahSender.Services;
public partial class BotUpdateHandler
{  
 private async Task HandleViewOfVideoSurahsync(ITelegramBotClient botClient, CallbackQuery query, CancellationToken cancellationToken)
    {
        if (query.Data == "_nextVideo1")
        {
            var root = Directory.GetCurrentDirectory();
            var filePath = Path.Combine(root, "Resources/img41-80.png");

            var bytes = await System.IO.File.ReadAllBytesAsync(filePath, cancellationToken);

            using var stream = new MemoryStream(bytes);
            await botClient.SendPhotoAsync(
                query.Message.Chat.Id,
                photo: stream,
                replyMarkup: buttonsVideo2,
                cancellationToken: cancellationToken);

            await botClient.DeleteMessageAsync(
                query.Message.Chat.Id,
                query.Message.MessageId,
                cancellationToken: cancellationToken);
        }
        else if (query.Data == "_nextVideo2")
        {
            var root = Directory.GetCurrentDirectory();
            var filePath = Path.Combine(root, "Resources/img81-114.png");

            var bytes = await System.IO.File.ReadAllBytesAsync(filePath, cancellationToken);

            using var stream = new MemoryStream(bytes);
            await botClient.SendPhotoAsync(
                query.Message.Chat.Id,
                photo: stream,
                replyMarkup: buttonsVideo3,
                cancellationToken: cancellationToken);
            
            await botClient.DeleteMessageAsync(
                query.Message.Chat.Id,
                query.Message.MessageId,
                cancellationToken: cancellationToken);
        }
        else if (query.Data == "_backVideo1")
        {
            var root = Directory.GetCurrentDirectory();
            var filePath = Path.Combine(root, "Resources/img1-40.png");

            var bytes = await System.IO.File.ReadAllBytesAsync(filePath, cancellationToken);

            using var stream = new MemoryStream(bytes);
            await botClient.SendPhotoAsync(
                query.Message.Chat.Id,
                photo: stream,
                replyMarkup: buttonsVideo1,
                cancellationToken: cancellationToken);
            
            await botClient.DeleteMessageAsync(
                query.Message.Chat.Id,
                query.Message.MessageId,
                cancellationToken: cancellationToken);
        }
        else if (query.Data == "_backVideo2")
        {
            var root = Directory.GetCurrentDirectory();
            var filePath = Path.Combine(root, "Resources/img41-80.png");

            var bytes = await System.IO.File.ReadAllBytesAsync(filePath, cancellationToken);

            using var stream = new MemoryStream(bytes);
            await botClient.SendPhotoAsync(
                query.Message.Chat.Id,
                photo: stream,
                replyMarkup: buttonsVideo2,
                cancellationToken: cancellationToken);
            
            await botClient.DeleteMessageAsync(
                query.Message.Chat.Id,
                query.Message.MessageId,
                cancellationToken: cancellationToken);
        }

    }
}