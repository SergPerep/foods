using System.Collections.Generic;
using System.Threading.Tasks;
using Azure.Identity;
using foods.Model;
using Microsoft.Azure.Cosmos;
namespace foods.Services;

public class CosmosDBService
{
    private Container _container;
    public CosmosDBService(string cosmosDbAccount, string cosmosDbName, string cosmosDbContainer)
    {
        var credential =  new DefaultAzureCredential();
        var cosmosClient = new CosmosClient(cosmosDbAccount, credential);
        var database = cosmosClient.GetDatabase(cosmosDbName);
        _container = database.GetContainer(cosmosDbContainer);
    }

    public async Task Insert(Food foodItem)
    {
        var response = await _container.UpsertItemAsync(foodItem);
        if(response.StatusCode != System.Net.HttpStatusCode.OK && response.StatusCode != System.Net.HttpStatusCode.Created)
        {
            throw new Exception($"Failed to insert/upsert item. Status code: {response.StatusCode}");
        }
    }

    public async Task<Food?> Get(string id, string partitionKey)
    {
        try
        {
            var response = await _container.ReadItemAsync<Food>(id, new PartitionKey(partitionKey));
            return response.Resource;
        }
        catch (CosmosException ex) when (ex.StatusCode == System.Net.HttpStatusCode.NotFound)
        {
            System.Diagnostics.Debug.WriteLine($"Item with ID '{id}' not found in partition '{partitionKey}'");
            return null; // Item not found
        }
    }

    public async Task Delete(string id, string partitionKey)
    {
        try
        {
            var response = await _container.DeleteItemAsync<Food>(id, new PartitionKey(partitionKey));
            if(response.StatusCode != System.Net.HttpStatusCode.NoContent)
            {
                throw new Exception($"Failed to delete item. Status code: {response.StatusCode}");
            }
        }
        catch (CosmosException ex) when (ex.StatusCode == System.Net.HttpStatusCode.NotFound)
        {
            System.Diagnostics.Debug.WriteLine($"Item with ID '{id}' not found in partition '{partitionKey}' for deletion");
            // Item not found, consider it as already deleted
        }
    }

    public async Task<List<Food>> GetAll()
    {
        var results = new List<Food>();
        var query = _container.GetItemQueryIterator<Food>("SELECT * FROM c");
        while (query.HasMoreResults)
        {
            var response = await query.ReadNextAsync();
            foreach (var item in response)
            {
                results.Add(item);
            }
        }
        return results;
    }

}
