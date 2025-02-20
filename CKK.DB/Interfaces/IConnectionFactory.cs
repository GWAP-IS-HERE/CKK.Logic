using System.Data;

namespace CKK.DB.Interfaces
{
    interface IConnectionFactory
    {
        IDbConnection GetConnection { get; }
    }
}
