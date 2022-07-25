
using Telegram.Bot.Types.ReplyMarkups;

namespace SurahSender.Services;

public partial class BotUpdateHandler
{
  

    InlineKeyboardMarkup buttonsVideo1 = new(new[]
    {
        new []
        {
            InlineKeyboardButton.WithCallbackData(text: "1", callbackData: "001_video"),
            InlineKeyboardButton.WithCallbackData(text: "2", callbackData: "002_video"),
            InlineKeyboardButton.WithCallbackData(text: "3", callbackData: "003_video"),
            InlineKeyboardButton.WithCallbackData(text: "4", callbackData: "004_video"),
            InlineKeyboardButton.WithCallbackData(text: "5", callbackData: "005_video"),
            InlineKeyboardButton.WithCallbackData(text: "6", callbackData: "006_video"),
            InlineKeyboardButton.WithCallbackData(text: "7", callbackData: "007_video"),
            InlineKeyboardButton.WithCallbackData(text: "8", callbackData: "008_video")
        },
        new []
        {
            InlineKeyboardButton.WithCallbackData(text: "9", callbackData: "009_video"),
            InlineKeyboardButton.WithCallbackData(text: "10", callbackData: "010_video"),
            InlineKeyboardButton.WithCallbackData(text: "11", callbackData: "011_video"),
            InlineKeyboardButton.WithCallbackData(text: "12", callbackData: "012_video"),
            InlineKeyboardButton.WithCallbackData(text: "13", callbackData: "013_video"),
            InlineKeyboardButton.WithCallbackData(text: "14", callbackData: "014_video"),
            InlineKeyboardButton.WithCallbackData(text: "15", callbackData: "015_video"),
            InlineKeyboardButton.WithCallbackData(text: "16", callbackData: "016_video"),
        },
        new []
        {
            InlineKeyboardButton.WithCallbackData(text: "17", callbackData: "017_video"),
            InlineKeyboardButton.WithCallbackData(text: "18", callbackData: "018_video"),
            InlineKeyboardButton.WithCallbackData(text: "19", callbackData: "019_video"),
            InlineKeyboardButton.WithCallbackData(text: "20", callbackData: "020_video"),
            InlineKeyboardButton.WithCallbackData(text: "21", callbackData: "021_video"),
            InlineKeyboardButton.WithCallbackData(text: "22", callbackData: "022_video"),
            InlineKeyboardButton.WithCallbackData(text: "23", callbackData: "023_video"),
            InlineKeyboardButton.WithCallbackData(text: "24", callbackData: "024_video"),
        },
        new []
        {
            InlineKeyboardButton.WithCallbackData(text: "25", callbackData: "025_video"),
            InlineKeyboardButton.WithCallbackData(text: "26", callbackData: "026_video"),
            InlineKeyboardButton.WithCallbackData(text: "27", callbackData: "027_video"),
            InlineKeyboardButton.WithCallbackData(text: "28", callbackData: "028_video"),
            InlineKeyboardButton.WithCallbackData(text: "29", callbackData: "029_video"),
            InlineKeyboardButton.WithCallbackData(text: "30", callbackData: "030_video"),
            InlineKeyboardButton.WithCallbackData(text: "31", callbackData: "031_video"),
            InlineKeyboardButton.WithCallbackData(text: "32", callbackData: "032_video"),
        },
        new []
        {
            InlineKeyboardButton.WithCallbackData(text: "33", callbackData: "033_video"),
            InlineKeyboardButton.WithCallbackData(text: "34", callbackData: "034_video"),
            InlineKeyboardButton.WithCallbackData(text: "35", callbackData: "035_video"),
            InlineKeyboardButton.WithCallbackData(text: "36", callbackData: "036_video"),
            InlineKeyboardButton.WithCallbackData(text: "37", callbackData: "037_video"),
            InlineKeyboardButton.WithCallbackData(text: "38", callbackData: "038_video"),
            InlineKeyboardButton.WithCallbackData(text: "39", callbackData: "039_video"),
            InlineKeyboardButton.WithCallbackData(text: "40", callbackData: "040_video"),
        },
        new []
        {
            InlineKeyboardButton.WithCallbackData(text: "Keyingisi ➡️", callbackData: "_nextVideo1"),
        },
    });
    InlineKeyboardMarkup buttonsVideo2 = new(new[]
    {
        new []
        {
            InlineKeyboardButton.WithCallbackData(text: "41", callbackData: "041_video"),
            InlineKeyboardButton.WithCallbackData(text: "42", callbackData: "042_video"),
            InlineKeyboardButton.WithCallbackData(text: "43", callbackData: "043_video"),
            InlineKeyboardButton.WithCallbackData(text: "44", callbackData: "044_video"),
            InlineKeyboardButton.WithCallbackData(text: "45", callbackData: "045_video"),
            InlineKeyboardButton.WithCallbackData(text: "46", callbackData: "046_video"),
            InlineKeyboardButton.WithCallbackData(text: "47", callbackData: "047_video"),
            InlineKeyboardButton.WithCallbackData(text: "48", callbackData: "048_video")
        },
        new []
        {
            InlineKeyboardButton.WithCallbackData(text: "49", callbackData: "049_video"),
            InlineKeyboardButton.WithCallbackData(text: "50", callbackData: "050_video"),
            InlineKeyboardButton.WithCallbackData(text: "51", callbackData: "051_video"),
            InlineKeyboardButton.WithCallbackData(text: "52", callbackData: "052_video"),
            InlineKeyboardButton.WithCallbackData(text: "53", callbackData: "053_video"),
            InlineKeyboardButton.WithCallbackData(text: "54", callbackData: "054_video"),
            InlineKeyboardButton.WithCallbackData(text: "55", callbackData: "055_video"),
            InlineKeyboardButton.WithCallbackData(text: "56", callbackData: "056_video"),
        },
        new []
        {
            InlineKeyboardButton.WithCallbackData(text: "57", callbackData: "057_video"),
            InlineKeyboardButton.WithCallbackData(text: "58", callbackData: "058_video"),
            InlineKeyboardButton.WithCallbackData(text: "59", callbackData: "059_video"),
            InlineKeyboardButton.WithCallbackData(text: "60", callbackData: "060_video"),
            InlineKeyboardButton.WithCallbackData(text: "61", callbackData: "061_video"),
            InlineKeyboardButton.WithCallbackData(text: "62", callbackData: "062_video"),
            InlineKeyboardButton.WithCallbackData(text: "63", callbackData: "063_video"),
            InlineKeyboardButton.WithCallbackData(text: "64", callbackData: "064_video"),
        },
        new []
        {
            InlineKeyboardButton.WithCallbackData(text: "65", callbackData: "065_video"),
            InlineKeyboardButton.WithCallbackData(text: "66", callbackData: "066_video"),
            InlineKeyboardButton.WithCallbackData(text: "67", callbackData: "067_video"),
            InlineKeyboardButton.WithCallbackData(text: "68", callbackData: "068_video"),
            InlineKeyboardButton.WithCallbackData(text: "69", callbackData: "069_video"),
            InlineKeyboardButton.WithCallbackData(text: "70", callbackData: "070_video"),
            InlineKeyboardButton.WithCallbackData(text: "71", callbackData: "071_video"),
            InlineKeyboardButton.WithCallbackData(text: "72", callbackData: "072_video"),
        },
        new []
        {
            InlineKeyboardButton.WithCallbackData(text: "73", callbackData: "073_video"),
            InlineKeyboardButton.WithCallbackData(text: "74", callbackData: "074_video"),
            InlineKeyboardButton.WithCallbackData(text: "75", callbackData: "075_video"),
            InlineKeyboardButton.WithCallbackData(text: "76", callbackData: "076_video"),
            InlineKeyboardButton.WithCallbackData(text: "77", callbackData: "077_video"),
            InlineKeyboardButton.WithCallbackData(text: "78", callbackData: "078_video"),
            InlineKeyboardButton.WithCallbackData(text: "79", callbackData: "079_video"),
            InlineKeyboardButton.WithCallbackData(text: "80", callbackData: "080_video"),
        },
        new []
        {
            InlineKeyboardButton.WithCallbackData(text: "⬅️ Orqaga", callbackData: "_backVideo1"),
            InlineKeyboardButton.WithCallbackData(text: "Keyingisi ➡️", callbackData: "_nextVideo2"),
        },
    });
 
