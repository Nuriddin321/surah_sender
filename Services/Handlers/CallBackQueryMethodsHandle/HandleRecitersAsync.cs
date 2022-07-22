using Telegram.Bot;
using Telegram.Bot.Types;
namespace SurahSender.Services;
public partial class BotUpdateHandler
{
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
}