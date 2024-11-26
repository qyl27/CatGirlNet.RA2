using CatGirlNet.RA2.Server.Hubs;
using CatGirlNet.RA2.Server.Service;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSignalR()
    .AddMessagePackProtocol();
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer()
    .AddSwaggerGen();

builder.Services.AddSingleton<PlayerService>();
builder.Services.AddSingleton<RoomService>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

app.MapHub<GameHub>("/game");
app.MapControllers();

app.Run();