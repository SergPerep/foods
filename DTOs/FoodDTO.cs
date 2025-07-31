using System.ComponentModel.DataAnnotations;
using foods.Model;

namespace foods.DTOs
{
    public class FoodDTO
    {
        [StringLength(100, MinimumLength = 3)]
        public required string Name { get; set; }

        [Range(0, 100)]
        public int Protein { get; set; }

        [Range(0, 100)]
        public int Carbs { get; set; }

        [Range(0, 100)]
        public int Fat { get; set; }

        [Range(0, 100)]
        public int Fiber { get; set; }

        [Range(0, 100)]
        public int Alcohol { get; set; }
        public Food ToFood()
        {

            return new Food()
            {
                Name = Name,
                Protein = Protein,
                Carbs = Carbs,
                Fat = Fat,
                Fiber = Fiber,
                Alcohol = Alcohol
            };
        }
    }

}