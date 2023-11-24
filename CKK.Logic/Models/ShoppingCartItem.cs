using CKK.Logic.Interfaces;

namespace CKK.Logic.Models
{
    public class ShoppingCartItem : InventoryItem
    {

        public ShoppingCartItem(Product productIn, int quantityIn) : base(productIn, quantityIn)
        {}

        public decimal GetTotal()
        {
            return (decimal)Quantity * Prod.Price;
        }

        /* No longer necessary
        public int GetQuantity()
        {
            return quantity;
        }

        public void SetQuantity(int quantityIn)
        {
            quantity = quantityIn;
        }

        public Product GetProduct()
        {
            return product;
        }

        public void SetProduct(Product productIn)
        {
            product = productIn;
        }*/
    }
}
