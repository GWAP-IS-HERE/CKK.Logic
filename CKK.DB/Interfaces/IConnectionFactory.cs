using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CKK.DB.Interfaces
{
    public interface IConnectionFactory
    {
        //Sets a openSource Connection to database
        IDbConnection GetConnection { get; }

    }
}
