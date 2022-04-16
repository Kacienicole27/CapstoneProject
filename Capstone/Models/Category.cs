namespace CapstoneProject.Models
{
    public class Category
    {
        public int CategoryId { get; set; } = 0;
        public string CategoryName { get; set; } = "";
        public string Description { get; set; } = "";
        public virtual List<Project> Projects { get; set; } = new List<Project>();
    }
}
