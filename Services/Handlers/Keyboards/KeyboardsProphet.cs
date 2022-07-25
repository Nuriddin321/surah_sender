
using Telegram.Bot.Types.ReplyMarkups;

namespace SurahSender.Services;

public partial class BotUpdateHandler
{
      InlineKeyboardMarkup Prophet1 = new(new[]
    {
        new []
        {
            InlineKeyboardButton.WithCallbackData(text: "1", callbackData: "001_prophet"),
            InlineKeyboardButton.WithCallbackData(text: "2", callbackData: "002_prophet"),
            InlineKeyboardButton.WithCallbackData(text: "3", callbackData: "003_prophet"),
            InlineKeyboardButton.WithCallbackData(text: "4", callbackData: "004_prophet"),
        },
        new []
        {
            InlineKeyboardButton.WithCallbackData(text: "5", callbackData: "005_prophet"),
            InlineKeyboardButton.WithCallbackData(text: "6", callbackData: "006_prophet"),
            InlineKeyboardButton.WithCallbackData(text: "7", callbackData: "007_prophet"),
            InlineKeyboardButton.WithCallbackData(text: "8", callbackData: "008_prophet"),
        },
        new []
        {
            InlineKeyboardButton.WithCallbackData(text: "9", callbackData: "009_prophet"),
            InlineKeyboardButton.WithCallbackData(text: "10", callbackData: "010_prophet"),
            InlineKeyboardButton.WithCallbackData(text: "11", callbackData: "011_prophet"),
            InlineKeyboardButton.WithCallbackData(text: "12", callbackData: "012_prophet"),
        },
        new []
        {
            InlineKeyboardButton.WithCallbackData(text: "13", callbackData: "013_prophet"),
            InlineKeyboardButton.WithCallbackData(text: "14", callbackData: "014_prophet"),
            InlineKeyboardButton.WithCallbackData(text: "15", callbackData: "015_prophet"),
            InlineKeyboardButton.WithCallbackData(text: "16", callbackData: "016_prophet"),
        },
        new []
        {
            InlineKeyboardButton.WithCallbackData(text: "Keyingisi ➡️", callbackData: "_nextProphet1"),
        },
    });

    InlineKeyboardMarkup Prophet2 = new(new[]
   {

        new []
        {
            InlineKeyboardButton.WithCallbackData(text: "17", callbackData: "017_prophet"),
            InlineKeyboardButton.WithCallbackData(text: "18", callbackData: "018_prophet"),
            InlineKeyboardButton.WithCallbackData(text: "19", callbackData: "019_prophet"),
            InlineKeyboardButton.WithCallbackData(text: "20", callbackData: "020_prophet"),
        },
        new []
        {
            InlineKeyboardButton.WithCallbackData(text: "21", callbackData: "021_prophet"),
            InlineKeyboardButton.WithCallbackData(text: "22", callbackData: "022_prophet"),
            InlineKeyboardButton.WithCallbackData(text: "23", callbackData: "023_prophet"),
            InlineKeyboardButton.WithCallbackData(text: "24", callbackData: "024_prophet"),
        },
        new []
        {
            InlineKeyboardButton.WithCallbackData(text: "25", callbackData: "025_prophet"),
            InlineKeyboardButton.WithCallbackData(text: "26", callbackData: "026_prophet"),
            InlineKeyboardButton.WithCallbackData(text: "27", callbackData: "027_prophet"),
            InlineKeyboardButton.WithCallbackData(text: "28", callbackData: "028_prophet"),
        },
        new []
        {
            InlineKeyboardButton.WithCallbackData(text: "29", callbackData: "029_prophet"),
            InlineKeyboardButton.WithCallbackData(text: "30", callbackData: "030_prophet"),
            InlineKeyboardButton.WithCallbackData(text: "31", callbackData: "031_prophet"),
            InlineKeyboardButton.WithCallbackData(text: "32", callbackData: "032_prophet"),
        },
        new []
        {
            InlineKeyboardButton.WithCallbackData(text: "⬅️ Orqaga", callbackData: "_backProphet1"),
            InlineKeyboardButton.WithCallbackData(text: "Keyingisi ➡️", callbackData: "_nextProphet2"),
        },
   });

