using Microsoft.EntityFrameworkCore;

namespace CapstoneProject.Models
{
    public class ProjectRepository : IProjectRepository
    {
        private readonly AppDbContext _appDbContext;

        public ProjectRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Project> AllProjects => _appDbContext.Projects.Include(c => c.Category);
        public IEnumerable<Project> ProjectsOfTheWeek => AllProjects.Where(p => p.IsProjectOfTheWeek);
        public Project GetProjectById(int projectId) => _appDbContext.Projects.FirstOrDefault(p => p.ProjectId == projectId) ?? new Project();
    }
}
