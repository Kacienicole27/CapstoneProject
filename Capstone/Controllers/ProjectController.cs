using CapstoneProject.Models;
using CapstoneProject.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CapstoneProject.Controllers
{
    public class ProjectController : Controller
    {
        private readonly IProjectRepository _projectRepository;
        private readonly ICategoryRepository _categoryRepository;

        public ProjectController(IProjectRepository projectRepository, ICategoryRepository categoryRepository)
        {
            _projectRepository = projectRepository;
            _categoryRepository = categoryRepository;
        }

        //public ViewResult List()
        //{
        //    ProjectListViewModel listViewModel = new ProjectListViewModel();
        //    listViewModel.Projects = _projectRepository.AllProjects;
        //    listViewModel.CurrentCategory = "Cheese cakes";
        //    return View(listViewModel);
        //}

        public ViewResult List(string category)
        {
            IEnumerable<Project> projects;
            string currentCategory;
            if(string.IsNullOrEmpty(category))
            {
                projects = _projectRepository.AllProjects.OrderBy(p => p.ProjectId);
                currentCategory = "All Projects";
            }
            else
            {
                projects = _projectRepository.AllProjects.Where(p => p.Category.CategoryName == category).OrderBy(p => p.ProjectId);
                currentCategory = _categoryRepository.AllCategories.FirstOrDefault(c => c.CategoryName == category)
                    ?.CategoryName;
            }

            return View(new ProjectListViewModel()
            {
                Projects = projects,
                CurrentCategory = currentCategory
            });
        }

        public IActionResult Details(int id)
        {
            var project = _projectRepository.GetProjectById(id);
            if (project == null || project.ProjectId == 0)
            {
                return NotFound();
            }

            return View(project);
        }
    }
}
