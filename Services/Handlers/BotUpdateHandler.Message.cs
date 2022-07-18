
namespace SurahSender.Services;

public partial class BotUpdateHandler
{
    private async Task HandleMessageAsync(ITelegramBotClient botClient,
                                        Message? message,
                                        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(message);

        var from = message.From;

        _logger.LogInformation("Received message from {from.FirstName} ", from?.FirstName);

        var handler = message.Type switch
        {
            MessageType.Text => HandleTextMessageAsync(botClient, message, cancellationToken),
            _ => HandleUnknownMessageAsync(botClient, message, cancellationToken),
        };

        await handler;
  
    }

    private Task HandleUnknownMessageAsync(ITelegramBotClient botClient,
                                       Message message,
                                       CancellationToken cancellationToken)
    {
        _logger.LogInformation("Received message type {message.Type}", message.Type);

        return Task.CompletedTask;
    }

    private async Task HandleTextMessageAsync(ITelegramBotClient botClient,
                                              Message message,
                                              CancellationToken token)
    {
        var from = message.From;
        _logger.LogInformation("From: {from.Firstname}", from?.FirstName);

        if (message.Text == "/start")
        {
            await botClient.SendPhotoAsync(
                message.Chat.Id,
                photo: "https://raw.githubusercontent.com/Nuriddin321/imgs/main/Screenshot%20from%202022-07-17%2016-34-50.jpg",
                cancellationToken: cancellationToken);


            await botClient.SendTextMessageAsync(
                message.Chat.Id,
                text: "Qur'on tingla botga xush kelibsiz ",
                cancellationToken: cancellationToken);
        }
        
    }



}