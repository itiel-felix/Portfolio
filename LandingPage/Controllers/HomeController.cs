using LandingPage.Models;
using LandingPage.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace LandingPage.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IProjectRepository projectsRepo;
        private readonly IConfiguration config;

        public HomeController(
            ILogger<HomeController> logger,
            IProjectRepository projectsRepo,
            IConfiguration config
            )
        {
            _logger = logger;
            this.projectsRepo = projectsRepo;
            this.config = config;
        }

        public IActionResult Index()
        {
            // Esta configuracion se mantiene solo en esta vista (Index)
            // ViewBag.Name = "Itiel Felix Martinez";
            ViewBag.Edad = "23";
            var person = new Person()
            {
                name = "Itiel Felix",
                age = 23
            };
            var apellido = config.GetValue<string>("Apellido");
            _logger.LogInformation("This is a log message"+apellido);
            // Podemos apuntar a otra vista colocando el nombre del archivo
            var listOfProjects = projectsRepo.generateProjects().Take(2).ToList();
            var homeViewObject = new HomeIndexViewModel()
            {
                Projects = listOfProjects,
            };
            return View(homeViewObject);
        }

        public IActionResult Projects()
        {
            var projects = projectsRepo.generateProjects();
            return View(projects);
        }

        public IActionResult Contact()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Contact(ContactViewModel contactVM)
        {

            return RedirectToAction("Contact");
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}