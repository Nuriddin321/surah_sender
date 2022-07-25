
using Telegram.Bot.Types.ReplyMarkups;

namespace SurahSender.Services;

public partial class BotUpdateHandler
{
  

    InlineKeyboardMarkup buttonsOfSurah1 = new(new[]
    {
        new []
        {
            InlineKeyboardButton.WithCallbackData(text: "1", callbackData: "001_audio"),
            InlineKeyboardButton.WithCallbackData(text: "2", callbackData: "002_audio"),
            InlineKeyboardButton.WithCallbackData(text: "3", callbackData: "003_audio"),
            InlineKeyboardButton.WithCallbackData(text: "4", callbackData: "004_audio"),
            InlineKeyboardButton.WithCallbackData(text: "5", callbackData: "005_audio"),
            InlineKeyboardButton.WithCallbackData(text: "6", callbackData: "006_audio"),
            InlineKeyboardButton.WithCallbackData(text: "7", callbackData: "007_audio"),
            InlineKeyboardButton.WithCallbackData(text: "8", callbackData: "008_audio")
        },
        new []
        {
            InlineKeyboardButton.WithCallbackData(text: "9", callbackData: "009_audio"),
            InlineKeyboardButton.WithCallbackData(text: "10", callbackData: "010_audio"),
            InlineKeyboardButton.WithCallbackData(text: "11", callbackData: "011_audio"),
            InlineKeyboardButton.WithCallbackData(text: "12", callbackData: "012_audio"),
            InlineKeyboardButton.WithCallbackData(text: "13", callbackData: "013_audio"),
            InlineKeyboardButton.WithCallbackData(text: "14", callbackData: "014_audio"),
            InlineKeyboardButton.WithCallbackData(text: "15", callbackData: "015_audio"),
            InlineKeyboardButton.WithCallbackData(text: "16", callbackData: "016_audio"),
        },
        new []
        {
            InlineKeyboardButton.WithCallbackData(text: "17", callbackData: "017_audio"),
            InlineKeyboardButton.WithCallbackData(text: "18", callbackData: "018_audio"),
            InlineKeyboardButton.WithCallbackData(text: "19", callbackData: "019_audio"),
            InlineKeyboardButton.WithCallbackData(text: "20", callbackData: "020_audio"),
            InlineKeyboardButton.WithCallbackData(text: "21", callbackData: "021_audio"),
            InlineKeyboardButton.WithCallbackData(text: "22", callbackData: "022_audio"),
            InlineKeyboardButton.WithCallbackData(text: "23", callbackData: "023_audio"),
            InlineKeyboardButton.WithCallbackData(text: "24", callbackData: "024_audio"),
        },
        new []
        {
            InlineKeyboardButton.WithCallbackData(text: "25", callbackData: "025_audio"),
            InlineKeyboardButton.WithCallbackData(text: "26", callbackData: "026_audio"),
            InlineKeyboardButton.WithCallbackData(text: "27", callbackData: "027_audio"),
            InlineKeyboardButton.WithCallbackData(text: "28", callbackData: "028_audio"),
            InlineKeyboardButton.WithCallbackData(text: "29", callbackData: "029_audio"),
            InlineKeyboardButton.WithCallbackData(text: "30", callbackData: "030_audio"),
            InlineKeyboardButton.WithCallbackData(text: "31", callbackData: "031_audio"),
            InlineKeyboardButton.WithCallbackData(text: "32", callbackData: "032_audio"),
        },
        new []
        {
            InlineKeyboardButton.WithCallbackData(text: "33", callbackData: "033_audio"),
            InlineKeyboardButton.WithCallbackData(text: "34", callbackData: "034_audio"),
            InlineKeyboardButton.WithCallbackData(text: "35", callbackData: "035_audio"),
            InlineKeyboardButton.WithCallbackData(text: "36", callbackData: "036_audio"),
            InlineKeyboardButton.WithCallbackData(text: "37", callbackData: "037_audio"),
            InlineKeyboardButton.WithCallbackData(text: "38", callbackData: "038_audio"),
            InlineKeyboardButton.WithCallbackData(text: "39", callbackData: "039_audio"),
            InlineKeyboardButton.WithCallbackData(text: "40", callbackData: "040_audio"),
        },
        new []
        {
            InlineKeyboardButton.WithCallbackData(text: "Keyingisi ➡️", callbackData: "_next1"),
        },
    });
    InlineKeyboardMarkup buttonsOfSurah2 = new(new[]
    {
        new []
        {
            InlineKeyboardButton.WithCallbackData(text: "41", callbackData: "041_audio"),
            InlineKeyboardButton.WithCallbackData(text: "42", callbackData: "042_audio"),
            InlineKeyboardButton.WithCallbackData(text: "43", callbackData: "043_audio"),
            InlineKeyboardButton.WithCallbackData(text: "44", callbackData: "044_audio"),
            InlineKeyboardButton.WithCallbackData(text: "45", callbackData: "045_audio"),
            InlineKeyboardButton.WithCallbackData(text: "46", callbackData: "046_audio"),
            InlineKeyboardButton.WithCallbackData(text: "47", callbackData: "047_audio"),
            InlineKeyboardButton.WithCallbackData(text: "48", callbackData: "048_audio")
        },
        new []
        {
            InlineKeyboardButton.WithCallbackData(text: "49", callbackData: "049_audio"),
            InlineKeyboardButton.WithCallbackData(text: "50", callbackData: "050_audio"),
            InlineKeyboardButton.WithCallbackData(text: "51", callbackData: "051_audio"),
            InlineKeyboardButton.WithCallbackData(text: "52", callbackData: "052_audio"),
            InlineKeyboardButton.WithCallbackData(text: "53", callbackData: "053_audio"),
            InlineKeyboardButton.WithCallbackData(text: "54", callbackData: "054_audio"),
            InlineKeyboardButton.WithCallbackData(text: "55", callbackData: "055_audio"),
            InlineKeyboardButton.WithCallbackData(text: "56", callbackData: "056_audio"),
        },
        new []
        {
            InlineKeyboardButton.WithCallbackData(text: "57", callbackData: "057_audio"),
            InlineKeyboardButton.WithCallbackData(text: "58", callbackData: "058_audio"),
            InlineKeyboardButton.WithCallbackData(text: "59", callbackData: "059_audio"),
            InlineKeyboardButton.WithCallbackData(text: "60", callbackData: "060_audio"),
            InlineKeyboardButton.WithCallbackData(text: "61", callbackData: "061_audio"),
            InlineKeyboardButton.WithCallbackData(text: "62", callbackData: "062_audio"),
            InlineKeyboardButton.WithCallbackData(text: "63", callbackData: "063_audio"),
            InlineKeyboardButton.WithCallbackData(text: "64", callbackData: "064_audio"),
        },
        new []
        {
            InlineKeyboardButton.WithCallbackData(text: "65", callbackData: "065_audio"),
            InlineKeyboardButton.WithCallbackData(text: "66", callbackData: "066_audio"),
            InlineKeyboardButton.WithCallbackData(text: "67", callbackData: "067_audio"),
            InlineKeyboardButton.WithCallbackData(text: "68", callbackData: "068_audio"),
            InlineKeyboardButton.WithCallbackData(text: "69", callbackData: "069_audio"),
            InlineKeyboardButton.WithCallbackData(text: "70", callbackData: "070_audio"),
            InlineKeyboardButton.WithCallbackData(text: "71", callbackData: "071_audio"),
            InlineKeyboardButton.WithCallbackData(text: "72", callbackData: "072_audio"),
        },
        new []
        {
            InlineKeyboardButton.WithCallbackData(text: "73", callbackData: "073_audio"),
            InlineKeyboardButton.WithCallbackData(text: "74", callbackData: "074_audio"),
            InlineKeyboardButton.WithCallbackData(text: "75", callbackData: "075_audio"),
            InlineKeyboardButton.WithCallbackData(text: "76", callbackData: "076_audio"),
            InlineKeyboardButton.WithCallbackData(text: "77", callbackData: "077_audio"),
            InlineKeyboardButton.WithCallbackData(text: "78", callbackData: "078_audio"),
            InlineKeyboardButton.WithCallbackData(text: "79", callbackData: "079_audio"),
            InlineKeyboardButton.WithCallbackData(text: "80", callbackData: "080_audio"),
        },
        new []
        {
            InlineKeyboardButton.WithCallbackData(text: "⬅️ Orqaga", callbackData: "_back1"),
            InlineKeyboardButton.WithCallbackData(text: "Keyingisi ➡️", callbackData: "_next2"),
        },
    });
 
