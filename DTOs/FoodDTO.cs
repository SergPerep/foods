using System.ComponentModel.DataAnnotations;
using foods.Model;

namespace foods.DTOs
{
    public class FoodDTO
    {
        [StringLength(100, MinimumLength = 3)]
        public required string Name { get; set; }

        [Range(0, 100)]
        public required int Protein { get; set; }

        [Range(0, 100)]
        public required int Carbs { get; set; }

        [Range(0, 100)]
        public required int Fat { get; set; }

        [Range(0, 100)]
        public required int Fiber { get; set; }

        [Range(0, 100)]
        public required int Alcohol { get; set; }
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