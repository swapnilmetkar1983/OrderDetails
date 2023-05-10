using Microsoft.AspNetCore.Mvc;

namespace OrderDetails.Controllers
{
    public class SalesForceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
