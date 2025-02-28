using Microsoft.AspNetCore.Mvc;

namespace BalticAbode_Dapper_UI.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
