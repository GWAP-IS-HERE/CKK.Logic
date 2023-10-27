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
            prod.SetId(expected);
            test.AddProduct(prod);
            ShoppingCartItem? cartItem = test.GetProductById(expected);
            Product? prod2;
            if (cartItem != null)
            {
                prod2 = cartItem.GetProduct();
                Assert.Equal(prod2.GetId(), expected);
                Assert.Equal(1, cartItem.GetQuantity());
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
            prod.SetId(expected);
            test.AddProduct(prod, input);
            ShoppingCartItem? cartItem = test.GetProductById(expected);
            Product? prod2;
            if (cartItem != null)
            {
                prod2 = cartItem.GetProduct();
                Assert.Equal(prod2.GetId(), expected);
                Assert.Equal(input, cartItem.GetQuantity());
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
            prod.SetId(expected);
            test.AddProduct(prod);

            prod2.SetId(expected2);
            test.AddProduct(prod2);

            prod3.SetId(expected3);
            test.AddProduct(prod3);

            Product? tProd;
            ShoppingCartItem? cartItem = test.GetProductById(expected);
            if (cartItem != null)
            {
                tProd = cartItem.GetProduct();
                Assert.Equal(tProd.GetId(), expected);
            }
            else
                Assert.Fail("ShoppingCartItem (1st) returned is null!");

            cartItem = test.GetProductById(expected2);
            if (cartItem != null)
            {
                tProd = cartItem.GetProduct();
                Assert.Equal(tProd.GetId(), expected2);
            }
            else
                Assert.Fail("ShoppingCartItem (2nd) returned is null!");

            cartItem = test.GetProductById(expected3);
            if (cartItem != null)
            {
                tProd = cartItem.GetProduct();
                Assert.Equal(tProd.GetId(), expected3);
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
            prod.SetId(expected);
            test.AddProduct(prod);

            test.RemoveProduct(prod, 1);
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

            prod.SetId(id1);
            prod.SetPrice(price1);
            test.AddProduct(prod, 5);

            prod2.SetId(id2);
            prod2.SetPrice(price2);
            test.AddProduct(prod2, 12);

            prod3.SetId(id3);
            prod3.SetPrice(price3);
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

            prod.SetId(id1);
            test.AddProduct(prod, 5);

            prod2.SetId(id2);
            test.AddProduct(prod2, 12);

            prod3.SetId(id3);
            test.AddProduct(prod3, 3);

            ShoppingCartItem? testS = null;
            Product? testP = null;

            testS = test.GetProduct(1);
            testP = testS.GetProduct();
            Assert.Equal(id1, testP.GetId());

            testS = test.GetProduct(2);
            testP = testS.GetProduct();
            Assert.Equal(id2, testP.GetId());

            testS = test.GetProduct(3);
            testP = testS.GetProduct();
            Assert.Equal(id3, testP.GetId());
        }
    }
}