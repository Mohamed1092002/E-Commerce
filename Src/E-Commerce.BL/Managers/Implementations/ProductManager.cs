using E_Commerce.BL.Dtos.CategoryDtos;
using E_Commerce.BL.Dtos.ProductDtos;
using E_Commerce.BL.Managers.Abstractions;
using E_Commerce.DAL.Models;
using E_Commerce.DAL.Repositories.Abstracts;
using E_Commerce.DAL.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.BL.Managers.Implementations
{
    public class ProductManager: IProductManager

    {
        private readonly IProductRepo _productRepository;
        public ProductManager(IProductRepo productRepository)
        {
            _productRepository = productRepository;
        }

        public Result Add(Product product)
        {
            if (product is null)
            {
                return Result.Failure("Product is null");
            }
            var _product = new ProductDtos
            {
                Name = product.Name,
                Description = product.Description,
                Price = product.Price,
            };
            _productRepository.Create(product);
            return Result.Success(product);
        }

        public Result Delete(int id)
        {
            if (id <= 0)
            {
                return Result.Failure("Id is not valid");
            }
            _productRepository.Delete(id);
            return Result.Success();
        }

        public Result<Product> GetById(int id)
        {
            if (id <= 0)
            {
                return Result.Failure<Product>("Id is not valid");
            }
            var product = _productRepository.Get(id);
            if (product is null)
            {
                return Result.Failure<Product>("Product not found");
            }
            return Result.Success(product);
        }

        public Result<IEnumerable<Product>> GetProducts()
        {
            var products = _productRepository.GetAll();
            if (products is null)
            {
                return Result.Failure<IEnumerable<Product>>("No products found");
            }
            return Result.Success(products);
        }

        public Result Update(Product product)
        { 

           if (product is null)
            {
                return Result.Failure("Product is null");
            }
            var _product = new ProductDtos
            {
                Name = product.Name,
                Description = product.Description,
                Price = product.Price,
            };
            _productRepository.Update(product);
            return Result.Success(product);
        }
    }
}
