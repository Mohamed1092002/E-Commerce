using E_Commerce.BL.Dtos.CategoryDtos;
using E_Commerce.BL.Managers.Abstractions;
using E_Commerce.DAL.Models;
using E_Commerce.DAL.Repositories.Abstracts;
using E_Commerce.DAL.Repositories.Implementations;
using E_Commerce.DAL.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.BL.Managers.Implementations
{
    public class CategoryManager : ICategoryManager
    {
        private readonly ICategoryRepo _categoryRepository;
        public CategoryManager(ICategoryRepo categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public Result Add(Category category)
        {
            if (category is null)
            {
                return Result.Failure("Category is null");
            }
            var _category = new CategoryDtos
            {
                Name = category.Name,
                Description = category.Description,
            };
            _categoryRepository.Create(category);
            return Result.Success(category);
        }


        public Result Delete(int id)
        {
            if (id <= 0)
            {
                return Result.Failure("Id is not valid");
            }
            _categoryRepository.Delete(id);
            return Result.Success();
        }

        public Result<Category> GetById(int id)
        {
            if (id <= 0)
            {
                return Result.Failure<Category>("Id is not valid");
            }
            var category = _categoryRepository.Get(id);
            if (category is null)
            {
                return Result.Failure<Category>("Category not found");
            }
            return Result.Success(category);
        }

        public Result<IEnumerable<Category>> GetCategories()
        {
            var categories = _categoryRepository.GetAll();
            if (categories is null)
            {
                return Result.Failure<IEnumerable<Category>>("Category not found");
            }
            return Result.Success(categories);
        }

        public Result Update(Category category)
        {
            if (category is null)
            {
                return Result.Failure("Category is null");
            }
            var _category = new CategoryDtos
            {
                Name = category.Name,
                Description = category.Description,
            };
            _categoryRepository.Update(category);
            return Result.Success(category);
        }
    }
}
