
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

    InlineKeyboardMarkup Lesson1 = new(new[]
    {
        new []
        {
            InlineKeyboardButton.WithCallbackData(text: "1", callbackData: "1"),
            InlineKeyboardButton.WithCallbackData(text: "2", callbackData: "2"),
            InlineKeyboardButton.WithCallbackData(text: "3", callbackData: "3"),
            InlineKeyboardButton.WithCallbackData(text: "4", callbackData: "4"),
        },
        new []
        {
            InlineKeyboardButton.WithCallbackData(text: "5", callbackData: "5"),
            InlineKeyboardButton.WithCallbackData(text: "6", callbackData: "6"),
            InlineKeyboardButton.WithCallbackData(text: "7", callbackData: "7"),
            InlineKeyboardButton.WithCallbackData(text: "8", callbackData: "8"),
        },
        new []
        {
            InlineKeyboardButton.WithCallbackData(text: "9", callbackData: "9"),
            InlineKeyboardButton.WithCallbackData(text: "10", callbackData: "10"),
            InlineKeyboardButton.WithCallbackData(text: "11", callbackData: "11"),
            InlineKeyboardButton.WithCallbackData(text: "12", callbackData: "12"),
        },
        new []
        {
            InlineKeyboardButton.WithCallbackData(text: "13", callbackData: "13"),
            InlineKeyboardButton.WithCallbackData(text: "14", callbackData: "14"),
            InlineKeyboardButton.WithCallbackData(text: "15", callbackData: "15"),
            InlineKeyboardButton.WithCallbackData(text: "16", callbackData: "16"),
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
            InlineKeyboardButton.WithCallbackData(text: "17", callbackData: "17"),
            InlineKeyboardButton.WithCallbackData(text: "18", callbackData: "18"),
            InlineKeyboardButton.WithCallbackData(text: "19", callbackData: "19"),
            InlineKeyboardButton.WithCallbackData(text: "20", callbackData: "20"),
        },
        new []
        {
            InlineKeyboardButton.WithCallbackData(text: "21", callbackData: "21"),
            InlineKeyboardButton.WithCallbackData(text: "22", callbackData: "22"),
            InlineKeyboardButton.WithCallbackData(text: "23", callbackData: "23"),
            InlineKeyboardButton.WithCallbackData(text: "24", callbackData: "24"),
        },
        new []
        {
            InlineKeyboardButton.WithCallbackData(text: "25", callbackData: "25"),
            InlineKeyboardButton.WithCallbackData(text: "26", callbackData: "26"),
            InlineKeyboardButton.WithCallbackData(text: "27", callbackData: "27"),
            InlineKeyboardButton.WithCallbackData(text: "28", callbackData: "28"),
        },
        new []
        {
            InlineKeyboardButton.WithCallbackData(text: "29", callbackData: "29"),
            InlineKeyboardButton.WithCallbackData(text: "30", callbackData: "30"),
            InlineKeyboardButton.WithCallbackData(text: "31", callbackData: "31"),
            InlineKeyboardButton.WithCallbackData(text: "32", callbackData: "32"),
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
            InlineKeyboardButton.WithCallbackData(text: "33", callbackData: "33"),
            InlineKeyboardButton.WithCallbackData(text: "34", callbackData: "34"),
            InlineKeyboardButton.WithCallbackData(text: "35", callbackData: "35"),
            InlineKeyboardButton.WithCallbackData(text: "36", callbackData: "36"),
        },
        new []
        {
            InlineKeyboardButton.WithCallbackData(text: "37", callbackData: "37"),
            InlineKeyboardButton.WithCallbackData(text: "38", callbackData: "38"),
            InlineKeyboardButton.WithCallbackData(text: "39", callbackData: "39"),
            InlineKeyboardButton.WithCallbackData(text: "40", callbackData: "40"),
        },
        new []
        {
            InlineKeyboardButton.WithCallbackData(text: "41", callbackData: "41"),
            InlineKeyboardButton.WithCallbackData(text: "42", callbackData: "42"),
            InlineKeyboardButton.WithCallbackData(text: "43", callbackData: "43"),
            InlineKeyboardButton.WithCallbackData(text: "44", callbackData: "44"),
        },
        new []
        {
            InlineKeyboardButton.WithCallbackData(text: "45", callbackData: "45"),
            InlineKeyboardButton.WithCallbackData(text: "46", callbackData: "46"),
            InlineKeyboardButton.WithCallbackData(text: "47", callbackData: "47"),
            InlineKeyboardButton.WithCallbackData(text: "48", callbackData: "48")
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
            InlineKeyboardButton.WithCallbackData(text: "49", callbackData: "49"),
            InlineKeyboardButton.WithCallbackData(text: "50", callbackData: "50"),
            InlineKeyboardButton.WithCallbackData(text: "51", callbackData: "51"),
            InlineKeyboardButton.WithCallbackData(text: "52", callbackData: "52"),
        },
        new []
        {
            
            InlineKeyboardButton.WithCallbackData(text: "53", callbackData: "53"),
            InlineKeyboardButton.WithCallbackData(text: "54", callbackData: "54"),
            InlineKeyboardButton.WithCallbackData(text: "55", callbackData: "55"),
            InlineKeyboardButton.WithCallbackData(text: "56", callbackData: "56"),
        },
        new []
        {
            InlineKeyboardButton.WithCallbackData(text: "57", callbackData: "57"),
            InlineKeyboardButton.WithCallbackData(text: "58", callbackData: "58"),
            InlineKeyboardButton.WithCallbackData(text: "59", callbackData: "59"),
            InlineKeyboardButton.WithCallbackData(text: "60", callbackData: "60")
        },
         new []
        {
            InlineKeyboardButton.WithCallbackData(text: "61", callbackData: "61"),
            InlineKeyboardButton.WithCallbackData(text: "62", callbackData: "62"),
            InlineKeyboardButton.WithCallbackData(text: "63", callbackData: "63"),
        },
          new []
        {
            InlineKeyboardButton.WithCallbackData(text: "⬅️ Orqaga", callbackData: "_backLesson3"),
        },

    });

    InlineKeyboardMarkup buttonsOfSurah1 = new(new[]
    {
        new []
        {
            InlineKeyboardButton.WithCallbackData(text: "1", callbackData: "1"),
            InlineKeyboardButton.WithCallbackData(text: "2", callbackData: "2"),
            InlineKeyboardButton.WithCallbackData(text: "3", callbackData: "3"),
            InlineKeyboardButton.WithCallbackData(text: "4", callbackData: "4"),
            InlineKeyboardButton.WithCallbackData(text: "5", callbackData: "5"),
            InlineKeyboardButton.WithCallbackData(text: "6", callbackData: "6"),
            InlineKeyboardButton.WithCallbackData(text: "7", callbackData: "7"),
            InlineKeyboardButton.WithCallbackData(text: "8", callbackData: "8")
        },
        new []
        {
            InlineKeyboardButton.WithCallbackData(text: "9", callbackData: "9"),
            InlineKeyboardButton.WithCallbackData(text: "10", callbackData: "10"),
            InlineKeyboardButton.WithCallbackData(text: "11", callbackData: "11"),
            InlineKeyboardButton.WithCallbackData(text: "12", callbackData: "12"),
            InlineKeyboardButton.WithCallbackData(text: "13", callbackData: "13"),
            InlineKeyboardButton.WithCallbackData(text: "14", callbackData: "14"),
            InlineKeyboardButton.WithCallbackData(text: "15", callbackData: "15"),
            InlineKeyboardButton.WithCallbackData(text: "16", callbackData: "16"),
        },
        new []
        {
            InlineKeyboardButton.WithCallbackData(text: "17", callbackData: "17"),
            InlineKeyboardButton.WithCallbackData(text: "18", callbackData: "18"),
            InlineKeyboardButton.WithCallbackData(text: "19", callbackData: "19"),
            InlineKeyboardButton.WithCallbackData(text: "20", callbackData: "20"),
            InlineKeyboardButton.WithCallbackData(text: "21", callbackData: "21"),
            InlineKeyboardButton.WithCallbackData(text: "22", callbackData: "22"),
            InlineKeyboardButton.WithCallbackData(text: "23", callbackData: "23"),
            InlineKeyboardButton.WithCallbackData(text: "24", callbackData: "24"),
        },
        new []
        {
            InlineKeyboardButton.WithCallbackData(text: "25", callbackData: "25"),
            InlineKeyboardButton.WithCallbackData(text: "26", callbackData: "26"),
            InlineKeyboardButton.WithCallbackData(text: "27", callbackData: "27"),
            InlineKeyboardButton.WithCallbackData(text: "28", callbackData: "28"),
            InlineKeyboardButton.WithCallbackData(text: "29", callbackData: "29"),
            InlineKeyboardButton.WithCallbackData(text: "30", callbackData: "30"),
            InlineKeyboardButton.WithCallbackData(text: "31", callbackData: "31"),
            InlineKeyboardButton.WithCallbackData(text: "32", callbackData: "32"),
        },
        new []
        {
            InlineKeyboardButton.WithCallbackData(text: "33", callbackData: "33"),
            InlineKeyboardButton.WithCallbackData(text: "34", callbackData: "34"),
            InlineKeyboardButton.WithCallbackData(text: "35", callbackData: "35"),
            InlineKeyboardButton.WithCallbackData(text: "36", callbackData: "36"),
            InlineKeyboardButton.WithCallbackData(text: "37", callbackData: "37"),
            InlineKeyboardButton.WithCallbackData(text: "38", callbackData: "38"),
            InlineKeyboardButton.WithCallbackData(text: "39", callbackData: "39"),
            InlineKeyboardButton.WithCallbackData(text: "40", callbackData: "40"),
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
            InlineKeyboardButton.WithCallbackData(text: "41", callbackData: "41"),
            InlineKeyboardButton.WithCallbackData(text: "42", callbackData: "42"),
            InlineKeyboardButton.WithCallbackData(text: "43", callbackData: "43"),
            InlineKeyboardButton.WithCallbackData(text: "44", callbackData: "44"),
            InlineKeyboardButton.WithCallbackData(text: "45", callbackData: "45"),
            InlineKeyboardButton.WithCallbackData(text: "46", callbackData: "46"),
            InlineKeyboardButton.WithCallbackData(text: "47", callbackData: "47"),
            InlineKeyboardButton.WithCallbackData(text: "48", callbackData: "48")
        },
        new []
        {
            InlineKeyboardButton.WithCallbackData(text: "49", callbackData: "49"),
            InlineKeyboardButton.WithCallbackData(text: "50", callbackData: "50"),
            InlineKeyboardButton.WithCallbackData(text: "51", callbackData: "51"),
            InlineKeyboardButton.WithCallbackData(text: "52", callbackData: "52"),
            InlineKeyboardButton.WithCallbackData(text: "53", callbackData: "53"),
            InlineKeyboardButton.WithCallbackData(text: "54", callbackData: "54"),
            InlineKeyboardButton.WithCallbackData(text: "55", callbackData: "55"),
            InlineKeyboardButton.WithCallbackData(text: "56", callbackData: "56"),
        },
        new []
        {
            InlineKeyboardButton.WithCallbackData(text: "57", callbackData: "57"),
            InlineKeyboardButton.WithCallbackData(text: "58", callbackData: "58"),
            InlineKeyboardButton.WithCallbackData(text: "59", callbackData: "59"),
            InlineKeyboardButton.WithCallbackData(text: "60", callbackData: "60"),
            InlineKeyboardButton.WithCallbackData(text: "61", callbackData: "61"),
            InlineKeyboardButton.WithCallbackData(text: "62", callbackData: "62"),
            InlineKeyboardButton.WithCallbackData(text: "63", callbackData: "63"),
            InlineKeyboardButton.WithCallbackData(text: "64", callbackData: "64"),
        },
        new []
        {
            InlineKeyboardButton.WithCallbackData(text: "65", callbackData: "65"),
            InlineKeyboardButton.WithCallbackData(text: "66", callbackData: "66"),
            InlineKeyboardButton.WithCallbackData(text: "67", callbackData: "67"),
            InlineKeyboardButton.WithCallbackData(text: "68", callbackData: "68"),
            InlineKeyboardButton.WithCallbackData(text: "69", callbackData: "69"),
            InlineKeyboardButton.WithCallbackData(text: "70", callbackData: "70"),
            InlineKeyboardButton.WithCallbackData(text: "71", callbackData: "71"),
            InlineKeyboardButton.WithCallbackData(text: "72", callbackData: "72"),
        },
        new []
        {
            InlineKeyboardButton.WithCallbackData(text: "73", callbackData: "73"),
            InlineKeyboardButton.WithCallbackData(text: "74", callbackData: "74"),
            InlineKeyboardButton.WithCallbackData(text: "75", callbackData: "75"),
            InlineKeyboardButton.WithCallbackData(text: "76", callbackData: "76"),
            InlineKeyboardButton.WithCallbackData(text: "77", callbackData: "77"),
            InlineKeyboardButton.WithCallbackData(text: "78", callbackData: "78"),
            InlineKeyboardButton.WithCallbackData(text: "79", callbackData: "79"),
            InlineKeyboardButton.WithCallbackData(text: "80", callbackData: "80"),
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
            InlineKeyboardButton.WithCallbackData(text: "81", callbackData: "81"),
            InlineKeyboardButton.WithCallbackData(text: "82", callbackData: "82"),
            InlineKeyboardButton.WithCallbackData(text: "83", callbackData: "83"),
            InlineKeyboardButton.WithCallbackData(text: "84", callbackData: "84"),
            InlineKeyboardButton.WithCallbackData(text: "85", callbackData: "85"),
            InlineKeyboardButton.WithCallbackData(text: "86", callbackData: "86"),
            InlineKeyboardButton.WithCallbackData(text: "87", callbackData: "87"),
            InlineKeyboardButton.WithCallbackData(text: "88", callbackData: "88")
        },
        new []
        {
            InlineKeyboardButton.WithCallbackData(text: "89", callbackData: "89"),
            InlineKeyboardButton.WithCallbackData(text: "90", callbackData: "90"),
            InlineKeyboardButton.WithCallbackData(text: "91", callbackData: "91"),
            InlineKeyboardButton.WithCallbackData(text: "92", callbackData: "92"),
            InlineKeyboardButton.WithCallbackData(text: "93", callbackData: "93"),
            InlineKeyboardButton.WithCallbackData(text: "94", callbackData: "94"),
            InlineKeyboardButton.WithCallbackData(text: "95", callbackData: "95"),
            InlineKeyboardButton.WithCallbackData(text: "96", callbackData: "96"),
        },
        new []
        {
            InlineKeyboardButton.WithCallbackData(text: "97", callbackData: "97"),
            InlineKeyboardButton.WithCallbackData(text: "98", callbackData: "98"),
            InlineKeyboardButton.WithCallbackData(text: "99", callbackData: "99"),
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
            InlineKeyboardButton.WithCallbackData(text: "⬅️ Orqaga", callbackData: "_back2"),
        },

    });

    string aboutProphet1 = @"
