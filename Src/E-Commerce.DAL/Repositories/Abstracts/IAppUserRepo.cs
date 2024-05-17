using E_Commerce.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.DAL.Repositories.Abstracts;

public interface IAppUserRepo: IGenericRepository<ApplicationUser>
{
    ApplicationUser GetUserByEmail(string email);
}