    InlineKeyboardMarkup buttonsOfSurah3 = new(new[]
{
        new []
        {
            InlineKeyboardButton.WithCallbackData(text: "81", callbackData: "081_audio"),
            InlineKeyboardButton.WithCallbackData(text: "82", callbackData: "082_audio"),
            InlineKeyboardButton.WithCallbackData(text: "83", callbackData: "083_audio"),
            InlineKeyboardButton.WithCallbackData(text: "84", callbackData: "084_audio"),
            InlineKeyboardButton.WithCallbackData(text: "85", callbackData: "085_audio"),
            InlineKeyboardButton.WithCallbackData(text: "86", callbackData: "086_audio"),
            InlineKeyboardButton.WithCallbackData(text: "87", callbackData: "087_audio"),
            InlineKeyboardButton.WithCallbackData(text: "88", callbackData: "088_audio")
        },
        new []
        {
            InlineKeyboardButton.WithCallbackData(text: "89", callbackData: "089_audio"),
            InlineKeyboardButton.WithCallbackData(text: "90", callbackData: "090_audio"),
            InlineKeyboardButton.WithCallbackData(text: "91", callbackData: "091_audio"),
            InlineKeyboardButton.WithCallbackData(text: "92", callbackData: "092_audio"),
            InlineKeyboardButton.WithCallbackData(text: "93", callbackData: "093_audio"),
            InlineKeyboardButton.WithCallbackData(text: "94", callbackData: "094_audio"),
            InlineKeyboardButton.WithCallbackData(text: "95", callbackData: "095_audio"),
            InlineKeyboardButton.WithCallbackData(text: "96", callbackData: "096_audio"),
        },
        new []
        {
            InlineKeyboardButton.WithCallbackData(text: "97", callbackData: "097_audio"),
            InlineKeyboardButton.WithCallbackData(text: "98", callbackData: "098_audio"),
            InlineKeyboardButton.WithCallbackData(text: "99", callbackData: "099_audio"),
            InlineKeyboardButton.WithCallbackData(text: "100", callbackData: "100_audio"),
            InlineKeyboardButton.WithCallbackData(text: "101", callbackData: "101_audio"),
            InlineKeyboardButton.WithCallbackData(text: "102", callbackData: "102_audio"),
            InlineKeyboardButton.WithCallbackData(text: "103", callbackData: "103_audio"),
            InlineKeyboardButton.WithCallbackData(text: "104", callbackData: "104_audio"),
        },
        new []
        {
            InlineKeyboardButton.WithCallbackData(text: "105", callbackData: "105_audio"),
            InlineKeyboardButton.WithCallbackData(text: "106", callbackData: "106_audio"),
            InlineKeyboardButton.WithCallbackData(text: "107", callbackData: "107_audio"),
            InlineKeyboardButton.WithCallbackData(text: "108", callbackData: "108_audio"),
            InlineKeyboardButton.WithCallbackData(text: "109", callbackData: "109_audio"),
            InlineKeyboardButton.WithCallbackData(text: "110", callbackData: "110_audio"),
            InlineKeyboardButton.WithCallbackData(text: "111", callbackData: "111_audio"),
            InlineKeyboardButton.WithCallbackData(text: "112", callbackData: "112_audio"),
        },
        new []
        {
            InlineKeyboardButton.WithCallbackData(text: "113", callbackData: "113_audio"),
            InlineKeyboardButton.WithCallbackData(text: "114", callbackData: "114_audio"),
        },
        new []
        {
            InlineKeyboardButton.WithCallbackData(text: "⬅️ Orqaga", callbackData: "_back2"),
        },

    });


}