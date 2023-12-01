using CKK.Logic.Interfaces;

namespace CKK.Logic.Models
{
    public class ShoppingCart : IShoppingCart
    {
        private Customer Customer { get; set; }
        public List<ShoppingCartItem> Products { get; set; } = new List<ShoppingCartItem>();

        public ShoppingCart(Customer customer)
        {
            Customer = customer;
        }

        

        public ShoppingCartItem? AddProduct(Product prod, int quantity)
        {
            if (quantity > 0)
            {
                foreach (ShoppingCartItem value in Products)
                {
                    if (value.Prod.Id == prod.Id)
                    {
                        value.Quantity +=  quantity;
                        return value;
                    }
                }
                Products.Add(new ShoppingCartItem(prod, quantity));
                return Products.Last();
            }
            return null;
        }

        public ShoppingCartItem? AddProduct(Product prod)
        {
            return AddProduct(prod, 1);
        }

        public ShoppingCartItem? RemoveProduct(int prodId, int quantity)
        {
            quantity = abs(quantity);
            if (quantity > 0)
            {
                for (int ctr = 0; ctr < Products.Count(); ctr++)
                {
                    if (Products.ElementAt(ctr).Prod.Id == prodId)
                    {
                        if (quantity >= Products.ElementAt(ctr).Quantity)
                        {
                            Products.RemoveAt(ctr);
                            Product tempP = new Product();
                            tempP.Id = prodId;
                            ShoppingCartItem temp = new ShoppingCartItem(tempP, 0);
                            return temp;
                        }
                        else
                        {
                            Products.ElementAt(ctr).Quantity -= quantity;
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
                where (item.Prod.Id == id)
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

        private static int abs(int input)
        {
            return input & 0x7FFFFFFF;
        }

        public List<ShoppingCartItem> GetProducts()
        {
            return Products;
        }
        
        public int GetCustomerID()
        {
            return Customer.Id;
        }
    }
}
