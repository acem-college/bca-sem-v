using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChildNutrition.Application.Models.Comments
{
    
    public class CreateCommentVM
    {
        [Required]
        [MaxLength(300)]
        public string Name { get; set; }
        [Required]
        [MaxLength (50)]
        public string Email { get; set; }
        [Required, MaxLength (500)]
        public string Message { get; set; }
    }
}
