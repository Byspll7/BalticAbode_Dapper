using Microsoft.AspNetCore.Mvc;

namespace BalticAbode_Dapper_UI.ViewComponents.HomePage
{
    public class _DefaultServicesComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
