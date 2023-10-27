namespace CKK.Logic.Models
{
    public class ShoppingCart
    {
        private Customer Customer;
        private ShoppingCartItem? Product1;
        private ShoppingCartItem? Product2;
        private ShoppingCartItem? Product3;

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
                Product temp;
                if (Product1 != null)
                {
                    temp = Product1.GetProduct();
                    if (temp.GetId() == prod.GetId())
                    {
                        Product1.SetQuantity(Product1.GetQuantity() + quantity);
                        return Product1;
                    }
                }
                if (Product2 != null)
                {
                    temp = Product2.GetProduct();
                    if (temp.GetId() == prod.GetId())
                    {
                        Product2.SetQuantity(Product2.GetQuantity() + quantity);
                        return Product2;
                    }
                }

                if (Product3 != null)
                {
                    temp = Product3.GetProduct();
                    if (temp.GetId() == prod.GetId())
                    {
                        Product3.SetQuantity(Product3.GetQuantity() + quantity);
                        return Product3;
                    }
                }
                //Fall through. If none of the products had what you were looking for, try creating a new one
                if (Product1 == null)
                {
                    Product1 = new ShoppingCartItem(prod, quantity);
                    return Product1;
                }

                if (Product2 == null)
                {
                    Product2 = new ShoppingCartItem(prod, quantity);
                    return Product2;
                }

                if (Product3 == null)
                {
                    Product3 = new ShoppingCartItem(prod, quantity);
                    return Product3;
                }
            }
            return null;
        }

        public ShoppingCartItem? AddProduct(Product prod)
        {
            return AddProduct(prod, 1);
        }

        public ShoppingCartItem? RemoveProduct(Product prod, int quantity)
        {
            if (quantity > 0)
            {
                Product temp;
                if (Product1 != null) //Check Product1
                {
                    temp = Product1.GetProduct();
                    if (temp.GetId() == prod.GetId())
                    {
                        if (Product1.GetQuantity() > quantity)
                        {
                            Product1.SetQuantity(Product1.GetQuantity() - quantity);
                            return Product1;
                        }
                        Product1 = null;
                        return null;
                    }
                }
                if (Product2 != null) //Check Product2
                {
                    temp = Product2.GetProduct();
                    if (temp.GetId() == prod.GetId())
                    {
                        if (Product2.GetQuantity() > quantity)
                        {
                            Product2.SetQuantity(Product2.GetQuantity() - quantity);
                            return Product2;
                        }
                        Product2 = null;
                        return null;
                    }
                }

                if (Product3 != null) //Check Product3
                {
                    temp = Product3.GetProduct();
                    if (temp.GetId() == prod.GetId())
                    {
                        if (Product3.GetQuantity() > quantity)
                        {
                            Product3.SetQuantity(Product3.GetQuantity() - quantity);
                            return Product3;
                        }
                        Product3 = null;
                        return null;
                    }
                }
            }
            return null;
        }

        public ShoppingCartItem? GetProductById(int id)
        {
            Product temp;
            if (Product1 != null) //check Product1's Id
            {
                temp = Product1.GetProduct();
                if (temp.GetId() == id)
                    return Product1;
            }

            if (Product2 != null) //check Product2's Id
            {
                temp = Product2.GetProduct();
                if (temp.GetId() == id)
                    return Product2;
            }

            if (Product3 != null) //check Product3's Id
            {
                temp = Product3.GetProduct();
                if (temp.GetId() == id)
                    return Product3;
            }

            return null;
        }

        public decimal GetTotal()
        {
            decimal total = 0;
            Product temp;
            if (Product1 != null)
            {
                temp = Product1.GetProduct();
                total += (temp.GetPrice() * Product1.GetQuantity());
            }
            if (Product2 != null)
            {
                temp = Product2.GetProduct();
                total += (temp.GetPrice() * Product2.GetQuantity());
            }
            if (Product3 != null)
            {
                temp = Product3.GetProduct();
                total += (temp.GetPrice() * Product3.GetQuantity());
            }
            return total;
        }

        public ShoppingCartItem? GetProduct(int productNum)
        {
            switch (productNum)
            {
                case 1:
                    if (Product1 != null)
                        return Product1;
                    break;
                case 2:
                    if (Product2 != null)
                        return Product2;
                    break;
                case 3:
                    if (Product3 != null)
                        return Product3;
                    break;
            }
            return null;
        }
    }
}