    InlineKeyboardMarkup buttonsVideo3 = new(new[]
{
        new []
        {
            InlineKeyboardButton.WithCallbackData(text: "81", callbackData: "081_video"),
            InlineKeyboardButton.WithCallbackData(text: "82", callbackData: "082_video"),
            InlineKeyboardButton.WithCallbackData(text: "83", callbackData: "083_video"),
            InlineKeyboardButton.WithCallbackData(text: "84", callbackData: "084_video"),
            InlineKeyboardButton.WithCallbackData(text: "85", callbackData: "085_video"),
            InlineKeyboardButton.WithCallbackData(text: "86", callbackData: "086_video"),
            InlineKeyboardButton.WithCallbackData(text: "87", callbackData: "087_video"),
            InlineKeyboardButton.WithCallbackData(text: "88", callbackData: "088_video")
        },
        new []
        {
            InlineKeyboardButton.WithCallbackData(text: "89", callbackData: "089_video"),
            InlineKeyboardButton.WithCallbackData(text: "90", callbackData: "090_video"),
            InlineKeyboardButton.WithCallbackData(text: "91", callbackData: "091_video"),
            InlineKeyboardButton.WithCallbackData(text: "92", callbackData: "092_video"),
            InlineKeyboardButton.WithCallbackData(text: "93", callbackData: "093_video"),
            InlineKeyboardButton.WithCallbackData(text: "94", callbackData: "094_video"),
            InlineKeyboardButton.WithCallbackData(text: "95", callbackData: "095_video"),
            InlineKeyboardButton.WithCallbackData(text: "96", callbackData: "096_video"),
        },
        new []
        {
            InlineKeyboardButton.WithCallbackData(text: "97", callbackData: "097_video"),
            InlineKeyboardButton.WithCallbackData(text: "98", callbackData: "098_video"),
            InlineKeyboardButton.WithCallbackData(text: "99", callbackData: "099_video"),
            InlineKeyboardButton.WithCallbackData(text: "100", callbackData: "100_video"),
            InlineKeyboardButton.WithCallbackData(text: "101", callbackData: "101_video"),
            InlineKeyboardButton.WithCallbackData(text: "102", callbackData: "102_video"),
            InlineKeyboardButton.WithCallbackData(text: "103", callbackData: "103_video"),
            InlineKeyboardButton.WithCallbackData(text: "104", callbackData: "104_video"),
        },
        new []
        {
            InlineKeyboardButton.WithCallbackData(text: "105", callbackData: "105_video"),
            InlineKeyboardButton.WithCallbackData(text: "106", callbackData: "106_video"),
            InlineKeyboardButton.WithCallbackData(text: "107", callbackData: "107_video"),
            InlineKeyboardButton.WithCallbackData(text: "108", callbackData: "108_video"),
            InlineKeyboardButton.WithCallbackData(text: "109", callbackData: "109_video"),
            InlineKeyboardButton.WithCallbackData(text: "110", callbackData: "110_video"),
            InlineKeyboardButton.WithCallbackData(text: "111", callbackData: "111_video"),
            InlineKeyboardButton.WithCallbackData(text: "112", callbackData: "112_video"),
        },
        new []
        {
            InlineKeyboardButton.WithCallbackData(text: "113", callbackData: "113_video"),
            InlineKeyboardButton.WithCallbackData(text: "114", callbackData: "114_video"),
        },
        new []
        {
            InlineKeyboardButton.WithCallbackData(text: "⬅️ Orqaga", callbackData: "_backVideo2"),
        },

    });


}