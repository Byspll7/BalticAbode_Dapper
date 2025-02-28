using Microsoft.AspNetCore.Mvc;

namespace BalticAbode_Dapper_UI.ViewComponents.HomePage
{
    public class _DefaultDiscountOfDayComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
