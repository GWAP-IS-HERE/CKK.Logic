using CKK.DB.Interfaces;
using CKK.Logic.Models;

namespace CKK.DB.Repository
{
    class ShoppingCartRepository : IShoppingCartRepository
    {
        public ShoppingCartItem AddToCart(int ShoppingCartId, int ProductId, int quantity)
        {

        }

        public int ClearCart(int shoppingCartId)
        {

        }

        public decimal GetTotal(int ShoppingCartId)
        {

        }

        public List<ShoppingCartItem> GetProducts(int shoppingCartId)
        {

        }

        public void Ordered(int ShoppingCartId)
        {

        }

        public int Update(ShoppingCartItem entity)
        {

        }

        public int Add(ShoppingCartItem entity)
        {

        }
    }
}
