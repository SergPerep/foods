using foods.Data;
using foods.DTOs;
using foods.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace foods.Controllers
{
    [ApiController]
    [Route("foods")]
    public class FoodController : ControllerBase
    {
        private FoodContext _db;

        public FoodController(FoodContext context)
        {
            _db = context;
        }

        [HttpGet]
        [Route("all")]
        public async Task<ActionResult<List<Food>>> GetAllFoods()
        {
            return await _db.Foods.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Food>> GetFood(int id)
        {
            Food? food = await _db.Foods.FindAsync(id);
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
            await _db.Foods.AddAsync(item);
            await _db.SaveChangesAsync();

            return CreatedAtAction(nameof(AddFood), new { id = item.Id }, item);
        }

        // Add bulk of foods

        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateFood(int id, [FromBody] FoodDTO foodDTO)
        {

            Food? food = await _db.Foods.FindAsync(id);
            if (food == null)
            {
                return NotFound();
            }

            food.Name = foodDTO.Name;
            food.Protein = foodDTO.Protein;
            food.Carbs = foodDTO.Carbs;
            food.Fiber = foodDTO.Fiber;
            food.Alcohol = foodDTO.Alcohol;
            await _db.SaveChangesAsync();

            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteFood(int id)
        {
            Food? food = await _db.Foods.FindAsync(id);
            if (food == null)
            {
                return NotFound();
            }
            _db.Foods.Remove(food);
            await _db.SaveChangesAsync();
            return Ok();
        }

        [HttpDelete("all")]
        public async Task<ActionResult> DeleteAllFoods()
        {
            Food[] foods = _db.Foods.ToArray();
            _db.Foods.RemoveRange(foods);
            await _db.SaveChangesAsync();
            return Ok();
        }
    }
}
