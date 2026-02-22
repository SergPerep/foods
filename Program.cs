using Azure.Identity;
using foods.Services;

var credential =  new DefaultAzureCredential();

var builder = WebApplication.CreateBuilder(args);

var config = new ConfigurationBuilder()
	.SetBasePath(AppContext.BaseDirectory)
	.AddJsonFile("appsettings.json", optional: false) // Reads json
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