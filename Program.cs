using foods.Database;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<DatabaseContext>(
    opt => opt.UseNpgsql(builder.Configuration.GetConnectionString("POSTGRESQLCONNSTR_PostgresConnection"))
    );
builder.Services.AddControllers();

var app = builder.Build();

app.MapControllers();

app.Run();