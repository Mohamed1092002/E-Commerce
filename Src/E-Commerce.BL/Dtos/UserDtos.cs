using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.BL.Dtos
{
    public class UserDtos
    {
        //    public UserDtos(string firstName, string lastName, int id, string email)
        //    {
        //        this.firstName = firstName;
        //        this.lastName = lastName;
        //        this.Id = id;
        //        this.email = email;
        //    }
        public int Id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }

    }
}
