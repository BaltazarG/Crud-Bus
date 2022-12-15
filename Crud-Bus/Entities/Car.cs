using System.ComponentModel.DataAnnotations;

namespace Crud_Bus.Entities
{
    public class Car
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        [Required]
        public string Color { get; set; } = string.Empty;
    }
}
