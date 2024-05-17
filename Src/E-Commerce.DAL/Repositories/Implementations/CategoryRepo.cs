using E_Commerce.DAL.Contexts;
using E_Commerce.DAL.Models;
using E_Commerce.DAL.Repositories.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.DAL.Repositories.Implementations;

public class CategoryRepo: GenericRepository<Category>, ICategoryRepo
{
    private readonly ECommerceDbContext _context;
    public CategoryRepo(ECommerceDbContext context): base(context)
    {
        _context = context;
    }
}
