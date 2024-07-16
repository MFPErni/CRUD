using System.ComponentModel.DataAnnotations;

namespace CartoonsMVC.Models
{
    public class Product
    {
        public int Id { get; set; }

        [MaxLength(100)]
        public string CharacterName { get; set; } = "";

        [MaxLength(100)]
        public string Show { get; set; } = "";

        [MaxLength(100)]
        public string Channel { get; set; } = "";

        public DateTime CreatedAt { get; set; }
    }
}