Darslar ro'yxati 👇
1. Siyratning fazilati
2. Amr ibn Luhay
3. As'hob ul Uhdud
4. Fil voqeasi
5. Yamanga forslarini kelishi
6. Zam-zam va Muhammad Sallollohu Alayhi vasallamning 
   tug'ilishi
7. Enaga Halima
8. Shom safari va to'y
9. Ka'ba ta'miri
10. Vahiyning boshlanishi
11. Avvalgi musulmonlar
12. Hamza RoziAllohu anhuning Islomga kirishi
13. Mo'jiza talabi; aziyatlar
14. Umar RoziAllohu anhuning islomga kirishi
15. Iqtisodiy qamal ostida
16. Toifga safar";

    string aboutProphet2 = @"
Darslar ro'yxati 👇
17. Nusaybin Jinlari Islomda
18. Najjoshiy xuzurida
19. Isro va Meroj
20. Mo'jizalar
21. Aqoba baytlari
22. Rosululloh Sallollohu Alayhi vasallam xijrati
23. Madinaga kirish
24. Abdulloh ibn Sallam
25. Badr g'azoti - 1
26. Badr g'azoti - 2
27. Badr g'azoti - 3
28. Badr g'azoti - 4
29. Uhud g'azoti - 1
30. Uhud g'azoti - 2
31. Uhud g'azoti - 3
32. Uhud g'azoti - 4";

    string aboutProphet3 = @"
