using Microsoft.AspNetCore.Mvc;

namespace OrderDetails.Controllers
{
    public class ADController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
