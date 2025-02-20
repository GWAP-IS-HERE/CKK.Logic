using CKK.Logic.Models;

namespace CKK.DB.Interfaces
{
    interface IProductRepository : IGenericRepository<Product>
    {
        List<Product> GetByName(string name);
    }
}
