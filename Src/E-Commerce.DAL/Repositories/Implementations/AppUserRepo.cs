using E_Commerce.DAL.Contexts;
using E_Commerce.DAL.Models;
using E_Commerce.DAL.Repositories.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.DAL.Repositories.Implementations;

public class AppUserRepo : GenericRepository<ApplicationUser>, IAppUserRepo
{
    private readonly ECommerceDbContext _context;
    public AppUserRepo(ECommerceDbContext context) : base(context)
    {
    }

    public ApplicationUser GetUserByEmail(string email)
    {
        return _context.Users.FirstOrDefault(x => x.Email == email);
    }
}
