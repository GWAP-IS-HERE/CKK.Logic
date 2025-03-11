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
    public class OrderRepository : IOrderRepository
    {
        private readonly IConnectionFactory _connectionFactory; //this variable is identical to the other repository classes

        public OrderRepository(IConnectionFactory conn) //initialization of the connection factory
        {
            _connectionFactory = conn;
        }

        public int Add(Order entity) //adds a single row to the Order table
        {
            var sql = "Insert into Orders (OrderId, OrderNumber,CustomerId,ShoppingCartId) Values(@OrderId,@OrderNumber,@CustomerId,@ShoppingCartId)";
            using (var connection = _connectionFactory.GetConnection)
            {
                connection.Open();
                var results = connection.Execute(sql, entity);
                return results;
            }
        }

        public int Delete(int id) //deletes a row from the Orders table by id
        {
            var sql = "Delete FROM Orders WHERE OrderId = @OrderId";

            using(var connection = _connectionFactory.GetConnection)
            {
                connection.Open();
                var results = connection.Execute(sql, new { OrderId = id });
                return results;
            }
        }
        
        public List<Order> GetAll() //gets all rows from the Orders table
        {
            var sql = "Select * From Orders";
            using(var connection = _connectionFactory.GetConnection)
            {
                connection.Open();
                var results = connection.QuerySingleOrDefault<List<Order>>(sql);
                return results;
            }
        }

        public Order GetById(int id) //gets a single row from the Orders table by id
        {
            var sql = $"Select * From Orders where OrderId = {id}";
            using( var connection = _connectionFactory.GetConnection) 
            {
                connection.Open();
                var results = connection.QuerySingleOrDefault<Order>(sql, new { OrderId = id });
                return results;
            }
        }

        public Order GetOrderByCustomerId(int id) //gets a single row from the Orders table by CustomerId instead of OrderId
        {
            var sql = "Select * From Orders where CustomerId = @CustomerId";
            using (var connection = _connectionFactory.GetConnection)
            {
                connection.Open();
                var results = connection.QuerySingleOrDefault(sql, new { CustomerId = id });
                return results;
            }
        }

        public int Update(Order entity) //change an order based on order id
        {
            var sql = "UPDATE Orders SET OrderNumber = @OrderNumber,CustomerId = @CustomerId AND ShoppingCartId = @ShoppingCartId WHERE OrderId = @OrderId";
            //establishing  a connection
            using(var connection =_connectionFactory.GetConnection) 
            {
                //opening the connection
                connection.Open();
                //excuting the sql statement and passing in the object of order
                var results = connection.Execute(sql, entity);
                //return results
                return results;
            }
        }
    }
}
