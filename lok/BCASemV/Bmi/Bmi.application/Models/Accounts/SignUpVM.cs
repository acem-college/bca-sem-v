using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bmi.Application.Models.Accounts
{
	public class SignUpVM
	{
		[Required]
		[MaxLength(300)]
		public string FirstName {  get; set; }
		[Required]
		[MaxLength(200)]
		public string LastName { get; set; }
		[Required]
		[EmailAddress]
		[MaxLength (200)]
		public string Email { get; set; }
		[Required]
		[MinLength(8)]
		[MaxLength (15)]
		public string Password { get; set; }
		[Required]
		[MinLength (8)]
		[MaxLength (15)]
		public string ConfirmPassword { get; set; }
		[Required]
		[MaxLength (300)]
		public string UserName {  get; set; }
		[Required]
		public DateTime DOB {  get; set; }
		
	}
}
