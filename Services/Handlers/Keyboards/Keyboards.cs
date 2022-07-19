
using Telegram.Bot.Types.ReplyMarkups;

namespace SurahSender.Services;

public partial class BotUpdateHandler
{
       InlineKeyboardMarkup selectSection = new(new[]
        {
            // first row
            new []
            {
                InlineKeyboardButton.WithCallbackData(text: "☪️  Audio Qur'on", callbackData: "_audioQuran"),
                InlineKeyboardButton.WithCallbackData(text: "☪️  Video Qur'on", callbackData: "_videoQuran"),
            },
            // second row
            new []
            {
                InlineKeyboardButton.WithCallbackData(text: "☪️  Qur'on matni", callbackData: "_textQuran"),
                InlineKeyboardButton.WithCallbackData(text: "☪️  Arab Alifbosi", callbackData: "_alphabet"),
            },
        });

          InlineKeyboardMarkup reciters = new(new[]
        {
            // first row
            new []
            {
                InlineKeyboardButton.WithCallbackData(text: "👳🏻‍♂️  Mishary bin Rashid", callbackData: "_reciters1"),
                InlineKeyboardButton.WithCallbackData(text: "👳🏻‍♂️  Saad Al Ghamdi", callbackData: "_reciters2"),
            },
            // second row
            new []
            {
                InlineKeyboardButton.WithCallbackData(text: "👳🏻‍♂️  Ahmad bin Ali Al-Ajmi.", callbackData: "_reciters3"), 
            },
        });
}