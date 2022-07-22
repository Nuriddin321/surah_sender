using Telegram.Bot;
using Telegram.Bot.Types;
namespace SurahSender.Services;
public partial class BotUpdateHandler
{
  private async Task HandleProphetAndAlphabetAsync(ITelegramBotClient botClient,
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
        else if (query.Data == "_nextButtonOfProphet1" && _sectionName == "_prophet")
        {
            await botClient.SendTextMessageAsync(
               query.Message.Chat.Id,
               text: aboutProphet2,
               replyMarkup: buttonsOfProphet2,
               cancellationToken: cancellationToken);
        }
        else if (query.Data == "_nextButtonOfProphet2" && _sectionName == "_prophet")
        {
            await botClient.SendTextMessageAsync(
               query.Message.Chat.Id,
               text: aboutProphet3,
               replyMarkup: buttonsOfProphet3,
               cancellationToken: cancellationToken);
        }
        else if (query.Data == "_nextButtonOfProphet3" && _sectionName == "_prophet")
        {
            await botClient.SendTextMessageAsync(
               query.Message.Chat.Id,
               text: aboutProphet4,
               replyMarkup: buttonsOfProphet4,
               cancellationToken: cancellationToken);
        }

        else if (query.Data == "_alphabet")
        {
            _sectionName = query.Data;
            _logger.LogInformation("_sectionName is {_sectionName}", _sectionName);

            await botClient.SendTextMessageAsync(
                query.Message.Chat.Id,
                text: $" Qur'on arab tilida nozil bo'lgan " +
                    "va albatta musxafni asl tilida o'qish eng katta savoblardan biri hisoblanadi." +
                    " Bu bo'limda siz Arab harflarini o'rganishingiz mumkin",
                cancellationToken: cancellationToken);

            await botClient.SendTextMessageAsync(
                query.Message.Chat.Id,
                text: alphabetText1,
                replyMarkup: buttonsOfProphet1,
                cancellationToken: cancellationToken);
        }
        else if (query.Data == "_nextButtonOfProphet1" && _sectionName == "_alphabet")
        {
            await botClient.SendTextMessageAsync(
               query.Message.Chat.Id,
               text: alphabetText1,
               replyMarkup: buttonsOfProphet2,
               cancellationToken: cancellationToken);
        }
        else if (query.Data == "_nextButtonOfProphet2" && _sectionName == "_alphabet")
        {
            await botClient.SendTextMessageAsync(
               query.Message.Chat.Id,
               text: alphabetText1,
               replyMarkup: buttonsOfProphet3,
               cancellationToken: cancellationToken);
        }
        else if (query.Data == "_nextButtonOfProphet3" && _sectionName == "_alphabet")
        {
            await botClient.SendTextMessageAsync(
               query.Message.Chat.Id,
               text: alphabetText1,
               replyMarkup: buttonsOfProphet4,
               cancellationToken: cancellationToken);
        }
    }
}