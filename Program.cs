
using Microsoft.EntityFrameworkCore;
using SurahSender.Data;
using SurahSender.Services; 
using Telegram.Bot;
using Telegram.Bot.Polling;

var builder = WebApplication.CreateBuilder(args); 


var token = builder.Configuration.GetValue("BotToken", string.Empty);
var data = builder.Configuration.GetConnectionString("DefaultConnection");  
builder.Services.AddSingleton(p => new TelegramBotClient(token)); 
builder.Services.AddSingleton<IUpdateHandler, BotUpdateHandler>();  
builder.Services.AddHostedService<BotBackgroundService>();
builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlite(data));  

var app = builder.Build(); 

app.Run();
