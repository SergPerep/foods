using foods.DTOs;
using foods.Model;
using Microsoft.AspNetCore.Http;
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

            Food item = new Food(foodDTO) { Name = foodDTO.Name };
            await _db.Foods.AddAsync(item);
            await _db.SaveChangesAsync();

            return CreatedAtAction(nameof(AddFood), new { id = item.Id }, item);
        }

        // Add bulk of foods

        // Update

        // Delete

        // Delete all
    }
}
