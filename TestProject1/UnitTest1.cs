using CKK.Logic.Models;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void AddProductEmpty()
        {
            Customer cust = new Customer();
            ShoppingCart test = new ShoppingCart(cust);
            Product prod = new Product();

            int expected = 42;
            prod.Id = expected;
            test.AddProduct(prod);
            ShoppingCartItem? cartItem = test.GetProductById(expected);
            Product? prod2;
            if (cartItem != null)
            {
                prod2 = cartItem.Prod;
                Assert.Equal(prod2.Id, expected);
                Assert.Equal(1, cartItem.Quantity);
            }
            else
                Assert.Fail("ShoppingCartItem returned is null!");
        }

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(10)]
        public void AddProductByQuantity(int input)
        {
            Customer cust = new Customer();
            ShoppingCart test = new ShoppingCart(cust);
            Product prod = new Product();

            int expected = 42;
            prod.Id = expected;
            test.AddProduct(prod, input);
            ShoppingCartItem? cartItem = test.GetProductById(expected);
            Product? prod2;
            if (cartItem != null)
            {
                prod2 = cartItem.Prod;
                Assert.Equal(prod2.Id, expected);
                Assert.Equal(input, cartItem.Quantity);
            }
            else
                Assert.Fail("ShoppingCartItem returned is null!");
        }

        [Fact]
        public void AddProductSlotsNotYetFull()
        {
            Customer cust = new Customer();
            ShoppingCart test = new ShoppingCart(cust);
            Product prod = new Product();
            Product prod2 = new Product();
            Product prod3 = new Product();

            int expected = 40;
            int expected2 = 38;
            int expected3 = 7;
            prod.Id = expected;
            test.AddProduct(prod);

            prod2.Id = expected2;
            test.AddProduct(prod2);

            prod3.Id = expected3;
            test.AddProduct(prod3);

            Product? tProd;
            ShoppingCartItem? cartItem = test.GetProductById(expected);
            if (cartItem != null)
            {
                tProd = cartItem.Prod;
                Assert.Equal(tProd.Id, expected);
            }
            else
                Assert.Fail("ShoppingCartItem (1st) returned is null!");

            cartItem = test.GetProductById(expected2);
            if (cartItem != null)
            {
                tProd = cartItem.Prod;
                Assert.Equal(tProd.Id, expected2);
            }
            else
                Assert.Fail("ShoppingCartItem (2nd) returned is null!");

            cartItem = test.GetProductById(expected3);
            if (cartItem != null)
            {
                tProd = cartItem.Prod;
                Assert.Equal(tProd.Id, expected3);
            }
            else
                Assert.Fail("ShoppingCartItem (3rd) returned is null!");
        }

        [Fact]
        public void RemoveTest()
        {
            Customer cust = new Customer();
            ShoppingCart test = new ShoppingCart(cust);
            Product prod = new Product();

            int expected = 42;
            prod.Id = expected;
            test.AddProduct(prod);

            test.RemoveProduct(prod.Id, 1);
            ShoppingCartItem? cartItem = test.GetProductById(expected);
            if (cartItem != null)
                Assert.Fail("Item wasn't properly removed!");
            else
                Assert.True(true);
        }

        [Fact]
        public void GetTotalTest()
        {
            Customer cust = new Customer();
            ShoppingCart test = new ShoppingCart(cust);
            Product prod = new Product();
            Product prod2 = new Product();
            Product prod3 = new Product();

            int id1 = 40;
            int id2 = 38;
            int id3 = 7;
            decimal price1 = 10m;
            decimal price2 = 20m;
            decimal price3 = 30m;

            prod.Id = id1;
            prod.Price = price1;
            test.AddProduct(prod, 5);

            prod2.Id = id2;
            prod2.Price = price2;
            test.AddProduct(prod2, 12);

            prod3.Id = id3;
            prod3.Price = price3;
            test.AddProduct(prod3, 3);

            Assert.Equal(test.GetTotal(), 380);
        }

        [Fact]
        public void GetProductByPlace()
        {
            Customer cust = new Customer();
            ShoppingCart test = new ShoppingCart(cust);
            Product prod = new Product();
            Product prod2 = new Product();
            Product prod3 = new Product();

            int id1 = 40;
            int id2 = 38;
            int id3 = 7;

            prod.Id = id1;
            test.AddProduct(prod, 5);

            prod2.Id = id2;
            test.AddProduct(prod2, 12);

            prod3.Id = id3;
            test.AddProduct(prod3, 3);

            ShoppingCartItem? testS = null;
            Product? testP = null;

            testS = test.Products.ElementAt(0);
            testP = testS.Prod;
            Assert.Equal(id1, testP.Id);

            testS = test.Products.ElementAt(1);
            testP = testS.Prod;
            Assert.Equal(id2, testP.Id);

            testS = test.Products.ElementAt(2);
            testP = testS.Prod;
            Assert.Equal(id3, testP.Id);
        }
    }
}