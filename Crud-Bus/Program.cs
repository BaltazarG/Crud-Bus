using Crud_Bus.Context;
using Crud_Bus.Repositories;
using Microsoft.EntityFrameworkCore;
using Azure.Messaging.ServiceBus;
using Crud_Bus.Services;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("CarContextConnection");

builder.Services.AddDbContext<CarContext>(options =>
    options.UseSqlServer(connectionString));

builder.Services.AddScoped<ICarRepository, CarRepository>();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

string servicebusKey = builder.Configuration.GetConnectionString("ServiceBusKey");
AzureBusService service = new AzureBusService(servicebusKey);
builder.Services.AddScoped<AzureBusService>(z => service);



var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
