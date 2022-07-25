
using Telegram.Bot.Types.ReplyMarkups;

namespace SurahSender.Services;

public partial class BotUpdateHandler
{
    InlineKeyboardMarkup selectSection = new(new[]
     {
        // first row
        new []
        {
            InlineKeyboardButton.WithCallbackData(text: "🎧  Audio Qur'on", callbackData: "_audioQuran"),
            InlineKeyboardButton.WithCallbackData(text: "▶️  Video Qur'on", callbackData: "_videoQuran"),
        },
        // second row
        new []
        {
            InlineKeyboardButton.WithCallbackData(text: "📖 Qur'on matni", callbackData: "_textQuran"),
            InlineKeyboardButton.WithCallbackData(text: "🔤 Arab Alifbosi", callbackData: "_alphabet"),
        },
        new []
        {
            InlineKeyboardButton.WithCallbackData(text: "🎧 Siyrat darslari", callbackData: "_prophet"),
        },
    });

    InlineKeyboardMarkup reciters = new(new[]
    {
        // first row
        new []
        {
            InlineKeyboardButton.WithCallbackData(text: "👳🏻‍♂️  Mishary bin Rashid", callbackData: "_reciters1"),
            InlineKeyboardButton.WithCallbackData(text: "👳🏻‍♂️  Abdul Rahman Al Sudais ", callbackData: "_reciters2"),
        },
        // second row
        new []
        {
            InlineKeyboardButton.WithCallbackData(text: "👳🏻‍♂️  Saad Al Ghamdi", callbackData: "_reciters3"),
        },
    });

    InlineKeyboardMarkup books = new(new[]
    {
        new []
        {
            InlineKeyboardButton.WithCallbackData(text: "📖 Asl Qur'oni Karim", callbackData: "_arabBook"),
        },
        new []
        {
            InlineKeyboardButton.WithCallbackData(text: "📖 Qur'oni Karim uzb tarjima", callbackData: "_uzBook"),
        },
    });
}