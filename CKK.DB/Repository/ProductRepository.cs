using CKK.DB.Interfaces;
using CKK.Logic.Models;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKK.DB.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly IConnectionFactory _connectionFactory; //this variable is identical to the other repository classes

        public ProductRepository(IConnectionFactory conn) //initialization of the connection factory
        {
            _connectionFactory = conn;
        }

        public int Add(Product entity) //adds a single row to the Products table
        {
            string sql = "INSERT INTO Products (Price,Quantity,Name) VALUES (@Price,@Quantity,@Name)";
            using (var connection = _connectionFactory.GetConnection)
            {
                connection.Open();
                var result = connection.Execute(sql, entity);
                return result;
            }
        }

        public int Delete(int id) //deletes a single product by id
        {
            string sql = "DELETE FROM Products WHERE Id = @Id";
            using (var connection = _connectionFactory.GetConnection)
            {
                connection.Open();
                var result = connection.Execute(sql, new {Id=id});
                return result;
            }
           
            
        }

        public List<Product> GetAll() //gets every product
        {
            string sql = "SELECT * FROM Products";
            using (var connection = _connectionFactory.GetConnection)
            {
                connection.Open();
                var results = (List<Product>)connection.Query<Product>(sql);
                return results;
                
            }
        }

        public Product GetById(int id) //gets a single result by product id
        {
            string sql = "select * From Products WHERE Id = @Id";
            using (var connection = _connectionFactory.GetConnection)
            {
                connection.Open();
                var results = connection.QuerySingleOrDefault<Product>(sql,new {Id=id});
                return results;
            }
        }

        public List<Product> GetByName(string name) //gets products by name
        {
            string sql = "SELECT * FROM Products WHERE Name = @Name";
            using (var connection = _connectionFactory.GetConnection)
            {
                connection.Open();
                var results = (List<Product>)connection.Query<Product>(sql,new {Name=name});
                return results;
            }
        }

        public int Update(Product entity) //changes the values of a single product that matches the id of the product given in the parameter
        {
            string sql = "UPDATE products SET price = @Price, quantity = @Quantity , name = @Name where Id=@Id ";
            using(var connection = _connectionFactory.GetConnection) 
            {
                connection.Open();
                var results = connection.Execute(sql, entity);
                return results;
            }
        }
    }
}
