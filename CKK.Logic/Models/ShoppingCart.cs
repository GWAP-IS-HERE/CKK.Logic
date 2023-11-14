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
        public ShoppingCartItem RemoveProduct(int prodId, int quantity)
        {
            quantity = abs(quantity);
            if (quantity > 0)
            {
                for (int ctr = 0; ctr < Products.Count(); ctr++)
                {
                    if (Products.ElementAt(ctr).GetProduct().GetId() == prodId)
                    {
                        if (quantity >= Products.ElementAt(ctr).GetQuantity())
                        {
                            Products.RemoveAt(ctr);
                            Product tempP = new Product();
                            tempP.SetId(prodId);
                            ShoppingCartItem temp = new ShoppingCartItem(tempP, 0);
                            return temp;
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
            var myList =
                from item in Products
                where (item.GetProduct().GetId() == id)
                select item;

            if (myList.Any())
                return myList.ElementAt(0);

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

        private int abs(int input)
        {
            return input & 0x7FFFFFFF;
        }
    }
}
