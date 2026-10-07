using WebShoppieAalst.Domain.Services.Implementations;
using WebShoppieAalst.Domain.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddScoped<ICustomerService, CustomerService>();

var app = builder.Build();

app.MapControllers();

app.Run();