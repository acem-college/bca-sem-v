using chatBot.Bots;
using Microsoft.Bot.Builder.Integration.AspNet.Core;
using Microsoft.Bot.Builder;
using Microsoft.Extensions.DependencyInjection;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddSingleton<IBotFrameworkHttpAdapter, BotAdapterWithErrorHandler>();
builder.Services.AddTransient<IBot, EchoBot>();

builder.Services.AddControllers().AddNewtonsoftJson(); // Ensure controllers are added if not already.

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseHttpsRedirection();
app.UseAuthorization();

app.MapControllers();

app.Run();

