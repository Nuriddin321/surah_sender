using Telegram.Bot;
using Telegram.Bot.Types;
 
namespace SurahSender.Services;
public partial class BotUpdateHandler
{

    private async Task HandleNextAndBackProphet(ITelegramBotClient botClient, CallbackQuery query, CancellationToken cancellationToken)
    {
        if (query.Data == "_nextProphet1")
        {
            await botClient.SendTextMessageAsync(
               query.Message.Chat.Id,
               text: aboutProphet2,
               replyMarkup: Prophet2,
               cancellationToken: cancellationToken);

            await botClient.DeleteMessageAsync(
                query.Message.Chat.Id,
                query.Message.MessageId,
                cancellationToken: cancellationToken);
        }
        else if (query.Data == "_nextProphet2" )
        {
            await botClient.SendTextMessageAsync(
               query.Message.Chat.Id,
               text: aboutProphet3,
               replyMarkup: Prophet3,
               cancellationToken: cancellationToken);

            await botClient.DeleteMessageAsync(
                query.Message.Chat.Id,
                query.Message.MessageId,
                cancellationToken: cancellationToken);
        }
        else if (query.Data == "_nextProphet3" )
        {
            await botClient.SendTextMessageAsync(
               query.Message.Chat.Id,
               text: aboutProphet4,
               replyMarkup: Prophet4,
               cancellationToken: cancellationToken);

            await botClient.DeleteMessageAsync(
                query.Message.Chat.Id,
                query.Message.MessageId,
                cancellationToken: cancellationToken);
        }
        else if (query.Data == "_backProphet1"  )
        {
            await botClient.SendTextMessageAsync(
               query.Message.Chat.Id,
               text: aboutProphet1,
               replyMarkup: Prophet1,
               cancellationToken: cancellationToken);

            await botClient.DeleteMessageAsync(
                query.Message.Chat.Id,
                query.Message.MessageId,
                cancellationToken: cancellationToken);
        }
        else if (query.Data == "_backProphet2" )
        {
            await botClient.SendTextMessageAsync(
               query.Message.Chat.Id,
               text: aboutProphet2,
               replyMarkup: Prophet2,
               cancellationToken: cancellationToken);

            await botClient.DeleteMessageAsync(
                query.Message.Chat.Id,
                query.Message.MessageId,
                cancellationToken: cancellationToken);
        }
        else if (query.Data == "_backProphet3")
        {
            await botClient.SendTextMessageAsync(
               query.Message.Chat.Id,
               text: aboutProphet3,
               replyMarkup: Prophet3,
               cancellationToken: cancellationToken);

            await botClient.DeleteMessageAsync(
                query.Message.Chat.Id,
                query.Message.MessageId,
                cancellationToken: cancellationToken);
        }
    }
}