using Microsoft.AspNetCore.Mvc;

namespace mvcproject1.Controllers
{
        public abstract class BaseController : Controller
        {
            protected string Value()
            {
                return "ACEM BCA";
            }
        }
}
