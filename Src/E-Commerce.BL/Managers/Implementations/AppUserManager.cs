using E_Commerce.BL.Dtos.AppUserDtos;
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
    public class AppUserManager : IAppUserManager
    {
        private readonly IAppUserRepo _appUserRepo;
        public AppUserManager(IAppUserRepo appUserRepo)
        {
            _appUserRepo = appUserRepo;
        }
        public Result Add(ApplicationUser appUser)
        {
            if (appUser is null)
            {
                return Result.Failure("User is null");
            }
            var _appUser = new ApplicationUser
            {
                Email = appUser.Email,
                FirstName = appUser.FirstName,
                LastName = appUser.LastName,
            };
            _appUserRepo.Create(appUser);
            return Result.Success(appUser);
        }

        public Result Delete(int id)
        {
            if (id <= 0)
            {
                return Result.Failure("Id is not valid");
            }
            _appUserRepo.Delete(id);
            return Result.Success();
        }

        public Result<IEnumerable<ApplicationUser>> GetAppUser()
        {
            var appUsers = _appUserRepo.GetAll();
            if (appUsers is null)
            {
                return Result.Failure<IEnumerable<ApplicationUser>>("App User not found");
            }
            return Result.Success(appUsers);
        }

        public Result<ApplicationUser> GetById(int id)
        {
            if (id <= 0)
            {
                return Result.Failure<ApplicationUser>("Id is not valid");
            }
            var appUser = _appUserRepo.Get(id);
            if (appUser is null)
            {
                return Result.Failure<ApplicationUser>("Category not found");
            }
            return Result.Success(appUser);
        }

        public Result<ApplicationUser> Login(string email, string password)
        {

            var appUser = _appUserRepo.GetUserByEmail(email);
            if (appUser is null)
            {
                return Result.Failure<ApplicationUser>("User not found");
            }
            if (appUser.Password != password)
            {
                return Result.Failure<ApplicationUser>("Password");
            }
            return Result.Success(appUser);
        }

        public Result<ApplicationUser> Register(ApplicationUser appUser)
        {
            if (appUser is null)
            {
                return Result.Failure<ApplicationUser>("User is null");
            }
            var AppUser = new ApplicationUser
            {
                FirstName = appUser.FirstName,
                LastName = appUser.LastName,
                Email = appUser.Email,
                Password = appUser.Password
            };
            _appUserRepo.Create(appUser);
            return Result.Success(appUser);
        }
    }
}