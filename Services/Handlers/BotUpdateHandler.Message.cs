
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;

namespace SurahSender.Services;
public partial class BotUpdateHandler
{
    private async Task HandleMessageAsync(
        ITelegramBotClient botClient,
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
                                              CancellationToken cancellationToken)
    {
        _logger.LogInformation("From: {from.Firstname} : {message.Text}   ", message.From?.FirstName, message.Text);

        if (message.Text == "/start")
        {
            await botClient.ForwardMessageAsync(
                chatId: message.Chat.Id,
                fromChatId: -1001407276572,
                508,
                cancellationToken: cancellationToken);


            await botClient.SendTextMessageAsync(
                message.Chat.Id,
                text: $"☪️ \t\t\t\t\t\t\t\t\t\t {message.From?.FirstName ?? "👻"} \t\t\t\t\t\t\t\t\t\t  ☪️   \n\n" +
                    "📿 Qur'on tingla botga  xush kelibsiz! \n\n🛒 Bo'limni tanlang  👇",
                replyMarkup: selectSection,
                cancellationToken: cancellationToken);

        }
        else if (message.Text == "/change")
        {
            await botClient.SendTextMessageAsync(
               message.Chat.Id,
               text: $"🛒 Bo'limni tanlang  👇",
               replyMarkup: selectSection,
               cancellationToken: cancellationToken);

            await botClient.DeleteMessageAsync(
                message.Chat.Id,
                message.MessageId,
                cancellationToken: cancellationToken);
        }
        else
        {
            await botClient.SendTextMessageAsync(
                message.Chat.Id,
                text: "Iltimos, yuqorida ko'rsatilgan tugmalardan birini bosing",
                cancellationToken: cancellationToken);
        }
    }
}

