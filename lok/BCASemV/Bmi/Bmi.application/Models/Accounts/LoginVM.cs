using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bmi.Application.Models.Accounts
{
	public class LoginVM
	{
		[Required]
		[MaxLength(300)]
		public string UserName { get; set; }
		[Required]
		[MinLength(8)]
		[MaxLength(15)]
		public string Password { get; set; }
	}
}
