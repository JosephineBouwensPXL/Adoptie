using CildAdoptie.Models;
using CildAdoptie.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CildAdoptie.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IChildRepository _childRepository;

        public HomeController(ILogger<HomeController> logger, IChildRepository childRepository)
        {
            _logger = logger;
            _childRepository = childRepository;
        }

        public IActionResult Index()
        {
            return View(_childRepository.AllChild().ToList());
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
