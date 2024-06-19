using DesignPatterns.Creational.Factory.Enums;
using DesignPatterns.Creational.Factory.Factories;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

#region Factory
// Create an instance of BeverageMakerFactory
var beverageMakerFactory = new BeverageMakerFactory();
builder.Services.AddSingleton<IBeverageMaker>(
    s => beverageMakerFactory
        .CreateBeverageMaker((BeverageType)Convert.ToInt32(builder.Configuration["FactorySettings:BeverageType"])));

#endregion

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.MapControllers();
app.Run();