    InlineKeyboardMarkup Prophet3 = new(new[]
    {
        new []
        {
            InlineKeyboardButton.WithCallbackData(text: "33", callbackData: "033_prophet"),
            InlineKeyboardButton.WithCallbackData(text: "34", callbackData: "034_prophet"),
            InlineKeyboardButton.WithCallbackData(text: "35", callbackData: "035_prophet"),
            InlineKeyboardButton.WithCallbackData(text: "36", callbackData: "036_prophet"),
        },
        new []
        {
            InlineKeyboardButton.WithCallbackData(text: "37", callbackData: "037_prophet"),
            InlineKeyboardButton.WithCallbackData(text: "38", callbackData: "038_prophet"),
            InlineKeyboardButton.WithCallbackData(text: "39", callbackData: "039_prophet"),
            InlineKeyboardButton.WithCallbackData(text: "40", callbackData: "040_prophet"),
        },
        new []
        {
            InlineKeyboardButton.WithCallbackData(text: "41", callbackData: "041_prophet"),
            InlineKeyboardButton.WithCallbackData(text: "42", callbackData: "042_prophet"),
            InlineKeyboardButton.WithCallbackData(text: "43", callbackData: "043_prophet"),
            InlineKeyboardButton.WithCallbackData(text: "44", callbackData: "044_prophet"),
        },
        new []
        {
            InlineKeyboardButton.WithCallbackData(text: "45", callbackData: "045_prophet"),
            InlineKeyboardButton.WithCallbackData(text: "46", callbackData: "046_prophet"),
            InlineKeyboardButton.WithCallbackData(text: "47", callbackData: "047_prophet"),
            InlineKeyboardButton.WithCallbackData(text: "48", callbackData: "048_prophet")
        },
        new []
        {   
            InlineKeyboardButton.WithCallbackData(text: "⬅️ Orqaga", callbackData: "_backProphet2"),
            InlineKeyboardButton.WithCallbackData(text: "Keyingisi ➡️", callbackData: "_nextProphet3"),
        },

    });

    InlineKeyboardMarkup Prophet4 = new(new[]
   {

        new []
        {
            InlineKeyboardButton.WithCallbackData(text: "49", callbackData: "049_prophet"),
            InlineKeyboardButton.WithCallbackData(text: "50", callbackData: "050_prophet"),
            InlineKeyboardButton.WithCallbackData(text: "51", callbackData: "051_prophet"),
            InlineKeyboardButton.WithCallbackData(text: "52", callbackData: "052_prophet"),
        },
        new []
        {
            
            InlineKeyboardButton.WithCallbackData(text: "53", callbackData: "053_prophet"),
            InlineKeyboardButton.WithCallbackData(text: "54", callbackData: "054_prophet"),
            InlineKeyboardButton.WithCallbackData(text: "55", callbackData: "055_prophet"),
            InlineKeyboardButton.WithCallbackData(text: "56", callbackData: "056_prophet"),
        },
        new []
        {
            InlineKeyboardButton.WithCallbackData(text: "57", callbackData: "057_prophet"),
            InlineKeyboardButton.WithCallbackData(text: "58", callbackData: "058_prophet"),
            InlineKeyboardButton.WithCallbackData(text: "59", callbackData: "059_prophet"),
            InlineKeyboardButton.WithCallbackData(text: "60", callbackData: "060_prophet")
        },
         new []
        {
            InlineKeyboardButton.WithCallbackData(text: "61", callbackData: "061_prophet"),
            InlineKeyboardButton.WithCallbackData(text: "62", callbackData: "062_prophet"),
            InlineKeyboardButton.WithCallbackData(text: "63", callbackData: "063_prophet"),
        },
          new []
        {
            InlineKeyboardButton.WithCallbackData(text: "⬅️ Orqaga", callbackData: "_backProphet3"),
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