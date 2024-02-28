using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mental.Application.Models.Accounts
{
    public class CreateCommentVM
    {
        [Required] //data annotation
        [MaxLength(300)]
        public string Name { get; set; }
        [Required]
        [MaxLength(300)]
        public string Email { get; set; }
        [Required]
        [MaxLength (500)]
        public string Message { get; set; }
       

      
    }
}
