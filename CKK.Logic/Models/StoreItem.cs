using CKK.Logic.Interfaces;

namespace CKK.Logic.Models
{
    [Serializable]
    public class StoreItem : InventoryItem
    {

        public StoreItem(Product productIn, int quantityIn) : base(productIn, quantityIn)
        {}

        public Product Product
        {
            get
            {
                return base.Prod;
            }
            set
            {
                base.Prod = value;
            }
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
