namespace CKK.DB.Interfaces
{
    interface IGenericRepository<T>
    {
        T GetById(int id);
        List<T> GetAll();
        int Add(T entity);
        int Update(T entity);
        int Delete(int id);
    }
}
