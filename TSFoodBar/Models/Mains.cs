
    using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace TSFoodBar.Models
{
    public class Mains
    {
    [Key]
    public int MainId { get; set; }
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
