using CKK.Logic.Models;

namespace CKK.Logic.Interfaces
{
    public interface IShoppingCart
    {
        public int GetCustomerID();
        public ShoppingCartItem? AddProduct(Product prod, int quantity);
        public ShoppingCartItem? RemoveProduct(int prodId, int quantity);
        public ShoppingCartItem? GetProductById(int id);
        public decimal GetTotal();
        public List<ShoppingCartItem> GetProducts();
    }
}
