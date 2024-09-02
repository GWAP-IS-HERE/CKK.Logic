using CKK.Logic.Models;
using CKK.Logic.Exceptions;

namespace CKK.Logic.Interfaces
{
    [Serializable]
    public abstract class InventoryItem
    {
        private Product prod;
        private int quantity { get; set; }

        public InventoryItem(Product productIn, int quantityIn)
        {
            prod = productIn;
            Quantity = quantityIn;
        }

        public Product Prod
        {
            get
            {
                return prod;
            }
            set
            {
                prod = value;
            }
        }

        public int Quantity
        {
            get
            {
                return quantity;
            }
            set
            {
                if (value < 0)
                    throw new InventoryItemStockTooLowException();
                quantity = value;
            }
        }
    }
}
