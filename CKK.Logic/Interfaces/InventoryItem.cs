using CKK.Logic.Models;

namespace CKK.Logic.Interfaces
{
    public abstract class InventoryItem
    {
        public Product Prod { get; set; }
        public int Quantity { get; set; }

        public InventoryItem(Product productIn, int quantityIn)
        {
            Prod = productIn;
            Quantity = quantityIn;
        }
    }
}
