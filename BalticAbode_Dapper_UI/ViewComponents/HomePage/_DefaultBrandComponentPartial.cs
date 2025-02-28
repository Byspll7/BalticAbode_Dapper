using Microsoft.AspNetCore.Mvc;

namespace BalticAbode_Dapper_UI.ViewComponents.HomePage
{
    public class _DefaultBrandComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
