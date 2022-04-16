namespace CapstoneProject.Models
{
    public class MockProjectRepository : IProjectRepository
    {
        private readonly ICategoryRepository _categoryRepository = new MockCategoryRepository();

        public IEnumerable<Project> AllProjects =>
            new List<Project>
            {
                new Project {ProjectId = 1, Name="Painting", Price=15.95M, ShortDescription="Painting Description", LongDescription="Painting Description", Category = _categoryRepository.AllCategories.ToList()[0], InStock=true, IsProjectOfTheWeek=false, ImageThumbnailUrl="https://gillcleerenpluralsight.blob.core.windows.net/files/strawberryprojectsmall.jpg"},
                new Project {ProjectId = 2, Name="Drawing", Price=18.95M, ShortDescription="Drawing Description", LongDescription="Drawing Description", Category = _categoryRepository.AllCategories.ToList()[1],ImageUrl="https://gillcleerenpluralsight.blob.core.windows.net/files/cheesecake.jpg", InStock=true, IsProjectOfTheWeek=false, ImageThumbnailUrl="https://gillcleerenpluralsight.blob.core.windows.net/files/cheesecakesmall.jpg"},
                new Project {ProjectId = 3, Name="Program", Price=15.95M, ShortDescription="Program Description", LongDescription="Program Description", Category = _categoryRepository.AllCategories.ToList()[0],ImageUrl="https://gillcleerenpluralsight.blob.core.windows.net/files/rhubarbproject.jpg", InStock=true, IsProjectOfTheWeek=true, ImageThumbnailUrl="https://gillcleerenpluralsight.blob.core.windows.net/files/rhubarbprojectsmall.jpg"},
                new Project {ProjectId = 4, Name="Logo", Price=12.95M, ShortDescription="Logo Description", LongDescription="Logo Description", Category = _categoryRepository.AllCategories.ToList()[2],ImageUrl="https://gillcleerenpluralsight.blob.core.windows.net/files/pumpkinproject.jpg", InStock=true, IsProjectOfTheWeek=true, ImageThumbnailUrl="https://gillcleerenpluralsight.blob.core.windows.net/files/pumpkinprojectsmall.jpg"}
            };

        public IEnumerable<Project> ProjectsOfTheWeek { get; }

        public Project GetProjectById(int projectId)
        {
            return AllProjects.FirstOrDefault(p => p.ProjectId == projectId);
        }
    }
}
