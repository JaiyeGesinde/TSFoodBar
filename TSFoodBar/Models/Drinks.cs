
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace TSFoodBar.Models
{
    public class Drinks
    {
        [Key]
        public int DrinkId { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public string? Description { get; set; }
        [Required]
        public string? Image { get; set; }
        [Required]

       /* public IFormFile ImageUpload { get; set; }
        [Required]*/
        public string? Video { get; set; }
        [Required]
        [Precision(18, 2)]
        public decimal Price { get; set; }
        [Required]
        public string? MainIngredients { get; set; }
        [Required]
        public string? OptionIngredients { get; set; }
    }

}
