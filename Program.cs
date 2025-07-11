using foods.Model;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<FoodContext>(
    opt => opt.UseNpgsql(builder.Configuration.GetConnectionString("PostgresConnection"))
    );
builder.Services.AddControllers();

var app = builder.Build();

app.MapControllers();

app.Run();