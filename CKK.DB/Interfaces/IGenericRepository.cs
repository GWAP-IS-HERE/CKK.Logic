using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKK.DB.Interfaces
{
    public interface IGenericRepository<T> where T : class
    {
        //Gets Object by id
        T GetById(int id);
        //Gets all objects and stores it in list
        List<T> GetAll();
        //Add object
        int Add(T entity);
        //Updates objects
        int Update(T entity);
        //deletes objects
        int Delete(int id);

    }
}
