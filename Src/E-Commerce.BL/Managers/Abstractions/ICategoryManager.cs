using E_Commerce.BL.Dtos.CategoryDtos;
using E_Commerce.DAL.Models;
using E_Commerce.DAL.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.BL.Managers.Abstractions
{
    public interface ICategoryManager
    {
        Result<IEnumerable<Category>> GetCategories();
        Result<Category> GetById(int id);
        Result Add(Category category);
        Result Delete(int id);
        Result Update(Category category);
    }
}
