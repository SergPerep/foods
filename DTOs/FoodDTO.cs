using foods.Model;

namespace foods.DTOs
{
    public class FoodDTO
    {
        public required string Name { get; set; }
        public required int Protein { get; set; }
        public required int Carbs { get; set; }
        public required int Fat { get; set; }
        public required int Fiber { get; set; }
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