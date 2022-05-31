using Microsoft.AspNetCore.Mvc;

namespace Store.Web.Controllers
{
    public class SearchController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
