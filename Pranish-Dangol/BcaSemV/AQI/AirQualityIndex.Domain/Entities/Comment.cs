using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirQualityIndex.Domain.Entities
{
    public class Comment
    {
        [Key]
        [DatabaseGenerated (DatabaseGeneratedOption.Identity)]
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
        public string Message {  get; set; }
        [Required]
        public DateTime CreatedAt { get; set; }

    }
}
