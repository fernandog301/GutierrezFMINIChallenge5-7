using GutierrezFMINIChallenge5_7.Services.MadLib;
using GutierrezFMINIChallenge5_7.Services.OddOrEven;
using GutierrezFMINIChallenge5_7.Services.OddOrEven.MadLib.ReverseItAlphanumeric;
using GutierrezFMINIChallenge5_7.Services.OddOrEven.MadLib.ReverseItAlphanumeric.ReverseItNumbersOnly;
using GutierrezFMINIChallenge5_7.Services.ReverseItAlphanumeric;
using GutierrezFMINIChallenge5_7.Services.ReverseItNumbersOnly;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IOddOrEvenService, OddOrEvenService>();
builder.Services.AddScoped<IReverseItAlphanumericService, ReverseItAlphanumericService>();
builder.Services.AddScoped<IReverseItNumbersOnlyService, ReverseItNumbersOnlyService>();
builder.Services.AddScoped<IMadLibService, MadLibService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
