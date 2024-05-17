using E_Commerce.DAL.Models;
using E_Commerce.DAL.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.BL.Managers.Abstractions
{
    public interface IAppUserManager
    {
        Result<IEnumerable<ApplicationUser>> GetAppUser();
        Result<ApplicationUser> GetById(int id);
        Result Add(ApplicationUser appUser);
        Result Delete(int id);
        Result<ApplicationUser> Login(string email, string password);
        Result<ApplicationUser> Register(ApplicationUser appUser);
    }
}
