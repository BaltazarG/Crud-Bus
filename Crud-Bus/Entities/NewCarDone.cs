using System.ComponentModel.DataAnnotations;

namespace Crud_Bus.Entities
{
    public class NewCarDone
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        [Required]
        public string Color { get; set; } = string.Empty;


        [Required]
        public int CarId { get; set; }

        [Required]
        public bool IsNew { get; set; } = true;
    }
}