Darslar ro'yxati 👇
33. Banu Nazir g'azoti
34. Xandaq jangi - 1
35. Xandaq janggi - 2
36. Banu Qurayza g'azoti
37. Sumoma ibn Usol islomda
38. Banu Mustaliq g'azoti
39. Hadiys-ul ifk
40. Xudaybiya sulhi - 1
41. Xudaybiya sulhi - 2
42. Xaybar g'azoti - 1
43. Xaybar g'azoti - 2
44. Xaybar g'azoti - 3
45. Xaybar g'azoti - 4
46. Qazo umrasi; Xirakl va Abu sufyon suxbati
47. Mu'ta g'azoti
48. Zaat us-salosi sariyasi";
    string aboutProphet4 = @"
Darslar ro'yxati 👇
49. Makka fathi - 1
50. Makka fathi - 2
51. Makka fathi - 3
52. Hunayn g'azoti
53. G'animalarni tarqatish
54. Toif islomda, Tabuk safari
55. Tabuk safari
56. Tabukdan qaytish
57. Ka'b ibn Molik
58. Musaylama kazzob
59. Adiy ibn Holim va Najron vafoti
60. Vidolashuv Hajji
61. Vidolashuv hutbasi
62. Payg'ambarimiz Sallollohu Alayhi Vasallam vafoti
63.Payg'ambarimiz Sallollohu Alayhi Vasallamning dafn qilinishi";

    string alphabetText1 = @"Bu yerda darslar raqam holatda berilgan , quyidagilardan birini tanlang👇";

}