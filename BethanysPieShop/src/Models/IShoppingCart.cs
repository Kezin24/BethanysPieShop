namespace BethanysPieShop.Models
{
    public interface IShoppingCart
    {
        void AddToCart(Pie pie);
        int RemoveFromCart(Pie pie);
        List<ShoppingCartItem> GetShoppingCartItems();
        public List<ShoppingCartItem> ShoppingCartItems { get; set; }

        void ClearCart();
        decimal GetCartPrice();
    }
}
