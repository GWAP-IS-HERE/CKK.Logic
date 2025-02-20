using CKK.Logic.Models;

namespace CKK.DB.Interfaces
{
    interface IShoppingCartRepository
    {
        ShoppingCartItem AddToCart(int ShoppingCartId, int ProductId, int quantity);
        int ClearCart(int shoppingCartId);
        decimal GetTotal(int ShoppingCartId);
        List<ShoppingCartItem> GetProducts(int shoppingCartId);
        void Ordered(int ShoppingCartId);
        int Update(ShoppingCartItem entity);
        int Add(ShoppingCartItem entity);
    }
}
