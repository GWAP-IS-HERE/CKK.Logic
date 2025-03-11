using CKK.DB.Interfaces;
using CKK.DB.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKK.DB.UOW
{
    public class UnitOfWork : IUnitOfWork
    {
        //opens connection to database for the products, Order, and shoppingCarts repository 
        public UnitOfWork(IConnectionFactory Conn)
        {
            Products = new ProductRepository(Conn);
            Orders = new OrderRepository(Conn);
            ShoppingCarts = new ShoppingCartRepository(Conn);
        }

        public IProductRepository Products { get; private set; }
        public IOrderRepository Orders { get; private set; }

        public IShoppingCartRepository ShoppingCarts { get; set; }

    }
}
