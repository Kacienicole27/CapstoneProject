namespace CapstoneProject.Models
{
    public class ShoppingCartItem
    {
        public int ShoppingCartItemId { get; set; }
        public Project Project { get; set; }
        public int Amount { get; set; }
        public string ShoppingCartId { get; set; }
    }
}
