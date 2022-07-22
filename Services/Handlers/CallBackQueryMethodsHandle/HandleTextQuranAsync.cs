using Telegram.Bot;
using Telegram.Bot.Types;
namespace SurahSender.Services;
public partial class BotUpdateHandler
{



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
            await botClient.ForwardMessageAsync(
                chatId: query.Message.Chat.Id,
                fromChatId: -1001407276572,
                226,
                cancellationToken: cancellationToken);
        }
        else if (query.Data == "_arabBook")
        {
            await botClient.ForwardMessageAsync(
                chatId: query.Message.Chat.Id,
                fromChatId: -1001407276572,
                227,
                cancellationToken: cancellationToken);
        }
    }
}