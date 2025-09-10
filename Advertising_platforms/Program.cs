using AdPlatformsService.Bll.Interfaces;
using AdPlatformsService.Bll.Services;
using AdPlatformsService.Dal;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSingleton<IPlatformService, PlatformService>();
builder.Services.AddScoped<FilePlatformLoader>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapControllers();
app.Run();
