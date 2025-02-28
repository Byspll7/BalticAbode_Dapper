using Microsoft.AspNetCore.Mvc;

namespace BalticAbode_Dapper_UI.ViewComponents.Layout
{
    public class _HeaderViewComponentPartial : ViewComponent
    {  
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
