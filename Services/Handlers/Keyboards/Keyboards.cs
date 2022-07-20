
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

    InlineKeyboardMarkup surahs1 = new(new[]
    {
        new []
        {
            InlineKeyboardButton.WithCallbackData(text: "001", callbackData: "1"),
            InlineKeyboardButton.WithCallbackData(text: "002", callbackData: "2"),
            InlineKeyboardButton.WithCallbackData(text: "003", callbackData: "3"),
            InlineKeyboardButton.WithCallbackData(text: "004", callbackData: "4"),
            InlineKeyboardButton.WithCallbackData(text: "005", callbackData: "5"),
            InlineKeyboardButton.WithCallbackData(text: "006", callbackData: "6"),
            InlineKeyboardButton.WithCallbackData(text: "007", callbackData: "7"),
            InlineKeyboardButton.WithCallbackData(text: "008", callbackData: "8")
        },
        new []
        {
            InlineKeyboardButton.WithCallbackData(text: "009", callbackData: "9"),
            InlineKeyboardButton.WithCallbackData(text: "010", callbackData: "10"),
            InlineKeyboardButton.WithCallbackData(text: "011", callbackData: "11"),
            InlineKeyboardButton.WithCallbackData(text: "012", callbackData: "12"),
            InlineKeyboardButton.WithCallbackData(text: "013", callbackData: "13"),
            InlineKeyboardButton.WithCallbackData(text: "014", callbackData: "14"),
            InlineKeyboardButton.WithCallbackData(text: "015", callbackData: "15"),
            InlineKeyboardButton.WithCallbackData(text: "016", callbackData: "16"), 
        },
        new []
        {
            InlineKeyboardButton.WithCallbackData(text: "017", callbackData: "17"),
            InlineKeyboardButton.WithCallbackData(text: "018", callbackData: "18"),
            InlineKeyboardButton.WithCallbackData(text: "019", callbackData: "19"),
            InlineKeyboardButton.WithCallbackData(text: "020", callbackData: "20"),
            InlineKeyboardButton.WithCallbackData(text: "021", callbackData: "21"),
            InlineKeyboardButton.WithCallbackData(text: "022", callbackData: "22"),
            InlineKeyboardButton.WithCallbackData(text: "023", callbackData: "23"),
            InlineKeyboardButton.WithCallbackData(text: "024", callbackData: "24"), 
        },
        new []
        {
            InlineKeyboardButton.WithCallbackData(text: "025", callbackData: "25"),
            InlineKeyboardButton.WithCallbackData(text: "026", callbackData: "26"),
            InlineKeyboardButton.WithCallbackData(text: "027", callbackData: "27"),
            InlineKeyboardButton.WithCallbackData(text: "028", callbackData: "28"),
            InlineKeyboardButton.WithCallbackData(text: "029", callbackData: "29"),
            InlineKeyboardButton.WithCallbackData(text: "030", callbackData: "30"),
            InlineKeyboardButton.WithCallbackData(text: "031", callbackData: "31"),
            InlineKeyboardButton.WithCallbackData(text: "032", callbackData: "32"), 
        },
        new []
        {
            InlineKeyboardButton.WithCallbackData(text: "033", callbackData: "33"),
            InlineKeyboardButton.WithCallbackData(text: "034", callbackData: "34"),
            InlineKeyboardButton.WithCallbackData(text: "035", callbackData: "35"),
            InlineKeyboardButton.WithCallbackData(text: "036", callbackData: "36"),
            InlineKeyboardButton.WithCallbackData(text: "037", callbackData: "37"),
            InlineKeyboardButton.WithCallbackData(text: "038", callbackData: "38"),
            InlineKeyboardButton.WithCallbackData(text: "039", callbackData: "39"),
            InlineKeyboardButton.WithCallbackData(text: "040", callbackData: "40"), 
        },
        new []
        {
            InlineKeyboardButton.WithCallbackData(text: "Keyingisi", callbackData: "_next"), 
        },
    });
    InlineKeyboardMarkup surahs2 = new(new[]
    {
        new []
        {
            InlineKeyboardButton.WithCallbackData(text: "041", callbackData: "41"),
            InlineKeyboardButton.WithCallbackData(text: "042", callbackData: "42"),
            InlineKeyboardButton.WithCallbackData(text: "043", callbackData: "43"),
            InlineKeyboardButton.WithCallbackData(text: "044", callbackData: "44"),
            InlineKeyboardButton.WithCallbackData(text: "045", callbackData: "45"),
            InlineKeyboardButton.WithCallbackData(text: "046", callbackData: "46"),
            InlineKeyboardButton.WithCallbackData(text: "047", callbackData: "47"),
            InlineKeyboardButton.WithCallbackData(text: "048", callbackData: "48")
        },
        new []
        {
            InlineKeyboardButton.WithCallbackData(text: "049", callbackData: "49"),
            InlineKeyboardButton.WithCallbackData(text: "050", callbackData: "50"),
            InlineKeyboardButton.WithCallbackData(text: "051", callbackData: "51"),
            InlineKeyboardButton.WithCallbackData(text: "052", callbackData: "52"),
            InlineKeyboardButton.WithCallbackData(text: "053", callbackData: "53"),
            InlineKeyboardButton.WithCallbackData(text: "054", callbackData: "54"),
            InlineKeyboardButton.WithCallbackData(text: "055", callbackData: "55"),
            InlineKeyboardButton.WithCallbackData(text: "056", callbackData: "56"), 
        },
        new []
        {
            InlineKeyboardButton.WithCallbackData(text: "057", callbackData: "57"),
            InlineKeyboardButton.WithCallbackData(text: "058", callbackData: "58"),
            InlineKeyboardButton.WithCallbackData(text: "059", callbackData: "59"),
            InlineKeyboardButton.WithCallbackData(text: "060", callbackData: "60"),
            InlineKeyboardButton.WithCallbackData(text: "061", callbackData: "61"),
            InlineKeyboardButton.WithCallbackData(text: "062", callbackData: "62"),
            InlineKeyboardButton.WithCallbackData(text: "063", callbackData: "63"),
            InlineKeyboardButton.WithCallbackData(text: "064", callbackData: "64"), 
        },
        new []
        {
            InlineKeyboardButton.WithCallbackData(text: "065", callbackData: "65"),
            InlineKeyboardButton.WithCallbackData(text: "066", callbackData: "66"),
            InlineKeyboardButton.WithCallbackData(text: "067", callbackData: "67"),
            InlineKeyboardButton.WithCallbackData(text: "068", callbackData: "68"),
            InlineKeyboardButton.WithCallbackData(text: "069", callbackData: "69"),
            InlineKeyboardButton.WithCallbackData(text: "070", callbackData: "70"),
            InlineKeyboardButton.WithCallbackData(text: "071", callbackData: "71"),
            InlineKeyboardButton.WithCallbackData(text: "072", callbackData: "72"), 
        },
        new []
        {
            InlineKeyboardButton.WithCallbackData(text: "073", callbackData: "73"),
            InlineKeyboardButton.WithCallbackData(text: "074", callbackData: "74"),
            InlineKeyboardButton.WithCallbackData(text: "075", callbackData: "75"),
            InlineKeyboardButton.WithCallbackData(text: "076", callbackData: "76"),
            InlineKeyboardButton.WithCallbackData(text: "077", callbackData: "77"),
            InlineKeyboardButton.WithCallbackData(text: "078", callbackData: "78"),
            InlineKeyboardButton.WithCallbackData(text: "079", callbackData: "79"),
            InlineKeyboardButton.WithCallbackData(text: "080", callbackData: "80"), 
        },
        new []
        {
            InlineKeyboardButton.WithCallbackData(text: "Keyingisi", callbackData: "_next2"), 
        },
    });

        InlineKeyboardMarkup surahs3 = new(new[]
    {
        new []
        {
            InlineKeyboardButton.WithCallbackData(text: "081", callbackData: "81"),
            InlineKeyboardButton.WithCallbackData(text: "082", callbackData: "82"),
            InlineKeyboardButton.WithCallbackData(text: "083", callbackData: "83"),
            InlineKeyboardButton.WithCallbackData(text: "084", callbackData: "84"),
            InlineKeyboardButton.WithCallbackData(text: "085", callbackData: "85"),
            InlineKeyboardButton.WithCallbackData(text: "086", callbackData: "86"),
            InlineKeyboardButton.WithCallbackData(text: "087", callbackData: "87"),
            InlineKeyboardButton.WithCallbackData(text: "088", callbackData: "88")
        },
        new []
        {
            InlineKeyboardButton.WithCallbackData(text: "089", callbackData: "89"),
            InlineKeyboardButton.WithCallbackData(text: "090", callbackData: "90"),
            InlineKeyboardButton.WithCallbackData(text: "091", callbackData: "91"),
            InlineKeyboardButton.WithCallbackData(text: "092", callbackData: "92"),
            InlineKeyboardButton.WithCallbackData(text: "093", callbackData: "93"),
            InlineKeyboardButton.WithCallbackData(text: "094", callbackData: "94"),
            InlineKeyboardButton.WithCallbackData(text: "095", callbackData: "95"),
            InlineKeyboardButton.WithCallbackData(text: "096", callbackData: "96"), 
        },
        new []
        {
            InlineKeyboardButton.WithCallbackData(text: "097", callbackData: "97"),
            InlineKeyboardButton.WithCallbackData(text: "098", callbackData: "98"),
            InlineKeyboardButton.WithCallbackData(text: "099", callbackData: "99"),
            InlineKeyboardButton.WithCallbackData(text: "100", callbackData: "100"),
            InlineKeyboardButton.WithCallbackData(text: "101", callbackData: "101"),
            InlineKeyboardButton.WithCallbackData(text: "102", callbackData: "102"),
            InlineKeyboardButton.WithCallbackData(text: "103", callbackData: "103"),
            InlineKeyboardButton.WithCallbackData(text: "104", callbackData: "104"), 
        },
        new []
        {
            InlineKeyboardButton.WithCallbackData(text: "105", callbackData: "105"),
            InlineKeyboardButton.WithCallbackData(text: "106", callbackData: "106"),
            InlineKeyboardButton.WithCallbackData(text: "107", callbackData: "107"),
            InlineKeyboardButton.WithCallbackData(text: "108", callbackData: "108"),
            InlineKeyboardButton.WithCallbackData(text: "109", callbackData: "109"),
            InlineKeyboardButton.WithCallbackData(text: "110", callbackData: "110"),
            InlineKeyboardButton.WithCallbackData(text: "111", callbackData: "111"),
            InlineKeyboardButton.WithCallbackData(text: "112", callbackData: "112"), 
        },
        new []
        {
            InlineKeyboardButton.WithCallbackData(text: "113", callbackData: "113"),
            InlineKeyboardButton.WithCallbackData(text: "114", callbackData: "114"), 
        },
        new []
        {
            InlineKeyboardButton.WithCallbackData(text: "Keyingisi", callbackData: "_next2"), 
        },
    });
 
}
 
 
 