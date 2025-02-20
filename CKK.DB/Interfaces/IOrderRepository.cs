using CKK.Logic.Models;

namespace CKK.DB.Interfaces
{
    interface IOrderRepository : IGenericRepository<Order>
    {
        Order GetOrderByCustomerId(int id);
    }
}
