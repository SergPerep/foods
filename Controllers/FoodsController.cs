using foods.Services;
using foods.DTOs;
using foods.Model;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace foods.Controllers
{
    [ApiController]
    [Route("foods")]
    public class FoodController : ControllerBase
    {
        private readonly CosmosDBService _service;

        public FoodController(CosmosDBService service)
        {
            _service = service;
        }

        [HttpGet("all")]
        public async Task<ActionResult<List<Food>>> GetAllFoods()
        {
            var results = await _service.GetAll();
            return results;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Food>> GetFood(string id)
        {
            var food = await _service.Get(id);
            if (food != null)
            {
                return food;
            }
            return NotFound();
        }

        [HttpPost]
        public async Task<ActionResult> AddFood([FromBody] FoodDTO foodDTO)
        {
            Food item = foodDTO.ToFood();
            await _service.Insert(item);
            return CreatedAtAction(nameof(AddFood), new { id = item.Id }, item);
        }

        // Add bulk of foods

        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateFood(string id, [FromBody] FoodDTO foodDTO)
        {
            var food = await _service.Get(id);
            if (food == null)
            {
                return NotFound();
            }

            food.Name = foodDTO.Name;
            food.Protein = foodDTO.Protein;
            food.Carbs = foodDTO.Carbs;
            food.Fiber = foodDTO.Fiber;
            food.Fat = foodDTO.Fat;
            food.Alcohol = foodDTO.Alcohol;

            Console.WriteLine(JsonSerializer.Serialize(food));

            await _service.Insert(food);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteFood(string id)
        {
            await _service.Delete(id);
            return NoContent();
        }

        [HttpDelete("all")]
        public async Task<ActionResult> DeleteAllFoods()
        {
            var foods = await _service.GetAll();
            foreach (var f in foods)
            {
                await _service.Delete(f.Id);
            }
            return Ok();
        }
    }
}
