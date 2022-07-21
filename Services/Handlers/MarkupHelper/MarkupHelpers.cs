// using Telegram.Bot.Types.ReplyMarkups;

// namespace SurahSender.Services.MarcupHelper;

// public static class MarcupHelpers
// {
//     public static InlineKeyboardMarkup GetKeyboardMarkup(Dictionary<string, string> keys, int columns = 2)
//     {
//         int row = 0;

//         var buttonMatrix = new List<List<InlineKeyboardButton>>();

//         while (keys.Skip(row).Take(columns)?.Count() > 0)
//         {
//             var buttons =
//             keys.Skip(row * columns).Take(columns).Select(k
//             => InlineKeyboardButton.WithCallbackData(k.Key, k.Value)).ToArray();

//             buttonMatrix.Add(buttons.ToList());

//             row++;

//         }
//         return new InlineKeyboardMarkup(buttonMatrix.ToArray());

//     }

// }