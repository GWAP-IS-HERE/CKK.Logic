using CKK.DB.Interfaces;
using CKK.Logic.Models;
using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKK.DB.Repository
{
    public class ShoppingCartRepository : IShoppingCartRepository
    {
        private IConnectionFactory _connectionFactory; //this variable is identical to the other repository classes

        public ShoppingCartRepository(IConnectionFactory conn) //initialization of the connection factory
        {
            _connectionFactory = conn;
        }

        public int Add(ShoppingCartItem entity) //adds a single row to the ShoppingCartItems table
        {
            var sql = "insert into ShoppingCartItems (ShoppingCartId,ProductId,Quantity) VALUES ( @ShoppingCartId, @ProductId, @Quantity)";
            using(var connection = _connectionFactory.GetConnection)
            {
                connection.Open();
                var result = connection.Execute(sql, entity);
                return result;
            }
        }

        public ShoppingCartItem AddToCart(int ShoppingCardId, int ProductId, int quantity) //add an item to the cart that has the given an id and product id (if any), and updates its quantity or adds a new ShoppingCartItem
        {
            using(var conn = _connectionFactory.GetConnection)
            {
                ProductRepository _productRepository = new ProductRepository(_connectionFactory);
                var item = _productRepository.GetById(ProductId);
                //creating productitems variable then we are finding products by shoppingCardId then we find product by its id and set it to ProductId
                var ProductItems = GetProducts(ShoppingCardId).Find(x => x.ProductId == ProductId);

                //creates a new object of ShoppingCartItem called shopitem and settings its values equal to the ones in the methods paramaters
                var shopitem = new ShoppingCartItem()
                {
                    ShoppingCartId = ShoppingCardId,
                    ProductId = ProductId,
                    Quantity = quantity
                };

                //if items Quantity is greater than or equal to the quantity passed in code continues
                if(item.Quantity >= quantity) 
                {
                    //if ProductItems is not null then code continues
                    if(ProductItems != null) 
                    {
                        //Product already in cart so update quantity
                        var test = Update(shopitem);
                    }
                    else
                    {
                        //Product not in cart, so add it in
                        var test = Add(shopitem);
                    }
                }
                return shopitem;
            }
        }

        public int ClearCart(int shoppingCartId) //deletes all items from a given cart, by ShoppingCartId
        {
            var sql = "DELETE from ShoppingCartItems where ShoppingCartId = @ShoppingCartId";
            using (var connection = _connectionFactory.GetConnection)
            {
                connection.Open();
                var result = connection.Execute(sql, new { ShoppingCartId = shoppingCartId });
                return result;
            }
        }

        public List<ShoppingCartItem> GetProducts(int shoppingCartId) //returns a list of products that are in a specific shopping cart by id
        {
            var sql = "SELECT ProductId FROM ShoppingCartItems where ShoppingCartId = @shoppingCartId";
            using(var connection = _connectionFactory.GetConnection) 
            {
                connection.Open();
                var result = connection.Query<ShoppingCartItem>(sql, new {shoppingCartId = shoppingCartId}).ToList();
                return result;
            }

        }

        public decimal GetTotal(int shoppingCartId) //returns the total of all items in a given shopping cart
        {
            var sql = "SELECT SUM(Price * ShoppingCartItems.Quantity) FROM Products JOIN ShoppingCartItems ON ProductId = Products.Id WHERE ShoppingCartId = @shoppingCartId";
            using(var connection = _connectionFactory.GetConnection) 
            {
                connection.Open();
                var result = connection.QueryFirstOrDefault<decimal?>(sql, new {shoppingCartId = shoppingCartId});

                if(result != null) //returns 0 if null, and works normally if it isn't null
                {
                    return (decimal)result;
                }
                else
                {
                    return 0;
                }
            }
        }

        public void Ordered(int shoppingCartId) //deletes the given ShoppingCartItem from the database when it is ordered
        {
            string sql = "DELETE * FROM ShoppingCartItems WHERE ShoppingCartId = @ShoppingCartId";
            using(var connection = _connectionFactory.GetConnection)
            {
                connection.Open();
                var result = connection.Execute(sql,new {ShoppingCartId = shoppingCartId});
            }
        }

        public int Update(ShoppingCartItem entity) //change a specific row in ShoppingCartItems table given the id of the ShoppingCartItem in the parameter
        {
            string sql = "UPDATE ShoppingCartItems SET ShoppingCartId = @ShoppingCartId, ProductId = @ProductId, Quantity = @Quantity WHERE ShoppingCartId = @ShoppingCartId AND ProductId = @ProductId";
            using(var connection = _connectionFactory.GetConnection) 
            {
                connection.Open();
                var result = connection.Execute(sql, entity);
                return result;
            }
        }
    }
}
