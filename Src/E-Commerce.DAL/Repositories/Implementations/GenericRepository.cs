using E_Commerce.DAL.Contexts;
using E_Commerce.DAL.Repositories.Abstracts;
using Microsoft.EntityFrameworkCore;

namespace E_Commerce.DAL.Repositories.Implementations;

public class GenericRepository<TModel> : IGenericRepository<TModel> where TModel : class
{
    private readonly ECommerceDbContext _context;

    public GenericRepository(ECommerceDbContext context)
    {
        _context = context;
    }

    public void Create(TModel entity) => _context.Set<TModel>().Add(entity);

    public void Delete(int id) => _context.Set<TModel>().Remove(Get(id));

    public TModel Get(int id) => _context.Set<TModel>().Find(id);

    public IEnumerable<TModel> GetAll() => _context
                                            .Set<TModel>()
                                            .AsNoTracking()
                                            .AsEnumerable();

    public int SaveChanges() => _context.SaveChanges();

    public void Update(TModel entity) => _context.Set<TModel>().Update(entity);
}