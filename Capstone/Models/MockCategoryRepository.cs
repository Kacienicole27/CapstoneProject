namespace CapstoneProject.Models
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> AllCategories =>
            new List<Category>
            {
                new Category{CategoryId=1, CategoryName="Art", Description="Drawings and Paintings"},
                new Category{CategoryId=2, CategoryName="Design", Description="Logos, Branding, and Advertisements"},
                new Category{CategoryId=3, CategoryName="Programs", Description="Software and Websites"}
            };
    }
}
