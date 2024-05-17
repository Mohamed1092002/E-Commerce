using E_Commerce.BL.Dtos;
using E_Commerce.BL.Managers.Abstractions;
using E_Commerce.DAL.Models;
using E_Commerce.DAL.Shared;
using E_Commerce.Presentation.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace E_Commerce.Presentation.Controllers
{
    public class AppUserController : ControllerBase
    {
        private readonly IAppUserManager _userManager;
        private readonly IConfiguration _configuration;
        public AppUserController(IAppUserManager userManager, IConfiguration configuration)
        {
            _userManager = userManager;
            _configuration = configuration;
        }
        [HttpGet(ApiRoute.Users.GetAll)]
        public IActionResult GetAll()
        {
            var users = _userManager.GetAll();
            if (users.IsSuccess)
            {
                return Ok(users.Value);
            }
            return BadRequest(users.Error);
        }
        [HttpGet(ApiRoute.Users.Get)]
        public IActionResult Get(int id)
        {
            var user = _userManager.GetById(id);
            if (user.IsSuccess)
            {
                return Ok(user.Value);
            }
            return BadRequest(user.Error);
        }
        [HttpPost(ApiRoute.Users.Create)]
        public IActionResult Create(UserRegister user)
        {
            var result = _userManager.Add(user);
            if (result.IsSuccess)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpDelete(ApiRoute.Users.Delete)]
        public IActionResult Delete(int id)
        {
            var result = _userManager.Delete(id);
            if (result.IsSuccess)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPut(ApiRoute.Users.Update)]
        public IActionResult Update(UserDtos user)
        {
            var result = _userManager.Update(user);
            if (result.IsSuccess)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}