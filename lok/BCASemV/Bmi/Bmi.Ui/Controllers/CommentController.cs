using Bmi.Application.Interface;
using Microsoft.AspNetCore.Mvc;

namespace Bmi.Ui.Controllers
{
    public class CommentController: Controller
    {
        private readonly ICommentServices _services;

        public CommentController(ICommentServices services)
        {
            _services = services;
        }
        public IActionResult Comment()
        {
            return View();
        }
        
    }
}
