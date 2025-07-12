using System.ComponentModel.DataAnnotations.Schema;
using foods.DTOs;

namespace foods.Model
{
    [Table("foods")]
    public class Food
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("name")]
        public required string Name { get; set; }
        [Column("protein")]
        public int Protein { get; set; }
        [Column("carbs")]
        public int Carbs { get; set; }
        [Column("fat")]
        public int Fat { get; set; }
        [Column("fiber")]
        public int Fiber { get; set; }
        [Column("alcohol")]
        public int Alcohol { get; set; }

        public Food(FoodDTO foodDTO)
        {
            Protein = foodDTO.Protein;
            Carbs = foodDTO.Carbs;
            Fat = foodDTO.Fat;
            Fiber = foodDTO.Fiber;
            Alcohol = foodDTO.Alcohol;
        }
    }
}
