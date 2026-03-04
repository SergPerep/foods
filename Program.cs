using Azure.Identity;
using foods.Services;
using Microsoft.Extensions.Configuration;

var credential =  new DefaultAzureCredential();

var builder = WebApplication.CreateBuilder(args);

var config = new ConfigurationBuilder()
	.SetBasePath(AppContext.BaseDirectory)
	.AddEnvironmentVariables()
	.AddJsonFile("appsettings.json", optional: true) // Reads json
	.Build();


builder.Services.AddSingleton(s =>
{
	return new CosmosDBService(
		cosmosDbAccount: config["CosmosDBAccount"],
		cosmosDbName: config["CosmosDBDatabase"],
		cosmosDbContainer: config["CosmosDBContainer"]);
});

builder.Services.AddControllers();

var app = builder.Build();

app.MapControllers();

app.Run();