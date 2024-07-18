using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;

namespace CartoonsMVC.Models
{
    public class ProductDto
    {
        [Required, MaxLength(100)]
        public string CharacterName { get; set; } = "";

        [Required, MaxLength(100)]
        public string Show { get; set; } = "";

        [Required, MaxLength(100)]
        public string Channel { get; set; } = "";

        public IFormFile Image { get; set; }
    }
}