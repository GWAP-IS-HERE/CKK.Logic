namespace CKK.Logic.Models
{
    public class ShoppingCart
    {
        private Customer Customer;
        List<ShoppingCartItem> Products = new List<ShoppingCartItem>();

        public ShoppingCart(Customer customer)
        {
            Customer = customer;
        }

        public int GetCustomerID()
        {
            return Customer.GetId();
        }

        public ShoppingCartItem? AddProduct(Product prod, int quantity)
        {
            if (quantity > 0)
            {
                foreach (ShoppingCartItem value in Products)
                {
                    if (value.GetProduct().GetId() == prod.GetId())
                    {
                        value.SetQuantity(value.GetQuantity() + quantity);
                        return value;
                    }
                }
                Products.Add(new ShoppingCartItem(prod, quantity));
                return Products.Last();
            }
            return null;
        }
        /*
        public ShoppingCartItem? AddProduct(Product prod)
        {
            return AddProduct(prod, 1);
        }
        */
        public ShoppingCartItem? RemoveProduct(Product prod, int quantity)
        {
            if (quantity > 0)
            {
                for (int ctr = 0; ctr < Products.Count(); ctr++)
                {
                    if (Products.ElementAt(ctr).GetProduct().GetId() == prod.GetId())
                    {
                        if (quantity >= Products.ElementAt(ctr).GetQuantity())
                        {
                            Products.RemoveAt(ctr);
                            return null;
                        }
                        else
                        {
                            Products.ElementAt(ctr).SetQuantity(Products.ElementAt(ctr).GetQuantity() - quantity);
                            return Products.ElementAt(ctr);
                        }
                    }
                }
            }
            return null;
        }

        public ShoppingCartItem? GetProductById(int id)
        {
            foreach (ShoppingCartItem value in Products)
            {
                if (value.GetProduct().GetId() == id)
                    return value;
            }

            return null;
        }

        public decimal GetTotal()
        {
            decimal total = 0;
            foreach (ShoppingCartItem value in Products)
            {
                total += value.GetTotal();
            }
            return total;
        }

        public List<ShoppingCartItem> GetProducts()
        {
            return Products;
        }
    }
}
