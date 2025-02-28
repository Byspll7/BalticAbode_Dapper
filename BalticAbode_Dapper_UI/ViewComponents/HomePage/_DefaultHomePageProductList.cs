using Microsoft.AspNetCore.Mvc;

namespace BalticAbode_Dapper_UI.ViewComponents.HomePage
{
    public class _DefaultHomePageProductList :ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
