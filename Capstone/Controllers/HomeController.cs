using CapstoneProject.Models;
using CapstoneProject.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CapstoneProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProjectRepository _projectRepository;

        public HomeController(IProjectRepository projectRepository)
        {
            _projectRepository = projectRepository;
        }

        public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                ProjectOfTheWeek = _projectRepository.ProjectsOfTheWeek
            };

            return View(homeViewModel);
        }
    }
}
