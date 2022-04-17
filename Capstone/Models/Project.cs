using System.ComponentModel.DataAnnotations.Schema;

namespace CapstoneProject.Models
{
    public class Project
    {

        public int ProjectId { get; set; } = 0;
        public string Name { get; set; } = "";
        public string ShortDescription { get; set; } = "";
        public string LongDescription { get; set; } = "";
        public decimal Price { get; set; } = new decimal(0.0);
        public string ImageUrl { get; set; } = "";
        public string ImageThumbnailUrl { get; set; } = "";
        public bool IsProjectOfTheWeek { get; set; } = false;
        public bool InStock { get; set; } = false;
        public int CategoryId { get; set; } = 0;
        public virtual Category Category { get; set; } = new Category();
        public string Notes { get; set; } = "";
        [NotMapped]
        public bool CanSell => Price > 0.0m;
    }
}
