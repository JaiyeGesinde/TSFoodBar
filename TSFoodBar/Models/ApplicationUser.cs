using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
namespace TSFoodBar.Models
{
    public class ApplicationUser: IdentityUser
    {
        [Required]
        [MaxLength(255)]
        [MinLength(255)]
        public string? FirstName { get; set; }
        public string? LastName { get; set; }

        /*public string? PhoneNumber { get; set; }*/
    }
}
