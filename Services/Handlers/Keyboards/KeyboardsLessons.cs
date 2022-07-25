using Telegram.Bot.Types.ReplyMarkups;

namespace SurahSender.Services;

public partial class BotUpdateHandler
{
    
    InlineKeyboardMarkup Lesson1 = new(new[]
    {
        new []
        {
            InlineKeyboardButton.WithCallbackData(text: "1", callbackData: "001_alphabet"),
            InlineKeyboardButton.WithCallbackData(text: "2", callbackData: "002_alphabet"),
            InlineKeyboardButton.WithCallbackData(text: "3", callbackData: "003_alphabet"),
            InlineKeyboardButton.WithCallbackData(text: "4", callbackData: "004_alphabet"),
        },
        new []
        {
            InlineKeyboardButton.WithCallbackData(text: "5", callbackData: "005_alphabet"),
            InlineKeyboardButton.WithCallbackData(text: "6", callbackData: "006_alphabet"),
            InlineKeyboardButton.WithCallbackData(text: "7", callbackData: "007_alphabet"),
            InlineKeyboardButton.WithCallbackData(text: "8", callbackData: "008_alphabet"),
        },
        new []
        {
            InlineKeyboardButton.WithCallbackData(text: "9", callbackData: "009_alphabet"),
            InlineKeyboardButton.WithCallbackData(text: "10", callbackData: "010_alphabet"),
            InlineKeyboardButton.WithCallbackData(text: "11", callbackData: "011_alphabet"),
            InlineKeyboardButton.WithCallbackData(text: "12", callbackData: "012_alphabet"),
        },
        new []
        {
            InlineKeyboardButton.WithCallbackData(text: "13", callbackData: "013_alphabet"),
            InlineKeyboardButton.WithCallbackData(text: "14", callbackData: "014_alphabet"),
            InlineKeyboardButton.WithCallbackData(text: "15", callbackData: "015_alphabet"),
            InlineKeyboardButton.WithCallbackData(text: "16", callbackData: "016_alphabet"),
        },
        new []
        {
            InlineKeyboardButton.WithCallbackData(text: "Keyingisi ➡️", callbackData: "_nextLesson1"),
        },
    });

    InlineKeyboardMarkup Lesson2 = new(new[]
   {

        new []
        {
            InlineKeyboardButton.WithCallbackData(text: "17", callbackData: "017_alphabet"),
            InlineKeyboardButton.WithCallbackData(text: "18", callbackData: "018_alphabet"),
            InlineKeyboardButton.WithCallbackData(text: "19", callbackData: "019_alphabet"),
            InlineKeyboardButton.WithCallbackData(text: "20", callbackData: "020_alphabet"),
        },
        new []
        {
            InlineKeyboardButton.WithCallbackData(text: "21", callbackData: "021_alphabet"),
            InlineKeyboardButton.WithCallbackData(text: "22", callbackData: "022_alphabet"),
            InlineKeyboardButton.WithCallbackData(text: "23", callbackData: "023_alphabet"),
            InlineKeyboardButton.WithCallbackData(text: "24", callbackData: "024_alphabet"),
        },
        new []
        {
            InlineKeyboardButton.WithCallbackData(text: "25", callbackData: "025_alphabet"),
            InlineKeyboardButton.WithCallbackData(text: "26", callbackData: "026_alphabet"),
            InlineKeyboardButton.WithCallbackData(text: "27", callbackData: "027_alphabet"),
            InlineKeyboardButton.WithCallbackData(text: "28", callbackData: "028_alphabet"),
        },
        new []
        {
            InlineKeyboardButton.WithCallbackData(text: "29", callbackData: "029_alphabet"),
            InlineKeyboardButton.WithCallbackData(text: "30", callbackData: "030_alphabet"),
            InlineKeyboardButton.WithCallbackData(text: "31", callbackData: "031_alphabet"),
            InlineKeyboardButton.WithCallbackData(text: "32", callbackData: "032_alphabet"),
        },
        new []
        {
            InlineKeyboardButton.WithCallbackData(text: "⬅️ Orqaga", callbackData: "_backLesson1"),
            InlineKeyboardButton.WithCallbackData(text: "Keyingisi ➡️", callbackData: "_nextLesson2"),
        },
   });

