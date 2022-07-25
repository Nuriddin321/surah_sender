using Telegram.Bot;
using Telegram.Bot.Types;
namespace SurahSender.Services;
public partial class BotUpdateHandler
{
    private string _reciterName = "default";
    private string _sectionName = "default";
    private int _surahNumber = 0;

    private async Task HandleSurahNumberAsync(ITelegramBotClient botClient,
                                              CallbackQuery query,
                                              CancellationToken cancellationToken)
    {
        _logger.LogInformation("_sectionName is {_sectionName}", _sectionName);
        var text = query.Data.Substring(4, 5);

        if (text == "audio")
        {
            if (_reciterName == "_reciters1")
            {
                var surahId = (int.Parse(query.Data.Substring(0, 3))) + 230;

                await SendDataToUser(botClient, query, surahId, cancellationToken);
            }
            else if (_reciterName == "_reciters2")
            {
                var surahId = (int.Parse(query.Data.Substring(0, 3))) + 670;
                
                await SendDataToUser(botClient, query, surahId, cancellationToken);
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
        else if (text == "video")
        {
            var surahId = (int.Parse(query.Data.Substring(0, 3))) + 110;

            await SendDataToUser(botClient, query, surahId, cancellationToken);
        }
        else if (text == "proph")
        {
            var surahId = (int.Parse(query.Data.Substring(0, 3))) + 600;

            await SendDataToUser(botClient, query, surahId, cancellationToken);
        }
        else if (text == "alpha")
        {
            var surahId = (int.Parse(query.Data.Substring(0, 3))) + 420;

            await SendDataToUser(botClient, query, surahId, cancellationToken);
        }
        
    }

    private async Task SendDataToUser(ITelegramBotClient botClient,
                                      CallbackQuery? query,
                                      int id,
                                      CancellationToken cancellationToken)
    {
        await botClient.ForwardMessageAsync(
           chatId: query.Message.Chat.Id,
           fromChatId: -1001407276572,
           id,
           cancellationToken: cancellationToken);
    }
}