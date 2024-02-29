using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pim.Application.Models.Comment
{
   public class CreateCommentVm
    {
        [Required]
        [MaxLength(300)]
        public string Name {  get; set; }
        [Required]
        [MaxLength(300)]
        public string Email { get; set; }
        [Required]
        [MaxLength(300)]
        public string Message { get; set; }
    }
}
