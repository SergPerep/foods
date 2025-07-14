using foods.Model;

namespace foods.DTOs
{
    public class FoodDTO
    {
        public required string Name { get; set; }
        public int Protein { get; set; }
        public int Carbs { get; set; }
        public int Fat { get; set; }
        public int Fiber { get; set; }
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