    InlineKeyboardMarkup Lesson3 = new(new[]
    {
        new []
        {
            InlineKeyboardButton.WithCallbackData(text: "33", callbackData: "033_alphabet"),
            InlineKeyboardButton.WithCallbackData(text: "34", callbackData: "034_alphabet"),
            InlineKeyboardButton.WithCallbackData(text: "35", callbackData: "035_alphabet"),
            InlineKeyboardButton.WithCallbackData(text: "36", callbackData: "036_alphabet"),
        },
        new []
        {
            InlineKeyboardButton.WithCallbackData(text: "37", callbackData: "037_alphabet"),
            InlineKeyboardButton.WithCallbackData(text: "38", callbackData: "038_alphabet"),
            InlineKeyboardButton.WithCallbackData(text: "39", callbackData: "039_alphabet"),
            InlineKeyboardButton.WithCallbackData(text: "40", callbackData: "040_alphabet"),
        },
        new []
        {
            InlineKeyboardButton.WithCallbackData(text: "41", callbackData: "041_alphabet"),
            InlineKeyboardButton.WithCallbackData(text: "42", callbackData: "042_alphabet"),
            InlineKeyboardButton.WithCallbackData(text: "43", callbackData: "043_alphabet"),
            InlineKeyboardButton.WithCallbackData(text: "44", callbackData: "044_alphabet"),
        },
        new []
        {
            InlineKeyboardButton.WithCallbackData(text: "45", callbackData: "045_alphabet"),
            InlineKeyboardButton.WithCallbackData(text: "46", callbackData: "046_alphabet"),
            InlineKeyboardButton.WithCallbackData(text: "47", callbackData: "047_alphabet"),
            InlineKeyboardButton.WithCallbackData(text: "48", callbackData: "048_alphabet")
        },
        new []
        {   
            InlineKeyboardButton.WithCallbackData(text: "⬅️ Orqaga", callbackData: "_backLesson2"),
            InlineKeyboardButton.WithCallbackData(text: "Keyingisi ➡️", callbackData: "_nextLesson3"),
        },

    });

    InlineKeyboardMarkup Lesson4 = new(new[]
   {

        new []
        {
            InlineKeyboardButton.WithCallbackData(text: "49", callbackData: "049_alphabet"),
            InlineKeyboardButton.WithCallbackData(text: "50", callbackData: "050_alphabet"),
            InlineKeyboardButton.WithCallbackData(text: "51", callbackData: "051_alphabet"),
            InlineKeyboardButton.WithCallbackData(text: "52", callbackData: "052_alphabet"),
        },
        new []
        {
            
            InlineKeyboardButton.WithCallbackData(text: "53", callbackData: "053_alphabet"),
            InlineKeyboardButton.WithCallbackData(text: "54", callbackData: "054_alphabet"),
            InlineKeyboardButton.WithCallbackData(text: "55", callbackData: "055_alphabet"),
            InlineKeyboardButton.WithCallbackData(text: "56", callbackData: "056_alphabet"),
        },
        new []
        {
            InlineKeyboardButton.WithCallbackData(text: "57", callbackData: "057_alphabet"),
            InlineKeyboardButton.WithCallbackData(text: "58", callbackData: "058_alphabet"),
            InlineKeyboardButton.WithCallbackData(text: "59", callbackData: "059_alphabet"),
            InlineKeyboardButton.WithCallbackData(text: "60", callbackData: "060_alphabet")
        },
         new []
        {
            InlineKeyboardButton.WithCallbackData(text: "61", callbackData: "061_alphabet"),
            InlineKeyboardButton.WithCallbackData(text: "62", callbackData: "062_alphabet"),
            InlineKeyboardButton.WithCallbackData(text: "63", callbackData: "063_alphabet"),
        },
          new []
        {
            InlineKeyboardButton.WithCallbackData(text: "⬅️ Orqaga", callbackData: "_backLesson3"),
        },

    });
}