using Telegram.Bot;
using Telegram.Bot.Types;
namespace SurahSender.Services;
public partial class BotUpdateHandler
{
  private async Task HandleNextAndBackLessons(ITelegramBotClient botClient,
                                          CallbackQuery query,
                                          CancellationToken cancellationToken)
    {   
        if (query.Data == "_nextLesson1")
        {
            await botClient.SendTextMessageAsync(
               query.Message.Chat.Id,
               text: alphabetText1,
               replyMarkup: Lesson2,
               cancellationToken: cancellationToken);

            await botClient.DeleteMessageAsync(
                query.Message.Chat.Id,
                query.Message.MessageId,
                cancellationToken: cancellationToken);
        }
        else if (query.Data == "_nextLesson2")
        {
            await botClient.SendTextMessageAsync(
               query.Message.Chat.Id,
               text: alphabetText1,
               replyMarkup: Lesson3,
               cancellationToken: cancellationToken);

            await botClient.DeleteMessageAsync(
                query.Message.Chat.Id,
                query.Message.MessageId,
                cancellationToken: cancellationToken);
        }
        else if (query.Data == "_nextLesson3")
        {
            await botClient.SendTextMessageAsync(
               query.Message.Chat.Id,
               text: alphabetText1,
               replyMarkup: Lesson4,
               cancellationToken: cancellationToken);

            await botClient.DeleteMessageAsync(
                query.Message.Chat.Id,
                query.Message.MessageId,
                cancellationToken: cancellationToken);
        }
        else if (query.Data == "_backLesson1")
        {
            await botClient.SendTextMessageAsync(
               query.Message.Chat.Id,
               text: alphabetText1,
               replyMarkup: Lesson1,
               cancellationToken: cancellationToken);

            await botClient.DeleteMessageAsync(
                query.Message.Chat.Id,
                query.Message.MessageId,
                cancellationToken: cancellationToken);
        }
        else if (query.Data == "_backLesson2")
        {
            await botClient.SendTextMessageAsync(
               query.Message.Chat.Id,
               text: alphabetText1,
               replyMarkup: Lesson2,
               cancellationToken: cancellationToken);

            await botClient.DeleteMessageAsync(
                query.Message.Chat.Id,
                query.Message.MessageId,
                cancellationToken: cancellationToken);
        }
        else if (query.Data == "_backLesson3")
        {
            await botClient.SendTextMessageAsync(
               query.Message.Chat.Id,
               text: alphabetText1,
               replyMarkup: Lesson3,
               cancellationToken: cancellationToken);
               
            await botClient.DeleteMessageAsync(
                query.Message.Chat.Id,
                query.Message.MessageId,
                cancellationToken: cancellationToken);
        }
    }
}
