using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ticko.Services.Models;

namespace Ticko.Services
{
    public class UserService
    {
        private List<User> _users = new List<User>
        {
            new User() { Id = 1, Name = "Tomas Westerlund" },
            new User() { Id = 2, Name = "Mega Man" }
        };

        public bool SignIn(string username, string password) 
        {
            throw new NotImplementedException();
        }

        public User GetById(int id)
        {
            return _users.Where(c => c.Id == id).First();
        }
    }
}
