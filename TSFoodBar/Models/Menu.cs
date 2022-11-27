using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace TSFoodBar.Models
{
    public class Menu
    {
        public int MenuId { get; set; }

        public string? Name { get; set; }
        [Required]
        public string? Description { get; set; }
        [Required]
        public string? ImageUrl { get; set; }
        [Required]
        public string? VideoUrl { get; set; }
        [Required]
        public double Price { get; set; }
        [Required]
        public string? MainIngredients { get; set; }
        [Required]
        public string? OptionIngredients { get; set; }

    }
}
