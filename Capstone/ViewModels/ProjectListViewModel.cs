using CapstoneProject.Models;

namespace CapstoneProject.ViewModels
{
    public class ProjectListViewModel
    {
        public IEnumerable<Project> Projects { get; set; }
        public string CurrentCategory { get; set; }
    }
}
