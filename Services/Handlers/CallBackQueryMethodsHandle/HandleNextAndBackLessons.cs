using Telegram.Bot;
using Telegram.Bot.Types;
namespace SurahSender.Services;
public partial class BotUpdateHandler
{
  private async Task HandleNextAndBackLessons(ITelegramBotClient botClient,
                                          CallbackQuery query,
                                          CancellationToken cancellationToken)
    {   
        //prophet
        if (query.Data == "_nextLesson1" && _sectionName == "_prophet")
        {
            await botClient.SendTextMessageAsync(
               query.Message.Chat.Id,
               text: aboutProphet2,
               replyMarkup: Lesson2,
               cancellationToken: cancellationToken);

            await botClient.DeleteMessageAsync(
                query.Message.Chat.Id,
                query.Message.MessageId,
                cancellationToken: cancellationToken);
        }
        else if (query.Data == "_nextLesson2" && _sectionName == "_prophet")
        {
            await botClient.SendTextMessageAsync(
               query.Message.Chat.Id,
               text: aboutProphet3,
               replyMarkup: Lesson3,
               cancellationToken: cancellationToken);

            await botClient.DeleteMessageAsync(
                query.Message.Chat.Id,
                query.Message.MessageId,
                cancellationToken: cancellationToken);
        }
        else if (query.Data == "_nextLesson3" && _sectionName == "_prophet")
        {
            await botClient.SendTextMessageAsync(
               query.Message.Chat.Id,
               text: aboutProphet4,
               replyMarkup: Lesson4,
               cancellationToken: cancellationToken);

            await botClient.DeleteMessageAsync(
                query.Message.Chat.Id,
                query.Message.MessageId,
                cancellationToken: cancellationToken);
        }
        else if (query.Data == "_backLesson1" && _sectionName == "_prophet")
        {
            await botClient.SendTextMessageAsync(
               query.Message.Chat.Id,
               text: aboutProphet1,
               replyMarkup: Lesson1,
               cancellationToken: cancellationToken);

            await botClient.DeleteMessageAsync(
                query.Message.Chat.Id,
                query.Message.MessageId,
                cancellationToken: cancellationToken);
        }
        else if (query.Data == "_backLesson2" && _sectionName == "_prophet")
        {
            await botClient.SendTextMessageAsync(
               query.Message.Chat.Id,
               text: aboutProphet2,
               replyMarkup: Lesson2,
               cancellationToken: cancellationToken);

            await botClient.DeleteMessageAsync(
                query.Message.Chat.Id,
                query.Message.MessageId,
                cancellationToken: cancellationToken);
        }
        else if (query.Data == "_backLesson3" && _sectionName == "_prophet")
        {
            await botClient.SendTextMessageAsync(
               query.Message.Chat.Id,
               text: aboutProphet3,
               replyMarkup: Lesson3,
               cancellationToken: cancellationToken);

            await botClient.DeleteMessageAsync(
                query.Message.Chat.Id,
                query.Message.MessageId,
                cancellationToken: cancellationToken);
        }
        //alphabet
        else if (query.Data == "_nextLesson1" && _sectionName == "_alphabet")
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
        else if (query.Data == "_nextLesson2" && _sectionName == "_alphabet")
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
        else if (query.Data == "_nextLesson3" && _sectionName == "_alphabet")
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
        else if (query.Data == "_backLesson1" && _sectionName == "_alphabet")
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
        else if (query.Data == "_backLesson2" && _sectionName == "_alphabet")
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
        else if (query.Data == "_backLesson3" && _sectionName == "_alphabet")
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
