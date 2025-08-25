using Azure.Identity;
using Azure.Security.KeyVault.Secrets;
using foods.Database;
using Microsoft.EntityFrameworkCore;

var keyVaultUrl = "https://foods-key-vault.vault.azure.net/";
var secretName = "postgres-connection-string";
var client = new SecretClient(new Uri(keyVaultUrl), new DefaultAzureCredential());

KeyVaultSecret dbConnectionStringSecret = await client.GetSecretAsync(secretName);

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<DatabaseContext>(
    opt => opt.UseNpgsql(dbConnectionStringSecret.Value)
    );
builder.Services.AddControllers();

var app = builder.Build();

app.MapControllers();

app.Run();