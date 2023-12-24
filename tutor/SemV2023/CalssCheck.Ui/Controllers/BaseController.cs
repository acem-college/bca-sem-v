using Microsoft.AspNetCore.Mvc;

namespace ClassCheck.Ui.Controllers
{
    public abstract class BaseController : Controller
    {
        protected string Value()
        {
            return "ACEM BCA";
        }
    }
}
