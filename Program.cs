using foods.Model;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddDbContext<FoodContext>(opt => opt.UseNpgsql(builder.Configuration.GetConnectionString("PostgresConnection")));
var app = builder.Build();

app.Run();
