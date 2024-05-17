using Microsoft.AspNetCore.Mvc;
using OA_SERVICE;
using OA_WEB.Models;
using System.Diagnostics;

namespace OA_WEB.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IProductService product;
        public HomeController(ILogger<HomeController> logger, IProductService pro)
        {
            _logger = logger;
            product = pro;
        }

        public IActionResult Index()
        {
            return View(product.GetProduct());  
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
