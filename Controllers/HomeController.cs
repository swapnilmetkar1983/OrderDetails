using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using OrderDetails.Models;
using System.Diagnostics;

namespace OrderDetails.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            //Creating the List of SelectListItem, this list you can bind from the database.
            //List<SelectListItem> cities = new()
            //{
            //    new SelectListItem { Value = "0", Text = "Select Application" },
            //    new SelectListItem { Value = "1", Text = "IP Man" },
            //    new SelectListItem { Value = "2", Text = "Sales force" },
            //    new SelectListItem { Value = "3", Text = "Coloumbus" },

            //};

            ////assigning SelectListItem to view Bag
            //ViewBag.cities = cities;
            return View();
        }

        

        [HttpPost]
        public IActionResult Index(string selectedDate)
        {
            ViewBag.Message = "Selected Date: " + selectedDate;
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}