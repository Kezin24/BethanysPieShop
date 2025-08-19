using BethanysPieShop.Models;
using Microsoft.AspNetCore.Mvc;

namespace BethanysPieShop.ViewModels
{
    public class ShoppingCartViewModel : Controller
    {
        public IShoppingCart ShoppingCart { get; }
        public decimal ShoppingCartTotal { get; }

        public ShoppingCartViewModel(IShoppingCart shoppingCart, decimal shoppingCartTotal)
        {
            ShoppingCart = shoppingCart;
            ShoppingCartTotal = shoppingCartTotal;
        }
    }
}
