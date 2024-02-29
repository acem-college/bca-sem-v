using Pim.Application.Models.Comment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pim.Application.Interfaces
{
	public interface ICommentServices
    {
		Task<int> CreateAsync(CreateCommentVm comment, CancellationToken cancellationToken);
	}
}
