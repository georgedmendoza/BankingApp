using BankingApp.Repositories;
using BankingApp.Services;
using BankingApp.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
//builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddSwaggerGen();

//DI
//builder.Services.AddScoped<IAccountRepository, InMemoryAccountRepository>();
builder.Services.AddSingleton<IAccountRepository, InMemoryAccountRepository>();
builder.Services.AddScoped<IAccountService, AccountService>();

var app = builder.Build();
//add account
var repo = app.Services.GetRequiredService<IAccountRepository>();
repo.AddAccount(new Account
{
    AccountId = 2,
    CustomerId = 1,
    Balance = 0m
});

// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
//    app.UseSwagger();
//    app.UseSwaggerUI();
//}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
