using System.ComponentModel.DataAnnotations;

namespace Crud_Bus.Entities
{
    public class CarDone
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        [Required]
        public string Color { get; set; } = string.Empty;

        public DateTime Date { get; set; } = DateTime.Now;
    }
}
