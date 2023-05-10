using Microsoft.AspNetCore.Mvc;

namespace OrderDetails.Controllers
{
    public class VPmanController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
