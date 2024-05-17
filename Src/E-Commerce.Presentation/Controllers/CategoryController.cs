using E_Commerce.BL.Dtos;
using E_Commerce.BL.Managers.Abstractions;
using E_Commerce.Presentation.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace E_Commerce.Presentation.Controllers
{
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryManager _categoryManager;
        private readonly IConfiguration _configuration;
        public CategoryController(ICategoryManager categoryManager, IConfiguration configuration)
        {
            _categoryManager = categoryManager;
            _configuration = configuration;
        }
        [HttpGet(ApiRoute.Categories.GetAll)]
        public IActionResult GetAll()
        {
            var result = _categoryManager.GetAll();
            if (result.IsSuccess)
            {
                return Ok(result.Value);
            }
            return BadRequest(result);
        }
        [HttpGet(ApiRoute.Categories.Get)]
        public IActionResult Get(int id)
        {
            var result = _categoryManager.GetById(id);
            if (result.IsSuccess)
            {
                return Ok(result.Value);
            }
            return BadRequest(result);
        }
        [HttpPost(ApiRoute.Categories.Create)]
        public IActionResult Create([FromBody] CategoryDtos categoryDtos)
        {
            var result = _categoryManager.Add(categoryDtos);
            if (result.IsSuccess)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpDelete(ApiRoute.Categories.Delete)]
        public IActionResult Delete(int id)
        {
            var result = _categoryManager.Delete(id);
            if (result.IsSuccess)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPut(ApiRoute.Categories.Update)]
        public IActionResult Update([FromBody] CategoryDtos categoryDtos)
        {
            var result = _categoryManager.Update(categoryDtos);
            if (result.IsSuccess)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
       
    }
}
