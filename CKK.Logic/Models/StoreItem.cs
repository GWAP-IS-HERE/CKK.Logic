namespace CKK.Logic.Models
{
    public class StoreItem
    {
        private Product product;
        private int quantity;

        public StoreItem(Product productIn, int quantityIn)
        {
            product = productIn;
            quantity = quantityIn;
        }

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
        }
    }
}
