namespace E_Commerce.DAL.Repositories.Abstracts;

public interface IGenericRepository<T> where T : class
{
    IEnumerable<T> GetAll();

    T Get(int id);

    void Create(T entity);

    void Update(T entity);

    void Delete(int id);

    int SaveChanges();
}