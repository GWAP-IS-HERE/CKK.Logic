using CKK.Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKK.DB.Interfaces
{
    public interface IShoppingCartRepository
    {
        //adding item to shopping cart 
        ShoppingCartItem AddToCart(int ShoppingCartId, int ProductId, int quantity);
        //clearing the shopping cart
        int ClearCart(int shoppingCartId);
        //getting the total of the shopping cart
        decimal GetTotal(int ShoppingCartId);
        //Get Products by shopping cart id and return them in a list of ShoppingCartItem
        List<ShoppingCartItem> GetProducts(int shoppingCartId);
        //shows the items ordered by ShoppingCartId
        void Ordered(int shoppingCartId);
        //updates the ShoppingCartItem 
        int Update(ShoppingCartItem entity);
        //adds items to shoppingCartItem
        int Add(ShoppingCartItem entity);

    }
}
