using surahSender.Services;
using Telegram.Bot;

var builder = WebApplication.CreateBuilder(args);

var token = builder.Configuration.GetValue("BotToken", string.Empty);

builder.Services.AddSingleton(p => new TelegramBotClient(token));
builder.Services.AddHostedService<BotBackgroundService>();

var app = builder.Build();

app.Run();
