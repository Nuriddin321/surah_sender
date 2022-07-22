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
                  await   SendDataToUser(botClient, query, 230, cancellationToken );
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
                 await   SendDataToUser(botClient, query, 110, cancellationToken );
            }
            else if (_sectionName == "_alphabet")
            {
                 await   SendDataToUser(botClient, query, 420, cancellationToken );
            }
            else if (_sectionName == "_prophet")
            {
                 await   SendDataToUser(botClient, query, 350, cancellationToken );
            }

        }
        else
        {
            _logger.LogInformation("buttonVlaue is {queryValue}", query.Data);
        }

    }

    private async Task SendDataToUser(ITelegramBotClient botClient,
                                      CallbackQuery? query,
                                      int id,
                                      CancellationToken cancellationToken)
    {
        int surahId = _surahNumber + id; 

        await botClient.ForwardMessageAsync(
            chatId: query.Message.Chat.Id,
            fromChatId: -1001407276572,
            surahId,
            cancellationToken: cancellationToken);
    }
}