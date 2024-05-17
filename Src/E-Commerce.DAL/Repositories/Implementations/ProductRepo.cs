using E_Commerce.DAL.Contexts;
using E_Commerce.DAL.Models;
using E_Commerce.DAL.Repositories.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.DAL.Repositories.Implementations;

public class ProductRepo : GenericRepository<Product>, IProductRepo
{
    private readonly ECommerceDbContext _context;
    public ProductRepo(ECommerceDbContext context) : base(context)
    {
        _context = context;
    }
}
