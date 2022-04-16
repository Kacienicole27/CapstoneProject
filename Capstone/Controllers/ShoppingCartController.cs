using CapstoneProject.Models;
using CapstoneProject.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CapstoneProject.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly IProjectRepository _projectRepository;
        private readonly ShoppingCart _shoppingCart;

        public ShoppingCartController(IProjectRepository projectRepository, ShoppingCart shoppingCart)
        {
            _projectRepository = projectRepository;
            _shoppingCart = shoppingCart;
        }

        public ViewResult Index()
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;

            var shoppingCartViewModel = new ShoppingCartViewModel
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()
            };

            return View(shoppingCartViewModel);
        }

        public RedirectToActionResult AddToShoppingCart(int projectId)
        {
            var selectedProject = _projectRepository.AllProjects.FirstOrDefault(p => p.ProjectId == projectId);

            if (selectedProject != null)
            {
                _shoppingCart.AddToCart(selectedProject, 1);
            }
            return RedirectToAction("Index");
        }

        public RedirectToActionResult RemoveFromShoppingCart(int ProjectId)
        {
            var selectedProject = _projectRepository.AllProjects.FirstOrDefault(p => p.ProjectId == ProjectId);

            if (selectedProject != null)
            {
                _shoppingCart.RemoveFromCart(selectedProject);
            }
            return RedirectToAction("Index");
        }
    }
}
