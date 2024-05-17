using E_Commerce.DAL.Models;
using E_Commerce.DAL.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.BL.Managers.Abstractions;

public interface IProductManager
{
    Result<IEnumerable<Product>> GetProducts();
    Result<Product> GetById(int id);
    Result Add(Product product);
    Result Delete(int id);
    Result Update(Product product);
}
