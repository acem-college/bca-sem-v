using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IrrigationInformationSystem.Domain.Entities
{
    public class Comment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [MaxLength(300)]
        public string Name { get; set; }
        [Required]
        [MaxLength(300)]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [MaxLength(300)]
        public string Message { get; set; }
        [Required]
        public DateTime CreatedAt { get; set; }
    }
}
