using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PacificOilTools.Models;

namespace PacificOilTools.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IServicesRepository servicesRepository;

        public HomeController(ILogger<HomeController> logger, IServicesRepository servicesRepository)
        {
            _logger = logger;
            this.servicesRepository = servicesRepository;
        }

        public IActionResult Index()
        {
            var services = servicesRepository.GetServices();
            var model = new HomeIndexVM()
            {
                ServicesList = services
            };
            return View(model);
        }

        public IActionResult Contact()
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